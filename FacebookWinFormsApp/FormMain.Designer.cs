namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonCreatePost = new System.Windows.Forms.Button();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.groupBoxPosts = new System.Windows.Forms.GroupBox();
            this.buttonAddComment = new System.Windows.Forms.Button();
            this.labelComment = new System.Windows.Forms.Label();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.labelpostContext = new System.Windows.Forms.Label();
            this.pictureBoxPost = new System.Windows.Forms.PictureBox();
            this.linkLabelFetchPosts = new System.Windows.Forms.LinkLabel();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.groupBoxFriends = new System.Windows.Forms.GroupBox();
            this.buttonFetchFriendsInListPosts = new System.Windows.Forms.Button();
            this.buttonEditSelectedFriendList = new System.Windows.Forms.Button();
            this.buttonCreateFriendList = new System.Windows.Forms.Button();
            this.linkLabelFriends = new System.Windows.Forms.LinkLabel();
            this.listBoxFriendLists = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.groupBoxAlbumsAndphotos = new System.Windows.Forms.GroupBox();
            this.progressBarDownloadProgress = new System.Windows.Forms.ProgressBar();
            this.labelDownloadingStatus = new System.Windows.Forms.Label();
            this.textBoxDestinationFolder = new System.Windows.Forms.TextBox();
            this.labelDestinationFolder = new System.Windows.Forms.Label();
            this.buttonChooseFolder = new System.Windows.Forms.Button();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanelPhotoSelector = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDownloadAllAlbums = new System.Windows.Forms.Button();
            this.buttonDownloadSelectedPhotos = new System.Windows.Forms.Button();
            this.linkAlbums = new System.Windows.Forms.LinkLabel();
            this.buttonAddPhotoToAlbum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.buttonCreateAlbum = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxPosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).BeginInit();
            this.groupBoxFriends.SuspendLayout();
            this.groupBoxAlbumsAndphotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(18, 57);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 36);
            this.label1.TabIndex = 53;
            this.label1.Text = "This is the AppID of \"Design Patterns App 2.4\". The grader will use it to test yo" +
    "ur app.\r\nType here your own AppID to test it:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1283, 1030);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.checkBoxRememberUser);
            this.tabPage1.Controls.Add(this.groupBoxPosts);
            this.tabPage1.Controls.Add(this.groupBoxFriends);
            this.tabPage1.Controls.Add(this.groupBoxAlbumsAndphotos);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.textBoxAppID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1275, 999);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonCreatePost
            // 
            this.buttonCreatePost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreatePost.Location = new System.Drawing.Point(516, 181);
            this.buttonCreatePost.Name = "buttonCreatePost";
            this.buttonCreatePost.Size = new System.Drawing.Size(89, 46);
            this.buttonCreatePost.TabIndex = 68;
            this.buttonCreatePost.Text = "Create Post";
            this.buttonCreatePost.UseVisualStyleBackColor = true;
            this.buttonCreatePost.Click += new System.EventHandler(this.buttonCreatePost_Click);
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(166, 92);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(126, 22);
            this.checkBoxRememberUser.TabIndex = 67;
            this.checkBoxRememberUser.Text = "Remember Me";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            // 
            // groupBoxPosts
            // 
            this.groupBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPosts.Controls.Add(this.buttonCreatePost);
            this.groupBoxPosts.Controls.Add(this.buttonAddComment);
            this.groupBoxPosts.Controls.Add(this.labelComment);
            this.groupBoxPosts.Controls.Add(this.richTextBoxComment);
            this.groupBoxPosts.Controls.Add(this.listBoxComments);
            this.groupBoxPosts.Controls.Add(this.labelpostContext);
            this.groupBoxPosts.Controls.Add(this.pictureBoxPost);
            this.groupBoxPosts.Controls.Add(this.linkLabelFetchPosts);
            this.groupBoxPosts.Controls.Add(this.listBoxPosts);
            this.groupBoxPosts.Location = new System.Drawing.Point(3, 180);
            this.groupBoxPosts.Name = "groupBoxPosts";
            this.groupBoxPosts.Size = new System.Drawing.Size(690, 475);
            this.groupBoxPosts.TabIndex = 66;
            this.groupBoxPosts.TabStop = false;
            this.groupBoxPosts.Text = "Posts";
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddComment.Location = new System.Drawing.Point(516, 426);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(165, 36);
            this.buttonAddComment.TabIndex = 75;
            this.buttonAddComment.Text = "add comment ";
            this.buttonAddComment.UseVisualStyleBackColor = true;
            this.buttonAddComment.Click += new System.EventHandler(this.buttonAddComment_Click);
            // 
            // labelComment
            // 
            this.labelComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(515, 246);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(75, 18);
            this.labelComment.TabIndex = 74;
            this.labelComment.Text = "comment:";
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxComment.Location = new System.Drawing.Point(516, 267);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(165, 149);
            this.richTextBoxComment.TabIndex = 73;
            this.richTextBoxComment.Text = "";
            // 
            // listBoxComments
            // 
            this.listBoxComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 18;
            this.listBoxComments.Location = new System.Drawing.Point(135, 368);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(375, 94);
            this.listBoxComments.TabIndex = 68;
            // 
            // labelpostContext
            // 
            this.labelpostContext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelpostContext.Location = new System.Drawing.Point(138, 20);
            this.labelpostContext.Name = "labelpostContext";
            this.labelpostContext.Size = new System.Drawing.Size(543, 145);
            this.labelpostContext.TabIndex = 67;
            // 
            // pictureBoxPost
            // 
            this.pictureBoxPost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPost.Location = new System.Drawing.Point(135, 181);
            this.pictureBoxPost.Name = "pictureBoxPost";
            this.pictureBoxPost.Size = new System.Drawing.Size(375, 173);
            this.pictureBoxPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPost.TabIndex = 66;
            this.pictureBoxPost.TabStop = false;
            // 
            // linkLabelFetchPosts
            // 
            this.linkLabelFetchPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabelFetchPosts.AutoSize = true;
            this.linkLabelFetchPosts.Location = new System.Drawing.Point(12, 32);
            this.linkLabelFetchPosts.Name = "linkLabelFetchPosts";
            this.linkLabelFetchPosts.Size = new System.Drawing.Size(110, 18);
            this.linkLabelFetchPosts.TabIndex = 65;
            this.linkLabelFetchPosts.TabStop = true;
            this.linkLabelFetchPosts.Text = "Fetch my posts";
            this.linkLabelFetchPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFetchPosts_LinkClicked);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 18;
            this.listBoxPosts.Location = new System.Drawing.Point(9, 62);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(117, 400);
            this.listBoxPosts.TabIndex = 64;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // groupBoxFriends
            // 
            this.groupBoxFriends.Controls.Add(this.buttonFetchFriendsInListPosts);
            this.groupBoxFriends.Controls.Add(this.buttonEditSelectedFriendList);
            this.groupBoxFriends.Controls.Add(this.buttonCreateFriendList);
            this.groupBoxFriends.Controls.Add(this.linkLabelFriends);
            this.groupBoxFriends.Controls.Add(this.listBoxFriendLists);
            this.groupBoxFriends.Controls.Add(this.listBoxFriends);
            this.groupBoxFriends.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxFriends.Location = new System.Drawing.Point(873, 3);
            this.groupBoxFriends.Name = "groupBoxFriends";
            this.groupBoxFriends.Size = new System.Drawing.Size(400, 658);
            this.groupBoxFriends.TabIndex = 66;
            this.groupBoxFriends.TabStop = false;
            this.groupBoxFriends.Text = "Friends";
            // 
            // buttonFetchFriendsInListPosts
            // 
            this.buttonFetchFriendsInListPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFetchFriendsInListPosts.Enabled = false;
            this.buttonFetchFriendsInListPosts.Location = new System.Drawing.Point(168, 567);
            this.buttonFetchFriendsInListPosts.Name = "buttonFetchFriendsInListPosts";
            this.buttonFetchFriendsInListPosts.Size = new System.Drawing.Size(75, 85);
            this.buttonFetchFriendsInListPosts.TabIndex = 67;
            this.buttonFetchFriendsInListPosts.Text = "Fetch Friend List Post\'s";
            this.buttonFetchFriendsInListPosts.UseVisualStyleBackColor = true;
            this.buttonFetchFriendsInListPosts.Click += new System.EventHandler(this.buttonFetchFriendsInListPosts_Click);
            // 
            // buttonEditSelectedFriendList
            // 
            this.buttonEditSelectedFriendList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditSelectedFriendList.Enabled = false;
            this.buttonEditSelectedFriendList.Location = new System.Drawing.Point(87, 567);
            this.buttonEditSelectedFriendList.Name = "buttonEditSelectedFriendList";
            this.buttonEditSelectedFriendList.Size = new System.Drawing.Size(75, 85);
            this.buttonEditSelectedFriendList.TabIndex = 66;
            this.buttonEditSelectedFriendList.Text = "Edit Selected Friends List";
            this.buttonEditSelectedFriendList.UseVisualStyleBackColor = true;
            this.buttonEditSelectedFriendList.Click += new System.EventHandler(this.buttonEditSelectedFriendList_Click);
            // 
            // buttonCreateFriendList
            // 
            this.buttonCreateFriendList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateFriendList.Location = new System.Drawing.Point(6, 567);
            this.buttonCreateFriendList.Name = "buttonCreateFriendList";
            this.buttonCreateFriendList.Size = new System.Drawing.Size(75, 85);
            this.buttonCreateFriendList.TabIndex = 65;
            this.buttonCreateFriendList.Text = "Create New Friends list";
            this.buttonCreateFriendList.UseVisualStyleBackColor = true;
            this.buttonCreateFriendList.Click += new System.EventHandler(this.buttonCreateFriendList_Click);
            // 
            // linkLabelFriends
            // 
            this.linkLabelFriends.AutoSize = true;
            this.linkLabelFriends.LinkArea = new System.Windows.Forms.LinkArea(0, 30);
            this.linkLabelFriends.Location = new System.Drawing.Point(6, 17);
            this.linkLabelFriends.Name = "linkLabelFriends";
            this.linkLabelFriends.Size = new System.Drawing.Size(239, 39);
            this.linkLabelFriends.TabIndex = 64;
            this.linkLabelFriends.TabStop = true;
            this.linkLabelFriends.Text = "Fetch Friends and Firend lists\r\n(Click a Friend List to view options)";
            this.linkLabelFriends.UseCompatibleTextRendering = true;
            this.linkLabelFriends.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFriends_LinkClicked);
            // 
            // listBoxFriendLists
            // 
            this.listBoxFriendLists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFriendLists.FormattingEnabled = true;
            this.listBoxFriendLists.ItemHeight = 18;
            this.listBoxFriendLists.Location = new System.Drawing.Point(6, 59);
            this.listBoxFriendLists.Name = "listBoxFriendLists";
            this.listBoxFriendLists.Size = new System.Drawing.Size(174, 472);
            this.listBoxFriendLists.TabIndex = 58;
            this.listBoxFriendLists.SelectedIndexChanged += new System.EventHandler(this.listBoxFriendLists_SelectedIndexChanged);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 18;
            this.listBoxFriends.Location = new System.Drawing.Point(220, 59);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(174, 472);
            this.listBoxFriends.TabIndex = 57;
            // 
            // groupBoxAlbumsAndphotos
            // 
            this.groupBoxAlbumsAndphotos.Controls.Add(this.progressBarDownloadProgress);
            this.groupBoxAlbumsAndphotos.Controls.Add(this.labelDownloadingStatus);
            this.groupBoxAlbumsAndphotos.Controls.Add(this.textBoxDestinationFolder);
            this.groupBoxAlbumsAndphotos.Controls.Add(this.labelDestinationFolder);
            this.groupBoxAlbumsAndphotos.Controls.Add(this.buttonChooseFolder);
            this.groupBoxAlbumsAndphotos.Controls.Add(this.checkBoxSelectAll);
            this.groupBoxAlbumsAndphotos.Controls.Add(this.flowLayoutPanelPhotoSelector);
            this.groupBoxAlbumsAndphotos.Controls.Add(this.buttonDownloadAllAlbums);
            this.groupBoxAlbumsAndphotos.Controls.Add(this.buttonDownloadSelectedPhotos);
            this.groupBoxAlbumsAndphotos.Controls.Add(this.linkAlbums);
            this.groupBoxAlbumsAndphotos.Controls.Add(this.buttonAddPhotoToAlbum);
            this.groupBoxAlbumsAndphotos.Controls.Add(this.label2);
            this.groupBoxAlbumsAndphotos.Controls.Add(this.listBoxAlbums);
            this.groupBoxAlbumsAndphotos.Controls.Add(this.buttonCreateAlbum);
            this.groupBoxAlbumsAndphotos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxAlbumsAndphotos.Location = new System.Drawing.Point(3, 661);
            this.groupBoxAlbumsAndphotos.Name = "groupBoxAlbumsAndphotos";
            this.groupBoxAlbumsAndphotos.Size = new System.Drawing.Size(1270, 318);
            this.groupBoxAlbumsAndphotos.TabIndex = 64;
            this.groupBoxAlbumsAndphotos.TabStop = false;
            this.groupBoxAlbumsAndphotos.Text = "Albums And Photos";
            // 
            // progressBarDownloadProgress
            // 
            this.progressBarDownloadProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarDownloadProgress.Location = new System.Drawing.Point(999, 271);
            this.progressBarDownloadProgress.Name = "progressBarDownloadProgress";
            this.progressBarDownloadProgress.Size = new System.Drawing.Size(226, 23);
            this.progressBarDownloadProgress.TabIndex = 74;
            // 
            // labelDownloadingStatus
            // 
            this.labelDownloadingStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDownloadingStatus.AutoSize = true;
            this.labelDownloadingStatus.Location = new System.Drawing.Point(996, 251);
            this.labelDownloadingStatus.Name = "labelDownloadingStatus";
            this.labelDownloadingStatus.Size = new System.Drawing.Size(148, 18);
            this.labelDownloadingStatus.TabIndex = 73;
            this.labelDownloadingStatus.Text = "[Downloading Status]";
            // 
            // textBoxDestinationFolder
            // 
            this.textBoxDestinationFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDestinationFolder.Location = new System.Drawing.Point(289, 271);
            this.textBoxDestinationFolder.Name = "textBoxDestinationFolder";
            this.textBoxDestinationFolder.Size = new System.Drawing.Size(449, 24);
            this.textBoxDestinationFolder.TabIndex = 72;
            // 
            // labelDestinationFolder
            // 
            this.labelDestinationFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDestinationFolder.AutoSize = true;
            this.labelDestinationFolder.Location = new System.Drawing.Point(151, 274);
            this.labelDestinationFolder.Name = "labelDestinationFolder";
            this.labelDestinationFolder.Size = new System.Drawing.Size(132, 18);
            this.labelDestinationFolder.TabIndex = 71;
            this.labelDestinationFolder.Text = "Destination Folder:";
            // 
            // buttonChooseFolder
            // 
            this.buttonChooseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseFolder.Location = new System.Drawing.Point(744, 271);
            this.buttonChooseFolder.Name = "buttonChooseFolder";
            this.buttonChooseFolder.Size = new System.Drawing.Size(113, 24);
            this.buttonChooseFolder.TabIndex = 70;
            this.buttonChooseFolder.Text = "Select Folder";
            this.buttonChooseFolder.UseVisualStyleBackColor = true;
            this.buttonChooseFolder.Click += new System.EventHandler(this.buttonChooseFolder_Click);
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.Enabled = false;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(154, 58);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(136, 22);
            this.checkBoxSelectAll.TabIndex = 69;
            this.checkBoxSelectAll.Text = "Select all photos";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
            // 
            // flowLayoutPanelPhotoSelector
            // 
            this.flowLayoutPanelPhotoSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelPhotoSelector.AutoScroll = true;
            this.flowLayoutPanelPhotoSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelPhotoSelector.Location = new System.Drawing.Point(154, 80);
            this.flowLayoutPanelPhotoSelector.Name = "flowLayoutPanelPhotoSelector";
            this.flowLayoutPanelPhotoSelector.Size = new System.Drawing.Size(965, 168);
            this.flowLayoutPanelPhotoSelector.TabIndex = 68;
            // 
            // buttonDownloadAllAlbums
            // 
            this.buttonDownloadAllAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownloadAllAlbums.Location = new System.Drawing.Point(1132, 154);
            this.buttonDownloadAllAlbums.Name = "buttonDownloadAllAlbums";
            this.buttonDownloadAllAlbums.Size = new System.Drawing.Size(126, 66);
            this.buttonDownloadAllAlbums.TabIndex = 66;
            this.buttonDownloadAllAlbums.Text = "Download All Albums";
            this.buttonDownloadAllAlbums.UseVisualStyleBackColor = true;
            this.buttonDownloadAllAlbums.Click += new System.EventHandler(this.buttonDownloadAllAlbums_Click);
            // 
            // buttonDownloadSelectedPhotos
            // 
            this.buttonDownloadSelectedPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownloadSelectedPhotos.Enabled = false;
            this.buttonDownloadSelectedPhotos.Location = new System.Drawing.Point(1132, 82);
            this.buttonDownloadSelectedPhotos.Name = "buttonDownloadSelectedPhotos";
            this.buttonDownloadSelectedPhotos.Size = new System.Drawing.Size(126, 66);
            this.buttonDownloadSelectedPhotos.TabIndex = 64;
            this.buttonDownloadSelectedPhotos.Text = "Download Selected  photos";
            this.buttonDownloadSelectedPhotos.UseVisualStyleBackColor = true;
            this.buttonDownloadSelectedPhotos.Click += new System.EventHandler(this.buttonDownloadSelectedPhotos_Click);
            // 
            // linkAlbums
            // 
            this.linkAlbums.AutoSize = true;
            this.linkAlbums.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkAlbums.Location = new System.Drawing.Point(6, 20);
            this.linkAlbums.Name = "linkAlbums";
            this.linkAlbums.Size = new System.Drawing.Size(215, 39);
            this.linkAlbums.TabIndex = 62;
            this.linkAlbums.TabStop = true;
            this.linkAlbums.Text = "Fetch Albums\r\n(Click an album to view photos)";
            this.linkAlbums.UseCompatibleTextRendering = true;
            this.linkAlbums.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAlbums_LinkClicked);
            // 
            // buttonAddPhotoToAlbum
            // 
            this.buttonAddPhotoToAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddPhotoToAlbum.Enabled = false;
            this.buttonAddPhotoToAlbum.Location = new System.Drawing.Point(1132, 10);
            this.buttonAddPhotoToAlbum.Name = "buttonAddPhotoToAlbum";
            this.buttonAddPhotoToAlbum.Size = new System.Drawing.Size(125, 66);
            this.buttonAddPhotoToAlbum.TabIndex = 61;
            this.buttonAddPhotoToAlbum.Text = "Add Photo To Selected Album";
            this.buttonAddPhotoToAlbum.UseVisualStyleBackColor = true;
            this.buttonAddPhotoToAlbum.Click += new System.EventHandler(this.buttonAddPhotoToAlbum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 59;
            this.label2.Text = "Albums:";
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 18;
            this.listBoxAlbums.Location = new System.Drawing.Point(9, 80);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(120, 166);
            this.listBoxAlbums.TabIndex = 56;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // buttonCreateAlbum
            // 
            this.buttonCreateAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateAlbum.Location = new System.Drawing.Point(6, 261);
            this.buttonCreateAlbum.Name = "buttonCreateAlbum";
            this.buttonCreateAlbum.Size = new System.Drawing.Size(120, 51);
            this.buttonCreateAlbum.TabIndex = 57;
            this.buttonCreateAlbum.Text = "Create New Album";
            this.buttonCreateAlbum.UseVisualStyleBackColor = true;
            this.buttonCreateAlbum.Click += new System.EventHandler(this.buttonCreateAlbum_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 96);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(79, 78);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(317, 61);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(237, 24);
            this.textBoxAppID.TabIndex = 54;
            this.textBoxAppID.Text = "1785626892011384";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1275, 999);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 1030);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1299, 1008);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxPosts.ResumeLayout(false);
            this.groupBoxPosts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).EndInit();
            this.groupBoxFriends.ResumeLayout(false);
            this.groupBoxFriends.PerformLayout();
            this.groupBoxAlbumsAndphotos.ResumeLayout(false);
            this.groupBoxAlbumsAndphotos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonCreateAlbum;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddPhotoToAlbum;
        private System.Windows.Forms.LinkLabel linkAlbums;
        private System.Windows.Forms.GroupBox groupBoxAlbumsAndphotos;
        private System.Windows.Forms.GroupBox groupBoxFriends;
        private System.Windows.Forms.ListBox listBoxFriendLists;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.LinkLabel linkLabelFriends;
        private System.Windows.Forms.Button buttonCreateFriendList;
        private System.Windows.Forms.GroupBox groupBoxPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.LinkLabel linkLabelFetchPosts;
        private System.Windows.Forms.PictureBox pictureBoxPost;
        private System.Windows.Forms.Label labelpostContext;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.Button buttonDownloadSelectedPhotos;
        private System.Windows.Forms.Button buttonDownloadAllAlbums;
        private System.Windows.Forms.TextBox textBoxDestinationFolder;
        private System.Windows.Forms.Label labelDestinationFolder;
        private System.Windows.Forms.Button buttonChooseFolder;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPhotoSelector;
        private System.Windows.Forms.Button buttonFetchFriendsInListPosts;
        private System.Windows.Forms.Button buttonEditSelectedFriendList;
        private System.Windows.Forms.Label labelDownloadingStatus;
        private System.Windows.Forms.ProgressBar progressBarDownloadProgress;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
        private System.Windows.Forms.Button buttonAddComment;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.RichTextBox richTextBoxComment;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.Button buttonCreatePost;
    }
}

