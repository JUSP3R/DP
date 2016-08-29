using System;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C16_Ex01_Alex_318021698_Benny_060129210
{
    public class FeatureSearchPost
    {
        public string UserInput { get; set; }

        public FeatureSearchPost()
        {
            UserInput = string.Empty;
        }

        public void SearchPost(User i_LoggedInUser, ListBox i_ListBoxSearchResults, RichTextBox i_RichTextBoxSearchPost, DateTime i_Time, RadioButton i_radioButtonSearchAll, RadioButton i_radioButtonSearchByDate)
        {
            i_ListBoxSearchResults.Items.Clear();
            UserInput = i_RichTextBoxSearchPost.Text.ToString();
            
            foreach (Post post in i_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    if (i_radioButtonSearchAll.Checked)
                    {
                        if (post.Message.Contains(UserInput))
                        {
                            i_ListBoxSearchResults.Items.Add(post.Message);
                        }
                    }
                    else
                    {
                        if(post.CreatedTime.Value.Day == i_Time.Day && post.CreatedTime.Value.Month == i_Time.Month && post.CreatedTime.Value.Year == i_Time.Year)
                        {
                            i_ListBoxSearchResults.Items.Add(post.Message);
                        }
                    }
                }
            }

            if (i_ListBoxSearchResults.Items.Count == 0)
            {
                MessageBox.Show(string.Format("Not Found"));
            }
        }
    }
}
