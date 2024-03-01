using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{

    public class Control : Ticket
    {

        int tricket = 20;
        int price = 90;



        public bool buyticket()
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
        public bool buyticketnr()
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

        public bool buyticketst()
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

