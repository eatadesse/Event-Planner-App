using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Event_Planner
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;



        string first;
        string last;
        string emailAddress;
        string eventType;
        string date;
        string street;
        string city;
        string state;




        const double taxRate = 0.07;
        int cost = 600;

        decimal guestAmount;
        double doc;
        double phoneNo;
        double zipcode;

        
        public Form1()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           /* listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel.Add(panel4);

            listPanel[index].BringToFront();*/
        }

        private void detailPage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void detalPage_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = datePicker.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            guestAmount = guestNumber.Value;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void occationBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void messageBox_Enter(object sender, EventArgs e)
        {
            if  (messageBox.Text == "Is there anything else you want us to know?")
            {
                messageBox.Text = "";
                messageBox.ForeColor = Color.Black;

            }
            
        }

        private void messageBox_Leave(object sender, EventArgs e)
        {
    
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
           first = firstName.Text;

            //if (e.Mandled = !(char.IsLetter(e.keychar) ||))



        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
           last = lastName.Text;
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
           emailAddress = emailTextBox.Text;
        }

        private void phoneTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          phoneNo = double.Parse(phoneTextBox.Text);
        }

        private void registorPage_Click(object sender, EventArgs e)
        {

        }

        private void checkout_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void registorButton_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void messageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void noButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void occasionBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkoutPage_Click(object sender, EventArgs e)
        {

        }

        private void tax_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void totalCost_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void DOC_Click(object sender, EventArgs e)
        {

        }

        private void cost_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void streetTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void stateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void zipcodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
          
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void costLabel_Click(object sender, EventArgs e)
        {
           
            

        }

        private void taxLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void yesButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void streetTextBox_TextChanged_1(object sender, EventArgs e)
        {
            street = streetTextBox.Text;
        }

        private void cityTextBox_TextChanged_1(object sender, EventArgs e)
        {
            city = cityTextBox.Text;
        }

        private void stateTextBox_TextChanged_1(object sender, EventArgs e)
        {
            state = stateTextBox.Text;
        }

        private void occasionBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

       



        private void button1_Click_2(object sender, EventArgs e)
        {

            if (yesButton.Checked == true)
            {

                doc = 300;

            }
            else
            {
                doc = 0;
            }

            double calCost;
            double calTax;
            double calDoc;
            double calTotal;

            calCost = cost;
            calDoc = doc;
            calTax = calCost * taxRate;

            calTotal = calCost + calDoc + calTax;


           labelcost.Text = calCost.ToString("c");
           labelTax.Text = calTax.ToString("c");
           labelDoc.Text = calDoc.ToString("c");
           labelTotal.Text = calTotal.ToString("c");

        }

        private void labelcost_Click(object sender, EventArgs e)
        {
           
        }

        private void occasionBox_Enter(object sender, EventArgs e)
        {
            

            if (occasionBox.Text == "Select event type")
            {
                occasionBox.Text = "";
                occasionBox.ForeColor = Color.Black;
            }
        }

        private void messageBox_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void occasionBox_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            eventType = occasionBox.Text;
        }

        private void messageBox_Enter_1(object sender, EventArgs e)
        {
            if (messageBox.Text == "Is there anything else you want us to know?")
            {
                messageBox.Text = "";
                messageBox.ForeColor = Color.Black;
            }
        }

        private void messageBox_Leave_1(object sender, EventArgs e)
        {
            if (messageBox.Text == "")
            {
                messageBox.Text = "Is there anything else you want us to know?";
                messageBox.ForeColor = Color.Gray;
                messageBox.Text = "";
            }
        }

        private void zipcodeTextBox_TextChanged_1(object sender, EventArgs e)
        {
            zipcode = double.Parse(zipcodeTextBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
       
        {

            string constring = "Data Source = ELSHU-YOGA\\SQLEXPRESS01;Initial Catalog=Event Planner;Integrated Security = True;User ID=username;Password=password";

            
            SqlConnection conDataBase = new SqlConnection(constring);
            conDataBase.Open();

            if (conDataBase.State == System.Data.ConnectionState.Open)
            {

                string Query = "insert into database.edata (Fisrt name, Lasr name, Email, Phone, Occasion, Date, Guest amount, Sreet address, City, State, Zipcode) values " +
                    "('" + this.firstName.Text + "','" + this.lastName.Text + "','" + this.
                    emailTextBox.Text + "','" + this.phoneTextBox.Text + "','" + this.occasionBox.Text + "','" + this.streetTextBox.Text + "','" + this.
                    cityTextBox.Text + "','" + this.stateTextBox.Text + "','" + this.zipcodeTextBox.Text + "','" + this.datePicker.Text + "','" + this.
                    guestNumber.Text + "','" + this.yesButton.Text + "','" + this.noButton.Text + "') ;";
                SqlCommand cmd = new SqlCommand(Query, conDataBase);
                cmd.ExecuteNonQuery();
               
            }
         
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
    }
    

