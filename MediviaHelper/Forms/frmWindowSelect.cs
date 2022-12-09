using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MediviaHelper.Classes;

namespace MediviaHelper
{
    public partial class FrmWindowSelect : Form
    {
        private List<Client> clients = new List<Client>();

        public FrmWindowSelect()
        {
            InitializeComponent();
        }

        private void frmWindowSelect_Load(object sender, EventArgs e)
        {
            listClients();
        }
        private void listClients()
        {
            this.lvWindows.Items.Clear();

            Process[] processes = this.getMediviaClients();
            
            if(processes == null || processes.Length == 0)
            {
                return;
            }

            foreach (Process client in processes)
            {
                var newClient = new Client(client);

                if (!newClient.player.online) continue;

                this.clients.Add(newClient);

                string[] lvRow = {
                    newClient.player.name, 
                    newClient.player.server, 
                    newClient.processID.ToString() 
                };

                var lvRowItem = new ListViewItem(lvRow);
                this.lvWindows.Items.Add(lvRowItem);
            }

        }

        private Process[] getMediviaClients()
        {
            Process[] mediviaClients = Process.GetProcessesByName("Medivia");
            return (mediviaClients.Length > 0) ? mediviaClients : null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.listClients();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.lvWindows.SelectedIndices.Count == 0) return;

            int idx = this.lvWindows.SelectedIndices[0];
            Client selectedClient = this.clients[idx];
            if (selectedClient != null)
            {
                FrmHelper fHelper = new FrmHelper(selectedClient);
                fHelper.Show();
                this.Hide();
            }
        }
    }
}
