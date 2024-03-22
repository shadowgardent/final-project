using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Ticket
    {
        protected DateTime tm; //เวลาที่จะถูกเก็บไว้ในตัวแปรนี้
        public DateTime time_stamp() // เมทอดนี้ใช้สำหรับคืนค่าเวลาปัจจุบัน
        {
            return DateTime.Now;
        }


        // Constructor ของคลาส Ticket ที่รับค่าเวลาเป็นพารามิเตอร์
        public Ticket (DateTime time_stamp)
        {
           this.tm = time_stamp;   // กำหนดค่าเวลาที่ถูกส่งมาให้กับตัวแปร tm
        }

        public Ticket()
        {

        }

        public bool WriteF(List<customer> customers)
        {

            string path = @"D:\Github\final project\Ticket_machine\WRITEFILE.csv";// กำหนดที่อยู่ของไฟล์ที่จะเขียน
            string content = string.Empty;  // สร้างตัวแปรสำหรับเก็บเนื้อหาที่จะเขียนเข้าไฟล์
            // วนลูปผ่านรายการลูกค้าที่ได้รับเป็นพารามิเตอร์
            foreach ( customer s in customers )
            {
               // สร้างเนื้อหาที่จะเขียนเข้าไฟล์ โดยใช้ข้อมูลจากแต่ละลูกค้า
                content += string.Format("{0},{1},{2}\n",s.Gender,s.Price,s.tm.ToString("dd/MM/yyyy"));
            }

            // เขียนเนื้อหาลงในไฟล์ที่กำหนด
            File.WriteAllText(path, content);
            return true;// ส่งค่าคืนว่าการเขียนไฟล์สำเร็จ
        }  // เขียนไฟล์บันทึก csv

    }
    








  

    
}
