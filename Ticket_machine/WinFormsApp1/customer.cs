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
        //เข้าถึงและกำหนดค่าของตัวแปรแต่ละประเภทได้โดยตรง |  getter และ setter มีการใช้งานเพียงแค่การส่งค่าไปยังตัวแปรและคืนค่าของตัวแปรนั้นๆ โดยไม่มีการประมวลผลเพิ่มเติม
        public string Gender { get => gender; set => gender = value; }
        public int Price { get => price; set => price = value; }

        public customer(string gender, int price , DateTime tm):base(tm)
        {
            // เรียก Constructor ของ superclass และส่งค่าเวลา (tm) ไปให้ Constructor ของ superclass
            this.Gender = gender;  // กำหนดค่าของเพศ (Gender) ของลูกค้า
            this.Price = price;    // กำหนดค่าของราคา (Price) ของลูกค้า
        }
        

        
    }
}
