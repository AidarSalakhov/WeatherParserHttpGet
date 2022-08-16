namespace WeatherParserHttpGet
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bGetWeather = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.forecastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDownloadStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.citiesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forecastBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bGetWeather
            // 
            this.bGetWeather.BackColor = System.Drawing.Color.Gold;
            this.bGetWeather.Enabled = false;
            this.bGetWeather.Location = new System.Drawing.Point(551, 502);
            this.bGetWeather.Name = "bGetWeather";
            this.bGetWeather.Size = new System.Drawing.Size(166, 56);
            this.bGetWeather.TabIndex = 0;
            this.bGetWeather.Text = "Узнать погоду";
            this.bGetWeather.UseVisualStyleBackColor = false;
            this.bGetWeather.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(743, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem2});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.оПрограммеToolStripMenuItem.Text = "Помощь";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.оПрограммеToolStripMenuItem1.Text = "Справка";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // оПрограммеToolStripMenuItem2
            // 
            this.оПрограммеToolStripMenuItem2.Name = "оПрограммеToolStripMenuItem2";
            this.оПрограммеToolStripMenuItem2.Size = new System.Drawing.Size(187, 26);
            this.оПрограммеToolStripMenuItem2.Text = "О программе";
            this.оПрограммеToolStripMenuItem2.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem2_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.DimGray;
            this.progressBar.Location = new System.Drawing.Point(551, 436);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(166, 44);
            this.progressBar.TabIndex = 4;
            this.progressBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(14, 63);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(515, 208);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // forecastBindingSource
            // 
            this.forecastBindingSource.DataSource = typeof(WeatherParserHttpGet.Forecast);
            // 
            // regionsListBox
            // 
            this.regionsListBox.FormattingEnabled = true;
            this.regionsListBox.ItemHeight = 20;
            this.regionsListBox.Location = new System.Drawing.Point(14, 314);
            this.regionsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.regionsListBox.Name = "regionsListBox";
            this.regionsListBox.Size = new System.Drawing.Size(259, 244);
            this.regionsListBox.TabIndex = 6;
            this.regionsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите регион";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Выберите город";
            // 
            // labelDownloadStatus
            // 
            this.labelDownloadStatus.AutoSize = true;
            this.labelDownloadStatus.Location = new System.Drawing.Point(551, 413);
            this.labelDownloadStatus.Name = "labelDownloadStatus";
            this.labelDownloadStatus.Size = new System.Drawing.Size(147, 20);
            this.labelDownloadStatus.TabIndex = 10;
            this.labelDownloadStatus.Text = "Состояние загрузки";
            this.labelDownloadStatus.Click += new System.EventHandler(this.labelDownloadStatus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Погода";
            // 
            // citiesCheckedListBox
            // 
            this.citiesCheckedListBox.CheckOnClick = true;
            this.citiesCheckedListBox.FormattingEnabled = true;
            this.citiesCheckedListBox.Location = new System.Drawing.Point(279, 313);
            this.citiesCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.citiesCheckedListBox.Name = "citiesCheckedListBox";
            this.citiesCheckedListBox.Size = new System.Drawing.Size(250, 246);
            this.citiesCheckedListBox.TabIndex = 12;
            this.citiesCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 577);
            this.Controls.Add(this.citiesCheckedListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDownloadStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regionsListBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.bGetWeather);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Parser HTTP GET";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forecastBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bGetWeather;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private ToolStripMenuItem оПрограммеToolStripMenuItem2;
        private ProgressBar progressBar;
        private RichTextBox richTextBox1;
        private BindingSource forecastBindingSource;
        private ListBox regionsListBox;
        private Label label1;
        private Label label2;
        private Label labelDownloadStatus;
        private Label label4;
        private CheckedListBox citiesCheckedListBox;
    }
}