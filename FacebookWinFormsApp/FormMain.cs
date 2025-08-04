using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using CefSharp.DevTools.Fetch;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Globalization;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {

        AppSettings m_AppSettings;
        private FacebookWrapper.LoginResult m_LoginResult;
        private User m_LoggedInUser;
        private Album m_SelectedAlbum;
        private Post m_SelectedPost;
        private int m_CheckBoxCheckedCounter = 0;
        private readonly List<FriendListWrapper> r_FriendLists = new List<FriendListWrapper>();
        private FriendListWrapper m_SelectedFriendList;
        private readonly object r_DownloadPhotosContext = new object();
        private ILoginable m_LoginService;

        public FormMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            m_AppSettings = AppSettings.Instance;
            this.Size = m_AppSettings.LastWindowSize;
            this.Location = m_AppSettings.LastWindowLocation;
            this.checkBoxRememberUser.Checked = m_AppSettings.RememberUser;
            PhotoDownloader.Instance.ProgressUpdate += photoDownloader_ProgressUpdate;
            m_LoginService = new FacebookServiceAdapter();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            m_AppSettings.LastWindowSize = this.Size;
            m_AppSettings.LastWindowLocation = this.Location;
            m_AppSettings.RememberUser = this.checkBoxRememberUser.Checked;
            m_AppSettings.LastAccessToken = m_AppSettings.RememberUser ? m_LoginResult.AccessToken : null;
            m_AppSettings.SaveToFile();
        }

        protected override void OnShown(EventArgs e)
        {
            if (m_AppSettings.RememberUser
                && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
            {
                m_LoginResult = m_LoginService.Login(m_AppSettings.LastAccessToken);
                fetchLoggedInUser();
            }
            base.OnShown(e);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if(m_LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            m_LoginService.AppID = textBoxAppID.Text;
            m_LoginResult = m_LoginService.Login();
            fetchLoggedInUser();
        }

        private void fetchLoggedInUser()
        {
            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
                m_LoggedInUser = m_LoginResult.LoggedInUser;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_LoginService.Logout();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        private void fetchPosts(IEnumerable<Post> i_PostsToShow)
        {
            listBoxPosts.Items.Clear();
            listBoxPosts.DisplayMember = "Type";
            foreach(Post post in i_PostsToShow)
            {
                listBoxPosts.Items.Add(post);
            }
        }

        private void linkAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";
            foreach(Album album in m_LoggedInUser.Albums)
            {
                if (string.IsNullOrEmpty(album.Name))
                {
                    album.Name = "no name album";
                }
                listBoxAlbums.Items.Add(album);
            }

            if(listBoxAlbums.Items.Count == 0)
            {
                listBoxAlbums.Items.Add("No albums to retrieve");
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxAlbums.SelectedItems.Count == 1)
            {
                showSelectedAlbum();
                buttonAddPhotoToAlbum.Enabled = true;
                checkBoxSelectAll.Enabled = true;
            }
            else
            {
                buttonAddPhotoToAlbum.Enabled = false;
                checkBoxSelectAll.Enabled = false;
            }
        }

        private void showSelectedAlbum()
        {
            if(listBoxAlbums.SelectedItems.Count == 1)
            {
                m_SelectedAlbum = listBoxAlbums.SelectedItem as Album;
                if(m_SelectedAlbum != null)
                {
                    initializeFlowLayoutPanel();
                }
            }
        }

        private void initializeFlowLayoutPanel()
        {
            flowLayoutPanelPhotoSelector.Controls.Clear();
            m_CheckBoxCheckedCounter = 0;
            buttonDownloadSelectedPhotos.Enabled = false;
            checkBoxSelectAll.Checked = false;
            if(m_SelectedAlbum.Photos.Count == 0)
            {
                flowLayoutPanelPhotoSelector.Controls.Add(new Label { Text = "No photos to retrieve", AutoSize = true });
            }
            else
            {
                initializeControlsInFlowLayoutPanel();
            }
        }

        private void initializeControlsInFlowLayoutPanel()
        {
            foreach(Photo photo in m_SelectedAlbum.Photos)
            {
                Panel panel = new Panel { Width = 250, Height = 250 };
                CheckBox checkBox = new CheckBox { Dock = DockStyle.Top, Text = "Select", TextAlign = ContentAlignment.TopLeft };
                PictureBox pictureBox = new PictureBox();

                checkBox.AutoSize = true;
                checkBox.CheckedChanged += checkBoxes_CheckedChanged;
                pictureBox.LoadAsync(photo.PictureNormalURL);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Top;
                pictureBox.Size = new Size(panel.Width, panel.Height - checkBox.Height);
                panel.Controls.Add(checkBox);
                panel.Controls.Add(pictureBox);
                panel.BorderStyle = BorderStyle.FixedSingle;
                flowLayoutPanelPhotoSelector.Controls.Add(panel);
            }
        }

        private void checkBoxes_CheckedChanged(object sender, EventArgs e)
        {
            const bool v_ShouldBeChecked = true;
            CheckBox changedCheckBox = sender as CheckBox;
            
            if(changedCheckBox.Checked)
            {
                buttonDownloadSelectedPhotos.Enabled = true;
                m_CheckBoxCheckedCounter++;
                if(m_CheckBoxCheckedCounter == m_SelectedAlbum.Photos.Count)
                {
                    changeCheckBoxSelectAll(v_ShouldBeChecked);
                }
            }
            else
            {
                m_CheckBoxCheckedCounter--;
                if(m_CheckBoxCheckedCounter == 0)
                {
                    buttonDownloadSelectedPhotos.Enabled = false;
                }

                changeCheckBoxSelectAll(!v_ShouldBeChecked);
            }
        }

        private void changeCheckBoxSelectAll(bool i_ShouldBeChecked)
        {
            checkBoxSelectAll.CheckedChanged -= checkBoxSelectAll_CheckedChanged;
            checkBoxSelectAll.Checked = i_ShouldBeChecked;
            checkBoxSelectAll.CheckedChanged += checkBoxSelectAll_CheckedChanged;
        }

        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBoxSelectAll.Checked;

            foreach(Control control in flowLayoutPanelPhotoSelector.Controls)
            {
                Panel panel = control as Panel;

                foreach(Control childControl in panel.Controls)
                {
                    CheckBox checkBox = childControl as CheckBox;

                    if(checkBox != null && checkBox.Checked != isChecked)
                    {
                        checkBox.Checked = isChecked;
                    }
                }
            }
        }

        private void buttonChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();

            browserDialog.Description = "Select a folder";
            browserDialog.ShowNewFolderButton = true;
            DialogResult result = browserDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                textBoxDestinationFolder.Text = browserDialog.SelectedPath;
            }
        }

        private void listBoxFriendLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriendLists.SelectedItems.Count == 1)
            {
                m_SelectedFriendList = listBoxFriendLists.SelectedItem as FriendListWrapper;

                if (m_SelectedFriendList != null)
                {
                    listBoxFriends.Items.Clear();
                    listBoxFriends.DisplayMember = "Name";
                    foreach(User friend in m_SelectedFriendList.Members)
                    {
                        listBoxFriends.Items.Add(friend);
                    }

                    buttonEditSelectedFriendList.Enabled = true;
                    buttonFetchFriendsInListPosts.Enabled = true;
                }
            }
            else
            {
                buttonEditSelectedFriendList.Enabled = false;
                buttonFetchFriendsInListPosts.Enabled = false;
            }
        }

        private void fetchFriendListPosts()
        {
            if(!m_SelectedFriendList.Members.Any())
            {
                string message = "No friend in list to show their posts";
                MessageBox.Show(message, "Friend List Is Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<Post> postsToShow = new List<Post>();

                foreach(User friendInList in m_SelectedFriendList.Members)
                {
                    foreach(Post post in friendInList.NewsFeed)
                    {
                        postsToShow.Add(post);
                    }
                }

                postsToShow.Sort(FacebookObjectComperer.PostComperer);
                fetchPosts(postsToShow);
            }
        }

        private void linkLabelFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchFriendLists();
            fetchFriends();
        }

        private void fetchFriendLists()
        {
            try
            {
                listBoxFriendLists.Items.Clear();
                listBoxFriendLists.DisplayMember = "Name";
                foreach(FriendListWrapper friendList in r_FriendLists)
                {
                    listBoxFriendLists.Items.Add(friendList);
                }
            }
            catch(Exception ex)
            {
                showErrorMessageToUser($"Couldn't fetch friend lists: {ex.Message}");
            }
        }

        private void fetchFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";
            foreach(User friend in m_LoggedInUser.Friends)
            {
                listBoxFriends.Items.Add(friend);
            }
        }

        private void linkLabelFetchPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPosts(m_LoggedInUser.NewsFeed);
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            showSelectedPost();
        }

        private void showSelectedPost()
        {
            if (listBoxPosts.SelectedItems.Count == 1)
            {
                m_SelectedPost = listBoxPosts.SelectedItem as Post;
                updateLabelPostContext();
            }
        }

        private void updateLabelPostContext()
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            labelpostContext.Text = string.Empty;
            if(m_SelectedPost != null)
            {
                listBoxComments.DataSource = m_SelectedPost.Comments;
                pictureBoxPost.ImageLocation = m_SelectedPost.PictureURL;

                if(!string.IsNullOrEmpty(m_SelectedPost.Message))
                {
                    stringBuilder.AppendLine($"Message: {m_SelectedPost.Message}");
                }
                if(!string.IsNullOrEmpty(m_SelectedPost.Name))
                {
                    stringBuilder.AppendLine($"Name: {m_SelectedPost.Name}");
                }
                if(!string.IsNullOrEmpty(m_SelectedPost.Description))
                {
                    stringBuilder.AppendLine($"Description: {m_SelectedPost.Description}");
                }
                if(!string.IsNullOrEmpty(m_SelectedPost.Caption))
                {
                    stringBuilder.AppendLine($"Caption: {m_SelectedPost.Caption}");
                }

                labelpostContext.Text = stringBuilder.ToString();
            }
        }

        private void buttonAddPhotoToAlbum_Click(object sender, EventArgs e)
        {
            addPhotoToSelectedAlbum();
        }

        private void addPhotoToSelectedAlbum()
        {
            if(m_SelectedAlbum != null)
            {
                FormUploadPhoto formUploadPhoto = new FormUploadPhoto();

                formUploadPhoto.ShowDialog();
                if(formUploadPhoto.ClosedByUpload)
                {
                    Photo uploadedPhoto = formUploadPhoto.UploadedPhoto;
                    
                    if(uploadedPhoto != null)
                    {
                        m_SelectedAlbum.Photos.Add(uploadedPhoto);
                    }
                }
            }
        }

        private void buttonCreateAlbum_Click(object sender, EventArgs e)
        {
            createNewAlbum();
        }

        private void createNewAlbum()
        {
            FormAlbumCreation albumCreation = new FormAlbumCreation();

            albumCreation.ShowDialog();
            if(albumCreation.ClosedByCreate)
            {
                try
                {
                    Album createdAlbum = m_LoggedInUser.CreateAlbum(albumCreation.AlbumName, albumCreation.AlbumDescription);

                    if(createdAlbum != null)
                    {
                        listBoxAlbums.Items.Add(createdAlbum);
                    }
                    else
                    {
                        showErrorMessageToUser("Couldn't create Album");
                    }
                }
                catch(Exception ex)
                {
                    showErrorMessageToUser($"There was an error while creating album: {ex.Message}");
                }
            }
        }

        private void showErrorMessageToUser(string i_Message)
        {
            MessageBox.Show(i_Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonAddComment_Click(object sender, EventArgs e)
        {
            addCommentToSelectedPost();
        }

        private void addCommentToSelectedPost()
        {
            string comment = richTextBoxComment.Text;

            try
            {
                Comment com = m_SelectedPost.Comment(comment);

                m_SelectedPost.Comments.Add(com);
            }
            catch(Exception ex)
            {
                showErrorMessageToUser($"Couldn't add comment: {ex.Message}");
            }
        }

        private void buttonDownloadSelectedPhotos_Click(object sender, EventArgs e)
        {
            startDownloadMethodInNewThread(downloadSelectedPhotos);
        }

        private void downloadSelectedPhotos()
        {
            prepareProgressBarForDownload();
            List<string> photoURLS = getUrlOfSelectedPhotos();
            Dictionary<string, List<string>> dictToDownload = new Dictionary<string, List<string>> { { m_SelectedAlbum.Name, photoURLS } };

            downloadPhotos(dictToDownload);
        }

        private void prepareProgressBarForDownload()
        {
            labelDownloadingStatus.Text = "Setting things up...";
            progressBarDownloadProgress.Value = 0;
        }

        private void configureProgressBar(int i_MaxForProgressBar)
        {
            progressBarDownloadProgress.Maximum = i_MaxForProgressBar;
            labelDownloadingStatus.Text = "Downloading...";
        }

        private void downloadListOfPhotosURLS(List<string> i_PhotoURLS, string i_AlbumName)
        {
            try
            {
                PhotoDownloader.Instance.BaseDestinationFolder = textBoxDestinationFolder.Text.Trim();
                PhotoDownloader.Instance.DownloadSetOfPhotosURL(i_PhotoURLS, i_AlbumName);
            }
            catch(Exception ex)
            {
                showErrorMessageToUser(ex.Message);
            }
        }

        private void downloadPhotos(Dictionary<string, List<string>> i_AlbumPhotos)
        {
            lock(r_DownloadPhotosContext)
            {
                int totalPhotos = i_AlbumPhotos.Values.Sum(photo => photo.Count);

                configureProgressBar(totalPhotos);
                foreach(KeyValuePair<string, List<string>> albumEntry in i_AlbumPhotos)
                {
                    downloadListOfPhotosURLS(albumEntry.Value, albumEntry.Key);
                }

                notifyUserDownloadComplete();
            }
        }

        private void downloadAllAlbums()
        {
            prepareProgressBarForDownload();
            Dictionary<string, List<string>> dictToDownload = new Dictionary<string, List<string>>();

            foreach(Album userAlbum in m_LoggedInUser.Albums)
            {
                if(userAlbum.Photos.Count > 0)
                {
                    List<string> photoURLS = userAlbum.Photos.Select(photo => photo.PictureNormalURL).ToList();
                    dictToDownload.Add(userAlbum.Name, photoURLS);
                }
            }

            downloadPhotos(dictToDownload);
        }

        private void notifyUserDownloadComplete()
        {
            labelDownloadingStatus.Text = "Download Complete!";
            MessageBox.Show("Download Completed");
        }

        private List<string> getUrlOfSelectedPhotos()
        {
            List<string> photoURLS = new List<string>();

            foreach(Control control in flowLayoutPanelPhotoSelector.Controls)
            {
                Panel panel = control as Panel;
                CheckBox checkBox = panel.Controls[0] as CheckBox;

                if(checkBox != null && checkBox.Checked)
                {
                    PictureBox pictureBox = panel.Controls[1] as PictureBox;

                    photoURLS.Add(pictureBox.ImageLocation);
                }
            }

            return photoURLS;
        }

        private void buttonDownloadAllAlbums_Click(object sender, EventArgs e)
        {
            startDownloadMethodInNewThread(downloadAllAlbums);
        }

        private void startDownloadMethodInNewThread(ThreadStart i_MethodToStart)
        {
            if(string.IsNullOrEmpty(textBoxDestinationFolder.Text) || !Path.IsPathRooted(textBoxDestinationFolder.Text))
            {
                showErrorMessageToUser("Destination folder Path is Empty");
            }
            else
            {
                Thread selectedPhotoDownloaderThread = new Thread(i_MethodToStart);

                selectedPhotoDownloaderThread.Start();
            }
        }

        private void buttonCreateFriendList_Click(object sender, EventArgs e)
        {
            FormEditFriendList formEditFriendList = new FormEditFriendList();

            formEditFriendList.LoggedInUser = m_LoggedInUser;
            formEditFriendList.ShowDialog();
            if(formEditFriendList.ClosedByConfirm)
            {
                FriendListWrapper newFriendList = formEditFriendList.TheCreatedList;

                r_FriendLists.Add(newFriendList);
                fetchFriendLists();
            }
        }

        private void buttonEditSelectedFriendList_Click(object sender, EventArgs e)
        {
            if (listBoxFriendLists.SelectedItems.Count == 1)
            {
                FriendListWrapper selectedFriendList = listBoxFriendLists.SelectedItem as FriendListWrapper;
                FormEditFriendList formEditFriendList = new FormEditFriendList();

                formEditFriendList.LoggedInUser = m_LoggedInUser;
                formEditFriendList.TheCreatedList = selectedFriendList;
                formEditFriendList.ListName = selectedFriendList.Name;
                formEditFriendList.EditMode = true;
                formEditFriendList.ShowDialog();
                if (formEditFriendList.ClosedByConfirm)
                {
                    selectedFriendList = formEditFriendList.TheCreatedList;
                    fetchFriendLists();
                }
            }
        }

        private void buttonFetchFriendsInListPosts_Click(object sender, EventArgs e)
        {
            fetchFriendListPosts();
        }

        private void photoDownloader_ProgressUpdate()
        {
            progressBarDownloadProgress.Value++;
        }

        private void buttonCreatePost_Click(object sender, EventArgs e)
        {
            FormCreatePost formCreatePost = new FormCreatePost();

            formCreatePost.ShowDialog();
            if(formCreatePost.ClosedByPost)
            {
                try
                {
                    m_LoggedInUser.PostStatus(formCreatePost.PostText, i_PictureURL: formCreatePost.ImagePath);
                }
                catch(Exception)
                {
                    showErrorMessageToUser("Can not post on behalf of user. Currently not supported by Graph API ");
                }
            }
        }
    }
}