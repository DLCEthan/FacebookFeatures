using FacebookWrapper;

namespace BasicFacebookFeatures
{
    class FacebookServiceAdapter : ILoginable
    {
        public string AppID { get; set; }

        LoginResult ILoginable.Login()
        {
            LoginResult loginResult = FacebookService.Login(
                /// (This is Desig Patter's App ID. replace it with your own)
                AppID,
                /// requested permissions:
                "email",
                "public_profile",
                "user_friends",
                "user_photos",
                "user_likes",
                "user_hometown",
                "user_posts",
                "user_gender",
                "user_birthday"
                /// add any relevant permissions
                );

            return loginResult;
        }

        LoginResult ILoginable.Login(string i_AccessToken)
        {
            return FacebookService.Connect(i_AccessToken);
        }

        void ILoginable.Logout()
        {
            FacebookService.LogoutWithUI();
        }
    }
}