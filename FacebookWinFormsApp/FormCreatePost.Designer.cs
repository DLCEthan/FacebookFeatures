namespace BasicFacebookFeatures
{
    partial class FormCreatePost
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
            if(disposing && (components != null))
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label textLabel;
            this.listBoxPostTemplates = new System.Windows.Forms.ListBox();
            this.postTemplateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonAddPhoto = new System.Windows.Forms.Button();
            this.buttonRemoveTemplate = new System.Windows.Forms.Button();
            this.buttonCloneTemplate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.imagePathPictureBox = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.buttonUpdateTemplate = new System.Windows.Forms.Button();
            this.buttonRemovePhoto = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            textLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postTemplateBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePathPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(6, 11);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(85, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Template Name:";
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new System.Drawing.Point(6, 40);
            textLabel.Name = "textLabel";
            textLabel.Size = new System.Drawing.Size(31, 13);
            textLabel.TabIndex = 8;
            textLabel.Text = "Text:";
            // 
            // listBoxPostTemplates
            // 
            this.listBoxPostTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxPostTemplates.DataSource = this.postTemplateBindingSource;
            this.listBoxPostTemplates.DisplayMember = "Name";
            this.listBoxPostTemplates.FormattingEnabled = true;
            this.listBoxPostTemplates.Location = new System.Drawing.Point(12, 17);
            this.listBoxPostTemplates.Name = "listBoxPostTemplates";
            this.listBoxPostTemplates.Size = new System.Drawing.Size(126, 472);
            this.listBoxPostTemplates.TabIndex = 0;
            // 
            // postTemplateBindingSource
            // 
            this.postTemplateBindingSource.DataSource = typeof(BasicFacebookFeatures.PostTemplate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Templates:";
            // 
            // buttonPost
            // 
            this.buttonPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPost.Location = new System.Drawing.Point(416, 520);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 3;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonAddPhoto
            // 
            this.buttonAddPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddPhoto.Location = new System.Drawing.Point(322, 506);
            this.buttonAddPhoto.Name = "buttonAddPhoto";
            this.buttonAddPhoto.Size = new System.Drawing.Size(88, 23);
            this.buttonAddPhoto.TabIndex = 5;
            this.buttonAddPhoto.Text = "Add Photo";
            this.buttonAddPhoto.UseVisualStyleBackColor = true;
            this.buttonAddPhoto.Click += new System.EventHandler(this.buttonAddPhoto_Click);
            // 
            // buttonRemoveTemplate
            // 
            this.buttonRemoveTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveTemplate.Location = new System.Drawing.Point(107, 514);
            this.buttonRemoveTemplate.Name = "buttonRemoveTemplate";
            this.buttonRemoveTemplate.Size = new System.Drawing.Size(60, 36);
            this.buttonRemoveTemplate.TabIndex = 7;
            this.buttonRemoveTemplate.Text = "Remove Template";
            this.buttonRemoveTemplate.UseVisualStyleBackColor = true;
            this.buttonRemoveTemplate.Click += new System.EventHandler(this.buttonRemoveTemplate_Click);
            // 
            // buttonCloneTemplate
            // 
            this.buttonCloneTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCloneTemplate.Location = new System.Drawing.Point(12, 514);
            this.buttonCloneTemplate.Name = "buttonCloneTemplate";
            this.buttonCloneTemplate.Size = new System.Drawing.Size(89, 36);
            this.buttonCloneTemplate.TabIndex = 8;
            this.buttonCloneTemplate.Text = "Clone Selected Template";
            this.buttonCloneTemplate.UseVisualStyleBackColor = true;
            this.buttonCloneTemplate.Click += new System.EventHandler(this.buttonCloneTemplate_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(textLabel);
            this.panel1.Controls.Add(this.textTextBox);
            this.panel1.Controls.Add(this.imagePathPictureBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Location = new System.Drawing.Point(156, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 488);
            this.panel1.TabIndex = 9;
            // 
            // textTextBox
            // 
            this.textTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postTemplateBindingSource, "Text", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textTextBox.Location = new System.Drawing.Point(97, 37);
            this.textTextBox.Multiline = true;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textTextBox.Size = new System.Drawing.Size(224, 195);
            this.textTextBox.TabIndex = 9;
            // 
            // imagePathPictureBox
            // 
            this.imagePathPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePathPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.postTemplateBindingSource, "ImagePath", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.imagePathPictureBox.Location = new System.Drawing.Point(97, 238);
            this.imagePathPictureBox.Name = "imagePathPictureBox";
            this.imagePathPictureBox.Size = new System.Drawing.Size(224, 241);
            this.imagePathPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePathPictureBox.TabIndex = 8;
            this.imagePathPictureBox.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postTemplateBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.nameTextBox.Location = new System.Drawing.Point(97, 8);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(224, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // buttonUpdateTemplate
            // 
            this.buttonUpdateTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUpdateTemplate.Location = new System.Drawing.Point(173, 514);
            this.buttonUpdateTemplate.Name = "buttonUpdateTemplate";
            this.buttonUpdateTemplate.Size = new System.Drawing.Size(74, 36);
            this.buttonUpdateTemplate.TabIndex = 10;
            this.buttonUpdateTemplate.Text = "Update Template";
            this.buttonUpdateTemplate.UseVisualStyleBackColor = true;
            this.buttonUpdateTemplate.Click += new System.EventHandler(this.buttonUpdateTemplate_Click);
            // 
            // buttonRemovePhoto
            // 
            this.buttonRemovePhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemovePhoto.Location = new System.Drawing.Point(322, 530);
            this.buttonRemovePhoto.Name = "buttonRemovePhoto";
            this.buttonRemovePhoto.Size = new System.Drawing.Size(88, 23);
            this.buttonRemovePhoto.TabIndex = 11;
            this.buttonRemovePhoto.Text = "Remove photo";
            this.buttonRemovePhoto.UseVisualStyleBackColor = true;
            this.buttonRemovePhoto.Click += new System.EventHandler(this.buttonRemovePhoto_Click);
            // 
            // FormCreatePost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 558);
            this.Controls.Add(this.buttonRemovePhoto);
            this.Controls.Add(this.buttonUpdateTemplate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCloneTemplate);
            this.Controls.Add(this.buttonRemoveTemplate);
            this.Controls.Add(this.buttonAddPhoto);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPostTemplates);
            this.Name = "FormCreatePost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCreatePost";
            ((System.ComponentModel.ISupportInitialize)(this.postTemplateBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePathPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPostTemplates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonAddPhoto;
        private System.Windows.Forms.Button buttonRemoveTemplate;
        private System.Windows.Forms.Button buttonCloneTemplate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource postTemplateBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.PictureBox imagePathPictureBox;
        private System.Windows.Forms.Button buttonUpdateTemplate;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Button buttonRemovePhoto;
    }
}