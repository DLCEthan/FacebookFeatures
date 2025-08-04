namespace BasicFacebookFeatures
{
    partial class FormEditFriendList
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
            this.listBoxFriendsInList = new System.Windows.Forms.ListBox();
            this.textBoxListName = new System.Windows.Forms.TextBox();
            this.checkedListBoxLikedPages = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxRelationshipStatus = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxSelectFriends = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxSelectedFreindProfilePicture = new System.Windows.Forms.PictureBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxMinAge = new System.Windows.Forms.ComboBox();
            this.comboBoxMaxAge = new System.Windows.Forms.ComboBox();
            this.buttonUncheckPages = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFreindProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFriendsInList
            // 
            this.listBoxFriendsInList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFriendsInList.FormattingEnabled = true;
            this.listBoxFriendsInList.Location = new System.Drawing.Point(460, 22);
            this.listBoxFriendsInList.Name = "listBoxFriendsInList";
            this.listBoxFriendsInList.Size = new System.Drawing.Size(175, 407);
            this.listBoxFriendsInList.TabIndex = 3;
            this.listBoxFriendsInList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxFriendsInList_KeyDown);
            // 
            // textBoxListName
            // 
            this.textBoxListName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxListName.Location = new System.Drawing.Point(307, 22);
            this.textBoxListName.Name = "textBoxListName";
            this.textBoxListName.Size = new System.Drawing.Size(148, 20);
            this.textBoxListName.TabIndex = 4;
            // 
            // checkedListBoxLikedPages
            // 
            this.checkedListBoxLikedPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBoxLikedPages.FormattingEnabled = true;
            this.checkedListBoxLikedPages.Location = new System.Drawing.Point(12, 22);
            this.checkedListBoxLikedPages.Name = "checkedListBoxLikedPages";
            this.checkedListBoxLikedPages.Size = new System.Drawing.Size(160, 409);
            this.checkedListBoxLikedPages.TabIndex = 5;
            this.checkedListBoxLikedPages.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxLikedPages_ItemCheck);
            // 
            // checkedListBoxRelationshipStatus
            // 
            this.checkedListBoxRelationshipStatus.FormattingEnabled = true;
            this.checkedListBoxRelationshipStatus.Location = new System.Drawing.Point(184, 22);
            this.checkedListBoxRelationshipStatus.Name = "checkedListBoxRelationshipStatus";
            this.checkedListBoxRelationshipStatus.Size = new System.Drawing.Size(120, 169);
            this.checkedListBoxRelationshipStatus.TabIndex = 6;
            this.checkedListBoxRelationshipStatus.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxRelationshipStatus_ItemCheck);
            // 
            // checkedListBoxSelectFriends
            // 
            this.checkedListBoxSelectFriends.FormattingEnabled = true;
            this.checkedListBoxSelectFriends.Location = new System.Drawing.Point(311, 65);
            this.checkedListBoxSelectFriends.Name = "checkedListBoxSelectFriends";
            this.checkedListBoxSelectFriends.Size = new System.Drawing.Size(144, 199);
            this.checkedListBoxSelectFriends.TabIndex = 8;
            this.checkedListBoxSelectFriends.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxSelectFriends_ItemCheck);
            this.checkedListBoxSelectFriends.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxSelectFriends_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Liked pages:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Relationship status:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Selected friends to add:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name of list:";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(184, 215);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGender.TabIndex = 14;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxes_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gender:";
            // 
            // pictureBoxSelectedFreindProfilePicture
            // 
            this.pictureBoxSelectedFreindProfilePicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxSelectedFreindProfilePicture.Location = new System.Drawing.Point(312, 270);
            this.pictureBoxSelectedFreindProfilePicture.Name = "pictureBoxSelectedFreindProfilePicture";
            this.pictureBoxSelectedFreindProfilePicture.Size = new System.Drawing.Size(144, 159);
            this.pictureBoxSelectedFreindProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSelectedFreindProfilePicture.TabIndex = 16;
            this.pictureBoxSelectedFreindProfilePicture.TabStop = false;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirm.Location = new System.Drawing.Point(516, 437);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(120, 23);
            this.buttonConfirm.TabIndex = 17;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Min Age:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Max Age:";
            // 
            // comboBoxMinAge
            // 
            this.comboBoxMinAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxMinAge.FormattingEnabled = true;
            this.comboBoxMinAge.Location = new System.Drawing.Point(188, 268);
            this.comboBoxMinAge.Name = "comboBoxMinAge";
            this.comboBoxMinAge.Size = new System.Drawing.Size(49, 21);
            this.comboBoxMinAge.TabIndex = 20;
            this.comboBoxMinAge.SelectedIndexChanged += new System.EventHandler(this.comboBoxes_SelectedIndexChanged);
            // 
            // comboBoxMaxAge
            // 
            this.comboBoxMaxAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxMaxAge.FormattingEnabled = true;
            this.comboBoxMaxAge.Location = new System.Drawing.Point(256, 268);
            this.comboBoxMaxAge.Name = "comboBoxMaxAge";
            this.comboBoxMaxAge.Size = new System.Drawing.Size(49, 21);
            this.comboBoxMaxAge.TabIndex = 21;
            this.comboBoxMaxAge.SelectedIndexChanged += new System.EventHandler(this.comboBoxes_SelectedIndexChanged);
            // 
            // buttonUncheckPages
            // 
            this.buttonUncheckPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUncheckPages.Location = new System.Drawing.Point(12, 437);
            this.buttonUncheckPages.Name = "buttonUncheckPages";
            this.buttonUncheckPages.Size = new System.Drawing.Size(75, 23);
            this.buttonUncheckPages.TabIndex = 22;
            this.buttonUncheckPages.Text = "Unselect All Pages";
            this.buttonUncheckPages.UseVisualStyleBackColor = true;
            this.buttonUncheckPages.Click += new System.EventHandler(this.buttonUncheckPages_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Press \'Del\' to remove a friend from List";
            // 
            // FormEditFriendList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 470);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonUncheckPages);
            this.Controls.Add(this.comboBoxMaxAge);
            this.Controls.Add(this.comboBoxMinAge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.pictureBoxSelectedFreindProfilePicture);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxSelectFriends);
            this.Controls.Add(this.checkedListBoxRelationshipStatus);
            this.Controls.Add(this.checkedListBoxLikedPages);
            this.Controls.Add(this.textBoxListName);
            this.Controls.Add(this.listBoxFriendsInList);
            this.MinimumSize = new System.Drawing.Size(663, 509);
            this.Name = "FormEditFriendList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEditFriendList";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFreindProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxFriendsInList;
        private System.Windows.Forms.TextBox textBoxListName;
        private System.Windows.Forms.CheckedListBox checkedListBoxLikedPages;
        private System.Windows.Forms.CheckedListBox checkedListBoxRelationshipStatus;
        private System.Windows.Forms.CheckedListBox checkedListBoxSelectFriends;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxSelectedFreindProfilePicture;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxMinAge;
        private System.Windows.Forms.ComboBox comboBoxMaxAge;
        private System.Windows.Forms.Button buttonUncheckPages;
        private System.Windows.Forms.Label label8;
    }
}