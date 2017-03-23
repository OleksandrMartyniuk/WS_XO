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
using Core;
using Newtonsoft.Json;

namespace GameClient
{
    public partial class XO : UserControl
    {
        string gamestorage;
        int roomNumber;
        public XO()
        {
            InitializeComponent();
        }
        public XO(object[] args) { 
            InitializeComponent();
            roomNumber = Convert.ToInt32(args[0].ToString());
            statusPlay(args[2].ToString());
            ResponseHandler.move += (x) => btn_xo_Move(x);
            turn_text.Text = "Name: " + Client.Username;
        }
     
        
        private void btn_xo_Click(object sender, EventArgs e)
        {
            RequestManager.SendMove(new object[]{ roomNumber, gamestorage, Convert.ToInt32((sender as Button).Tag), Client.Username });
        }
      
        private void statusPlay(string args)
        {
            string name = Client.Username;
            if (args.ToString() == name)
            {
                gamestorage = "X";
                status_text.Text = "play: " + name + " go";
            }
            else
            {
                gamestorage = "O";
                status_text.Text = "play: " + gamestorage + " wait";
            }
        }

        private void btn_xo_Move(object x)
        {
            object[] args = JsonConvert.DeserializeObject<object[]>(x.ToString());
            if (gamestorage == args[0].ToString())
            {
                status_text.Text = "play: " + gamestorage + " wait";
            }
            else
            {
                status_text.Text = "play: " + gamestorage + " go";
            }
          
            switch (args[1].ToString())
            {
                case "0":
                    btn_xo1.Text = args[0].ToString();
                    break;
                case "1":
                    btn_xo2.Text = args[0].ToString();
                    break;
                case "2":
                    btn_xo3.Text = args[0].ToString();
                    break;
                case "3":
                    btn_xo4.Text = args[0].ToString();
                    break;
                case "4":
                    btn_xo5.Text = args[0].ToString();
                    break;
                case "5":
                    btn_xo6.Text = args[0].ToString();
                    break;
                case "6":
                    btn_xo7.Text = args[0].ToString();
                    break;
                case "7":
                    btn_xo8.Text = args[0].ToString();
                    break;
                case "8":
                    btn_xo9.Text = args[0].ToString();
                    break;
            }
        }
    }
}
