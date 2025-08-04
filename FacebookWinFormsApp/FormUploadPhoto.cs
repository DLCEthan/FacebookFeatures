using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
	public partial class FormUploadPhoto : Form
	{
		public string PhotoFilePath { get; private set; } = null;
		public Photo UploadedPhoto { get { return m_UploadedPhoto; } }
		public string Title { get { return textBoxTitle.Text.Trim(); } }
		public string Caption { get { return textBoxCaption.Text.Trim(); } }
		public bool ClosedByUpload { get; private set; } = false;
		public Album SelectedAlbum { get; set; }
		private Photo m_UploadedPhoto;

		public FormUploadPhoto()
		{
			InitializeComponent();
		}

		private void buttonSelectImage_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.Filter = "Image Files (*.jpg;*.jpeg)|*.jpg;*.jpeg";
			openFileDialog.Title = "Select a JPG Photo";
			DialogResult dialogResult = openFileDialog.ShowDialog();

			if(dialogResult == DialogResult.OK)
			{
				PhotoFilePath = openFileDialog.FileName;

				try
				{
					pictureBoxPreview.ImageLocation = PhotoFilePath;

				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void closeForm(object i_WhoIsClosing)
		{
			ClosedByUpload = i_WhoIsClosing == buttonUpload;
			this.Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			closeForm(sender);
		}

		private void buttonUpload_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(PhotoFilePath))
			{
				MessageBox.Show("Invalid Path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				uploadPhoto();
			}

			closeForm(sender);
		}

		private void uploadPhoto()
		{
			try
			{
				m_UploadedPhoto = SelectedAlbum.UploadPhoto(PhotoFilePath, i_Title: Title, i_Caption: Caption);
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
