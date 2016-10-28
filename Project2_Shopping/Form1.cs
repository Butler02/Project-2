using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/// <summary>
/// Jimmy Gould & Eric Butler
/// Project 2
/// 10/06/16
/// Project stuff
/// Boom!
/// </summary>
namespace Project2_Shopping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            //I think you should do Close();
            //yes Sr. -Eric
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstDeals.Items.Add("No Deals at this Time");
            //dtpExpireDate.Format = DateTimePickerFormat.Custom;
            //dtpExpireDate.CustomFormat = "MM/dd/yyyy";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StreamReader inputfile = new StreamReader("users.dat");
            if (tbLogin.Text == "")
            {
                lblstatus.Text = "Enter a username";
                tbLogin.Focus();
            }
            else
            {
                string users = inputfile.ReadLine();
                //soooooo this wont work. i think 
                while (!inputfile.EndOfStream)
                {
                    if (users.Contains(tbLogin.Text))
                    {
                        lblstatus.Text = "Welcome";
                        btnLogin.Enabled = false;
                        btnLogout.Enabled = true;
                    }
                }
                inputfile.Close();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            StreamWriter outputfile = new StreamWriter("users.dat");
            if (tbAddUsername.Text == "")
            {
                lblstatus.Text = "Enter a username";
                tbAddUsername.Focus();
            }
            else
            {
                outputfile.WriteLine(tbAddUsername.Text);
                lblstatus.Text="Just added a new user";
            }
            outputfile.Close();
        }

        private void btnAddDeal_Click(object sender, EventArgs e)
        {
            /////
            ///tried to make this not as crappy but for some reason it wouldnt work like this:
            ///   if(tbPrice.Text == "" && !double.TryParse(tbPrice.Text, out price) && price < 0)
            /////
            double price = 0;
            if (tbProductToAdd.Text == "")
            {
                lblstatus.Text = "Enter a product name";
            }
            else if (tbPrice.Text == "")
            
            {
                lblstatus.Text = ("Price is not a vaild amount");
            }
            else if (!double.TryParse(tbPrice.Text, out price))
            {
                lblstatus.Text = ("Price is not a vaild amount");
            }
            else if (price < 0)
            {
                lblstatus.Text = ("Price is not a vaild amount");
            }
        }

        private void btnSearchDeal_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                lblstatus.Text="Search name cannot be blank";
            }
            else
            {

            }
        }
    }
}
