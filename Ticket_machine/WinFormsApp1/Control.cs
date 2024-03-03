using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{

    public class Control : Ticket
    {

       private int standing_viewing = 60, view_tickets = 70, vip_Ticket = 90;

        public int Standing_viewing { get => standing_viewing; set => standing_viewing = value; }
        public int View_tickets { get => view_tickets; set => view_tickets = value; }
        public int VIP_Ticket { get => vip_Ticket; set => vip_Ticket = value; }

        public bool buyticket(int price)
        {
            if (price >= 90 )
            {
               

                return true;
            }
            else
            {

                return false;
            }
        }
        public bool buyticketnr(int price)
        {
            if (price >= 70)
            {

                return true;
            }
            else
            {

                return false;
            }
        }

        public bool buyticketst(int price)
        {
            if (price >= 60)
            {

                return true;
            }
            else
            {

                return false;
            }
        }





















    }
}

