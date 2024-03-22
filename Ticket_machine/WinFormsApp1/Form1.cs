using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Control Control;
        List<customer> customerList = new List<customer>();
        Ticket ticket = new Ticket();
        int price = 0;


        public Form1()
        {
            InitializeComponent();
            Control = new Control();
            comboBox1.Items.Add("Male");//เพศ
            comboBox1.Items.Add("Female");
            comboBox1.Items.Add("Other");
            comboBox2.Items.Add(60);//ราคา
            comboBox2.Items.Add(70);
            comboBox2.Items.Add(90);

        }

        private void Show_all() //โชว์บัตรทั้งหมด
        {
            TK.Show();
            DMFES.Show();
            TM.Show();
        }

        private void clearall() //เคลียข้อมูลคนที่ซื้อก่อนหน้า
        {
            
            comboBox1.Text = "Gender"; //เพศ
            comboBox2.Text = "Price"; //ราคา
              int price = 0;
        }

        private void change(int price , int ticket)  //เงินทอน
        {
            int change = price - ticket;//ราคาเงิน - ราคาตั๋ว
            MessageBox.Show($"Your change = {change}");
        }
        

        private void button1_Click(object sender, EventArgs e)  //ปุ่มราคา70
        {
            //เงิน == จำนวนCOMBOBOXที่เลือก 
            int price;
            bool canParse = int.TryParse(comboBox2.Text, out price);
            if (!canParse)
            {
                MessageBox.Show("กรุณาป้อนจำนวนเงิน");
                return;
            }
            bool canbuy = Control.buyticketnr(price);
            if (canbuy)
            {
                pictureBox1.Image = Properties.Resources.normalTicket;

                if (price >= Control.View_tickets)
                {
                    MessageBox.Show("Buy success");
                    change(price, Control.View_tickets);
                    Show_all();
                    clearall();
                    
                }
                else
                {
                    MessageBox.Show("Unsuccessful purchase");
                   
                    clearall();

                }

            }
            else
            {
            }


        }

        private void TK_Click(object sender, EventArgs e) //ปุ่มVIP
        {
            int price;
            bool canParse = int.TryParse(comboBox2.Text, out price);
            if (!canParse)
            {
                MessageBox.Show("กรุณาป้อนจำนวนเงิน");
                return;
            }
            bool canbuy = Control.buyticket(price);
            if (canbuy)
            {


                pictureBox1.Image = Properties.Resources.VIPTicket;

                if (price == Control.VIP_Ticket)
                {
                    MessageBox.Show("Buy success");
                    Show_all();
                    clearall();
                }
                else
                {
                    MessageBox.Show("Unsuccessful purchase");
                    change(price, Control.VIP_Ticket);
                    clearall();
                }

            }
            else
            {
            }

        }
        
   

        private void TM_Click(object sender, EventArgs e) // ปุ่ม60
        {
            int price;
            bool canParse = int.TryParse(comboBox2.Text , out price);
            if (!canParse)
            {
                MessageBox.Show("กรุณาใส่จำนวนเงิน");
                return;
            }
            bool canbuy = Control.buyticketst(price);
            if (canbuy)
            {
               
                pictureBox1.Image = Properties.Resources.standingTicket;
                if (price >= Control.Standing_viewing)
                {
                    Show_all();
                    clearall();
                    MessageBox.Show("Buy success");
                    change(price, Control.Standing_viewing);


                }
                else
                {
                    MessageBox.Show("Buy success");
                    change(price, Control.Standing_viewing);
                    clearall();
                }



            }
            else
            {
               
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string gender = comboBox1.SelectedItem.ToString();
            int price;
            bool canParse = int.TryParse(comboBox2.Text, out price);
            if (!canParse)
            {
                MessageBox.Show("กรุณาป้อนจำนวนเงิน");
                return;
            }

            customer customer = new customer(gender, price, ticket.time_stamp());
            customerList.Add(customer);
            if (price < 90)
            {
                if (price < 70)
                {
                    DMFES.Hide();
                    TK.Hide();
                }
                else
                {
                    TK.Hide();
                }

                foreach (customer cu in customerList)
                {
                    gender = cu.Gender;
                    price = cu.Price;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)  //เขียนไฟล์csv
        {
            bool s = ticket.WriteF(customerList);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GENDER_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
