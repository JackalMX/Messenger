﻿using System;
using Newtonsoft.Json;

namespace Messenger
{
    class Program
    {
        private static int MessageID;
        private static string UserName;
        private static MessengerClientAPI API = new MessengerClientAPI();

        private static void GetNewMessages()
        {
            Message msg = API.GetMessage(MessageID);
            while (msg != null)
            {
                Console.WriteLine(msg);
                MessageID++;
                msg = API.GetMessage(MessageID);
            }
        }

        static void Main(string[] args)
        {
            MessageID = 1;
            Console.WriteLine("Введите ваше имя:");
            UserName = Console.ReadLine();
            string MessageText = "";
            while (MessageText != "exit")
            {
                GetNewMessages();
                MessageText = Console.ReadLine();
                if (MessageText.Length > 1)
                {
                    Message sendMsg = new Message(UserName, MessageText, DateTime.Now);
                    API.SendMessage(sendMsg);
                }
            }
        }
    }
}
