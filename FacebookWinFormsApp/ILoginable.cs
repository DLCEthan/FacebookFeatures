using FacebookWrapper;

namespace BasicFacebookFeatures
{
    interface ILoginable
    {
        string AppID { get; set; }
        LoginResult Login();
        LoginResult Login(string i_AccessToken);
        void Logout();
    }
}