using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class customer : Ticket
    {
        public string gender;
        public int price;

        public customer(string gender, int price , DateTime tm):base(tm)
        {
            this.gender = gender;
            this.price = price;
        }

        
    }
}
