namespace MediviaHelper
{
    partial class FrmWindowSelect
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
            this.lvWindows = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colServer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvWindows
            // 
            this.lvWindows.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colServer,
            this.colPid});
            this.lvWindows.FullRowSelect = true;
            this.lvWindows.HideSelection = false;
            this.lvWindows.Location = new System.Drawing.Point(12, 12);
            this.lvWindows.Name = "lvWindows";
            this.lvWindows.Size = new System.Drawing.Size(225, 159);
            this.lvWindows.TabIndex = 0;
            this.lvWindows.UseCompatibleStateImageBehavior = false;
            this.lvWindows.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 80;
            // 
            // colServer
            // 
            this.colServer.Text = "Server";
            this.colServer.Width = 80;
            // 
            // colPid
            // 
            this.colPid.Text = "PID";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = global::MediviaHelper.Properties.Resources._16;
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(12, 177);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(114, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::MediviaHelper.Properties.Resources._14;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(132, 177);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 24);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmWindowSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 209);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lvWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWindowSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Medivia";
            this.Load += new System.EventHandler(this.frmWindowSelect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvWindows;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colServer;
        private System.Windows.Forms.ColumnHeader colPid;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnRefresh;
    }
}