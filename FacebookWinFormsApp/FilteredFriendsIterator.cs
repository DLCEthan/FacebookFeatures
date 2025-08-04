using FacebookWrapper.ObjectModel;
using System.Collections;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
	class FilteredFriendsIterator : IEnumerable<User>
	{
		public IEnumerable<User> Friends { get; set; }
		public IFilterHandler<User> Filters { get; set; }

		public IEnumerator<User> GetEnumerator()
		{
			foreach(User friend in Friends)
			{
				if(Filters.Handle(friend))
				{
					yield return friend;
				}
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}