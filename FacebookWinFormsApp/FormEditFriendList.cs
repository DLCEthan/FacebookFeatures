using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static FacebookWrapper.ObjectModel.User;

namespace BasicFacebookFeatures
{
	public partial class FormEditFriendList : Form
	{
		public string ListName
		{
			get { return textBoxListName.Text; }
			set
			{
				textBoxListName.Text = value;
				r_CustomFriendListCreator.ListName = value;
			}
		}

		public User LoggedInUser { get; set; }
		private List<User> m_FinalListToAdd = new List<User>();
		private readonly CustomFriendListCreator r_CustomFriendListCreator = new CustomFriendListCreator();
		public bool ClosedByConfirm { get; set; } = false;
		public bool EditMode { get; set; } = false;

		public FriendListWrapper TheCreatedList
		{
			get
			{
				return r_CustomFriendListCreator.TheCreatedList;
			}
			set
			{
				r_CustomFriendListCreator.TheCreatedList = value;
			}
		}

		public FormEditFriendList()
		{
			InitializeComponent();
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			if(LoggedInUser != null)
			{
				r_CustomFriendListCreator.LoggedInUser = LoggedInUser;
				r_CustomFriendListCreator.EditMode = this.EditMode;
				fetchUserLikedPages();
				fetchRelationshipStatuses();
				fetchGenders();
				fetchAges();
				if(TheCreatedList != null)
				{
					m_FinalListToAdd = TheCreatedList.Members.ToList();
				}

				showFinalFriendsList();
				setDefaultComboBoxesValues();
				showFilteredFriends();
				textBoxListName.Text = string.IsNullOrEmpty(this.ListName) ? "New Custom Friend List" : this.ListName;
			}
		}

		private void showFinalFriendsList()
		{
			listBoxFriendsInList.Items.Clear();
			listBoxFriendsInList.DisplayMember = "Name";
			foreach(User friend in m_FinalListToAdd)
			{
				listBoxFriendsInList.Items.Add(friend);
			}
		}

		private void setDefaultComboBoxesValues()
		{
			//don't want to activate the events
			comboBoxGender.SelectedIndexChanged -= comboBoxes_SelectedIndexChanged;
			comboBoxMaxAge.SelectedIndexChanged -= comboBoxes_SelectedIndexChanged;
			comboBoxMinAge.SelectedIndexChanged -= comboBoxes_SelectedIndexChanged;

			//setting the default values
			comboBoxGender.SelectedIndex = 0;
			comboBoxMaxAge.SelectedIndex = comboBoxMaxAge.Items.Count - 1;
			comboBoxMinAge.SelectedIndex = 0;

			//bringing back all the events
			comboBoxGender.SelectedIndexChanged += comboBoxes_SelectedIndexChanged;
			comboBoxMaxAge.SelectedIndexChanged += comboBoxes_SelectedIndexChanged;
			comboBoxMinAge.SelectedIndexChanged += comboBoxes_SelectedIndexChanged;
			updateMinAgeFilter();
			updateMaxAgeFilter();
		}

		private void updateMaxAgeFilter()
		{
			r_CustomFriendListCreator.MaxAgeToFilter = (int)comboBoxMaxAge.SelectedItem;
		}

		private void updateMinAgeFilter()
		{
			r_CustomFriendListCreator.MinAgeToFilter = (int)comboBoxMinAge.SelectedItem;
		}

		private void updateGenderFilter()
		{
			r_CustomFriendListCreator.GenderToFilter = comboBoxGender.SelectedItem.ToString() == "All Genders" ?
				null : (eGender?)(eGender)comboBoxGender.SelectedItem;
		}

		private void showFilteredFriends()
		{
			const bool v_Checked = true;

			uncheckedAllItems(checkedListBoxSelectFriends, checkedListBoxSelectFriends_ItemCheck);// uncheck all items before clearing the list of selected friends
			checkedListBoxSelectFriends.Items.Clear();
			checkedListBoxSelectFriends.DisplayMember = "Name";
			foreach(User friend in r_CustomFriendListCreator.FilteredFriends)
			{
				checkedListBoxSelectFriends.Items.Add(friend);
				bool shouldBeChecked = FacebookObjectComperer.IsFacebookObjectInCollection(friend, m_FinalListToAdd);

				if(shouldBeChecked)
				{
					int lastIndex = checkedListBoxSelectFriends.Items.Count - 1;

					checkedListBoxSelectFriends.SetItemChecked(lastIndex, v_Checked);
				}
			}
		}

		private void fetchGenders()
		{
			comboBoxGender.Items.Clear();
			comboBoxGender.Items.Add("All Genders");
			foreach(eGender gender in Enum.GetValues(typeof(eGender)))
			{
				comboBoxGender.Items.Add(gender);
			}
		}

