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

namespace WindowsFormsApp3
{
    public partial class input : Form
    {
        public input(string pin)
        {
            InitializeComponent();
            string Pin = pin;            
        }

        public input()
        {
            InitializeComponent();           
        }

        public static string PIN;
        string CS = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\source\repos\project2\WindowsFormsApp3\Clients.mdf;Integrated Security=True";
        string actionChoice;
        string accountType = "C";        
        LogIn login = new LogIn();
        string amount;

        
        


        private void Input_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        
        #region Choose your account
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void rbtnCheq_CheckedChanged(object sender, EventArgs e)
        {
            accountType = "C";
        }

        private void rbtnSav_CheckedChanged(object sender, EventArgs e)
        {
            accountType = "S";
        }
        #endregion

        #region Choose your action
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnWith_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnWith.Checked == true)
            {
                txtInst.Text = "Please enter an amount that is multiple of 10\nThe maximum amount is 1000";
                actionChoice = "with";
            }

        }
        private void rbtnDep_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDep.Checked == true)
            {
                txtInst.Text = "Please enter the amount you'd like to deposit";
                actionChoice = "dep";
            }
            
        }
        private void rbtnTran_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTran.Checked == true)
            {
                txtInst.Text = "Select the account you'd like to transfer TO\n The maximum amount is 10,000";
                actionChoice = "tran";
            }
        }

        private void rbtnBill_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBill.Checked == true)
            {
                txtInst.Text = "Please make sure your chequing account is selected\n The maximum amount is 10,000";
                actionChoice = "bill";
            }
        }
        #endregion

        #region input amount
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtInst_Click(object sender, EventArgs e)
        {
                        
        }



        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region number buttons

        private void button1_Click(object sender, EventArgs e)
        {
            txtAmount.Text = txtAmount.Text + "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtAmount.Text = txtAmount.Text + "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txtAmount.Text = txtAmount.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtAmount.Text = txtAmount.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtAmount.Text = txtAmount.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtAmount.Text = txtAmount.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtAmount.Text = txtAmount.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtAmount.Text = txtAmount.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtAmount.Text = txtAmount.Text + "9";
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtAmount.Text = txtAmount.Text + "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtAmount.Text = txtAmount.Text + ".";
        }

        #endregion
        #endregion

        #region stars
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        #endregion
                                 
        private void label3_Click_1(object sender, EventArgs e)
        {

        }

     

        

        private void btnLogout_Click(object sender, EventArgs e)
        {            
            
            this.Close();
            login.Show();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            amount = txtAmount.Text;
            switch (actionChoice)
            {
                case "with":
                    withdrawal(amount);
                    break;

                case "dep":
                    deposit(amount);
                    break;

                case "tran":
                    transfer(amount);
                    break;

                case "bill":
                    billPayment(amount);
                    break;

                case "default":
                    MessageBox.Show("Error: Please select an action");
                    break;
            }
        }

        private void billPayment(string _amount)
        {
            throw new NotImplementedException();
        }

        private void transfer(string _amount)
        {
            throw new NotImplementedException();
        }

        private void deposit(string _amount)
        {
            throw new NotImplementedException();
        }

        private void withdrawal(string _amount)
        {

            using (SqlConnection con1 = new SqlConnection(CS))
            {

                SqlDataAdapter sda = new SqlDataAdapter("select Balance from Accounts where PIN = '"+login.pin+"' and Type = '"+accountType+"'", con1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows[0][0].ToString()=="1")
                {
                    txtAmount.Text = login.pin;
                }
                else
                {
                    MessageBox.Show("Wrong");
                }
                string _balance = dt.Rows[0][0].ToString();
                
                decimal balance = Convert.ToDecimal(_balance);
                decimal amount = Convert.ToDecimal(_amount);
                decimal newBalance = balance - amount;
                SqlCommand cmd = new SqlCommand("set Balance = " + newBalance + " where Balance = " + balance + "");
                MessageBox.Show("Your new balance is $");

            }
        }
    }
}
//private string getInstructions()
//{
//    string inst = "Please select an action";


//    switch (actionChoice)
//    {
//        case "1":
//            inst = "Please enter an amount that is multiple of 10\nThe maximum amount is 1000";
//            return inst;
//        case "2":
//            inst = "Please enter the amount you'd like to deposit";
//            return inst;
//        case "3":
//            inst = "Select the account you'd like to transfer TO\n The maximum amount is 10,000";
//            return inst;
//        case "4":
//            inst = "Please make sure your chequing account is selected\n The maximum amount is 10,000";
//            return inst;
//        case "default":
//            inst = "Please select an action";
//            return inst;
//    }
//    return inst;
//}