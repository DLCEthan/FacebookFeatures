using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormAlbumCreation: Form
    {
        public string AlbumName
        {
            get
            {
                return textBoxTitle.Text.Trim();
            }
        }

        public string AlbumDescription
        {
            get
            {
                return textBoxDescription.Text.Trim();
            }
        }

        public bool ClosedByCreate { get; private set; } = false;


        public FormAlbumCreation()
        {
            InitializeComponent();
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            ClosedByCreate = sender == buttonCreate;
            this.Close();
        }
    }
}
