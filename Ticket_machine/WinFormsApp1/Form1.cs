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
        }

        private void Show_all()
        {
            TK.Show();
            DMFES.Show();
            TM.Show();
        }

        private void clear_all()
        {
            price.Text = string.Empty;
            GENDER.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool canbuy = Control.buyticketnr();
            if (canbuy)
            {
                pictureBox1.Image = Properties.Resources.normalTicket;

                if (int.Parse(price.Text) >= (int)TicketType.View_tickets)
                {
                    MessageBox.Show("Buy suc");
                    Show_all();
                    clear_all();
                }
                else
                {
                    MessageBox.Show("Please enter the correct amount.");
                }

            }
            else
            {
            }


        }

        private void TK_Click(object sender, EventArgs e)
        {
            bool canbuy = Control.buyticket();
            if (canbuy)
            {


                pictureBox1.Image = Properties.Resources.VIPTicket;

                if (int.Parse(price.Text) == (int)TicketType.VIP_Ticket)
                {
                    MessageBox.Show("Buy suc");
                    Show_all();
                    clear_all();
                }
                else
                {
                    MessageBox.Show("Please enter the correct amount.");
                }

            }
            else
            {
            }

        }

        private void TM_Click(object sender, EventArgs e)
        {
            bool canbuy = Control.buyticket();
            if (canbuy)
            {
                pictureBox1.Image = Properties.Resources.standingTicket;

                if (int.Parse(price.Text) >= (int)TicketType.Standing_viewing)
                {
                    MessageBox.Show("Buy suc");
                    Show_all();
                    clear_all();
                }
                else
                {
                    MessageBox.Show("Please enter the correct amount.");
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
            string gender = this.GENDER.Text;
            int price = int.Parse(this.price.Text);


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
                    gender = cu.gender;
                    price = cu.price;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool s = ticket.WriteF(customerList);
        }
    }
}
