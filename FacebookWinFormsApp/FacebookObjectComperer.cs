using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
	public static class FacebookObjectComperer
	{
		public static bool AreFacebookObjectsEqual(FacebookObject i_FacebookObjectLeft, FacebookObject i_FacebookObjectRight)
		{
			return i_FacebookObjectLeft.Id == i_FacebookObjectRight.Id;
		}

		public static bool IsFacebookObjectInCollection(FacebookObject i_FacebookObjectToCheck, IEnumerable<FacebookObject> i_FacebookObjects)
		{
			bool contains = false;

			foreach(FacebookObject facebookObject in i_FacebookObjects)
			{
				if(AreFacebookObjectsEqual(i_FacebookObjectToCheck, facebookObject))
				{
					contains = true;
					break;
				}
			}

			return contains;
		}

		public static int PostComperer(Post i_Left, Post i_Right)
		{
			int result;
			
			if(!i_Left.CreatedTime.HasValue && !i_Right.CreatedTime.HasValue)
			{
				result = 0;
			}
			else if(!i_Left.CreatedTime.HasValue)
			{
                result = 1;
			}
			else if(!i_Right.CreatedTime.HasValue)
			{
				result = -1;
			}
			else
			{
				result = (int)(i_Right.CreatedTime.Value.Ticks - i_Left.CreatedTime.Value.Ticks);
			}

			return result;
        }
	}
}