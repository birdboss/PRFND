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
using System.Configuration;

namespace WindowsFormsApp3
{
    //public delegate void DataSetter(string pin);

    public partial class LogIn : Form
    {
        
        public LogIn()
        {
            InitializeComponent();
        }
        string CS = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\source\repos\project2\WindowsFormsApp3\Clients.mdf;Integrated Security=True";
        private void LogIn_Load(object sender, EventArgs e)
        {
            
        }
        public string name;
        public static string pin;

        //public event DataSetter DataSet;

        #region instructions
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labLogin_Click(object sender, EventArgs e)
        {

        }
        private void labInst1_Click(object sender, EventArgs e)
        {

        }
        private void labInst2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region input area
        private void labName_Click(object sender, EventArgs e)
        {

        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labPin_Click(object sender, EventArgs e)
        {

        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
       
        #endregion

        #region login functions

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool error = validateUser();
            if (error == true)
            {
                MessageBox.Show("Error: Missing info.");
            }
            //else
            //{
            //    this.DataSet(txtPassword.Text);
            //}
        }

        private bool validateUser()
        {
            if (txtName.Text.TrimStart() == string.Empty || txtPassword.Text.TrimStart() == string.Empty)
            {
                return true;
            }
            else
            {

                
                
                using (SqlConnection con1 = new SqlConnection(CS))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select count (*) from Login where Names ='"+txtName.Text+"' and PIN = '"+txtPassword.Text+"'", con1);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        pin = txtPassword.Text;
                        input inpWin = new input();
                        inpWin.Show();
                        this.Hide();
                        con1.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error: Wrong Name or PIN.");
                    }

                }
                return false;
            }
        }



        #endregion

        





    }
    
    }
