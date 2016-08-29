using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C16_Ex01_Alex_318021698_Benny_060129210
{
      public class FacebookSessionData
    {
        private static readonly object sr_SyncRoot = new object();
        private static readonly object sr_DataDefender = new object();
        private static readonly object sr_AutoConnectionDefender = new object();

        public User LoggedInUser { get; set; }

        public LoginResult Result { get; set; }

        private FacebookSessionData()
        {
        }

        public void Conection()
        {
            lock (sr_DataDefender)
            {
                if (Result == null)
                {
                      Result = FacebookService.Login("1723018487949486", "email", "user_photos", "publish_actions", "user_status", "user_friends", "user_posts", "user_events", "user_birthday", "user_about_me");
                      LoggedInUser = Result.LoggedInUser;
                }
            }
        }
       
        public void AutoConnection(string i_Token)
        {
            lock (sr_AutoConnectionDefender)
            {
                if (Result == null)
                {
                    Result = FacebookService.Connect(i_Token);
                    LoggedInUser = Result.LoggedInUser;
                }
            }
        }
    } 
}
