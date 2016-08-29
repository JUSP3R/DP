using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C16_Ex01_Alex_318021698_Benny_060129210
{
    public class FeatureHappyBirthday
    {
        public FeatureHappyBirthday()
        {
            Date = DateTime.Now.ToString("dd/MM/yyyy");
            DateToChange = string.Empty;
        }

        public string Date { get; set; }

        public string DateToChange { get; set; }

        public void GetListOfBirthdayFriendsToday(User i_LoggedInUser, ListBox i_ListBoxHappyBirthday)
        {
            i_ListBoxHappyBirthday.Invoke(new Action(() =>
            {
                Date = CutDateYear(Date);
                foreach (User friend in i_LoggedInUser.Friends)
                {
                    DateToChange = CutDateYear(friend.Birthday);
                    if (Date == DateToChange)
                    {
                        i_ListBoxHappyBirthday.Items.Add(friend.Name);
                    }
                }
            }));
        }

        public string CutDateYear(string i_FriendBirthday)
        {
            string currentDate = DateTime.Now.ToString("dd/MM/yyyy");
            string afterTheYearCut = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                afterTheYearCut += i_FriendBirthday[i];
            }

            return afterTheYearCut;
        }

        public void PostHappyBirthdayFriendsToday(User i_LoggedInUser, ListBox i_ListBoxHappyBirthday)
        {
            Date = CutDateYear(Date);
            foreach (User friend in i_LoggedInUser.Friends)
            {
                DateToChange = CutDateYear(friend.Birthday);
                if (Date == DateToChange)
                {
                    Status postedStatus = i_LoggedInUser.PostStatus("Happy Birthday {0}", friend.Name);
                }
            }
        }
    }
}
