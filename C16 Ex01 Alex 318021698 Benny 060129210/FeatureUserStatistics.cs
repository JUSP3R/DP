using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using FacebookWrapper.ObjectModel;

namespace C16_Ex01_Alex_318021698_Benny_060129210
{
    public class FeatureUserStatistics
    {
        public void FillGraphs(FacebookSessionData i_SessionData, Chart i_bar)
        {
            int sumFriends = 0;
            int sumAlbums = 0;
            int sumPosts = 0;
            int counter = 0;

            foreach (User friend in i_SessionData.LoggedInUser.Friends)
            {
                sumFriends += friend.Friends.Count;
                sumPosts += friend.Posts.Count;
                sumAlbums += friend.Albums.Count;
                counter++;
            }

            double averagePosts = sumPosts / counter;
            double averageAlbums = sumAlbums / counter;
            double averageFriends = sumFriends / counter;

            i_bar.Series["Friends Posts Average"].Points.AddXY(" ", averagePosts);
            i_bar.Series["Your Posts"].Points.AddXY(" ", i_SessionData.LoggedInUser.Posts.Count);
            i_bar.Series["Friends Albums Average"].Points.AddXY(" ", averageAlbums);
            i_bar.Series["Your Albums"].Points.AddXY(" ", i_SessionData.LoggedInUser.Albums.Count);
            i_bar.Series["Friends Friends Average"].Points.AddXY(" ", averageFriends);
            i_bar.Series["Your Friends"].Points.AddXY(" ", i_SessionData.LoggedInUser.Friends.Count);
        }
    }
}
