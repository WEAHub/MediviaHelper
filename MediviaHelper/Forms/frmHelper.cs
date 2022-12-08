using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Memory;
using MediviaHelper.Classes;
using System.Timers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Reflection;
using Notification.Wpf;

namespace MediviaHelper
{

    public partial class FrmHelper : Form
    {

        private static System.Timers.Timer statsTimer;

        private Client client = null;
        private bool notyFullMana = false;
        private bool notyNotFullHp = false;
        private bool notyHungry = false;

        private NotificationManager notifyMan = new NotificationManager();
        private NotificationContent lastNotification = null;

        public FrmHelper(Client _client)
        {
            InitializeComponent();
            client = _client;
        }

        private void FrmHelper_Load(object sender, EventArgs e)
        {
            this.lblName.Text = $"Player: {client.player.name}";
            this.lblServer.Text = $"Server: {client.player.server}";
            this.startUpdate();
        }

        private void startUpdate()
        {
            UpdateManaPB();
            statsTimer = new System.Timers.Timer(1000);
            statsTimer.Elapsed += OnTimedEvent;
            statsTimer.AutoReset = true;
            statsTimer.SynchronizingObject = this;
            statsTimer.Enabled = true;
        }

        private void UpdateManaPB()
        {

            int hpMax = Convert.ToInt32(this.client.player.maxHP);
            int hp = Convert.ToInt32(this.client.player.hp);
            int manaMax = Convert.ToInt32(this.client.player.maxMana);
            int mana = Convert.ToInt32(this.client.player.mana);

            this.pbHP.Maximum = hpMax;
            this.pbHP.Value = hp;
            this.lblHP.Text = $"Health: {hp.ToString() + "/" + hpMax.ToString()}";

            this.pbMana.Maximum = manaMax;
            this.pbMana.Value = mana;
            this.lblMana.Text = $"Mana: {mana.ToString() + "/" + manaMax.ToString()}";

        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            this.client.playerUpdate();
            this.UpdateManaPB();
            
            // Notifications
            if(this.notyFullMana && this.client.player.mana == this.client.player.maxMana)
            {
                this.showNotification(
                    this.client.player.name,
                    $"Mana ({this.client.player.mana}) is full", 
                    NotificationType.Information
                );
            }

            if (this.notyNotFullHp && this.client.player.hp < this.client.player.maxHP)
            {
                this.showNotification(
                    this.client.player.name, 
                   $"HP ({this.client.player.hp}) lower than max. HP", 
                    NotificationType.Error
                );
            }

        }

        private void showNotification(string title, string message, NotificationType type)
        {
            var content = new NotificationContent {
                Title = title,
                Message = message,
                Type = type,
                CloseOnClick = false,
                LeftButtonAction = () => this.client.FocusWindow(),
            };

            if (this.lastNotification == null 
                || (this.lastNotification != null
                && content.Message != this.lastNotification.Message
                && content.Title != this.lastNotification.Title))
            {
                this.lastNotification = content;
                notifyMan.Show(content);
            }
        }

        private void FrmHelper_FormClosing(object sender, FormClosingEventArgs e)
        {
            statsTimer.Stop();
            Application.Exit();
        }

        private void chkNotFullHP_CheckedChanged(object sender, EventArgs e)
        {
            this.notyNotFullHp = !this.notyNotFullHp;
        }

        private void chkFullMana_CheckedChanged(object sender, EventArgs e)
        {
            this.notyFullMana = !this.notyFullMana;
        }

        private void chkHungry_CheckedChanged(object sender, EventArgs e)
        {
            this.notyHungry = !this.notyHungry;
        }
    }
}