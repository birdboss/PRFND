using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Windows;
using System.Configuration;
using System.Data;



namespace assignment2.Controllers
{
   
    public class DefaultController : Controller
    {
        static public string CS = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Butter Bird\Documents\prtqs.mdf';Integrated Security=True;Connect Timeout=30";
        // GET: Default
        public ActionResult Home()
        {

            return View();
        }

        public ActionResult AddContact()
        {
            return View();
        }

        public ActionResult ContactList()
        {

            using (SqlConnection con = new SqlConnection(CS))
            {
                
                string path = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
                con.ConnectionString = path;
                DataTable dt = new DataTable();
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from Contacts", con);
                    sda.Fill(dt);
                }
                catch(Exception)
                {
                    throw;
                }
                return View(dt);
            }
                
        }

        public ActionResult SetContact(string name, string mobNo, string offNo, string homeTown, string email)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Contacts values ('"+ email + "','" + name + "','" + mobNo + "','" + offNo + "','" + homeTown + "')", con);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    Response.Write("<script>alert('This email is already associated with another contact')</script>");
                    
                }
                
            }
            return View();
        }
    }
}