		private void fetchRelationshipStatuses()
		{
			checkedListBoxRelationshipStatus.Items.Clear();
			foreach(eRelationshipStatus status in Enum.GetValues(typeof(eRelationshipStatus)))
			{
				checkedListBoxRelationshipStatus.Items.Add(status);
			}
		}

		private void fetchUserLikedPages()
		{
			checkedListBoxLikedPages.Items.Clear();
			checkedListBoxLikedPages.DisplayMember = "Name";
			foreach(Page page in LoggedInUser.LikedPages)
			{
				checkedListBoxLikedPages.Items.Add(page);
			}
		}

		private void fetchAges()
		{
			List<int> ages = new List<int>();

			foreach(User friend in LoggedInUser.Friends)
			{
				try
				{
					int friendAge = r_CustomFriendListCreator.CalculateAge(friend.Birthday);

					if(!ages.Contains(friendAge))
					{
						ages.Add(friendAge);
					}
				}
				catch(FormatException)
				{
					//can't calculate age so skipping this user
					continue;
				}
			}

			ages.Sort();
			foreach(int age in ages)
			{
				comboBoxMinAge.Items.Add(age);
				comboBoxMaxAge.Items.Add(age);
			}
		}

		private void checkedListBoxLikedPages_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			updateFilterSelection(e, sender as CheckedListBox, r_CustomFriendListCreator.SelectedPages);
		}

		private void comboBoxes_SelectedIndexChanged(object sender, EventArgs e)
		{
			updateMinAgeFilter();
			updateMaxAgeFilter();
			updateGenderFilter();
			showFilteredFriends();
		}

		private void uncheckedAllItems(CheckedListBox i_CheckedListBoxToClear, ItemCheckEventHandler i_ItemChecked)
		{
			const bool v_Checked = true;

			i_CheckedListBoxToClear.ItemCheck -= i_ItemChecked;
			foreach(int checkedIndex in i_CheckedListBoxToClear.CheckedIndices)
			{
				checkedListBoxLikedPages.SetItemChecked(checkedIndex, !v_Checked);
			}

			i_CheckedListBoxToClear.ItemCheck += i_ItemChecked;
		}

		private void buttonUncheckPages_Click(object sender, EventArgs e)
		{
			uncheckedAllItems(checkedListBoxLikedPages, checkedListBoxLikedPages_ItemCheck);
			r_CustomFriendListCreator.SelectedPages.Clear();
			showFilteredFriends();
		}

		private void checkedListBoxSelectFriends_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			User selectedFriend = checkedListBoxSelectFriends.Items[e.Index] as User;

			if(e.NewValue == CheckState.Checked)
			{
				bool finalListOfUsersToAddContainsUser = FacebookObjectComperer.IsFacebookObjectInCollection(selectedFriend, m_FinalListToAdd);

				if(!finalListOfUsersToAddContainsUser)
				{
					m_FinalListToAdd.Add(selectedFriend);
				}
			}
			else
			{
				m_FinalListToAdd.Remove(selectedFriend);
			}

			showFinalFriendsList();
		}

		private void checkedListBoxSelectFriends_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(checkedListBoxSelectFriends.SelectedItems.Count == 1)
			{
				User selectedFriend = checkedListBoxSelectFriends.SelectedItem as User;

				pictureBoxSelectedFreindProfilePicture.LoadAsync(selectedFriend.PictureNormalURL);
			}
		}

		private void listBoxFriendsInList_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Delete)
			{
				removeSelectedFriendFromFinalList();
			}
		}

		private void removeSelectedFriendFromFinalList()
		{
			if(listBoxFriendsInList.SelectedItems.Count == 1)
			{
				int indexToRemove = listBoxFriendsInList.SelectedIndex;

				m_FinalListToAdd.RemoveAt(indexToRemove);
				showFilteredFriends();
				showFinalFriendsList();
			}
		}

		private void buttonConfirm_Click(object sender, EventArgs e)
		{
			confirmList();
		}

		private void confirmList()
		{
			if(string.IsNullOrEmpty(textBoxListName.Text))
			{
				MessageBox.Show("Name of List Cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				r_CustomFriendListCreator.ListName = textBoxListName.Text.Trim();
				r_CustomFriendListCreator.AddMembersToList(m_FinalListToAdd);
				ClosedByConfirm = true;
				this.Close();
			}
		}

		private void checkedListBoxRelationshipStatus_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			updateFilterSelection(e, sender as CheckedListBox, r_CustomFriendListCreator.RelationshipStatuses);
		}

		private void updateFilterSelection<T>(ItemCheckEventArgs i_EventArgs, CheckedListBox i_CheckedListBox, ICollection<T> i_Values)
		{
			T item = (T)i_CheckedListBox.Items[i_EventArgs.Index];

			if(i_EventArgs.NewValue == CheckState.Checked)
			{
				i_Values.Add(item);
			}
			else
			{
				i_Values.Remove(item);
			}

			showFilteredFriends();
		}
	}
}