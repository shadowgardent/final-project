﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Ticket
    {
        protected DateTime tm;
        public DateTime time_stamp()
        {
            return DateTime.Now;
        }
        public Ticket (DateTime time_stamp)
        {
           this.tm = time_stamp;
        }

        public Ticket()
        {

        }

        public bool WriteF(List<customer> customers)
        {
            string path = @"D:\Github\final project\Ticket_machine\WRITEFILE.csv";
            string content = string.Empty;  
            foreach ( customer s in customers )
            {
                content += string.Format("{0},{1},{2}\n",s.gender,s.price,s.tm.ToString("MM/dd/yyyy"));
            }
            File.WriteAllText(path, content);
            return true;
        }


    }
    public enum TicketType
    {
        Standing_viewing = 60 ,View_tickets = 70,  VIP_Ticket = 90
    }








  

    
}