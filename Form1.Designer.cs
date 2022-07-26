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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Казань");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Рыбная Слобода");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Татарстан", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Москва");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Реутов");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Московский регион", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(405, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Узнать погоду";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.FullRowSelect = true;
            this.treeView1.Location = new System.Drawing.Point(58, 272);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел1";
            treeNode1.Text = "Казань";
            treeNode2.Name = "Узел2";
            treeNode2.Text = "Рыбная Слобода";
            treeNode3.Name = "Татарстан";
            treeNode3.Text = "Татарстан";
            treeNode4.Name = "Узел4";
            treeNode4.Text = "Москва";
            treeNode5.Name = "Узел6";
            treeNode5.Text = "Реутов";
            treeNode6.Name = "Узел3";
            treeNode6.Text = "Московский регион";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(317, 148);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(519, 223);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 440);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Parser HTTP GET";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TreeView treeView1;
        private TextBox textBox1;
    }
}