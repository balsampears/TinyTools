namespace WechatOfficialAccountUtils
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelAppid = new System.Windows.Forms.Label();
            this.labelAppsecret = new System.Windows.Forms.Label();
            this.textBoxAppid = new System.Windows.Forms.TextBox();
            this.textBoxAppSecret = new System.Windows.Forms.TextBox();
            this.buttonGetAccessToken = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonMenuHelp = new System.Windows.Forms.Button();
            this.textBoxMenu = new System.Windows.Forms.TextBox();
            this.buttonCreateMenu = new System.Windows.Forms.Button();
            this.buttonQueryMenu = new System.Windows.Forms.Button();
            this.buttonDeleteMenu = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMediaId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUpdateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonCountResource = new System.Windows.Forms.Button();
            this.labelNewsCount = new System.Windows.Forms.Label();
            this.labelImageCount = new System.Windows.Forms.Label();
            this.labelVideoCount = new System.Windows.Forms.Label();
            this.labelVoiceCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonNews = new System.Windows.Forms.RadioButton();
            this.radioButtonVideo = new System.Windows.Forms.RadioButton();
            this.buttonQueryResource = new System.Windows.Forms.Button();
            this.buttonUploadResource = new System.Windows.Forms.Button();
            this.radioButtonVoice = new System.Windows.Forms.RadioButton();
            this.radioButtonImage = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonTemplateHelp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTemplateUrl = new System.Windows.Forms.TextBox();
            this.textBoxTemplateUsers = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTemplateSend = new System.Windows.Forms.Button();
            this.textBoxTemplateId = new System.Windows.Forms.TextBox();
            this.textBoxTemplateContent = new System.Windows.Forms.TextBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAccessTokenCopy = new System.Windows.Forms.Button();
            this.buttonLogClear = new System.Windows.Forms.Button();
            this.pageControl1 = new WechatOfficialAccountUtils.PageControl();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAppid
            // 
            this.labelAppid.AutoSize = true;
            this.labelAppid.Location = new System.Drawing.Point(19, 33);
            this.labelAppid.Name = "labelAppid";
            this.labelAppid.Size = new System.Drawing.Size(35, 12);
            this.labelAppid.TabIndex = 0;
            this.labelAppid.Text = "appid";
            // 
            // labelAppsecret
            // 
            this.labelAppsecret.AutoSize = true;
            this.labelAppsecret.Location = new System.Drawing.Point(205, 34);
            this.labelAppsecret.Name = "labelAppsecret";
            this.labelAppsecret.Size = new System.Drawing.Size(59, 12);
            this.labelAppsecret.TabIndex = 1;
            this.labelAppsecret.Text = "appsecret";
            // 
            // textBoxAppid
            // 
            this.textBoxAppid.Location = new System.Drawing.Point(66, 29);
            this.textBoxAppid.Name = "textBoxAppid";
            this.textBoxAppid.Size = new System.Drawing.Size(124, 21);
            this.textBoxAppid.TabIndex = 2;
            // 
            // textBoxAppSecret
            // 
            this.textBoxAppSecret.Location = new System.Drawing.Point(271, 29);
            this.textBoxAppSecret.Name = "textBoxAppSecret";
            this.textBoxAppSecret.Size = new System.Drawing.Size(209, 21);
            this.textBoxAppSecret.TabIndex = 3;
            // 
            // buttonGetAccessToken
            // 
            this.buttonGetAccessToken.Location = new System.Drawing.Point(491, 15);
            this.buttonGetAccessToken.Name = "buttonGetAccessToken";
            this.buttonGetAccessToken.Size = new System.Drawing.Size(125, 35);
            this.buttonGetAccessToken.TabIndex = 4;
            this.buttonGetAccessToken.Text = "获取accessToken";
            this.buttonGetAccessToken.UseVisualStyleBackColor = true;
            this.buttonGetAccessToken.Click += new System.EventHandler(this.buttonGetAccessToken_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonMenuHelp);
            this.tabPage1.Controls.Add(this.textBoxMenu);
            this.tabPage1.Controls.Add(this.buttonCreateMenu);
            this.tabPage1.Controls.Add(this.buttonQueryMenu);
            this.tabPage1.Controls.Add(this.buttonDeleteMenu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "菜单管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonMenuHelp
            // 
            this.buttonMenuHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMenuHelp.Location = new System.Drawing.Point(631, 315);
            this.buttonMenuHelp.Name = "buttonMenuHelp";
            this.buttonMenuHelp.Size = new System.Drawing.Size(25, 25);
            this.buttonMenuHelp.TabIndex = 14;
            this.buttonMenuHelp.UseVisualStyleBackColor = true;
            this.buttonMenuHelp.Click += new System.EventHandler(this.buttonMenuHelp_Click);
            // 
            // textBoxMenu
            // 
            this.textBoxMenu.Location = new System.Drawing.Point(19, 24);
            this.textBoxMenu.Multiline = true;
            this.textBoxMenu.Name = "textBoxMenu";
            this.textBoxMenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMenu.Size = new System.Drawing.Size(477, 301);
            this.textBoxMenu.TabIndex = 6;
            // 
            // buttonCreateMenu
            // 
            this.buttonCreateMenu.Location = new System.Drawing.Point(511, 24);
            this.buttonCreateMenu.Name = "buttonCreateMenu";
            this.buttonCreateMenu.Size = new System.Drawing.Size(123, 46);
            this.buttonCreateMenu.TabIndex = 7;
            this.buttonCreateMenu.Text = "创建自定义菜单";
            this.buttonCreateMenu.UseVisualStyleBackColor = true;
            this.buttonCreateMenu.Click += new System.EventHandler(this.buttonCreateMenu_Click);
            // 
            // buttonQueryMenu
            // 
            this.buttonQueryMenu.Location = new System.Drawing.Point(511, 152);
            this.buttonQueryMenu.Name = "buttonQueryMenu";
            this.buttonQueryMenu.Size = new System.Drawing.Size(123, 46);
            this.buttonQueryMenu.TabIndex = 9;
            this.buttonQueryMenu.Text = "查询自定义菜单";
            this.buttonQueryMenu.UseVisualStyleBackColor = true;
            this.buttonQueryMenu.Click += new System.EventHandler(this.buttonQueryMenu_Click);
            // 
            // buttonDeleteMenu
            // 
            this.buttonDeleteMenu.Location = new System.Drawing.Point(511, 86);
            this.buttonDeleteMenu.Name = "buttonDeleteMenu";
            this.buttonDeleteMenu.Size = new System.Drawing.Size(123, 46);
            this.buttonDeleteMenu.TabIndex = 8;
            this.buttonDeleteMenu.Text = "删除自定义菜单";
            this.buttonDeleteMenu.UseVisualStyleBackColor = true;
            this.buttonDeleteMenu.Click += new System.EventHandler(this.buttonDeleteMenu_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(31, 80);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 377);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pageControl1);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "素材管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderMediaId,
            this.columnHeaderUpdateTime,
            this.columnHeaderUrl});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.HotTracking = true;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(183, 4);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(472, 324);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listViewClick);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "名称/内容";
            this.columnHeaderName.Width = 66;
            // 
            // columnHeaderMediaId
            // 
            this.columnHeaderMediaId.Text = "media_id";
            this.columnHeaderMediaId.Width = 66;
            // 
            // columnHeaderUpdateTime
            // 
            this.columnHeaderUpdateTime.Text = "更新时间";
            this.columnHeaderUpdateTime.Width = 83;
            // 
            // columnHeaderUrl
            // 
            this.columnHeaderUrl.Text = "资源地址";
            this.columnHeaderUrl.Width = 82;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonCountResource);
            this.groupBox4.Controls.Add(this.labelNewsCount);
            this.groupBox4.Controls.Add(this.labelImageCount);
            this.groupBox4.Controls.Add(this.labelVideoCount);
            this.groupBox4.Controls.Add(this.labelVoiceCount);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(9, 8);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(156, 94);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "永久素材总数";
            // 
            // buttonCountResource
            // 
            this.buttonCountResource.Location = new System.Drawing.Point(19, 64);
            this.buttonCountResource.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCountResource.Name = "buttonCountResource";
            this.buttonCountResource.Size = new System.Drawing.Size(118, 22);
            this.buttonCountResource.TabIndex = 8;
            this.buttonCountResource.Text = "查询";
            this.buttonCountResource.UseVisualStyleBackColor = true;
            this.buttonCountResource.Click += new System.EventHandler(this.buttonCountResource_Click);
            // 
            // labelNewsCount
            // 
            this.labelNewsCount.AutoSize = true;
            this.labelNewsCount.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNewsCount.Location = new System.Drawing.Point(119, 43);
            this.labelNewsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNewsCount.Name = "labelNewsCount";
            this.labelNewsCount.Size = new System.Drawing.Size(14, 14);
            this.labelNewsCount.TabIndex = 7;
            this.labelNewsCount.Text = "0";
            // 
            // labelImageCount
            // 
            this.labelImageCount.AutoSize = true;
            this.labelImageCount.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelImageCount.Location = new System.Drawing.Point(119, 19);
            this.labelImageCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImageCount.Name = "labelImageCount";
            this.labelImageCount.Size = new System.Drawing.Size(14, 14);
            this.labelImageCount.TabIndex = 6;
            this.labelImageCount.Text = "0";
            // 
            // labelVideoCount
            // 
            this.labelVideoCount.AutoSize = true;
            this.labelVideoCount.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVideoCount.Location = new System.Drawing.Point(50, 43);
            this.labelVideoCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVideoCount.Name = "labelVideoCount";
            this.labelVideoCount.Size = new System.Drawing.Size(14, 14);
            this.labelVideoCount.TabIndex = 5;
            this.labelVideoCount.Text = "0";
            // 
            // labelVoiceCount
            // 
            this.labelVoiceCount.AutoSize = true;
            this.labelVoiceCount.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVoiceCount.Location = new System.Drawing.Point(50, 19);
            this.labelVoiceCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVoiceCount.Name = "labelVoiceCount";
            this.labelVoiceCount.Size = new System.Drawing.Size(14, 14);
            this.labelVoiceCount.TabIndex = 4;
            this.labelVoiceCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(83, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "图文";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(83, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "图片";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "视频";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "语音";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonNews);
            this.groupBox3.Controls.Add(this.radioButtonVideo);
            this.groupBox3.Controls.Add(this.buttonQueryResource);
            this.groupBox3.Controls.Add(this.buttonUploadResource);
            this.groupBox3.Controls.Add(this.radioButtonVoice);
            this.groupBox3.Controls.Add(this.radioButtonImage);
            this.groupBox3.Location = new System.Drawing.Point(9, 106);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(156, 121);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "永久素材";
            // 
            // radioButtonNews
            // 
            this.radioButtonNews.AutoSize = true;
            this.radioButtonNews.Location = new System.Drawing.Point(79, 39);
            this.radioButtonNews.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNews.Name = "radioButtonNews";
            this.radioButtonNews.Size = new System.Drawing.Size(47, 16);
            this.radioButtonNews.TabIndex = 3;
            this.radioButtonNews.TabStop = true;
            this.radioButtonNews.Text = "图文";
            this.radioButtonNews.UseVisualStyleBackColor = true;
            this.radioButtonNews.CheckedChanged += new System.EventHandler(this.radioButtonNews_CheckedChanged);
            // 
            // radioButtonVideo
            // 
            this.radioButtonVideo.AutoSize = true;
            this.radioButtonVideo.Location = new System.Drawing.Point(79, 19);
            this.radioButtonVideo.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonVideo.Name = "radioButtonVideo";
            this.radioButtonVideo.Size = new System.Drawing.Size(47, 16);
            this.radioButtonVideo.TabIndex = 2;
            this.radioButtonVideo.TabStop = true;
            this.radioButtonVideo.Text = "视频";
            this.radioButtonVideo.UseVisualStyleBackColor = true;
            this.radioButtonVideo.CheckedChanged += new System.EventHandler(this.radioButtonVideo_CheckedChanged);
            // 
            // buttonQueryResource
            // 
            this.buttonQueryResource.Location = new System.Drawing.Point(19, 91);
            this.buttonQueryResource.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQueryResource.Name = "buttonQueryResource";
            this.buttonQueryResource.Size = new System.Drawing.Size(118, 22);
            this.buttonQueryResource.TabIndex = 9;
            this.buttonQueryResource.Text = "查询";
            this.buttonQueryResource.UseVisualStyleBackColor = true;
            this.buttonQueryResource.Click += new System.EventHandler(this.buttonQueryResource_Click);
            // 
            // buttonUploadResource
            // 
            this.buttonUploadResource.Location = new System.Drawing.Point(19, 65);
            this.buttonUploadResource.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUploadResource.Name = "buttonUploadResource";
            this.buttonUploadResource.Size = new System.Drawing.Size(118, 22);
            this.buttonUploadResource.TabIndex = 9;
            this.buttonUploadResource.Text = "上传（未完成）";
            this.buttonUploadResource.UseVisualStyleBackColor = true;
            this.buttonUploadResource.Click += new System.EventHandler(this.buttonUploadResource_Click);
            // 
            // radioButtonVoice
            // 
            this.radioButtonVoice.AutoSize = true;
            this.radioButtonVoice.Location = new System.Drawing.Point(16, 40);
            this.radioButtonVoice.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonVoice.Name = "radioButtonVoice";
            this.radioButtonVoice.Size = new System.Drawing.Size(47, 16);
            this.radioButtonVoice.TabIndex = 1;
            this.radioButtonVoice.TabStop = true;
            this.radioButtonVoice.Text = "语音";
            this.radioButtonVoice.UseVisualStyleBackColor = true;
            this.radioButtonVoice.CheckedChanged += new System.EventHandler(this.radioButtonVoice_CheckedChanged);
            // 
            // radioButtonImage
            // 
            this.radioButtonImage.AutoSize = true;
            this.radioButtonImage.Location = new System.Drawing.Point(16, 19);
            this.radioButtonImage.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonImage.Name = "radioButtonImage";
            this.radioButtonImage.Size = new System.Drawing.Size(47, 16);
            this.radioButtonImage.TabIndex = 0;
            this.radioButtonImage.TabStop = true;
            this.radioButtonImage.Text = "图片";
            this.radioButtonImage.UseVisualStyleBackColor = true;
            this.radioButtonImage.CheckedChanged += new System.EventHandler(this.radioButtonImage_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonTemplateHelp);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textBoxTemplateUrl);
            this.tabPage3.Controls.Add(this.textBoxTemplateUsers);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.buttonTemplateSend);
            this.tabPage3.Controls.Add(this.textBoxTemplateId);
            this.tabPage3.Controls.Add(this.textBoxTemplateContent);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(673, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "模板管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonTemplateHelp
            // 
            this.buttonTemplateHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTemplateHelp.Location = new System.Drawing.Point(631, 315);
            this.buttonTemplateHelp.Name = "buttonTemplateHelp";
            this.buttonTemplateHelp.Size = new System.Drawing.Size(25, 25);
            this.buttonTemplateHelp.TabIndex = 17;
            this.buttonTemplateHelp.UseVisualStyleBackColor = true;
            this.buttonTemplateHelp.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "点击URL";
            // 
            // textBoxTemplateUrl
            // 
            this.textBoxTemplateUrl.Location = new System.Drawing.Point(77, 42);
            this.textBoxTemplateUrl.Name = "textBoxTemplateUrl";
            this.textBoxTemplateUrl.Size = new System.Drawing.Size(394, 21);
            this.textBoxTemplateUrl.TabIndex = 15;
            // 
            // textBoxTemplateUsers
            // 
            this.textBoxTemplateUsers.Location = new System.Drawing.Point(329, 91);
            this.textBoxTemplateUsers.Multiline = true;
            this.textBoxTemplateUsers.Name = "textBoxTemplateUsers";
            this.textBoxTemplateUsers.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTemplateUsers.Size = new System.Drawing.Size(280, 243);
            this.textBoxTemplateUsers.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "用户列表（用户openid，回车另起）";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "模板内容（data中的JSON）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "模板Id";
            // 
            // buttonTemplateSend
            // 
            this.buttonTemplateSend.Location = new System.Drawing.Point(484, 15);
            this.buttonTemplateSend.Name = "buttonTemplateSend";
            this.buttonTemplateSend.Size = new System.Drawing.Size(161, 48);
            this.buttonTemplateSend.TabIndex = 10;
            this.buttonTemplateSend.Text = "批量发送模板消息";
            this.buttonTemplateSend.UseVisualStyleBackColor = true;
            this.buttonTemplateSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTemplateId
            // 
            this.textBoxTemplateId.Location = new System.Drawing.Point(77, 15);
            this.textBoxTemplateId.Name = "textBoxTemplateId";
            this.textBoxTemplateId.Size = new System.Drawing.Size(394, 21);
            this.textBoxTemplateId.TabIndex = 8;
            // 
            // textBoxTemplateContent
            // 
            this.textBoxTemplateContent.Location = new System.Drawing.Point(21, 91);
            this.textBoxTemplateContent.Multiline = true;
            this.textBoxTemplateContent.Name = "textBoxTemplateContent";
            this.textBoxTemplateContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTemplateContent.Size = new System.Drawing.Size(280, 243);
            this.textBoxTemplateContent.TabIndex = 7;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(31, 463);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(637, 64);
            this.textBoxLog.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAccessTokenCopy);
            this.groupBox1.Controls.Add(this.textBoxAppid);
            this.groupBox1.Controls.Add(this.textBoxAppSecret);
            this.groupBox1.Controls.Add(this.labelAppid);
            this.groupBox1.Controls.Add(this.buttonGetAccessToken);
            this.groupBox1.Controls.Add(this.labelAppsecret);
            this.groupBox1.Location = new System.Drawing.Point(35, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 58);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "载入订阅号/服务号信息";
            // 
            // buttonAccessTokenCopy
            // 
            this.buttonAccessTokenCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAccessTokenCopy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAccessTokenCopy.Location = new System.Drawing.Point(624, 15);
            this.buttonAccessTokenCopy.Name = "buttonAccessTokenCopy";
            this.buttonAccessTokenCopy.Size = new System.Drawing.Size(37, 37);
            this.buttonAccessTokenCopy.TabIndex = 5;
            this.buttonAccessTokenCopy.Text = "复制";
            this.buttonAccessTokenCopy.UseVisualStyleBackColor = true;
            this.buttonAccessTokenCopy.Click += new System.EventHandler(this.buttonAccessTokenCopy_Click);
            // 
            // buttonLogClear
            // 
            this.buttonLogClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogClear.Location = new System.Drawing.Point(683, 502);
            this.buttonLogClear.Name = "buttonLogClear";
            this.buttonLogClear.Size = new System.Drawing.Size(25, 25);
            this.buttonLogClear.TabIndex = 13;
            this.buttonLogClear.UseVisualStyleBackColor = true;
            this.buttonLogClear.Click += new System.EventHandler(this.buttonLogClear_Click);
            // 
            // pageControl1
            // 
            this.pageControl1.Current = 0;
            this.pageControl1.Enabled = false;
            this.pageControl1.Location = new System.Drawing.Point(22, 232);
            this.pageControl1.Name = "pageControl1";
            this.pageControl1.PageSize = 10;
            this.pageControl1.Size = new System.Drawing.Size(120, 36);
            this.pageControl1.TabIndex = 10;
            this.pageControl1.Total = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 539);
            this.Controls.Add(this.buttonLogClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "微信公众号辅助工具1.0 By zhu";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAppid;
        private System.Windows.Forms.Label labelAppsecret;
        private System.Windows.Forms.TextBox textBoxAppid;
        private System.Windows.Forms.TextBox textBoxAppSecret;
        private System.Windows.Forms.Button buttonGetAccessToken;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxMenu;
        private System.Windows.Forms.Button buttonCreateMenu;
        private System.Windows.Forms.Button buttonQueryMenu;
        private System.Windows.Forms.Button buttonDeleteMenu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderMediaId;
        private System.Windows.Forms.ColumnHeader columnHeaderUpdateTime;
        private System.Windows.Forms.ColumnHeader columnHeaderUrl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonCountResource;
        private System.Windows.Forms.Label labelNewsCount;
        private System.Windows.Forms.Label labelImageCount;
        private System.Windows.Forms.Label labelVideoCount;
        private System.Windows.Forms.Label labelVoiceCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonNews;
        private System.Windows.Forms.RadioButton radioButtonVideo;
        private System.Windows.Forms.Button buttonUploadResource;
        private System.Windows.Forms.RadioButton radioButtonVoice;
        private System.Windows.Forms.RadioButton radioButtonImage;
        private System.Windows.Forms.Button buttonQueryResource;
        private PageControl pageControl1;
        private System.Windows.Forms.Button buttonLogClear;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTemplateSend;
        private System.Windows.Forms.TextBox textBoxTemplateId;
        private System.Windows.Forms.TextBox textBoxTemplateContent;
        private System.Windows.Forms.TextBox textBoxTemplateUsers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTemplateUrl;
        private System.Windows.Forms.Button buttonMenuHelp;
        private System.Windows.Forms.Button buttonTemplateHelp;
        private System.Windows.Forms.Button buttonAccessTokenCopy;
    }
}

