using GameClient.API.Networking;
using GameClient.GUI.Game;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameClient
{
    public partial class LobbyForm : Form
    {
     
        public LobbyForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            LobbyHandler();
            ResponseHandler.wait +=()=> Invoke(new Action(WaitHandler));
            ResponseHandler.notificationLobby += ShowNotificationHandler;
            ResponseHandler.answer  +=(x)=> Invoke(new Action<object>(AnswerFormHandler),x);
            ResponseHandler.cancle  +=()=>Invoke(new Action(CancleHandler));
            ResponseHandler.start +=(x)=>Invoke(new Action<object>(GamesHandler),x);
            ResponseHandler.gamesOver +=(x)=>Invoke(new Action<object>(GameOver),x);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        public void GamesHandler(object x)
        {
            UserControl game=null;
            object[] args = JsonConvert.DeserializeObject<object[]>(x.ToString());
            switch (args[1].ToString())
            {
                case "XO":
                    game = new XO(args);
                    break;
                default:
                    break;
            }
            if (game != null)
            {
                this.Controls.RemoveAt(0);
                this.Controls.Add(game);
            }
        }
       
        void GameOver(object sender)
        {
            LobbyHandler();
            MessageBox.Show(sender.ToString());
        }
        void ShowNotificationHandler(object sender)
        {
            MessageBox.Show(sender.ToString());
        }

        private void AnswerFormHandler(object x)
        {
            this.Controls.RemoveAt(0);
            this.Controls.Add(new Answer(x));
        }

        private void CancleHandler()
        {
            LobbyHandler();
            MessageBox.Show("Приглашение откланено");
        }
        
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ResponseHandler.wait -= () => Invoke(new Action(WaitHandler));
            ResponseHandler.notificationLobby -= ShowNotificationHandler;
            ResponseHandler.answer -= (x) => Invoke(new Action<object>(AnswerFormHandler), x);
            ResponseHandler.cancle -= () => Invoke(new Action(CancleHandler));
            ResponseHandler.start -= (x) => Invoke(new Action<object>(GamesHandler), x);
            ResponseHandler.gamesOver -= (x) => Invoke(new Action<object>(GameOver), x);
            this.Close();
            this.Dispose();
        }

        private void LobbyHandler()
        {
            if (this.Controls.Count > 0)
                this.Controls.RemoveAt(0);
            this.Controls.Add(new Lobby());
        }
        private void WaitHandler()
        {
            this.Controls.RemoveAt(0);
            this.Controls.Add(new Wait());  
        }
    }
}
