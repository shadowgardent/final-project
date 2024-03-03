namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Control Control;
        List<customer> customerList = new List<customer>();
        Ticket ticket = new Ticket();


        public Form1()
        {
            InitializeComponent();
            Control = new Control();
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            comboBox1.Items.Add("Other");
            comboBox2.Items.Add(60);
            comboBox2.Items.Add(70);
            comboBox2.Items.Add(90);

        }

        private void Show_all()
        {
            TK.Show();
            DMFES.Show();
            TM.Show();
        }

        private void clearall()
        {
            
            comboBox1.Text = "Gender";
            comboBox2.Text = "Price";
        }

        private void change(int price , int ticket)
        {
            int change = price - ticket;
            MessageBox.Show($"Your change = {change}");
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int price = (int)comboBox2.SelectedItem;
            bool canbuy = Control.buyticketnr(price);
            if (canbuy)
            {
                pictureBox1.Image = Properties.Resources.normalTicket;

                if (price == Control.View_tickets)
                {
                    MessageBox.Show("Buy suc");
                    Show_all();
                    clearall();
                }
                else
                {
                    MessageBox.Show("Buy suc");
                    change(price , Control.View_tickets);
                    clearall();

                }

            }
            else
            {
            }


        }

        private void TK_Click(object sender, EventArgs e)
        {
            int price = (int)comboBox2.SelectedItem;
            bool canbuy = Control.buyticket(price);
            if (canbuy)
            {


                pictureBox1.Image = Properties.Resources.VIPTicket;

                if (price == Control.VIP_Ticket)
                {
                    MessageBox.Show("Buy suc");
                    Show_all();
                    clearall();
                }
                else
                {
                    MessageBox.Show("Buy suc");
                    change(price, Control.VIP_Ticket);
                    clearall();
                }

            }
            else
            {
            }

        }

        private void TM_Click(object sender, EventArgs e)
        {
            int price = (int)comboBox2.SelectedItem;
            bool canbuy = Control.buyticketst(price);
            if (canbuy)
            {
                pictureBox1.Image = Properties.Resources.standingTicket;

                if (price == Control.Standing_viewing)
                {
                    MessageBox.Show("Buy suc");
                    Show_all();
                    clearall();
                }
                else
                {
                    MessageBox.Show("Buy suc");
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
            int price = (int)comboBox2.SelectedItem;


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

        private void button1_Click_1(object sender, EventArgs e)
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
