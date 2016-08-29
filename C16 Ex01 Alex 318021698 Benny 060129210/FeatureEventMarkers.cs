using System;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace C16_Ex01_Alex_318021698_Benny_060129210
{
    public class FeatureEventMarkers
    {
        public void GetMapsMarkers(FacebookSessionData i_SessionData, WebBrowser i_webBrowser)
        {
            i_webBrowser.ScriptErrorsSuppressed = true;
            if (i_SessionData.LoggedInUser.Events != null)
            {
                StringBuilder stringBuilder = new StringBuilder();
                bool firstFlag = true;
                stringBuilder.Append("http://dp-c16.azurewebsites.net/index.html?");
                foreach (Event _event in i_SessionData.LoggedInUser.Events)
                {
                    if (_event.Place != null && _event.Place.Location != null && _event.Place.Location.Latitude != null && _event.Place.Location.Longitude != null)
                    {
                        if (!firstFlag)
                        {
                            stringBuilder.Append("&");
                        }
                        else
                        {
                            firstFlag = false;
                        }
                        
                        stringBuilder.Append(_event.Place.Name);
                        stringBuilder.Append("&");
                        stringBuilder.Append(_event.Place.Location.Latitude);
                        stringBuilder.Append("&");
                        stringBuilder.Append(_event.Place.Location.Longitude);
                    }
                }

                i_webBrowser.Navigate(new Uri(stringBuilder.ToString()));
            }
        } 
    }
}