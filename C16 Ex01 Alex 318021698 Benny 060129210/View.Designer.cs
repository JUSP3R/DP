namespace C16_Ex01_Alex_318021698_Benny_060129210
{
   public partial class View
    {        
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label timeStringLabel;
            System.Windows.Forms.Label updateTimeLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBoxPostSomething = new System.Windows.Forms.RichTextBox();
            this.buttonSearchPost = new System.Windows.Forms.Button();
            this.listBoxGetPosts = new System.Windows.Forms.ListBox();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.labelHappyBirthday = new System.Windows.Forms.Label();
            this.listBoxHappyBirthday = new System.Windows.Forms.ListBox();
            this.buttonPostHappyBirthday = new System.Windows.Forms.Button();
            this.richTextBoxSearchPost = new System.Windows.Forms.RichTextBox();
            this.labelSearchResults = new System.Windows.Forms.Label();
            this.listBoxSearchResults = new System.Windows.Forms.ListBox();
            this.buttonPostSomething = new System.Windows.Forms.Button();
            this.pictureBoxUserPicture = new System.Windows.Forms.PictureBox();
            this.labelMyWall = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.bar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControlFrendsFeature = new System.Windows.Forms.TabControl();
            this.tabPageHomePage = new System.Windows.Forms.TabPage();
            this.listBoxGetFriends = new System.Windows.Forms.ListBox();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelUserName2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBoxRadioButtons = new System.Windows.Forms.GroupBox();
            this.radioButtonSearchAll = new System.Windows.Forms.RadioButton();
            this.radioButtonSearchByDate = new System.Windows.Forms.RadioButton();
            this.labelFriendsList = new System.Windows.Forms.Label();
            this.tabPageUserStatistics = new System.Windows.Forms.TabPage();
            this.tabPageFeatureEventMarkers = new System.Windows.Forms.TabPage();
            this.updateTimeLabel2 = new System.Windows.Forms.Label();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeStringLabel1 = new System.Windows.Forms.Label();
            this.startTimeLabel1 = new System.Windows.Forms.Label();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.endTimeLabel1 = new System.Windows.Forms.Label();
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            descriptionLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            timeStringLabel = new System.Windows.Forms.Label();
            updateTimeLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).BeginInit();
            this.tabControlFrendsFeature.SuspendLayout();
            this.tabPageHomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.groupBoxRadioButtons.SuspendLayout();
            this.tabPageUserStatistics.SuspendLayout();
            this.tabPageFeatureEventMarkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(325, 61);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(115, 25);
            descriptionLabel.TabIndex = 44;
            descriptionLabel.Text = "Description:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            endTimeLabel.Location = new System.Drawing.Point(325, 240);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(102, 25);
            endTimeLabel.TabIndex = 46;
            endTimeLabel.Text = "End Time:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            startTimeLabel.Location = new System.Drawing.Point(325, 161);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(108, 25);
            startTimeLabel.TabIndex = 63;
            startTimeLabel.Text = "Start Time:";
            // 
            // timeStringLabel
            // 
            timeStringLabel.AutoSize = true;
            timeStringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            timeStringLabel.Location = new System.Drawing.Point(325, 501);
            timeStringLabel.Name = "timeStringLabel";
            timeStringLabel.Size = new System.Drawing.Size(137, 25);
            timeStringLabel.TabIndex = 64;
            timeStringLabel.Text = "Time Created:";
            // 
            // updateTimeLabel1
            // 
            updateTimeLabel1.AutoSize = true;
            updateTimeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            updateTimeLabel1.Location = new System.Drawing.Point(325, 612);
            updateTimeLabel1.Name = "updateTimeLabel1";
            updateTimeLabel1.Size = new System.Drawing.Size(141, 25);
            updateTimeLabel1.TabIndex = 65;
            updateTimeLabel1.Text = "Updated Time:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogin.BackgroundImage")));
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLogin.Location = new System.Drawing.Point(21, 18);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(140, 58);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(21, 297);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 32);
            this.labelUserName.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(928, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.Visible = false;
            // 
            // richTextBoxPostSomething
            // 
            this.richTextBoxPostSomething.Location = new System.Drawing.Point(662, 229);
            this.richTextBoxPostSomething.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxPostSomething.Name = "richTextBoxPostSomething";
            this.richTextBoxPostSomething.Size = new System.Drawing.Size(628, 51);
            this.richTextBoxPostSomething.TabIndex = 16;
            this.richTextBoxPostSomething.Text = string.Empty;
            this.richTextBoxPostSomething.Visible = false;
            // 
            // buttonSearchPost
            // 
            this.buttonSearchPost.BackgroundImage = global::C16_Ex01_Alex_318021698_Benny_060129210.Properties.Resources.facebook_wallpaper;
            this.buttonSearchPost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSearchPost.ForeColor = System.Drawing.Color.White;
            this.buttonSearchPost.Location = new System.Drawing.Point(558, 308);
            this.buttonSearchPost.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchPost.Name = "buttonSearchPost";
            this.buttonSearchPost.Size = new System.Drawing.Size(298, 54);
            this.buttonSearchPost.TabIndex = 17;
            this.buttonSearchPost.Text = "Search Post";
            this.buttonSearchPost.UseVisualStyleBackColor = true;
            this.buttonSearchPost.Visible = false;
            this.buttonSearchPost.Click += new System.EventHandler(this.buttonSearchPost_Click);
            // 
            // listBoxGetPosts
            // 
            this.listBoxGetPosts.DataSource = this.postBindingSource;
            this.listBoxGetPosts.DisplayMember = "Message";
            this.listBoxGetPosts.FormattingEnabled = true;
            this.listBoxGetPosts.ItemHeight = 16;
            this.listBoxGetPosts.Location = new System.Drawing.Point(558, 62);
            this.listBoxGetPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxGetPosts.Name = "listBoxGetPosts";
            this.listBoxGetPosts.Size = new System.Drawing.Size(732, 164);
            this.listBoxGetPosts.TabIndex = 25;
            this.listBoxGetPosts.ValueMember = "Description";
            this.listBoxGetPosts.Visible = false;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(31, 85);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(122, 21);
            this.checkBoxRememberMe.TabIndex = 26;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            this.checkBoxRememberMe.CheckedChanged += new System.EventHandler(this.checkBoxRememberMe_CheckedChanged);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogOut.Image")));
            this.buttonLogOut.Location = new System.Drawing.Point(21, 19);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(165, 57);
            this.buttonLogOut.TabIndex = 27;
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Visible = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelHappyBirthday
            // 
            this.labelHappyBirthday.AutoSize = true;
            this.labelHappyBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHappyBirthday.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHappyBirthday.Image = global::C16_Ex01_Alex_318021698_Benny_060129210.Properties.Resources.facebook_wallpaper;
            this.labelHappyBirthday.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelHappyBirthday.Location = new System.Drawing.Point(67, 363);
            this.labelHappyBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHappyBirthday.Name = "labelHappyBirthday";
            this.labelHappyBirthday.Size = new System.Drawing.Size(214, 31);
            this.labelHappyBirthday.TabIndex = 30;
            this.labelHappyBirthday.Text = "Happy Birthday";
            this.labelHappyBirthday.Visible = false;
            // 
            // listBoxHappyBirthday
            // 
            this.listBoxHappyBirthday.FormattingEnabled = true;
            this.listBoxHappyBirthday.ItemHeight = 16;
            this.listBoxHappyBirthday.Location = new System.Drawing.Point(38, 398);
            this.listBoxHappyBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxHappyBirthday.Name = "listBoxHappyBirthday";
            this.listBoxHappyBirthday.Size = new System.Drawing.Size(307, 84);
            this.listBoxHappyBirthday.TabIndex = 31;
            this.listBoxHappyBirthday.Visible = false;
            // 
            // buttonPostHappyBirthday
            // 
            this.buttonPostHappyBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPostHappyBirthday.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPostHappyBirthday.Image = global::C16_Ex01_Alex_318021698_Benny_060129210.Properties.Resources.facebook_wallpaper;
            this.buttonPostHappyBirthday.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPostHappyBirthday.Location = new System.Drawing.Point(38, 491);
            this.buttonPostHappyBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPostHappyBirthday.Name = "buttonPostHappyBirthday";
            this.buttonPostHappyBirthday.Size = new System.Drawing.Size(307, 53);
            this.buttonPostHappyBirthday.TabIndex = 32;
            this.buttonPostHappyBirthday.Text = "Post Happy Birthday To All";
            this.buttonPostHappyBirthday.UseVisualStyleBackColor = true;
            this.buttonPostHappyBirthday.Visible = false;
            this.buttonPostHappyBirthday.Click += new System.EventHandler(this.buttonSendHappyBirthdayToAll_Click);
            // 
            // richTextBoxSearchPost
            // 
            this.richTextBoxSearchPost.Location = new System.Drawing.Point(864, 308);
            this.richTextBoxSearchPost.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxSearchPost.Name = "richTextBoxSearchPost";
            this.richTextBoxSearchPost.Size = new System.Drawing.Size(430, 50);
            this.richTextBoxSearchPost.TabIndex = 34;
            this.richTextBoxSearchPost.Text = string.Empty;
            this.richTextBoxSearchPost.Visible = false;
            // 
            // labelSearchResults
            // 
            this.labelSearchResults.AutoSize = true;
            this.labelSearchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSearchResults.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSearchResults.Image = global::C16_Ex01_Alex_318021698_Benny_060129210.Properties.Resources.facebook_wallpaper;
            this.labelSearchResults.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSearchResults.Location = new System.Drawing.Point(1077, 374);
            this.labelSearchResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchResults.Name = "labelSearchResults";
            this.labelSearchResults.Size = new System.Drawing.Size(213, 31);
            this.labelSearchResults.TabIndex = 35;
            this.labelSearchResults.Text = "Search Results";
            this.labelSearchResults.Visible = false;
            // 
            // listBoxSearchResults
            // 
            this.listBoxSearchResults.FormattingEnabled = true;
            this.listBoxSearchResults.HorizontalScrollbar = true;
            this.listBoxSearchResults.ItemHeight = 16;
            this.listBoxSearchResults.Location = new System.Drawing.Point(558, 410);
            this.listBoxSearchResults.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSearchResults.Name = "listBoxSearchResults";
            this.listBoxSearchResults.Size = new System.Drawing.Size(736, 132);
            this.listBoxSearchResults.TabIndex = 36;
            this.listBoxSearchResults.Visible = false;
            // 
            // buttonPostSomething
            // 
            this.buttonPostSomething.BackgroundImage = global::C16_Ex01_Alex_318021698_Benny_060129210.Properties.Resources.facebook_wallpaper;
            this.buttonPostSomething.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPostSomething.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPostSomething.Location = new System.Drawing.Point(558, 233);
            this.buttonPostSomething.Name = "buttonPostSomething";
            this.buttonPostSomething.Size = new System.Drawing.Size(97, 47);
            this.buttonPostSomething.TabIndex = 37;
            this.buttonPostSomething.Text = "Post Something";
            this.buttonPostSomething.UseVisualStyleBackColor = true;
            this.buttonPostSomething.Visible = false;
            this.buttonPostSomething.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // pictureBoxUserPicture
            // 
            this.pictureBoxUserPicture.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBoxUserPicture.BackgroundImage = global::C16_Ex01_Alex_318021698_Benny_060129210.Properties.Resources.facebook_wallpaper;
            this.pictureBoxUserPicture.Location = new System.Drawing.Point(948, 590);
            this.pictureBoxUserPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxUserPicture.Name = "pictureBoxUserPicture";
            this.pictureBoxUserPicture.Size = new System.Drawing.Size(195, 121);
            this.pictureBoxUserPicture.TabIndex = 39;
            this.pictureBoxUserPicture.TabStop = false;
            this.pictureBoxUserPicture.Visible = false;
            // 
            // labelMyWall
            // 
            this.labelMyWall.AutoSize = true;
            this.labelMyWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMyWall.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMyWall.Image = global::C16_Ex01_Alex_318021698_Benny_060129210.Properties.Resources.facebook_wallpaper;
            this.labelMyWall.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelMyWall.Location = new System.Drawing.Point(796, 27);
            this.labelMyWall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMyWall.Name = "labelMyWall";
            this.labelMyWall.Size = new System.Drawing.Size(116, 31);
            this.labelMyWall.TabIndex = 40;
            this.labelMyWall.Text = "My Wall";
            this.labelMyWall.Visible = false;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(582, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(730, 741);
            this.webBrowser.TabIndex = 41;
            // 
            // bar
            // 
            chartArea1.Name = "ChartArea1";
            this.bar.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.bar.Legends.Add(legend1);
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Name = "bar";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Teal;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Friends Posts Average";
            series1.YValuesPerPoint = 2;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Purple;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Your Posts";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Your Albums";
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Green;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Friends Albums Average";
            series5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.Fuchsia;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Your Friends";
            series6.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.Lime;
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Friends Friends Average";
            this.bar.Series.Add(series1);
            this.bar.Series.Add(series2);
            this.bar.Series.Add(series3);
            this.bar.Series.Add(series4);
            this.bar.Series.Add(series5);
            this.bar.Series.Add(series6);
            this.bar.Size = new System.Drawing.Size(1315, 747);
            this.bar.TabIndex = 43;
            this.bar.Text = "chart1";
            // 
            // tabControlFrendsFeature
            // 
            this.tabControlFrendsFeature.Controls.Add(this.tabPageHomePage);
            this.tabControlFrendsFeature.Controls.Add(this.tabPageUserStatistics);
            this.tabControlFrendsFeature.Controls.Add(this.tabPageFeatureEventMarkers);
            this.tabControlFrendsFeature.Location = new System.Drawing.Point(0, 1);
            this.tabControlFrendsFeature.Name = "tabControlFrendsFeature";
            this.tabControlFrendsFeature.SelectedIndex = 0;
            this.tabControlFrendsFeature.Size = new System.Drawing.Size(1323, 776);
            this.tabControlFrendsFeature.TabIndex = 44;
            // 
            // tabPageHomePage
            // 
            this.tabPageHomePage.AutoScroll = true;
            this.tabPageHomePage.BackgroundImage = global::C16_Ex01_Alex_318021698_Benny_060129210.Properties.Resources.facebook_wallpaper;
            this.tabPageHomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageHomePage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageHomePage.Controls.Add(this.listBoxGetFriends);
            this.tabPageHomePage.Controls.Add(this.pictureBoxUser);
            this.tabPageHomePage.Controls.Add(this.labelUserName2);
            this.tabPageHomePage.Controls.Add(this.dateTimePicker);
            this.tabPageHomePage.Controls.Add(this.groupBoxRadioButtons);
            this.tabPageHomePage.Controls.Add(this.labelFriendsList);
            this.tabPageHomePage.Controls.Add(this.buttonLogOut);
            this.tabPageHomePage.Controls.Add(this.listBoxSearchResults);
            this.tabPageHomePage.Controls.Add(this.labelSearchResults);
            this.tabPageHomePage.Controls.Add(this.buttonLogin);
            this.tabPageHomePage.Controls.Add(this.labelMyWall);
            this.tabPageHomePage.Controls.Add(this.checkBoxRememberMe);
            this.tabPageHomePage.Controls.Add(this.pictureBoxUserPicture);
            this.tabPageHomePage.Controls.Add(this.buttonPostSomething);
            this.tabPageHomePage.Controls.Add(this.buttonSearchPost);
            this.tabPageHomePage.Controls.Add(this.labelHappyBirthday);
            this.tabPageHomePage.Controls.Add(this.listBoxGetPosts);
            this.tabPageHomePage.Controls.Add(this.richTextBoxPostSomething);
            this.tabPageHomePage.Controls.Add(this.buttonPostHappyBirthday);
            this.tabPageHomePage.Controls.Add(this.listBoxHappyBirthday);
            this.tabPageHomePage.Controls.Add(this.richTextBoxSearchPost);
            this.tabPageHomePage.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageHomePage.Location = new System.Drawing.Point(4, 25);
            this.tabPageHomePage.Name = "tabPageHomePage";
            this.tabPageHomePage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHomePage.Size = new System.Drawing.Size(1315, 747);
            this.tabPageHomePage.TabIndex = 0;
            this.tabPageHomePage.Text = "Home Page";
            // 
            // listBoxGetFriends
            // 
            this.listBoxGetFriends.DataSource = this.membersBindingSource;
            this.listBoxGetFriends.DisplayMember = "Name";
            this.listBoxGetFriends.FormattingEnabled = true;
            this.listBoxGetFriends.ItemHeight = 16;
            this.listBoxGetFriends.Location = new System.Drawing.Point(1149, 596);
            this.listBoxGetFriends.Name = "listBoxGetFriends";
            this.listBoxGetFriends.Size = new System.Drawing.Size(147, 116);
            this.listBoxGetFriends.TabIndex = 48;
            this.listBoxGetFriends.ValueMember = "Id";
            this.listBoxGetFriends.Visible = false;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.pictureBoxUser.Location = new System.Drawing.Point(39, 208);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUser.TabIndex = 48;
            this.pictureBoxUser.TabStop = false;
            this.pictureBoxUser.Visible = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // labelUserName2
            // 
            this.labelUserName2.AutoSize = true;
            this.labelUserName2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.labelUserName2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.userBindingSource, "Name", true));
            this.labelUserName2.Font = new System.Drawing.Font("Miriam", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUserName2.Location = new System.Drawing.Point(38, 165);
            this.labelUserName2.Name = "labelUserName2";
            this.labelUserName2.Size = new System.Drawing.Size(0, 31);
            this.labelUserName2.TabIndex = 47;
            this.labelUserName2.Visible = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(862, 381);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 46;
            this.dateTimePicker.Visible = false;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // groupBoxRadioButtons
            // 
            this.groupBoxRadioButtons.BackColor = System.Drawing.Color.White;
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonSearchAll);
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonSearchByDate);
            this.groupBoxRadioButtons.Location = new System.Drawing.Point(558, 363);
            this.groupBoxRadioButtons.Name = "groupBoxRadioButtons";
            this.groupBoxRadioButtons.Size = new System.Drawing.Size(298, 43);
            this.groupBoxRadioButtons.TabIndex = 44;
            this.groupBoxRadioButtons.TabStop = false;
            this.groupBoxRadioButtons.Text = "Options";
            this.groupBoxRadioButtons.Visible = false;
            // 
            // radioButtonSearchAll
            // 
            this.radioButtonSearchAll.AutoSize = true;
            this.radioButtonSearchAll.Checked = true;
            this.radioButtonSearchAll.Location = new System.Drawing.Point(6, 22);
            this.radioButtonSearchAll.Name = "radioButtonSearchAll";
            this.radioButtonSearchAll.Size = new System.Drawing.Size(132, 21);
            this.radioButtonSearchAll.TabIndex = 42;
            this.radioButtonSearchAll.TabStop = true;
            this.radioButtonSearchAll.Text = "Search All Posts";
            this.radioButtonSearchAll.UseVisualStyleBackColor = true;
            this.radioButtonSearchAll.CheckedChanged += new System.EventHandler(this.radioButtonSearchAll_CheckedChanged);
            // 
            // radioButtonSearchByDate
            // 
            this.radioButtonSearchByDate.AutoSize = true;
            this.radioButtonSearchByDate.Location = new System.Drawing.Point(170, 21);
            this.radioButtonSearchByDate.Name = "radioButtonSearchByDate";
            this.radioButtonSearchByDate.Size = new System.Drawing.Size(128, 21);
            this.radioButtonSearchByDate.TabIndex = 43;
            this.radioButtonSearchByDate.Text = "Search By Date";
            this.radioButtonSearchByDate.UseVisualStyleBackColor = true;
            this.radioButtonSearchByDate.CheckedChanged += new System.EventHandler(this.radioButtonSearchByDate_CheckedChanged);
            // 
            // labelFriendsList
            // 
            this.labelFriendsList.AutoSize = true;
            this.labelFriendsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendsList.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFriendsList.Image = global::C16_Ex01_Alex_318021698_Benny_060129210.Properties.Resources.facebook_wallpaper;
            this.labelFriendsList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelFriendsList.Location = new System.Drawing.Point(1164, 542);
            this.labelFriendsList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFriendsList.Name = "labelFriendsList";
            this.labelFriendsList.Size = new System.Drawing.Size(112, 31);
            this.labelFriendsList.TabIndex = 41;
            this.labelFriendsList.Text = "Friends";
            this.labelFriendsList.Visible = false;
            // 
            // tabPageUserStatistics
            // 
            this.tabPageUserStatistics.BackgroundImage = global::C16_Ex01_Alex_318021698_Benny_060129210.Properties.Resources.facebook_wallpaper;
            this.tabPageUserStatistics.Controls.Add(this.bar);
            this.tabPageUserStatistics.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tabPageUserStatistics.Location = new System.Drawing.Point(4, 25);
            this.tabPageUserStatistics.Name = "tabPageUserStatistics";
            this.tabPageUserStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserStatistics.Size = new System.Drawing.Size(1315, 747);
            this.tabPageUserStatistics.TabIndex = 1;
            this.tabPageUserStatistics.Tag = "All User Statistics";
            this.tabPageUserStatistics.Text = "User Statistics";
            this.tabPageUserStatistics.UseVisualStyleBackColor = true;
            // 
            // tabPageFeatureEventMarkers
            // 
            this.tabPageFeatureEventMarkers.AutoScroll = true;
            this.tabPageFeatureEventMarkers.BackgroundImage = global::C16_Ex01_Alex_318021698_Benny_060129210.Properties.Resources.facebook_wallpaper;
            this.tabPageFeatureEventMarkers.Controls.Add(updateTimeLabel1);
            this.tabPageFeatureEventMarkers.Controls.Add(this.updateTimeLabel2);
            this.tabPageFeatureEventMarkers.Controls.Add(timeStringLabel);
            this.tabPageFeatureEventMarkers.Controls.Add(this.timeStringLabel1);
            this.tabPageFeatureEventMarkers.Controls.Add(startTimeLabel);
            this.tabPageFeatureEventMarkers.Controls.Add(this.startTimeLabel1);
            this.tabPageFeatureEventMarkers.Controls.Add(descriptionLabel);
            this.tabPageFeatureEventMarkers.Controls.Add(this.descriptionLabel1);
            this.tabPageFeatureEventMarkers.Controls.Add(endTimeLabel);
            this.tabPageFeatureEventMarkers.Controls.Add(this.endTimeLabel1);
            this.tabPageFeatureEventMarkers.Controls.Add(this.imageLargePictureBox);
            this.tabPageFeatureEventMarkers.Controls.Add(this.label1);
            this.tabPageFeatureEventMarkers.Controls.Add(this.listBoxEvents);
            this.tabPageFeatureEventMarkers.Controls.Add(this.webBrowser);
            this.tabPageFeatureEventMarkers.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tabPageFeatureEventMarkers.Location = new System.Drawing.Point(4, 25);
            this.tabPageFeatureEventMarkers.Name = "tabPageFeatureEventMarkers";
            this.tabPageFeatureEventMarkers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFeatureEventMarkers.Size = new System.Drawing.Size(1315, 747);
            this.tabPageFeatureEventMarkers.TabIndex = 2;
            this.tabPageFeatureEventMarkers.Text = "Events";
            this.tabPageFeatureEventMarkers.UseVisualStyleBackColor = true;
            // 
            // updateTimeLabel2
            // 
            this.updateTimeLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "UpdateTime", true));
            this.updateTimeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateTimeLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateTimeLabel2.Location = new System.Drawing.Point(262, 653);
            this.updateTimeLabel2.Name = "updateTimeLabel2";
            this.updateTimeLabel2.Size = new System.Drawing.Size(290, 49);
            this.updateTimeLabel2.TabIndex = 66;
            this.updateTimeLabel2.Text = "label2";
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "Events";
            this.eventsBindingSource.DataSource = this.userBindingSource;
            // 
            // timeStringLabel1
            // 
            this.timeStringLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "TimeString", true));
            this.timeStringLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeStringLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.timeStringLabel1.Location = new System.Drawing.Point(262, 542);
            this.timeStringLabel1.Name = "timeStringLabel1";
            this.timeStringLabel1.Size = new System.Drawing.Size(274, 43);
            this.timeStringLabel1.TabIndex = 65;
            this.timeStringLabel1.Text = "label2";
            // 
            // startTimeLabel1
            // 
            this.startTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "StartTime", true));
            this.startTimeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTimeLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startTimeLabel1.Location = new System.Drawing.Point(275, 186);
            this.startTimeLabel1.Name = "startTimeLabel1";
            this.startTimeLabel1.Size = new System.Drawing.Size(277, 45);
            this.startTimeLabel1.TabIndex = 64;
            this.startTimeLabel1.Text = "label2";
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "Description", true));
            this.descriptionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.descriptionLabel1.Location = new System.Drawing.Point(275, 103);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(277, 48);
            this.descriptionLabel1.TabIndex = 45;
            this.descriptionLabel1.Text = "label2";
            // 
            // endTimeLabel1
            // 
            this.endTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventsBindingSource, "EndTime", true));
            this.endTimeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endTimeLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.endTimeLabel1.Location = new System.Drawing.Point(267, 277);
            this.endTimeLabel1.Name = "endTimeLabel1";
            this.endTimeLabel1.Size = new System.Drawing.Size(285, 46);
            this.endTimeLabel1.TabIndex = 47;
            this.endTimeLabel1.Text = "label2";
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventsBindingSource, "ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(267, 346);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(303, 131);
            this.imageLargePictureBox.TabIndex = 49;
            this.imageLargePictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Image = global::C16_Ex01_Alex_318021698_Benny_060129210.Properties.Resources.facebook_wallpaper;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 44;
            this.label1.Text = "List of Events";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxEvents.DataSource = this.eventsBindingSource;
            this.listBoxEvents.DisplayMember = "Name";
            this.listBoxEvents.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.HorizontalScrollbar = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(2, 46);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(236, 692);
            this.listBoxEvents.TabIndex = 43;
            this.listBoxEvents.ValueMember = "Description";
            this.listBoxEvents.Visible = false;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // View
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1369, 777);
            this.Controls.Add(this.tabControlFrendsFeature);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomePage";
            this.Text = "Faceebook App";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).EndInit();
            this.tabControlFrendsFeature.ResumeLayout(false);
            this.tabPageHomePage.ResumeLayout(false);
            this.tabPageHomePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.groupBoxRadioButtons.ResumeLayout(false);
            this.groupBoxRadioButtons.PerformLayout();
            this.tabPageUserStatistics.ResumeLayout(false);
            this.tabPageFeatureEventMarkers.ResumeLayout(false);
            this.tabPageFeatureEventMarkers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBoxPostSomething;
        private System.Windows.Forms.Button buttonSearchPost;
        private System.Windows.Forms.ListBox listBoxGetPosts;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label labelHappyBirthday;
        private System.Windows.Forms.ListBox listBoxHappyBirthday;
        private System.Windows.Forms.Button buttonPostHappyBirthday;
        private System.Windows.Forms.RichTextBox richTextBoxSearchPost;
        private System.Windows.Forms.Label labelSearchResults;
        private System.Windows.Forms.ListBox listBoxSearchResults;
        private System.Windows.Forms.Button buttonPostSomething;
        private System.Windows.Forms.PictureBox pictureBoxUserPicture;
        private System.Windows.Forms.Label labelMyWall;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.DataVisualization.Charting.Chart bar;
        private System.Windows.Forms.TabControl tabControlFrendsFeature;
        private System.Windows.Forms.TabPage tabPageHomePage;
        private System.Windows.Forms.TabPage tabPageUserStatistics;
        private System.Windows.Forms.TabPage tabPageFeatureEventMarkers;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFriendsList;
        private System.Windows.Forms.GroupBox groupBoxRadioButtons;
        private System.Windows.Forms.RadioButton radioButtonSearchAll;
        private System.Windows.Forms.RadioButton radioButtonSearchByDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label labelUserName2;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.ListBox listBoxGetFriends;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label endTimeLabel1;
        private System.Windows.Forms.PictureBox imageLargePictureBox;
        private System.Windows.Forms.Label startTimeLabel1;
        private System.Windows.Forms.Label updateTimeLabel2;
        private System.Windows.Forms.Label timeStringLabel1;
        private System.Windows.Forms.BindingSource postBindingSource;
    }
}