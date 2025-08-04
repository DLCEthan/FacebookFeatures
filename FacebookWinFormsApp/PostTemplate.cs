using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
	[Serializable]
	public class PostTemplate
	{
		public string Name { get; set; }
		public string Text { get; set; }
		public string ImagePath { get; set; }
	}
}
