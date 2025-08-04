using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public partial class FormCreatePost: Form
    {
        private  BindingList<PostTemplate> m_PostTemplates = new BindingList<PostTemplate>();
        private readonly string r_TemplatesPath = Path.Combine(Application.ExecutablePath, "..", "PostTemplates.bin");
        public bool ClosedByPost { get; private set; } = false;
        public string PostText { get{ return textTextBox.Text.Trim(); } }
        public string ImagePath { get{ return imagePathPictureBox.ImageLocation; } }

        public FormCreatePost()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            getTemplatesFromFile();
            populateTemplateListBox();
            base.OnShown(e);
        }

        private void getTemplatesFromFile()
        {
            if(File.Exists(r_TemplatesPath))
            {
                using(Stream stream = new FileStream(r_TemplatesPath, FileMode.Open))
                {
                    BinaryFormatter serializer = new BinaryFormatter();

                    m_PostTemplates = serializer.Deserialize(stream) as BindingList<PostTemplate>;
                }
            }
            else
            {
                m_PostTemplates.Add(new PostTemplate() { 
                    Name = "Basic Template",
                    Text = $"This is a Basic Template!{Environment.NewLine}Design it however you want"
                });
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            saveTemplatesToFile();

            base.OnClosing(e);
        }

        private void saveTemplatesToFile()
        {
            FileMode fileMode = File.Exists(r_TemplatesPath) ? 
                FileMode.Truncate : FileMode.OpenOrCreate;

            using(Stream stream = new FileStream(r_TemplatesPath, fileMode))
            {
                BinaryFormatter serializer = new BinaryFormatter();

                serializer.Serialize(stream, m_PostTemplates);
            }
        }

        private void populateTemplateListBox()
        {
            postTemplateBindingSource.DataSource = m_PostTemplates;
        }

        private void buttonRemoveTemplate_Click(object sender, EventArgs e)
        {
            if(listBoxPostTemplates.SelectedIndex == 0)
            {
                MessageBox.Show("Can't delete the first template.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PostTemplate templateToRemove = listBoxPostTemplates.SelectedItem as PostTemplate;

                m_PostTemplates.Remove(templateToRemove);
            }
        }

        private void buttonCloneTemplate_Click(object sender, EventArgs e)
        {
            PostTemplate clonedTemplate = (postTemplateBindingSource.Current as PostTemplate).DeepClone();

            m_PostTemplates.Add(clonedTemplate);
        }

        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Title = "Select an Image";
                fileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if(fileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePathPictureBox.ImageLocation = fileDialog.FileName;
                }
            }
        }

        private void buttonUpdateTemplate_Click(object sender, EventArgs e)
        {
            PostTemplate currentTemplate = postTemplateBindingSource.Current as PostTemplate;

            currentTemplate.Text = textTextBox.Text;
            currentTemplate.Name = nameTextBox.Text;
            currentTemplate.ImagePath = imagePathPictureBox.ImageLocation;
        }

        private void buttonRemovePhoto_Click(object sender, EventArgs e)
        {
            imagePathPictureBox.ImageLocation = null;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            ClosedByPost = true;
            this.Close();
        }
    }
}