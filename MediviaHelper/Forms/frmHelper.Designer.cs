namespace MediviaHelper
{
    partial class FrmHelper
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.pbMana = new System.Windows.Forms.ProgressBar();
            this.lblMana = new System.Windows.Forms.Label();
            this.pbHP = new System.Windows.Forms.ProgressBar();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.chkFullMana = new System.Windows.Forms.CheckBox();
            this.chkBattle = new System.Windows.Forms.CheckBox();
            this.chkNotFullHP = new System.Windows.Forms.CheckBox();
            this.chkHungry = new System.Windows.Forms.CheckBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabNoty = new System.Windows.Forms.TabPage();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.lvLog = new System.Windows.Forms.ListView();
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMsg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblLvl = new System.Windows.Forms.Label();
            this.lblLvlExp = new System.Windows.Forms.Label();
            this.lblLvlPercent = new System.Windows.Forms.Label();
            this.gbDisconnected = new System.Windows.Forms.GroupBox();
            this.lblDisconnected = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabNoty.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbDisconnected.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Player Name";
            // 
            // pbMana
            // 
            this.pbMana.Location = new System.Drawing.Point(18, 222);
            this.pbMana.Name = "pbMana";
            this.pbMana.Size = new System.Drawing.Size(217, 15);
            this.pbMana.TabIndex = 1;
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.BackColor = System.Drawing.Color.Transparent;
            this.lblMana.Location = new System.Drawing.Point(15, 206);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(34, 13);
            this.lblMana.TabIndex = 2;
            this.lblMana.Text = "Mana";
            this.lblMana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbHP
            // 
            this.pbHP.Location = new System.Drawing.Point(18, 176);
            this.pbHP.Name = "pbHP";
            this.pbHP.Size = new System.Drawing.Size(217, 13);
            this.pbHP.TabIndex = 3;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.BackColor = System.Drawing.Color.Transparent;
            this.lblHP.Location = new System.Drawing.Point(15, 160);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(38, 13);
            this.lblHP.TabIndex = 4;
            this.lblHP.Text = "Health";
            this.lblHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(15, 50);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(41, 13);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "Server:";
            // 
            // chkFullMana
            // 
            this.chkFullMana.AutoSize = true;
            this.chkFullMana.BackColor = System.Drawing.Color.White;
            this.chkFullMana.Location = new System.Drawing.Point(18, 58);
            this.chkFullMana.Name = "chkFullMana";
            this.chkFullMana.Size = new System.Drawing.Size(82, 17);
            this.chkFullMana.TabIndex = 4;
            this.chkFullMana.Text = "Mana is full.";
            this.chkFullMana.UseVisualStyleBackColor = false;
            this.chkFullMana.CheckedChanged += new System.EventHandler(this.chkFullMana_CheckedChanged);
            // 
            // chkBattle
            // 
            this.chkBattle.AutoSize = true;
            this.chkBattle.Location = new System.Drawing.Point(18, 123);
            this.chkBattle.Name = "chkBattle";
            this.chkBattle.Size = new System.Drawing.Size(67, 17);
            this.chkBattle.TabIndex = 7;
            this.chkBattle.Text = "In battle.";
            this.chkBattle.UseVisualStyleBackColor = true;
            this.chkBattle.CheckedChanged += new System.EventHandler(this.chkBattle_CheckedChanged);
            // 
            // chkNotFullHP
            // 
            this.chkNotFullHP.AutoSize = true;
            this.chkNotFullHP.BackColor = System.Drawing.Color.White;
            this.chkNotFullHP.Location = new System.Drawing.Point(18, 26);
            this.chkNotFullHP.Name = "chkNotFullHP";
            this.chkNotFullHP.Size = new System.Drawing.Size(94, 17);
            this.chkNotFullHP.TabIndex = 6;
            this.chkNotFullHP.Text = "Health not full.";
            this.chkNotFullHP.UseVisualStyleBackColor = false;
            this.chkNotFullHP.CheckedChanged += new System.EventHandler(this.chkNotFullHP_CheckedChanged);
            // 
            // chkHungry
            // 
            this.chkHungry.AutoSize = true;
            this.chkHungry.Location = new System.Drawing.Point(18, 91);
            this.chkHungry.Name = "chkHungry";
            this.chkHungry.Size = new System.Drawing.Size(83, 17);
            this.chkHungry.TabIndex = 5;
            this.chkHungry.Text = "Has hungry.";
            this.chkHungry.UseVisualStyleBackColor = true;
            this.chkHungry.CheckedChanged += new System.EventHandler(this.chkHungry_CheckedChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMain);
            this.tabControl.Controls.Add(this.tabNoty);
            this.tabControl.Controls.Add(this.tabLog);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(258, 288);
            this.tabControl.TabIndex = 6;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.gbDisconnected);
            this.tabMain.Controls.Add(this.lblLvlPercent);
            this.tabMain.Controls.Add(this.lblLvl);
            this.tabMain.Controls.Add(this.lblLvlExp);
            this.tabMain.Controls.Add(this.pbHP);
            this.tabMain.Controls.Add(this.lblHP);
            this.tabMain.Controls.Add(this.lblServer);
            this.tabMain.Controls.Add(this.lblName);
            this.tabMain.Controls.Add(this.pbMana);
            this.tabMain.Controls.Add(this.lblMana);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(250, 262);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Home";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tabNoty
            // 
            this.tabNoty.Controls.Add(this.chkNotFullHP);
            this.tabNoty.Controls.Add(this.chkFullMana);
            this.tabNoty.Controls.Add(this.chkHungry);
            this.tabNoty.Controls.Add(this.chkBattle);
            this.tabNoty.Location = new System.Drawing.Point(4, 22);
            this.tabNoty.Name = "tabNoty";
            this.tabNoty.Padding = new System.Windows.Forms.Padding(3);
            this.tabNoty.Size = new System.Drawing.Size(250, 262);
            this.tabNoty.TabIndex = 2;
            this.tabNoty.Text = "Notifications";
            this.tabNoty.UseVisualStyleBackColor = true;
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.lvLog);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(250, 262);
            this.tabLog.TabIndex = 1;
            this.tabLog.Text = "Logs";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // lvLog
            // 
            this.lvLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDate,
            this.colMsg});
            this.lvLog.FullRowSelect = true;
            this.lvLog.HideSelection = false;
            this.lvLog.Location = new System.Drawing.Point(6, 6);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(238, 250);
            this.lvLog.TabIndex = 0;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.Details;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 80;
            // 
            // colMsg
            // 
            this.colMsg.Text = "Message";
            this.colMsg.Width = 158;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 308);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(282, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(107, 17);
            this.toolStripStatusLabel1.Text = "Developed by WEA";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.IsLink = true;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(162, 17);
            this.toolStripStatusLabel2.Text = "http://github.com/WEAHub/";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "MediviaHelper";
            this.notifyIcon.Visible = true;
            // 
            // lblLvl
            // 
            this.lblLvl.AutoSize = true;
            this.lblLvl.Location = new System.Drawing.Point(15, 78);
            this.lblLvl.Name = "lblLvl";
            this.lblLvl.Size = new System.Drawing.Size(36, 13);
            this.lblLvl.TabIndex = 6;
            this.lblLvl.Text = "Level:";
            // 
            // lblLvlExp
            // 
            this.lblLvlExp.AutoSize = true;
            this.lblLvlExp.Location = new System.Drawing.Point(15, 131);
            this.lblLvlExp.Name = "lblLvlExp";
            this.lblLvlExp.Size = new System.Drawing.Size(63, 13);
            this.lblLvlExp.TabIndex = 5;
            this.lblLvlExp.Text = "Experience:";
            // 
            // lblLvlPercent
            // 
            this.lblLvlPercent.AutoSize = true;
            this.lblLvlPercent.Location = new System.Drawing.Point(15, 104);
            this.lblLvlPercent.Name = "lblLvlPercent";
            this.lblLvlPercent.Size = new System.Drawing.Size(47, 13);
            this.lblLvlPercent.TabIndex = 7;
            this.lblLvlPercent.Text = "Level %:";
            // 
            // gbDisconnected
            // 
            this.gbDisconnected.BackgroundImage = global::MediviaHelper.Properties.Resources.disconnected;
            this.gbDisconnected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbDisconnected.Controls.Add(this.lblDisconnected);
            this.gbDisconnected.Cursor = System.Windows.Forms.Cursors.No;
            this.gbDisconnected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDisconnected.Location = new System.Drawing.Point(6, 6);
            this.gbDisconnected.Name = "gbDisconnected";
            this.gbDisconnected.Size = new System.Drawing.Size(238, 250);
            this.gbDisconnected.TabIndex = 9;
            this.gbDisconnected.TabStop = false;
            this.gbDisconnected.Visible = false;
            // 
            // lblDisconnected
            // 
            this.lblDisconnected.Location = new System.Drawing.Point(27, 44);
            this.lblDisconnected.Name = "lblDisconnected";
            this.lblDisconnected.Size = new System.Drawing.Size(185, 28);
            this.lblDisconnected.TabIndex = 0;
            this.lblDisconnected.Text = "Player disconnected";
            this.lblDisconnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 330);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediviaHelper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHelper_FormClosing);
            this.Load += new System.EventHandler(this.FrmHelper_Load);
            this.tabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabNoty.ResumeLayout(false);
            this.tabNoty.PerformLayout();
            this.tabLog.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbDisconnected.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ProgressBar pbMana;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ProgressBar pbHP;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.CheckBox chkFullMana;
        private System.Windows.Forms.CheckBox chkNotFullHP;
        private System.Windows.Forms.CheckBox chkHungry;
        private System.Windows.Forms.CheckBox chkBattle;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListView lvLog;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colMsg;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TabPage tabNoty;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label lblLvlPercent;
        private System.Windows.Forms.Label lblLvl;
        private System.Windows.Forms.Label lblLvlExp;
        private System.Windows.Forms.GroupBox gbDisconnected;
        private System.Windows.Forms.Label lblDisconnected;
    }
}

