namespace TShockDBEditor
{
    partial class TShockDBEditor
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
            this.itemListBanned = new System.Windows.Forms.ListBox();
            this.itemListAvailable = new System.Windows.Forms.ListBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_moveAllLeft = new System.Windows.Forms.Button();
            this.btn_moveAllRight = new System.Windows.Forms.Button();
            this.btn_moveLeft = new System.Windows.Forms.Button();
            this.btn_moveRight = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_moveAllLeftCmd = new System.Windows.Forms.Button();
            this.btn_moveLeftCmd = new System.Windows.Forms.Button();
            this.btn_moveRightCmd = new System.Windows.Forms.Button();
            this.lst_AvailableCmds = new System.Windows.Forms.ListBox();
            this.btn_moveAllRightCmd = new System.Windows.Forms.Button();
            this.lst_bannedCmds = new System.Windows.Forms.ListBox();
            this.lst_groupList = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_OpenDB = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemListBanned
            // 
            this.itemListBanned.FormattingEnabled = true;
            this.itemListBanned.Location = new System.Drawing.Point(321, 19);
            this.itemListBanned.Name = "itemListBanned";
            this.itemListBanned.Size = new System.Drawing.Size(275, 290);
            this.itemListBanned.TabIndex = 1;
            // 
            // itemListAvailable
            // 
            this.itemListAvailable.FormattingEnabled = true;
            this.itemListAvailable.Location = new System.Drawing.Point(7, 19);
            this.itemListAvailable.Name = "itemListAvailable";
            this.itemListAvailable.Size = new System.Drawing.Size(275, 290);
            this.itemListAvailable.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 143);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(610, 407);
            this.tabControl.TabIndex = 3;
            this.tabControl.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_moveAllLeft);
            this.tabPage1.Controls.Add(this.btn_moveAllRight);
            this.tabPage1.Controls.Add(this.btn_moveLeft);
            this.tabPage1.Controls.Add(this.btn_moveRight);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.itemListAvailable);
            this.tabPage1.Controls.Add(this.itemListBanned);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(602, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Item Bans";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_moveAllLeft
            // 
            this.btn_moveAllLeft.Location = new System.Drawing.Point(288, 193);
            this.btn_moveAllLeft.Name = "btn_moveAllLeft";
            this.btn_moveAllLeft.Size = new System.Drawing.Size(27, 23);
            this.btn_moveAllLeft.TabIndex = 8;
            this.btn_moveAllLeft.Text = "<<";
            this.btn_moveAllLeft.UseVisualStyleBackColor = true;
            this.btn_moveAllLeft.Click += new System.EventHandler(this.btn_moveAllLeftItems_Click);
            // 
            // btn_moveAllRight
            // 
            this.btn_moveAllRight.Location = new System.Drawing.Point(288, 106);
            this.btn_moveAllRight.Name = "btn_moveAllRight";
            this.btn_moveAllRight.Size = new System.Drawing.Size(27, 23);
            this.btn_moveAllRight.TabIndex = 7;
            this.btn_moveAllRight.Text = ">>";
            this.btn_moveAllRight.UseVisualStyleBackColor = true;
            this.btn_moveAllRight.Click += new System.EventHandler(this.btn_moveAllRightItems_Click);
            // 
            // btn_moveLeft
            // 
            this.btn_moveLeft.Location = new System.Drawing.Point(288, 164);
            this.btn_moveLeft.Name = "btn_moveLeft";
            this.btn_moveLeft.Size = new System.Drawing.Size(27, 23);
            this.btn_moveLeft.TabIndex = 6;
            this.btn_moveLeft.Text = "<";
            this.btn_moveLeft.UseVisualStyleBackColor = true;
            this.btn_moveLeft.Click += new System.EventHandler(this.btn_moveLeftItems_Click);
            // 
            // btn_moveRight
            // 
            this.btn_moveRight.Location = new System.Drawing.Point(288, 135);
            this.btn_moveRight.Name = "btn_moveRight";
            this.btn_moveRight.Size = new System.Drawing.Size(27, 23);
            this.btn_moveRight.TabIndex = 5;
            this.btn_moveRight.Text = ">";
            this.btn_moveRight.UseVisualStyleBackColor = true;
            this.btn_moveRight.Click += new System.EventHandler(this.btn_moveRightItems_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Blacklisted Items";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Whitelisted Items";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btn_moveAllLeftCmd);
            this.tabPage2.Controls.Add(this.btn_moveLeftCmd);
            this.tabPage2.Controls.Add(this.btn_moveRightCmd);
            this.tabPage2.Controls.Add(this.lst_AvailableCmds);
            this.tabPage2.Controls.Add(this.btn_moveAllRightCmd);
            this.tabPage2.Controls.Add(this.lst_bannedCmds);
            this.tabPage2.Controls.Add(this.lst_groupList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(602, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Group Manager";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_moveAllLeftCmd
            // 
            this.btn_moveAllLeftCmd.Location = new System.Drawing.Point(291, 300);
            this.btn_moveAllLeftCmd.Name = "btn_moveAllLeftCmd";
            this.btn_moveAllLeftCmd.Size = new System.Drawing.Size(27, 23);
            this.btn_moveAllLeftCmd.TabIndex = 15;
            this.btn_moveAllLeftCmd.Text = "<<";
            this.btn_moveAllLeftCmd.UseVisualStyleBackColor = true;
            this.btn_moveAllLeftCmd.Click += new System.EventHandler(this.btn_moveAllLeftCmd_Click);
            // 
            // btn_moveLeftCmd
            // 
            this.btn_moveLeftCmd.Location = new System.Drawing.Point(291, 270);
            this.btn_moveLeftCmd.Name = "btn_moveLeftCmd";
            this.btn_moveLeftCmd.Size = new System.Drawing.Size(27, 23);
            this.btn_moveLeftCmd.TabIndex = 14;
            this.btn_moveLeftCmd.Text = "<";
            this.btn_moveLeftCmd.UseVisualStyleBackColor = true;
            this.btn_moveLeftCmd.Click += new System.EventHandler(this.btn_moveLeftCmd_Click);
            // 
            // btn_moveRightCmd
            // 
            this.btn_moveRightCmd.Location = new System.Drawing.Point(291, 240);
            this.btn_moveRightCmd.Name = "btn_moveRightCmd";
            this.btn_moveRightCmd.Size = new System.Drawing.Size(27, 23);
            this.btn_moveRightCmd.TabIndex = 13;
            this.btn_moveRightCmd.Text = ">";
            this.btn_moveRightCmd.UseVisualStyleBackColor = true;
            this.btn_moveRightCmd.Click += new System.EventHandler(this.btn_moveRightCmd_Click);
            // 
            // lst_AvailableCmds
            // 
            this.lst_AvailableCmds.FormattingEnabled = true;
            this.lst_AvailableCmds.Location = new System.Drawing.Point(324, 161);
            this.lst_AvailableCmds.Name = "lst_AvailableCmds";
            this.lst_AvailableCmds.Size = new System.Drawing.Size(272, 212);
            this.lst_AvailableCmds.TabIndex = 12;
            // 
            // btn_moveAllRightCmd
            // 
            this.btn_moveAllRightCmd.Location = new System.Drawing.Point(291, 210);
            this.btn_moveAllRightCmd.Name = "btn_moveAllRightCmd";
            this.btn_moveAllRightCmd.Size = new System.Drawing.Size(27, 23);
            this.btn_moveAllRightCmd.TabIndex = 11;
            this.btn_moveAllRightCmd.Text = ">>";
            this.btn_moveAllRightCmd.UseVisualStyleBackColor = true;
            this.btn_moveAllRightCmd.Click += new System.EventHandler(this.btn_moveAllRightCmd_Click);
            // 
            // lst_bannedCmds
            // 
            this.lst_bannedCmds.FormattingEnabled = true;
            this.lst_bannedCmds.Location = new System.Drawing.Point(9, 161);
            this.lst_bannedCmds.Name = "lst_bannedCmds";
            this.lst_bannedCmds.Size = new System.Drawing.Size(275, 212);
            this.lst_bannedCmds.TabIndex = 10;
            // 
            // lst_groupList
            // 
            this.lst_groupList.FormattingEnabled = true;
            this.lst_groupList.Location = new System.Drawing.Point(9, 8);
            this.lst_groupList.Name = "lst_groupList";
            this.lst_groupList.Size = new System.Drawing.Size(200, 134);
            this.lst_groupList.TabIndex = 0;
            this.lst_groupList.SelectedIndexChanged += new System.EventHandler(this.lst_groupList_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 125);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_OpenDB);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(602, 99);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Local Database";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_OpenDB
            // 
            this.btn_OpenDB.Location = new System.Drawing.Point(9, 6);
            this.btn_OpenDB.Name = "btn_OpenDB";
            this.btn_OpenDB.Size = new System.Drawing.Size(96, 23);
            this.btn_OpenDB.TabIndex = 0;
            this.btn_OpenDB.Text = "Open Database";
            this.btn_OpenDB.UseVisualStyleBackColor = true;
            this.btn_OpenDB.Click += new System.EventHandler(this.btn_OpenDB_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(602, 99);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Remote Database";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Banned Commands";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Whitelisted Commands";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Not Added Yet";
            // 
            // TShockDBEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 562);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tabControl);
            this.Name = "TShockDBEditor";
            this.Text = "TShockDBEditor";
            this.Load += new System.EventHandler(this.TShockDBEditor_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox itemListBanned;
        private System.Windows.Forms.ListBox itemListAvailable;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_moveAllLeft;
        private System.Windows.Forms.Button btn_moveAllRight;
        private System.Windows.Forms.Button btn_moveLeft;
        private System.Windows.Forms.Button btn_moveRight;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_OpenDB;
        private System.Windows.Forms.Button btn_moveAllLeftCmd;
        private System.Windows.Forms.Button btn_moveLeftCmd;
        private System.Windows.Forms.Button btn_moveRightCmd;
        private System.Windows.Forms.ListBox lst_AvailableCmds;
        private System.Windows.Forms.Button btn_moveAllRightCmd;
        private System.Windows.Forms.ListBox lst_bannedCmds;
        private System.Windows.Forms.ListBox lst_groupList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

