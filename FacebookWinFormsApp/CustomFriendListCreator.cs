using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using static FacebookWrapper.ObjectModel.User;

namespace BasicFacebookFeatures
{
	internal class CustomFriendListCreator
	{
		public User LoggedInUser { get; set; }
		public FriendListWrapper TheCreatedList { get; set; } = null;
		public string ListName
		{
			get
			{
				if(TheCreatedList == null)
				{
					TheCreatedList = new FriendListWrapper();
				}

				return TheCreatedList.Name;
			}
			set
			{
				if(TheCreatedList == null)
				{
					TheCreatedList = new FriendListWrapper();
				}

				TheCreatedList.Name = value;
			}
		}
		public bool EditMode { get; set; }
		//criteria for filters
		public List<Page> SelectedPages { get; private set; } = new List<Page>();
		public List<eRelationshipStatus> RelationshipStatuses { get; private set; } = new List<eRelationshipStatus>();
		public int MinAgeToFilter { get; set; }
		public int MaxAgeToFilter { get; set; }
		public eGender? GenderToFilter { get; set; }

		//Filtering Result
		private readonly IFilterHandler<User> r_Filters;
		public IEnumerable<User> FilteredFriends
		{
			get
			{
				return new FilteredFriendsIterator { Friends = LoggedInUser.Friends, Filters = r_Filters };
			}
		}

		public CustomFriendListCreator()
		{
			r_Filters = createHandlers();
		}

		private FilterHandler<User> createHandlers()
		{
			FilterHandler<User> genderHandler = new FilterHandler<User>
			{
				Filter = filterByGender
			};
			FilterHandler<User> ageHandler = new FilterHandler<User>
			{
				Filter = filterByAge,
				NextHandler = genderHandler,
			};
			FilterHandler<User> relationshipStatusHandler = new FilterHandler<User>
			{
				Filter = filterByRelationShipStatus,
				NextHandler = ageHandler,
			};
			FilterHandler<User> likedPagesHandler = new FilterHandler<User>
			{
				Filter = filterByLikedPages,
				NextHandler = relationshipStatusHandler,
			};

			return likedPagesHandler;
		}

		public void AddMembersToList(IEnumerable<User> i_UsersToAdd)
		{
			if(!EditMode)
			{
				TheCreatedList.AddMembersToList(i_UsersToAdd);
			}
		}

		private bool convertBirthdayStringToDateTime(string i_Birthday, out DateTime o_DateBirthday)
		{
			return DateTime.TryParseExact(i_Birthday, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out o_DateBirthday);
		}

		public int CalculateAge(string i_Birthday)
		{
			bool success = convertBirthdayStringToDateTime(i_Birthday, out DateTime dateBirthday);

			if(!success)
			{
				throw new FormatException("Invalid birthday date format");
			}

			DateTime today = DateTime.Today;
			int age = today.Year - dateBirthday.Year;

			if(today < dateBirthday.AddYears(age))
			{
				age--;
			}

			return age;
		}

		private bool filterByGender(User i_FriendToCheck)
		{
			bool isGenderMatch = true;

			if(GenderToFilter.HasValue)
			{
				isGenderMatch =
					GenderToFilter.Value == i_FriendToCheck.Gender;
			}

			return isGenderMatch;
		}

		private bool filterByAge(User i_FriendToCheck)
		{
			bool isAgeInRange = true;

			try
			{
				int friendAge = CalculateAge(i_FriendToCheck.Birthday);

				isAgeInRange = friendAge >= MinAgeToFilter &&
								friendAge <= MaxAgeToFilter;
			}
			catch(Exception)
			{
				//can't calculate age so skipping this
			}

			return isAgeInRange;
		}

		private bool filterByRelationShipStatus(User i_FriendToCheck)
		{
			bool isStatus = true;

			if(RelationshipStatuses.Count > 0)
			{
				if(!RelationshipStatuses.Contains(i_FriendToCheck.RelationshipStatus.Value))
				{
					isStatus = false;
				}
			}

			return isStatus;
		}

		private bool filterByLikedPages(User i_FriendToCheck)
		{
			bool isCommon = true;

			foreach(Page selectedPage in SelectedPages)
			{
				if(!FacebookObjectComperer.IsFacebookObjectInCollection(
					selectedPage, i_FriendToCheck.LikedPages))
				{
					isCommon = false;
					break;
				}
			}

			return isCommon;
		}
	}
}