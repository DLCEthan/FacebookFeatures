using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
	public class FriendListWrapper
	{
		private readonly FriendList r_FriendList = new FriendList();
		private readonly List<User> r_MembersInList = new List<User>();

        public string Name
		{
			get { return r_FriendList.Name; }
			set { r_FriendList.Name = value; }
		}

		public IEnumerable<User> Members
		{
			get { return r_MembersInList; }
		}

		public void AddMembersToList(IEnumerable<User> i_UsersToAdd)
		{
			foreach(User userToAdd in i_UsersToAdd)
			{
				r_MembersInList.Add(userToAdd);
			}
		}
    }
}
