namespace HW4CardGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hand1newCardButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hand1CheckBox5 = new System.Windows.Forms.CheckBox();
            this.hand1CheckBox4 = new System.Windows.Forms.CheckBox();
            this.hand1CheckBox3 = new System.Windows.Forms.CheckBox();
            this.hand1CheckBox2 = new System.Windows.Forms.CheckBox();
            this.hand1CheckBox1 = new System.Windows.Forms.CheckBox();
            this.hand1PicBox5 = new System.Windows.Forms.PictureBox();
            this.hand1PicBox4 = new System.Windows.Forms.PictureBox();
            this.hand1PicBox3 = new System.Windows.Forms.PictureBox();
            this.hand1PicBox2 = new System.Windows.Forms.PictureBox();
            this.hand1PicBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hand2newCardButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hand2CheckBox5 = new System.Windows.Forms.CheckBox();
            this.hand2CheckBox4 = new System.Windows.Forms.CheckBox();
            this.hand2CheckBox3 = new System.Windows.Forms.CheckBox();
            this.hand2CheckBox2 = new System.Windows.Forms.CheckBox();
            this.hand2CheckBox1 = new System.Windows.Forms.CheckBox();
            this.hand2PicBox5 = new System.Windows.Forms.PictureBox();
            this.hand2PicBox4 = new System.Windows.Forms.PictureBox();
            this.hand2PicBox3 = new System.Windows.Forms.PictureBox();
            this.hand2PicBox2 = new System.Windows.Forms.PictureBox();
            this.hand2PicBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateHandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hand1PicBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand1PicBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand1PicBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand1PicBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand1PicBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hand2PicBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand2PicBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand2PicBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand2PicBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand2PicBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::HW4CardGame.Properties.Resources.poker_table;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.hand1newCardButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.hand1CheckBox5);
            this.tabPage1.Controls.Add(this.hand1CheckBox4);
            this.tabPage1.Controls.Add(this.hand1CheckBox3);
            this.tabPage1.Controls.Add(this.hand1CheckBox2);
            this.tabPage1.Controls.Add(this.hand1CheckBox1);
            this.tabPage1.Controls.Add(this.hand1PicBox5);
            this.tabPage1.Controls.Add(this.hand1PicBox4);
            this.tabPage1.Controls.Add(this.hand1PicBox3);
            this.tabPage1.Controls.Add(this.hand1PicBox2);
            this.tabPage1.Controls.Add(this.hand1PicBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Player 1 Hand";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // hand1newCardButton
            // 
            this.hand1newCardButton.BackColor = System.Drawing.Color.ForestGreen;
            this.hand1newCardButton.ForeColor = System.Drawing.SystemColors.Window;
            this.hand1newCardButton.Location = new System.Drawing.Point(342, 256);
            this.hand1newCardButton.Name = "hand1newCardButton";
            this.hand1newCardButton.Size = new System.Drawing.Size(100, 27);
            this.hand1newCardButton.TabIndex = 21;
            this.hand1newCardButton.Text = "Deal New Cards";
            this.hand1newCardButton.UseVisualStyleBackColor = false;
            this.hand1newCardButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(328, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Choose Cards To Hold";
            // 
            // hand1CheckBox5
            // 
            this.hand1CheckBox5.AutoSize = true;
            this.hand1CheckBox5.Location = new System.Drawing.Point(541, 212);
            this.hand1CheckBox5.Name = "hand1CheckBox5";
            this.hand1CheckBox5.Size = new System.Drawing.Size(15, 14);
            this.hand1CheckBox5.TabIndex = 19;
            this.hand1CheckBox5.UseVisualStyleBackColor = true;
            // 
            // hand1CheckBox4
            // 
            this.hand1CheckBox4.AutoSize = true;
            this.hand1CheckBox4.Location = new System.Drawing.Point(462, 212);
            this.hand1CheckBox4.Name = "hand1CheckBox4";
            this.hand1CheckBox4.Size = new System.Drawing.Size(15, 14);
            this.hand1CheckBox4.TabIndex = 18;
            this.hand1CheckBox4.UseVisualStyleBackColor = true;
            // 
            // hand1CheckBox3
            // 
            this.hand1CheckBox3.AutoSize = true;
            this.hand1CheckBox3.Location = new System.Drawing.Point(382, 212);
            this.hand1CheckBox3.Name = "hand1CheckBox3";
            this.hand1CheckBox3.Size = new System.Drawing.Size(15, 14);
            this.hand1CheckBox3.TabIndex = 17;
            this.hand1CheckBox3.UseVisualStyleBackColor = true;
            // 
            // hand1CheckBox2
            // 
            this.hand1CheckBox2.AutoSize = true;
            this.hand1CheckBox2.Location = new System.Drawing.Point(304, 212);
            this.hand1CheckBox2.Name = "hand1CheckBox2";
            this.hand1CheckBox2.Size = new System.Drawing.Size(15, 14);
            this.hand1CheckBox2.TabIndex = 16;
            this.hand1CheckBox2.UseVisualStyleBackColor = true;
            // 
            // hand1CheckBox1
            // 
            this.hand1CheckBox1.AutoSize = true;
            this.hand1CheckBox1.Location = new System.Drawing.Point(219, 212);
            this.hand1CheckBox1.Name = "hand1CheckBox1";
            this.hand1CheckBox1.Size = new System.Drawing.Size(15, 14);
            this.hand1CheckBox1.TabIndex = 15;
            this.hand1CheckBox1.UseVisualStyleBackColor = true;
            // 
            // hand1PicBox5
            // 
            this.hand1PicBox5.BackgroundImage = global::HW4CardGame.Properties.Resources._53;
            this.hand1PicBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hand1PicBox5.Location = new System.Drawing.Point(520, 129);
            this.hand1PicBox5.Name = "hand1PicBox5";
            this.hand1PicBox5.Size = new System.Drawing.Size(64, 80);
            this.hand1PicBox5.TabIndex = 4;
            this.hand1PicBox5.TabStop = false;
            // 
            // hand1PicBox4
            // 
            this.hand1PicBox4.BackgroundImage = global::HW4CardGame.Properties.Resources._53;
            this.hand1PicBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hand1PicBox4.Location = new System.Drawing.Point(439, 129);
            this.hand1PicBox4.Name = "hand1PicBox4";
            this.hand1PicBox4.Size = new System.Drawing.Size(64, 80);
            this.hand1PicBox4.TabIndex = 3;
            this.hand1PicBox4.TabStop = false;
            // 
            // hand1PicBox3
            // 
            this.hand1PicBox3.BackgroundImage = global::HW4CardGame.Properties.Resources._53;
            this.hand1PicBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hand1PicBox3.Location = new System.Drawing.Point(360, 129);
            this.hand1PicBox3.Name = "hand1PicBox3";
            this.hand1PicBox3.Size = new System.Drawing.Size(64, 80);
            this.hand1PicBox3.TabIndex = 2;
            this.hand1PicBox3.TabStop = false;
            // 
            // hand1PicBox2
            // 
            this.hand1PicBox2.BackgroundImage = global::HW4CardGame.Properties.Resources._53;
            this.hand1PicBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hand1PicBox2.Location = new System.Drawing.Point(280, 129);
            this.hand1PicBox2.Name = "hand1PicBox2";
            this.hand1PicBox2.Size = new System.Drawing.Size(64, 80);
            this.hand1PicBox2.TabIndex = 1;
            this.hand1PicBox2.TabStop = false;
            // 
            // hand1PicBox1
            // 
            this.hand1PicBox1.BackgroundImage = global::HW4CardGame.Properties.Resources._53;
            this.hand1PicBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hand1PicBox1.Location = new System.Drawing.Point(194, 129);
            this.hand1PicBox1.Name = "hand1PicBox1";
            this.hand1PicBox1.Size = new System.Drawing.Size(64, 80);
            this.hand1PicBox1.TabIndex = 0;
            this.hand1PicBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::HW4CardGame.Properties.Resources.poker_table;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.hand2newCardButton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.hand2CheckBox5);
            this.tabPage2.Controls.Add(this.hand2CheckBox4);
            this.tabPage2.Controls.Add(this.hand2CheckBox3);
            this.tabPage2.Controls.Add(this.hand2CheckBox2);
            this.tabPage2.Controls.Add(this.hand2CheckBox1);
            this.tabPage2.Controls.Add(this.hand2PicBox5);
            this.tabPage2.Controls.Add(this.hand2PicBox4);
            this.tabPage2.Controls.Add(this.hand2PicBox3);
            this.tabPage2.Controls.Add(this.hand2PicBox2);
            this.tabPage2.Controls.Add(this.hand2PicBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Player 2 Hand";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // hand2newCardButton
            // 
            this.hand2newCardButton.BackColor = System.Drawing.Color.ForestGreen;
            this.hand2newCardButton.ForeColor = System.Drawing.SystemColors.Window;
            this.hand2newCardButton.Location = new System.Drawing.Point(342, 256);
            this.hand2newCardButton.Name = "hand2newCardButton";
            this.hand2newCardButton.Size = new System.Drawing.Size(100, 27);
            this.hand2newCardButton.TabIndex = 22;
            this.hand2newCardButton.Text = "Deal New Cards";
            this.hand2newCardButton.UseVisualStyleBackColor = false;
            this.hand2newCardButton.Click += new System.EventHandler(this.hand2newCardButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(328, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Choose Cards To Hold";
            // 
            // hand2CheckBox5
            // 
            this.hand2CheckBox5.AutoSize = true;
            this.hand2CheckBox5.Location = new System.Drawing.Point(541, 212);
            this.hand2CheckBox5.Name = "hand2CheckBox5";
            this.hand2CheckBox5.Size = new System.Drawing.Size(15, 14);
            this.hand2CheckBox5.TabIndex = 14;
            this.hand2CheckBox5.UseVisualStyleBackColor = true;
            // 
            // hand2CheckBox4
            // 
            this.hand2CheckBox4.AutoSize = true;
            this.hand2CheckBox4.Location = new System.Drawing.Point(462, 212);
            this.hand2CheckBox4.Name = "hand2CheckBox4";
            this.hand2CheckBox4.Size = new System.Drawing.Size(15, 14);
            this.hand2CheckBox4.TabIndex = 13;
            this.hand2CheckBox4.UseVisualStyleBackColor = true;
            // 
            // hand2CheckBox3
            // 
            this.hand2CheckBox3.AutoSize = true;
            this.hand2CheckBox3.Location = new System.Drawing.Point(382, 212);
            this.hand2CheckBox3.Name = "hand2CheckBox3";
            this.hand2CheckBox3.Size = new System.Drawing.Size(15, 14);
            this.hand2CheckBox3.TabIndex = 12;
            this.hand2CheckBox3.UseVisualStyleBackColor = true;
            // 
            // hand2CheckBox2
            // 
            this.hand2CheckBox2.AutoSize = true;
            this.hand2CheckBox2.Location = new System.Drawing.Point(304, 212);
            this.hand2CheckBox2.Name = "hand2CheckBox2";
            this.hand2CheckBox2.Size = new System.Drawing.Size(15, 14);
            this.hand2CheckBox2.TabIndex = 11;
            this.hand2CheckBox2.UseVisualStyleBackColor = true;
            // 
            // hand2CheckBox1
            // 
            this.hand2CheckBox1.AutoSize = true;
            this.hand2CheckBox1.Location = new System.Drawing.Point(219, 212);
            this.hand2CheckBox1.Name = "hand2CheckBox1";
            this.hand2CheckBox1.Size = new System.Drawing.Size(15, 14);
            this.hand2CheckBox1.TabIndex = 10;
            this.hand2CheckBox1.UseVisualStyleBackColor = true;
            // 
            // hand2PicBox5
            // 
            this.hand2PicBox5.BackgroundImage = global::HW4CardGame.Properties.Resources._53;
            this.hand2PicBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hand2PicBox5.Location = new System.Drawing.Point(520, 129);
            this.hand2PicBox5.Name = "hand2PicBox5";
            this.hand2PicBox5.Size = new System.Drawing.Size(64, 80);
            this.hand2PicBox5.TabIndex = 9;
            this.hand2PicBox5.TabStop = false;
            // 
            // hand2PicBox4
            // 
            this.hand2PicBox4.BackgroundImage = global::HW4CardGame.Properties.Resources._53;
            this.hand2PicBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hand2PicBox4.Location = new System.Drawing.Point(439, 129);
            this.hand2PicBox4.Name = "hand2PicBox4";
            this.hand2PicBox4.Size = new System.Drawing.Size(64, 80);
            this.hand2PicBox4.TabIndex = 8;
            this.hand2PicBox4.TabStop = false;
            // 
            // hand2PicBox3
            // 
            this.hand2PicBox3.BackgroundImage = global::HW4CardGame.Properties.Resources._53;
            this.hand2PicBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hand2PicBox3.Location = new System.Drawing.Point(360, 129);
            this.hand2PicBox3.Name = "hand2PicBox3";
            this.hand2PicBox3.Size = new System.Drawing.Size(64, 80);
            this.hand2PicBox3.TabIndex = 7;
            this.hand2PicBox3.TabStop = false;
            // 
            // hand2PicBox2
            // 
            this.hand2PicBox2.BackgroundImage = global::HW4CardGame.Properties.Resources._53;
            this.hand2PicBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hand2PicBox2.Location = new System.Drawing.Point(280, 129);
            this.hand2PicBox2.Name = "hand2PicBox2";
            this.hand2PicBox2.Size = new System.Drawing.Size(64, 80);
            this.hand2PicBox2.TabIndex = 6;
            this.hand2PicBox2.TabStop = false;
            // 
            // hand2PicBox1
            // 
            this.hand2PicBox1.BackgroundImage = global::HW4CardGame.Properties.Resources._53;
            this.hand2PicBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hand2PicBox1.Location = new System.Drawing.Point(194, 129);
            this.hand2PicBox1.Name = "hand2PicBox1";
            this.hand2PicBox1.Size = new System.Drawing.Size(64, 80);
            this.hand2PicBox1.TabIndex = 5;
            this.hand2PicBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::HW4CardGame.Properties.Resources.poker_table;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.resultTextBox);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 385);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Result";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.generateHandsToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // generateHandsToolStripMenuItem
            // 
            this.generateHandsToolStripMenuItem.Name = "generateHandsToolStripMenuItem";
            this.generateHandsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.generateHandsToolStripMenuItem.Text = "Deal Cards";
            this.generateHandsToolStripMenuItem.Click += new System.EventHandler(this.generateHandsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(206, 121);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(374, 96);
            this.resultTextBox.TabIndex = 24;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(342, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 23;
            this.button1.Text = "Compare Hands";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "5 Card Poker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hand1PicBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand1PicBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand1PicBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand1PicBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand1PicBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hand2PicBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand2PicBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand2PicBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand2PicBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hand2PicBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox hand1PicBox5;
        private System.Windows.Forms.PictureBox hand1PicBox4;
        private System.Windows.Forms.PictureBox hand1PicBox3;
        private System.Windows.Forms.PictureBox hand1PicBox2;
        private System.Windows.Forms.PictureBox hand1PicBox1;
        private System.Windows.Forms.PictureBox hand2PicBox5;
        private System.Windows.Forms.PictureBox hand2PicBox4;
        private System.Windows.Forms.PictureBox hand2PicBox3;
        private System.Windows.Forms.PictureBox hand2PicBox2;
        private System.Windows.Forms.PictureBox hand2PicBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateHandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.CheckBox hand2CheckBox5;
        private System.Windows.Forms.CheckBox hand2CheckBox4;
        private System.Windows.Forms.CheckBox hand2CheckBox3;
        private System.Windows.Forms.CheckBox hand2CheckBox2;
        private System.Windows.Forms.CheckBox hand2CheckBox1;
        private System.Windows.Forms.CheckBox hand1CheckBox5;
        private System.Windows.Forms.CheckBox hand1CheckBox4;
        private System.Windows.Forms.CheckBox hand1CheckBox3;
        private System.Windows.Forms.CheckBox hand1CheckBox2;
        private System.Windows.Forms.CheckBox hand1CheckBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hand1newCardButton;
        private System.Windows.Forms.Button hand2newCardButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button button1;
    }
}

