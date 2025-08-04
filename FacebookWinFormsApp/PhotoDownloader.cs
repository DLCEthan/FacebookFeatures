using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace BasicFacebookFeatures
{
    internal sealed class PhotoDownloader
    {
        public event Action ProgressUpdate;
        public string BaseDestinationFolder { get; set; } = string.Empty;
        private string m_CombinedDestinationFolderName;

        private static readonly object sr_CreationalLockContext = new object();
        private readonly object r_DownloadPhotosLockContext = new object();
        private static PhotoDownloader s_Instance = null;
        public static PhotoDownloader Instance
        {
            get
            {
                if(s_Instance == null)
                {
                    lock(sr_CreationalLockContext)
                    {
                        if(s_Instance == null)
                        {
                            s_Instance = new PhotoDownloader();
                        }
                    }
                }

                return s_Instance;
            }
        }

        private PhotoDownloader() { }

        private void downloadSetOfPhotosURL(IEnumerable<string> i_ListOfURL)
        {
            foreach(string photoURL in i_ListOfURL)
            {
                downloadPhotoFromURL(photoURL);
                onProgressUpdate();
            }
        }

        public void DownloadSetOfPhotosURL(IEnumerable<string> i_ListOfURL, string i_InnerFolder)
        {
            i_InnerFolder = cleanFolderName(i_InnerFolder);
            lock(r_DownloadPhotosLockContext)
            {
                m_CombinedDestinationFolderName = Path.Combine(BaseDestinationFolder, i_InnerFolder);
                if(!Directory.Exists(m_CombinedDestinationFolderName))
                {
                    Directory.CreateDirectory(m_CombinedDestinationFolderName);
                }

                downloadSetOfPhotosURL(i_ListOfURL);
            }
        }

        private string cleanFolderName(string i_FolderName)
        {
            string folderName = i_FolderName;

            foreach(char c in Path.GetInvalidFileNameChars())
            {
                folderName = folderName.Replace(c, '_');
            }

            return folderName;
        }

        private void downloadPhotoFromURL(string i_PhotoURL)
        {
            using(HttpClient client = new HttpClient())
            {
                if(!string.IsNullOrEmpty(i_PhotoURL))
                {
                    byte[] imageBytes = client.GetByteArrayAsync(i_PhotoURL).Result;
                    string fileName = Path.Combine(
                        m_CombinedDestinationFolderName,
                        $"photo_{DateTime.Now.Ticks}.jpg"
                    );

                    File.WriteAllBytes(fileName, imageBytes);
                }
            }
        }

        private void onProgressUpdate()
        {
            ProgressUpdate?.Invoke();
        }
    }
}