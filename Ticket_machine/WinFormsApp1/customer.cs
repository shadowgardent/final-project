using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class customer : Ticket
    {
        private string gender;
        private int price;

        public string Gender { get => gender; set => gender = value; }
        public int Price { get => price; set => price = value; }

        public customer(string gender, int price , DateTime tm):base(tm)
        {
            this.Gender = gender;
            this.Price = price;
        }
        

        
    }
}
