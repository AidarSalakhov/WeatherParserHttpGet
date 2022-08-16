namespace WeatherParserHttpGet
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonGetWeather = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.richTextBoxWeather = new System.Windows.Forms.RichTextBox();
            this.forecastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxRegions = new System.Windows.Forms.ListBox();
            this.labelRegions = new System.Windows.Forms.Label();
            this.labelCities = new System.Windows.Forms.Label();
            this.labelDownloadStatus = new System.Windows.Forms.Label();
            this.labelWeather = new System.Windows.Forms.Label();
            this.checkedListBoxCities = new System.Windows.Forms.CheckedListBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forecastBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetWeather
            // 
            this.buttonGetWeather.BackColor = System.Drawing.Color.Gold;
            this.buttonGetWeather.Enabled = false;
            this.buttonGetWeather.Location = new System.Drawing.Point(551, 502);
            this.buttonGetWeather.Name = "buttonGetWeather";
            this.buttonGetWeather.Size = new System.Drawing.Size(166, 56);
            this.buttonGetWeather.TabIndex = 0;
            this.buttonGetWeather.Text = "Узнать погоду";
            this.buttonGetWeather.UseVisualStyleBackColor = false;
            this.buttonGetWeather.Click += new System.EventHandler(this.buttonGetWeather_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(743, 30);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSave,
            this.toolStripMenuItemExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItemFile.Text = "Файл";
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemSave.Text = "Сохранить";
            this.toolStripMenuItemSave.Click += new System.EventHandler(this.toolStripMenuItemSave_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItemExit.Text = "Выход";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemInfo,
            this.toolStripMenuItemAbout});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItemHelp.Text = "Помощь";
            // 
            // toolStripMenuItemInfo
            // 
            this.toolStripMenuItemInfo.Name = "toolStripMenuItemInfo";
            this.toolStripMenuItemInfo.Size = new System.Drawing.Size(187, 26);
            this.toolStripMenuItemInfo.Text = "Справка";
            this.toolStripMenuItemInfo.Click += new System.EventHandler(this.toolStripMenuItemInfo_Click);
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(187, 26);
            this.toolStripMenuItemAbout.Text = "О программе";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.DimGray;
            this.progressBar.Location = new System.Drawing.Point(551, 436);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(166, 44);
            this.progressBar.TabIndex = 4;
            // 
            // richTextBoxWeather
            // 
            this.richTextBoxWeather.Location = new System.Drawing.Point(14, 63);
            this.richTextBoxWeather.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxWeather.Name = "richTextBoxWeather";
            this.richTextBoxWeather.Size = new System.Drawing.Size(515, 208);
            this.richTextBoxWeather.TabIndex = 5;
            this.richTextBoxWeather.Text = "";
            // 
            // forecastBindingSource
            // 
            this.forecastBindingSource.DataSource = typeof(WeatherParserHttpGet.Forecast);
            // 
            // listBoxRegions
            // 
            this.listBoxRegions.FormattingEnabled = true;
            this.listBoxRegions.ItemHeight = 20;
            this.listBoxRegions.Location = new System.Drawing.Point(14, 314);
            this.listBoxRegions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxRegions.Name = "listBoxRegions";
            this.listBoxRegions.Size = new System.Drawing.Size(259, 244);
            this.listBoxRegions.TabIndex = 6;
            this.listBoxRegions.SelectedIndexChanged += new System.EventHandler(this.listBoxRegions_SelectedIndexChanged);
            // 
            // labelRegions
            // 
            this.labelRegions.AutoSize = true;
            this.labelRegions.Location = new System.Drawing.Point(14, 290);
            this.labelRegions.Name = "labelRegions";
            this.labelRegions.Size = new System.Drawing.Size(132, 20);
            this.labelRegions.TabIndex = 8;
            this.labelRegions.Text = "Выберите регион";
            // 
            // labelCities
            // 
            this.labelCities.AutoSize = true;
            this.labelCities.Location = new System.Drawing.Point(279, 290);
            this.labelCities.Name = "labelCities";
            this.labelCities.Size = new System.Drawing.Size(123, 20);
            this.labelCities.TabIndex = 9;
            this.labelCities.Text = "Выберите город";
            // 
            // labelDownloadStatus
            // 
            this.labelDownloadStatus.AutoSize = true;
            this.labelDownloadStatus.Location = new System.Drawing.Point(551, 413);
            this.labelDownloadStatus.Name = "labelDownloadStatus";
            this.labelDownloadStatus.Size = new System.Drawing.Size(147, 20);
            this.labelDownloadStatus.TabIndex = 10;
            this.labelDownloadStatus.Text = "Состояние загрузки";
            // 
            // labelWeather
            // 
            this.labelWeather.AutoSize = true;
            this.labelWeather.Location = new System.Drawing.Point(14, 39);
            this.labelWeather.Name = "labelWeather";
            this.labelWeather.Size = new System.Drawing.Size(60, 20);
            this.labelWeather.TabIndex = 11;
            this.labelWeather.Text = "Погода";
            // 
            // checkedListBoxCities
            // 
            this.checkedListBoxCities.CheckOnClick = true;
            this.checkedListBoxCities.FormattingEnabled = true;
            this.checkedListBoxCities.Location = new System.Drawing.Point(279, 313);
            this.checkedListBoxCities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBoxCities.Name = "checkedListBoxCities";
            this.checkedListBoxCities.Size = new System.Drawing.Size(250, 246);
            this.checkedListBoxCities.TabIndex = 12;
            this.checkedListBoxCities.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxCities_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 577);
            this.Controls.Add(this.checkedListBoxCities);
            this.Controls.Add(this.labelWeather);
            this.Controls.Add(this.labelDownloadStatus);
            this.Controls.Add(this.labelCities);
            this.Controls.Add(this.labelRegions);
            this.Controls.Add(this.listBoxRegions);
            this.Controls.Add(this.richTextBoxWeather);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonGetWeather);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Parser HTTP GET";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forecastBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonGetWeather;
        private MenuStrip menuStrip;
        private ToolStripMenuItem toolStripMenuItemFile;
        private ToolStripMenuItem toolStripMenuItemSave;
        private ToolStripMenuItem toolStripMenuItemExit;
        private ToolStripMenuItem toolStripMenuItemHelp;
        private ToolStripMenuItem toolStripMenuItemInfo;
        private ToolStripMenuItem toolStripMenuItemAbout;
        private ProgressBar progressBar;
        private RichTextBox richTextBoxWeather;
        private BindingSource forecastBindingSource;
        private ListBox listBoxRegions;
        private Label labelRegions;
        private Label labelCities;
        private Label labelDownloadStatus;
        private Label labelWeather;
        private CheckedListBox checkedListBoxCities;
    }
}