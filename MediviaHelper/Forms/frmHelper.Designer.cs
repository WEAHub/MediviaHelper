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
            this.lblName = new System.Windows.Forms.Label();
            this.pbMana = new System.Windows.Forms.ProgressBar();
            this.lblMana = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbHP = new System.Windows.Forms.ProgressBar();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.chkFullMana = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkNotFullHP = new System.Windows.Forms.CheckBox();
            this.chkHungry = new System.Windows.Forms.CheckBox();
            this.chkBattle = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Player Name";
            // 
            // pbMana
            // 
            this.pbMana.Location = new System.Drawing.Point(18, 132);
            this.pbMana.Name = "pbMana";
            this.pbMana.Size = new System.Drawing.Size(182, 15);
            this.pbMana.TabIndex = 1;
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.BackColor = System.Drawing.Color.Transparent;
            this.lblMana.Location = new System.Drawing.Point(15, 116);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(34, 13);
            this.lblMana.TabIndex = 2;
            this.lblMana.Text = "Mana";
            this.lblMana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbHP);
            this.groupBox1.Controls.Add(this.lblHP);
            this.groupBox1.Controls.Add(this.lblServer);
            this.groupBox1.Controls.Add(this.pbMana);
            this.groupBox1.Controls.Add(this.lblMana);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 165);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // pbHP
            // 
            this.pbHP.Location = new System.Drawing.Point(18, 91);
            this.pbHP.Name = "pbHP";
            this.pbHP.Size = new System.Drawing.Size(182, 15);
            this.pbHP.TabIndex = 3;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.BackColor = System.Drawing.Color.Transparent;
            this.lblHP.Location = new System.Drawing.Point(15, 75);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(38, 13);
            this.lblHP.TabIndex = 4;
            this.lblHP.Text = "Health";
            this.lblHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(15, 51);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(38, 13);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "Server";
            // 
            // chkFullMana
            // 
            this.chkFullMana.AutoSize = true;
            this.chkFullMana.Location = new System.Drawing.Point(18, 54);
            this.chkFullMana.Name = "chkFullMana";
            this.chkFullMana.Size = new System.Drawing.Size(79, 17);
            this.chkFullMana.TabIndex = 4;
            this.chkFullMana.Text = "Mana is full";
            this.chkFullMana.UseVisualStyleBackColor = true;
            this.chkFullMana.CheckedChanged += new System.EventHandler(this.chkFullMana_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBattle);
            this.groupBox2.Controls.Add(this.chkNotFullHP);
            this.groupBox2.Controls.Add(this.chkHungry);
            this.groupBox2.Controls.Add(this.chkFullMana);
            this.groupBox2.Location = new System.Drawing.Point(12, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 85);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notify";
            // 
            // chkNotFullHP
            // 
            this.chkNotFullHP.AutoSize = true;
            this.chkNotFullHP.Location = new System.Drawing.Point(18, 31);
            this.chkNotFullHP.Name = "chkNotFullHP";
            this.chkNotFullHP.Size = new System.Drawing.Size(75, 17);
            this.chkNotFullHP.TabIndex = 6;
            this.chkNotFullHP.Text = "HP not full";
            this.chkNotFullHP.UseVisualStyleBackColor = true;
            this.chkNotFullHP.CheckedChanged += new System.EventHandler(this.chkNotFullHP_CheckedChanged);
            // 
            // chkHungry
            // 
            this.chkHungry.AutoSize = true;
            this.chkHungry.Location = new System.Drawing.Point(125, 54);
            this.chkHungry.Name = "chkHungry";
            this.chkHungry.Size = new System.Drawing.Size(60, 17);
            this.chkHungry.TabIndex = 5;
            this.chkHungry.Text = "Hungry";
            this.chkHungry.UseVisualStyleBackColor = true;
            this.chkHungry.CheckedChanged += new System.EventHandler(this.chkHungry_CheckedChanged);
            // 
            // chkBattle
            // 
            this.chkBattle.AutoSize = true;
            this.chkBattle.Location = new System.Drawing.Point(125, 31);
            this.chkBattle.Name = "chkBattle";
            this.chkBattle.Size = new System.Drawing.Size(53, 17);
            this.chkBattle.TabIndex = 7;
            this.chkBattle.Text = "Battle";
            this.chkBattle.UseVisualStyleBackColor = true;
            this.chkBattle.CheckedChanged += new System.EventHandler(this.chkBattle_CheckedChanged);
            // 
            // FrmHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 276);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHelper";
            this.Text = "MediviaHelper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHelper_FormClosing);
            this.Load += new System.EventHandler(this.FrmHelper_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ProgressBar pbMana;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ProgressBar pbHP;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.CheckBox chkFullMana;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkNotFullHP;
        private System.Windows.Forms.CheckBox chkHungry;
        private System.Windows.Forms.CheckBox chkBattle;
    }
}

