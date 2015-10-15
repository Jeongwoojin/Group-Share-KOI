namespace Group_Share_User
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.lk_state = new System.Windows.Forms.LinkLabel();
            this.sendimgae = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lk_Codeshare = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tx_partpw = new System.Windows.Forms.TextBox();
            this.bt_Pressetion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_pw = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_filesend = new System.Windows.Forms.Button();
            this.tb_filepartpw = new System.Windows.Forms.TextBox();
            this.tb_filebrower = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cb_try = new System.Windows.Forms.CheckBox();
            this.cb_filestream = new System.Windows.Forms.CheckBox();
            this.ck_pressetion = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nf_try = new System.Windows.Forms.NotifyIcon(this.components);
            this.cm_try = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ms_main.SuspendLayout();
            this.cm_try.SuspendLayout();
            this.SuspendLayout();
            // 
            // lk_state
            // 
            this.lk_state.AutoSize = true;
            this.lk_state.Location = new System.Drawing.Point(19, 276);
            this.lk_state.Name = "lk_state";
            this.lk_state.Size = new System.Drawing.Size(0, 12);
            this.lk_state.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 261);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lk_Codeshare);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lk_Codeshare
            // 
            this.lk_Codeshare.AutoSize = true;
            this.lk_Codeshare.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lk_Codeshare.Location = new System.Drawing.Point(395, 175);
            this.lk_Codeshare.Name = "lk_Codeshare";
            this.lk_Codeshare.Size = new System.Drawing.Size(131, 32);
            this.lk_Codeshare.TabIndex = 4;
            this.lk_Codeshare.TabStop = true;
            this.lk_Codeshare.Text = "CodeShare";
            this.lk_Codeshare.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_Codeshare_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tx_partpw);
            this.groupBox2.Controls.Add(this.bt_Pressetion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(368, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 147);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "화면 공유";
            // 
            // tx_partpw
            // 
            this.tx_partpw.Location = new System.Drawing.Point(16, 54);
            this.tx_partpw.Name = "tx_partpw";
            this.tx_partpw.Size = new System.Drawing.Size(156, 25);
            this.tx_partpw.TabIndex = 3;
            // 
            // bt_Pressetion
            // 
            this.bt_Pressetion.Location = new System.Drawing.Point(16, 93);
            this.bt_Pressetion.Name = "bt_Pressetion";
            this.bt_Pressetion.Size = new System.Drawing.Size(156, 37);
            this.bt_Pressetion.TabIndex = 2;
            this.bt_Pressetion.Text = "연결";
            this.bt_Pressetion.UseVisualStyleBackColor = true;
            this.bt_Pressetion.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "요청할 파트너 비밀번호";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tx_pw);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 59);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "유저 데이터";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(10, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "비밀번호";
            // 
            // tx_pw
            // 
            this.tx_pw.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.tx_pw.Location = new System.Drawing.Point(72, 22);
            this.tx_pw.Name = "tx_pw";
            this.tx_pw.ReadOnly = true;
            this.tx_pw.Size = new System.Drawing.Size(255, 25);
            this.tx_pw.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bt_filesend);
            this.groupBox1.Controls.Add(this.tb_filepartpw);
            this.groupBox1.Controls.Add(this.tb_filebrower);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(6, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 153);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "파일 전송";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "전송할 파트너 비밀번호";
            // 
            // bt_filesend
            // 
            this.bt_filesend.Location = new System.Drawing.Point(15, 99);
            this.bt_filesend.Name = "bt_filesend";
            this.bt_filesend.Size = new System.Drawing.Size(314, 37);
            this.bt_filesend.TabIndex = 3;
            this.bt_filesend.Text = "전송";
            this.bt_filesend.UseVisualStyleBackColor = true;
            this.bt_filesend.Click += new System.EventHandler(this.bt_filesend_Click);
            // 
            // tb_filepartpw
            // 
            this.tb_filepartpw.Location = new System.Drawing.Point(156, 25);
            this.tb_filepartpw.Name = "tb_filepartpw";
            this.tb_filepartpw.Size = new System.Drawing.Size(171, 25);
            this.tb_filepartpw.TabIndex = 2;
            // 
            // tb_filebrower
            // 
            this.tb_filebrower.Location = new System.Drawing.Point(13, 57);
            this.tb_filebrower.Name = "tb_filebrower";
            this.tb_filebrower.ReadOnly = true;
            this.tb_filebrower.Size = new System.Drawing.Size(222, 25);
            this.tb_filebrower.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "파일 찾기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cb_try);
            this.tabPage2.Controls.Add(this.cb_filestream);
            this.tabPage2.Controls.Add(this.ck_pressetion);
            this.tabPage2.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Setting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cb_try
            // 
            this.cb_try.AutoSize = true;
            this.cb_try.Checked = true;
            this.cb_try.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_try.Location = new System.Drawing.Point(20, 74);
            this.cb_try.Name = "cb_try";
            this.cb_try.Size = new System.Drawing.Size(102, 21);
            this.cb_try.TabIndex = 2;
            this.cb_try.Text = "트레이 모드 ";
            this.cb_try.UseVisualStyleBackColor = true;
            // 
            // cb_filestream
            // 
            this.cb_filestream.AutoSize = true;
            this.cb_filestream.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_filestream.Location = new System.Drawing.Point(20, 47);
            this.cb_filestream.Name = "cb_filestream";
            this.cb_filestream.Size = new System.Drawing.Size(146, 21);
            this.cb_filestream.TabIndex = 1;
            this.cb_filestream.Text = "파일 수신 자동 수락";
            this.cb_filestream.UseVisualStyleBackColor = true;
            this.cb_filestream.CheckedChanged += new System.EventHandler(this.cb_filestream_CheckedChanged);
            // 
            // ck_pressetion
            // 
            this.ck_pressetion.AutoSize = true;
            this.ck_pressetion.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ck_pressetion.Location = new System.Drawing.Point(20, 20);
            this.ck_pressetion.Name = "ck_pressetion";
            this.ck_pressetion.Size = new System.Drawing.Size(146, 21);
            this.ck_pressetion.TabIndex = 0;
            this.ck_pressetion.Text = "화면 공유 자동 수락";
            this.ck_pressetion.UseVisualStyleBackColor = true;
            this.ck_pressetion.CheckedChanged += new System.EventHandler(this.ck_pressetion_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Location = new System.Drawing.Point(0, 284);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(582, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // ms_main
            // 
            this.ms_main.BackColor = System.Drawing.Color.Transparent;
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(582, 24);
            this.ms_main.TabIndex = 6;
            this.ms_main.Text = "menuStrip1";
            this.ms_main.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ms_main_ItemClicked);
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem1});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 종료ToolStripMenuItem1
            // 
            this.종료ToolStripMenuItem1.Name = "종료ToolStripMenuItem1";
            this.종료ToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.종료ToolStripMenuItem1.Text = "종료";
            this.종료ToolStripMenuItem1.Click += new System.EventHandler(this.종료ToolStripMenuItem1_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.menuToolStripMenuItem.Text = "메뉴";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // nf_try
            // 
            this.nf_try.ContextMenuStrip = this.cm_try;
            this.nf_try.Icon = ((System.Drawing.Icon)(resources.GetObject("nf_try.Icon")));
            this.nf_try.Text = "Group Share";
            this.nf_try.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nf_try_MouseDoubleClick);
            // 
            // cm_try
            // 
            this.cm_try.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.cm_try.Name = "contextMenuStrip1";
            this.cm_try.Size = new System.Drawing.Size(99, 48);
            this.cm_try.DoubleClick += new System.EventHandler(this.cm_try_DoubleClick);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.OpenToolStripMenuItem.Text = "열기";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.ExitToolStripMenuItem.Text = "종료";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 306);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ms_main);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lk_state);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_main;
            this.Name = "Main_Form";
            this.Text = "Group Share ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            this.cm_try.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lk_state;
        private System.Windows.Forms.Timer sendimgae;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tx_partpw;
        private System.Windows.Forms.Button bt_Pressetion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_pw;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox ck_pressetion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.LinkLabel lk_Codeshare;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_filesend;
        private System.Windows.Forms.TextBox tb_filepartpw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_filebrower;
        private System.Windows.Forms.CheckBox cb_filestream;
        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon nf_try;
        private System.Windows.Forms.ContextMenuStrip cm_try;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.CheckBox cb_try;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem1;

    }
}