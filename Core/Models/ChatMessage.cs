﻿using Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ChatMessage
    {
        public ChatMessage(string sndr, string text, DateTime time)
        {
            Sender = sndr;
            Text = text;
            TimeStamp = time;
        }

        public ChatMessage()
        {
        }

        public string Sender { get; set; }
        public string Text { get; set; }
        public DateTime TimeStamp { get; set; }

        public override string ToString()
        {
            return "[" + TimeStamp.ToString("T", CultureInfo.CreateSpecificCulture("es-ES")) + "]" + Sender + " : " + Text ;
        }
    }
}
