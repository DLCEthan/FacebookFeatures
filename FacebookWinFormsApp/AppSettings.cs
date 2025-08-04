using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
	public class AppSettings
	{
		private static readonly string sr_AppSettingPath = Path.Combine(getProjectRootPath(), "appSettings.xml");
		public Point LastWindowLocation { get; set; }
		public Size LastWindowSize { get; set; }
		public bool RememberUser { get; set; }
		public string LastAccessToken { get; set; }

		private static AppSettings s_Instance = null;
		private static readonly object sr_CreationalLockContext = new object();

		private static string getProjectRootPath()
		{
			string exeLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
			string pathToReturn = Path.Combine("..", "..");
			if(exeLocation.Contains("x64"))
			{
				pathToReturn = Path.Combine("..", pathToReturn);
			}

			return pathToReturn;
		}

		public static AppSettings Instance
		{
			get
			{
				if(s_Instance == null)
				{
					lock(sr_CreationalLockContext)
					{
						if(s_Instance == null)
						{
							s_Instance = loadFromFile();
						}
					}
				}

				return s_Instance;
			}
		}

		private AppSettings()
		{
			LastWindowLocation = new Point(20, 50);
			LastWindowSize = new Size(1275, 999);
			RememberUser = false;
			LastAccessToken = null;
		}

		public void SaveToFile()
		{
			FileMode fileMode = !File.Exists(sr_AppSettingPath) ?
				FileMode.Create : FileMode.Truncate;

			using(Stream stream = new FileStream(sr_AppSettingPath, fileMode))//same as try+finally and dispose
			{
				XmlSerializer serialize = new XmlSerializer(this.GetType());
				serialize.Serialize(stream, this);
			}
		}

		private static AppSettings loadFromFile()
		{
			AppSettings obj = new AppSettings();

			if(File.Exists(sr_AppSettingPath))
			{
				using(Stream stream = new FileStream(sr_AppSettingPath, FileMode.Open))
				{
					XmlSerializer serialize = new XmlSerializer(typeof(AppSettings));

					obj = serialize.Deserialize(stream) as AppSettings;
				}
			}

			return obj;
		}
	}
}
