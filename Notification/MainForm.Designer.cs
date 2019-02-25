namespace Notification
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.changedWebList = new System.Windows.Forms.Label();
            this.prevLinkList = new System.Windows.Forms.Button();
            this.nextLinkList = new System.Windows.Forms.Button();
            this.SetAsSeen = new System.Windows.Forms.Button();
            this.urlInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputURLButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.warningInputText = new System.Windows.Forms.Label();
            this.urlIDInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.removeUrl = new System.Windows.Forms.Button();
            this.nextUrlList = new System.Windows.Forms.Button();
            this.prevUrlList = new System.Windows.Forms.Button();
            this.webList = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.urlClassInput = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ProcessingIndicator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Post Changed at";
            // 
            // changedWebList
            // 
            this.changedWebList.AutoSize = true;
            this.changedWebList.Cursor = System.Windows.Forms.Cursors.Default;
            this.changedWebList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changedWebList.Location = new System.Drawing.Point(222, 268);
            this.changedWebList.Name = "changedWebList";
            this.changedWebList.Size = new System.Drawing.Size(53, 22);
            this.changedWebList.TabIndex = 1;
            this.changedWebList.Text = "None";
            this.changedWebList.Click += new System.EventHandler(this.changedWebList_Click);
            // 
            // prevLinkList
            // 
            this.prevLinkList.Location = new System.Drawing.Point(590, 267);
            this.prevLinkList.Name = "prevLinkList";
            this.prevLinkList.Size = new System.Drawing.Size(44, 23);
            this.prevLinkList.TabIndex = 2;
            this.prevLinkList.Text = "Up";
            this.prevLinkList.UseVisualStyleBackColor = true;
            this.prevLinkList.Click += new System.EventHandler(this.prevLinkList_Click);
            // 
            // nextLinkList
            // 
            this.nextLinkList.Location = new System.Drawing.Point(640, 267);
            this.nextLinkList.Name = "nextLinkList";
            this.nextLinkList.Size = new System.Drawing.Size(44, 23);
            this.nextLinkList.TabIndex = 3;
            this.nextLinkList.Text = "Down";
            this.nextLinkList.UseVisualStyleBackColor = true;
            this.nextLinkList.Click += new System.EventHandler(this.nextLinkList_Click);
            // 
            // SetAsSeen
            // 
            this.SetAsSeen.Location = new System.Drawing.Point(690, 267);
            this.SetAsSeen.Name = "SetAsSeen";
            this.SetAsSeen.Size = new System.Drawing.Size(75, 23);
            this.SetAsSeen.TabIndex = 4;
            this.SetAsSeen.Text = "Done";
            this.SetAsSeen.UseVisualStyleBackColor = true;
            this.SetAsSeen.Click += new System.EventHandler(this.SetAsSeen_Click);
            // 
            // urlInput
            // 
            this.urlInput.Location = new System.Drawing.Point(139, 25);
            this.urlInput.Name = "urlInput";
            this.urlInput.Size = new System.Drawing.Size(100, 20);
            this.urlInput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "URL";
            // 
            // inputURLButton
            // 
            this.inputURLButton.Location = new System.Drawing.Point(290, 23);
            this.inputURLButton.Name = "inputURLButton";
            this.inputURLButton.Size = new System.Drawing.Size(75, 23);
            this.inputURLButton.TabIndex = 7;
            this.inputURLButton.Text = "Input";
            this.inputURLButton.UseVisualStyleBackColor = true;
            this.inputURLButton.Click += new System.EventHandler(this.inputLinkButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Aqua;
            this.pictureBox1.Location = new System.Drawing.Point(1, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 152);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // warningInputText
            // 
            this.warningInputText.AutoSize = true;
            this.warningInputText.Cursor = System.Windows.Forms.Cursors.Default;
            this.warningInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningInputText.Location = new System.Drawing.Point(365, 13);
            this.warningInputText.Name = "warningInputText";
            this.warningInputText.Size = new System.Drawing.Size(0, 22);
            this.warningInputText.TabIndex = 9;
            // 
            // urlIDInput
            // 
            this.urlIDInput.Location = new System.Drawing.Point(139, 67);
            this.urlIDInput.Name = "urlIDInput";
            this.urlIDInput.Size = new System.Drawing.Size(100, 20);
            this.urlIDInput.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "HTML ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Aqua;
            this.pictureBox2.Location = new System.Drawing.Point(1, 251);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(776, 62);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // removeUrl
            // 
            this.removeUrl.Location = new System.Drawing.Point(690, 199);
            this.removeUrl.Name = "removeUrl";
            this.removeUrl.Size = new System.Drawing.Size(75, 23);
            this.removeUrl.TabIndex = 17;
            this.removeUrl.Text = "Remove";
            this.removeUrl.UseVisualStyleBackColor = true;
            this.removeUrl.Click += new System.EventHandler(this.removeWebList_Click);
            // 
            // nextUrlList
            // 
            this.nextUrlList.Location = new System.Drawing.Point(640, 199);
            this.nextUrlList.Name = "nextUrlList";
            this.nextUrlList.Size = new System.Drawing.Size(44, 23);
            this.nextUrlList.TabIndex = 16;
            this.nextUrlList.Text = "Down";
            this.nextUrlList.UseVisualStyleBackColor = true;
            this.nextUrlList.Click += new System.EventHandler(this.nextUrlList_Click);
            // 
            // prevUrlList
            // 
            this.prevUrlList.Location = new System.Drawing.Point(590, 199);
            this.prevUrlList.Name = "prevUrlList";
            this.prevUrlList.Size = new System.Drawing.Size(44, 23);
            this.prevUrlList.TabIndex = 15;
            this.prevUrlList.Text = "Up";
            this.prevUrlList.UseVisualStyleBackColor = true;
            this.prevUrlList.Click += new System.EventHandler(this.prevUrlList_Click);
            // 
            // webList
            // 
            this.webList.AutoSize = true;
            this.webList.Cursor = System.Windows.Forms.Cursors.Default;
            this.webList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webList.Location = new System.Drawing.Point(222, 200);
            this.webList.Name = "webList";
            this.webList.Size = new System.Drawing.Size(53, 22);
            this.webList.TabIndex = 14;
            this.webList.Text = "None";
            this.webList.Click += new System.EventHandler(this.webList_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Web List";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Aqua;
            this.pictureBox3.Location = new System.Drawing.Point(1, 183);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(776, 62);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "HTML Class";
            // 
            // urlClassInput
            // 
            this.urlClassInput.Location = new System.Drawing.Point(139, 106);
            this.urlClassInput.Name = "urlClassInput";
            this.urlClassInput.Size = new System.Drawing.Size(100, 20);
            this.urlClassInput.TabIndex = 19;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "UNISKA Notif";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ProcessingIndicator
            // 
            this.ProcessingIndicator.AutoSize = true;
            this.ProcessingIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessingIndicator.Location = new System.Drawing.Point(542, 13);
            this.ProcessingIndicator.Name = "ProcessingIndicator";
            this.ProcessingIndicator.Size = new System.Drawing.Size(235, 37);
            this.ProcessingIndicator.TabIndex = 21;
            this.ProcessingIndicator.Text = "Not Processing";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 313);
            this.Controls.Add(this.ProcessingIndicator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.urlClassInput);
            this.Controls.Add(this.removeUrl);
            this.Controls.Add(this.nextUrlList);
            this.Controls.Add(this.prevUrlList);
            this.Controls.Add(this.webList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.urlIDInput);
            this.Controls.Add(this.warningInputText);
            this.Controls.Add(this.inputURLButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.urlInput);
            this.Controls.Add(this.SetAsSeen);
            this.Controls.Add(this.nextLinkList);
            this.Controls.Add(this.prevLinkList);
            this.Controls.Add(this.changedWebList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label changedWebList;
        private System.Windows.Forms.Button prevLinkList;
        private System.Windows.Forms.Button nextLinkList;
        private System.Windows.Forms.Button SetAsSeen;
        private System.Windows.Forms.TextBox urlInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button inputURLButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label warningInputText;
        private System.Windows.Forms.TextBox urlIDInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button removeUrl;
        private System.Windows.Forms.Button nextUrlList;
        private System.Windows.Forms.Button prevUrlList;
        private System.Windows.Forms.Label webList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox urlClassInput;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label ProcessingIndicator;
    }
}

