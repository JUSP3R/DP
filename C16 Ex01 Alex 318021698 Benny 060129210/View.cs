using System.Threading;
using System;
using System.IO;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C16_Ex01_Alex_318021698_Benny_060129210
{
    public partial class View : Form
    {
        public AppSettings App { get; set; }

        public FacebookSessionData SessionData { get; set; }

        public FeatureHappyBirthday HappyBirthday { get; set; }

        public FeatureSearchPost SearchPost { get; set; }

        public FeatureEventMarkers Map { get; set; }

        public DateTime Time { get; set; }
   
        public FeatureUserStatistics FeatureUserStatistics { get; set; }

        public View()
        {
            InitializeComponent();
            App = Singleton<AppSettings>.Instance;
            SessionData = Singleton<FacebookSessionData>.Instance;
            HappyBirthday = new FeatureHappyBirthday();
            SearchPost = new FeatureSearchPost();
            Map = new FeatureEventMarkers();
            FeatureUserStatistics = new FeatureUserStatistics();
            
          
           // HappyBirthday = Singleton<FeatureHappyBirthday>.Instance;
           // SearchPost = Singleton<FeatureSearchPost>.Instance;
           // Map = Singleton<FeatureEventMarkers>.Instance;
           // FeatureUserStatistics = Singleton<FeatureUserStatistics>.Instance;
        }
 
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            App.LastWindowLocation = Location;
            App.LastWindowSize = Size;
            App.SaveToFile();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            if (File.Exists(App.FileNamePath))
            {
                App.LastAccessToken = AppSettings.ReadFromFile().LastAccessToken;
                App.AutoConnect = AppSettings.ReadFromFile().AutoConnect;
                App.LastWindowSize = AppSettings.ReadFromFile().LastWindowSize;
                App.LastWindowLocation = AppSettings.ReadFromFile().LastWindowLocation;
                Size = App.LastWindowSize;
                Location = App.LastWindowLocation;
            }
            
            if (App.AutoConnect)
            {
                checkBoxRememberMe.Checked = true;
            }    
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            getVisible();
            if (App.AutoConnect && !App.LastAccessToken.Equals(string.Empty))
            {
                SessionData.AutoConnection(App.LastAccessToken);              
            }
            else
            {
                SessionData.Conection();
            }

            if (SessionData.LoggedInUser != null)
            {           
                checkBoxRememberMe.Visible = false;
                App.LastAccessToken = SessionData.Result.AccessToken;
                checkBoxRememberMe.Visible = false;
                buttonLogin.Visible = false;
                buttonLogOut.Visible = true;
                new Thread(() => HappyBirthday.GetListOfBirthdayFriendsToday(SessionData.LoggedInUser, listBoxHappyBirthday)).Start();
                new Thread(() => FeatureUserStatistics.FillGraphs(SessionData, bar)).Start();
                new Thread(() => getFriends()).Start();
                new Thread(() => getEvents()).Start();
                new Thread(() => Map.GetMapsMarkers(SessionData, webBrowser)).Start();
                listBoxGetFriends.SelectedValueChanged += new EventHandler(listBoxGetFriends_SelectedIndexChanged);
                getMyPosts();
                userBindingSource.DataSource = SessionData.LoggedInUser;

                //new Thread(() => getMyPosts()).Start();
                //getFriends();
                //getEvents();
                //Map.GetMapsMarkers(SessionData, webBrowser);
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
        }

        private void getPostsButton(object sender, EventArgs e)
        {
            listBoxGetPosts.Items.Clear();
            if (SessionData.LoggedInUser != null)
            {
                foreach (Post post in SessionData.LoggedInUser.Posts)
                {
                    if (post.Message != null)
                    {
                        listBoxGetPosts.Items.Add(post.Message);
                    }
                }
            }
        }

        private void getMyPosts()
        {
            if (SessionData.LoggedInUser != null)
            {
                if(listBoxGetPosts.InvokeRequired)
                {
                    postBindingSource.DataSource = SessionData.LoggedInUser.Posts;
                }
                else
                {
                    listBoxGetPosts.Invoke(new Action(() => postBindingSource.DataSource = SessionData.LoggedInUser.Posts));
                }

                //foreach (Post post in SessionData.LoggedInUser.Posts)
                //{
                //    if (post.Message != null)
                //    {
                 //       listBoxGetPosts.Items.Add(post.Message);
                 //   }
                //}
            }
        }

        private void buttonSearchPost_Click(object sender, EventArgs e)
        {
            if (SessionData.LoggedInUser != null)
            {
                if(dateTimePicker.Value.Date == DateTime.Now.Date)
                {
                    SearchPost.SearchPost(SessionData.LoggedInUser, listBoxSearchResults, richTextBoxSearchPost, DateTime.Now.Date, radioButtonSearchAll, radioButtonSearchByDate);
                }
                else
                {
                    SearchPost.SearchPost(SessionData.LoggedInUser, listBoxSearchResults, richTextBoxSearchPost, Time, radioButtonSearchAll, radioButtonSearchByDate);
                }
            }
        }

        private void getFriends()
        {
            listBoxGetFriends.DisplayMember = "Name";

            if (SessionData.LoggedInUser != null)
            {
               if (!listBoxGetFriends.InvokeRequired)
                {
                    membersBindingSource.DataSource = SessionData.LoggedInUser.Friends;
                }
                  else
                {
                   listBoxGetFriends.Invoke(new Action(() => membersBindingSource.DataSource = SessionData.LoggedInUser.Friends));
                }
            }
        }

        private void getVisible()
        {
            buttonLogin.Visible = true;
            pictureBoxUser.Visible = true;
            buttonPostSomething.Visible = true;
            richTextBoxPostSomething.Visible = true;
            buttonSearchPost.Visible = true;
            richTextBoxSearchPost.Visible = true;
            labelSearchResults.Visible = true;
            labelHappyBirthday.Visible = true;
            listBoxHappyBirthday.Visible = true;
            listBoxSearchResults.Visible = true;
            listBoxGetPosts.Visible = true;
            listBoxGetFriends.Visible = true;
            buttonPostHappyBirthday.Visible = true;
            labelUserName2.Visible = true;
            labelMyWall.Visible = true;
            listBoxEvents.Visible = true;
            labelFriendsList.Visible = true;
            groupBoxRadioButtons.Visible = true;    
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {            
            if (checkBoxRememberMe.Checked)
            {
                App.AutoConnect = true;
            }
            else
            {
                App.AutoConnect = false;
                App.LastAccessToken = string.Empty;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            App.LastWindowLocation = Location;
            App.LastWindowSize = Size;
            App.SaveToFile();
            ActiveForm.Close();
        }

        private void buttonSendHappyBirthdayToAll_Click(object sender, EventArgs e)
        {
            if (SessionData.LoggedInUser != null)
            {
                new Thread(() => HappyBirthday.PostHappyBirthdayFriendsToday(SessionData.LoggedInUser, listBoxHappyBirthday)).Start();   
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if (SessionData.LoggedInUser != null)
            {
                if (richTextBoxPostSomething.Text != string.Empty)
                {
                    Status postedStatus = SessionData.LoggedInUser.PostStatus(richTextBoxPostSomething.Text);
                   // listBoxGetPosts.Items.Clear();
                   // listBoxGetPosts.Items.Add(richTextBoxPostSomething.Text);
                   // getMyPosts();
                    richTextBoxPostSomething.Text = string.Empty;
                }
            }
        }
        
        private void listBoxGetFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
           pictureBoxUserPicture.Visible = true;
           User user = (User)listBoxGetFriends.SelectedItem;
             
           if (user != null)
            {       
               pictureBoxUserPicture.Load(user.PictureNormalURL);
            }
         }

        private void getEvents()
        {
            if (SessionData.LoggedInUser != null)
            {
                if (!listBoxEvents.InvokeRequired)
                {
                    eventsBindingSource.DataSource = SessionData.LoggedInUser.Events;
                }
                else
                {
                    listBoxEvents.Invoke(new Action(() => eventsBindingSource.DataSource = SessionData.LoggedInUser.Events));
                }
            }
        }
   
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Time = dateTimePicker.Value;
        }

        private void radioButtonSearchAll_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonSearchAll.Checked)
            {
                dateTimePicker.Visible = false;
                richTextBoxSearchPost.Visible = true;
            }
        }

        private void radioButtonSearchByDate_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonSearchByDate.Checked)
            {
                dateTimePicker.Visible = true;
                richTextBoxSearchPost.Visible = false;
                richTextBoxSearchPost.Text = string.Empty;
            }
        }
    }
}