namespace Group_Share_Admin
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
            this.bt_srcontrol = new System.Windows.Forms.Button();
            this.lv_connectionlist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // bt_srcontrol
            // 
            this.bt_srcontrol.Location = new System.Drawing.Point(12, 412);
            this.bt_srcontrol.Name = "bt_srcontrol";
            this.bt_srcontrol.Size = new System.Drawing.Size(75, 23);
            this.bt_srcontrol.TabIndex = 0;
            this.bt_srcontrol.Text = "On";
            this.bt_srcontrol.UseVisualStyleBackColor = true;
            this.bt_srcontrol.Click += new System.EventHandler(this.bt_srcontrol_Click);
            // 
            // lv_connectionlist
            // 
            this.lv_connectionlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_connectionlist.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lv_connectionlist.FullRowSelect = true;
            this.lv_connectionlist.GridLines = true;
            this.lv_connectionlist.Location = new System.Drawing.Point(12, 12);
            this.lv_connectionlist.Name = "lv_connectionlist";
            this.lv_connectionlist.Size = new System.Drawing.Size(301, 394);
            this.lv_connectionlist.TabIndex = 1;
            this.lv_connectionlist.UseCompatibleStateImageBehavior = false;
            this.lv_connectionlist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP";
            this.columnHeader1.Width = 167;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PassWord";
            this.columnHeader2.Width = 105;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 447);
            this.Controls.Add(this.lv_connectionlist);
            this.Controls.Add(this.bt_srcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main_Form";
            this.Text = "Group Share Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_srcontrol;
        private System.Windows.Forms.ListView lv_connectionlist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}