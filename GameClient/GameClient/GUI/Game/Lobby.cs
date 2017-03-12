using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameClient.API.Networking;
using Newtonsoft.Json;

namespace GameClient
{
    public partial class Lobby : UserControl
    {
        public Lobby()
        {
            InitializeComponent();
            Text_name.Text = "UserName: "+ Client.Username;
            games_name.SelectedIndex = 0;
            ResponseHandler.refreshClients += RefreshClientsHandler;
        }
        private void btn_invite_Click(object sender, EventArgs e)
        {
            if (lst_clients.SelectedItem != null)
            {
                new Listener().SendInvite(new object[] { lst_clients.SelectedItem.ToString(), games_name.SelectedItem.ToString() });
            }
        }
        public void RefreshClientsHandler(object sender)
        {
            object[] clients = JsonConvert.DeserializeObject<object[]>(sender.ToString());
            lst_clients.Items.Clear();
            lst_clients.Items.AddRange(clients);
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RequestManager.SendRefreshClients();
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            new Authorization().SendLogout();
            ParentForm.Close(); 
            new LoginForm().ShowDialog();
        }
    }
}
