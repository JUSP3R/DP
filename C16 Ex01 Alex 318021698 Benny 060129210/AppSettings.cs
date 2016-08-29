using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace C16_Ex01_Alex_318021698_Benny_060129210
{
    public class AppSettings
    {
        private readonly string r_FileName = @"C:\App\applicatonSettings.xml";

        public string FileNamePath
        {
            get { return r_FileName; }
        }

        public string LastAccessToken { get; set; }

        public bool AutoConnect { get; set; }

        public Size LastWindowSize { get; set; }

        public Point LastWindowLocation { get; set; }

        private AppSettings()
        {
            LastAccessToken = string.Empty;
            AutoConnect = false;
            LastWindowSize = new Size(800, 800);
            LastWindowLocation = new Point(50, 50);
        }

        public static AppSettings ReadFromFile()
        {
            AppSettings newObject = null;
            if (File.Exists(@"C:\App\applicatonSettings.xml"))
            {
                using (FileStream stream = new FileStream(@"C:\App\applicatonSettings.xml", FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    newObject = serializer.Deserialize(stream) as AppSettings;
                }

                if (newObject == null)
                {
                    newObject = new AppSettings();
                }
            }

            return newObject;
        }

        public void SaveToFile()
        {
            FileStream stream = null;
            XmlSerializer serializer = null;
            if (!File.Exists(r_FileName))
            {
                serializer = new XmlSerializer(GetType());
                using (stream = new FileStream(FileNamePath, FileMode.CreateNew, FileAccess.ReadWrite))
                {
                    serializer.Serialize(stream, this);
                }
            }
            else
            {
                serializer = new XmlSerializer(GetType());
                using (stream = new FileStream(FileNamePath, FileMode.Truncate, FileAccess.ReadWrite))
                {
                    serializer.Serialize(stream, this);
                }
            }

            stream.Close();
        }
    }
}
