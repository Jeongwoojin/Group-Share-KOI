namespace Group_Share_User.Controller_Form
{
    partial class CodeShareForm
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
            this.rt_ligth = new System.Windows.Forms.RichTextBox();
            this.tm_ligth = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_sourcesend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rt_ligth
            // 
            this.rt_ligth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rt_ligth.Location = new System.Drawing.Point(12, 12);
            this.rt_ligth.Name = "rt_ligth";
            this.rt_ligth.Size = new System.Drawing.Size(435, 402);
            this.rt_ligth.TabIndex = 0;
            this.rt_ligth.Text = "";
            this.rt_ligth.TextChanged += new System.EventHandler(this.rt_ligth_TextChanged);
            // 
            // tm_ligth
            // 
            this.tm_ligth.Interval = 10000;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_sourcesend);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_pw);
            this.groupBox1.Location = new System.Drawing.Point(12, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Code Share";
            // 
            // bt_sourcesend
            // 
            this.bt_sourcesend.Location = new System.Drawing.Point(315, 24);
            this.bt_sourcesend.Name = "bt_sourcesend";
            this.bt_sourcesend.Size = new System.Drawing.Size(114, 25);
            this.bt_sourcesend.TabIndex = 4;
            this.bt_sourcesend.Text = "전송";
            this.bt_sourcesend.UseVisualStyleBackColor = true;
            this.bt_sourcesend.Click += new System.EventHandler(this.bt_sourcesend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "파트너 비밀번호";
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(116, 24);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.Size = new System.Drawing.Size(193, 25);
            this.tb_pw.TabIndex = 2;
            // 
            // CodeShareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 503);
            this.Controls.Add(this.rt_ligth);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CodeShareForm";
            this.Text = "Group Share[CodeShare]";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_ligth;
        private System.Windows.Forms.Timer tm_ligth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_sourcesend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pw;

    }
}