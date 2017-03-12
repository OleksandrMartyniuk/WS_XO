using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GameClient.GUI.Game
{
    public partial class Answer : UserControl
    {
        object args;
        public Answer(object arg)
        {
            InitializeComponent();
            object[] args = JsonConvert.DeserializeObject<object[]>(arg.ToString());
            label1.Text = args[0] + " приглашает вас поиграть в " + args[1];
            this.args = args;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            new Listener().SendOk(args);
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            new Listener().SendCancle(args);
        }
      
    }
}
