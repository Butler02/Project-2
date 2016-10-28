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

        List<String> users = new List<string>();
        string currentUser;
        const string USERS_FILE = "users.dat";
        bool LoggedIn = false;
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
            dtpExpireDate.MinDate = DateTime.Today;

            StreamReader inputFile;

            try
            {
                inputFile = new StreamReader(USERS_FILE);
                while (!inputFile.EndOfStream)
                {
                    users.Add(inputFile.ReadLine());
                }

                inputFile.Close();
            }
            catch (Exception)
            {

                lblstatus.Text = "Error reading users file";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string loginText = txtLogin.Text;
            if (loginText.Trim() == "")
            {
                lblstatus.Text = "Enter A Username";
                txtLogin.Text = "";
                txtLogin.Focus();
                return;
            }

            foreach (var user in users)
            {
                if (loginText == user.ToString())
                {
                    lblstatus.Text = "Welcome back!";
                    LoggedIn = true;
                    btnLogin.Enabled = false;
                    btnLogout.Enabled = true;
                    grpLikeDislike.Enabled = true;
                    currentUser = loginText;
                }
                else
                {
                    lblstatus.Text = "Username doesn't exist";
                    
                }
            }



        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string newUser=txtAddUsername.Text;
            if (newUser.Trim() == "")
            {
                lblstatus.Text = "Enter a username";
                txtAddUsername.Focus();
                return;

            }

            foreach (var user in users)
            {
                if (txtAddUsername.Text==user)
                {
                    lblstatus.Text = "User already exists";
                    return;
                }
            }
            users.Add(newUser);

            StreamWriter outputFile = new StreamWriter(USERS_FILE);
            try
            {
               
                foreach (var user in users)
                {
                    outputFile.WriteLine(user.ToString());
                }
                outputFile.Close();


            }
            catch (Exception)
            {

                lblstatus.Text = "Error writing to file";
                return;
            }

            lblstatus.Text = "User added successfully";




        }

        private void btnAddDeal_Click(object sender, EventArgs e)
        {
            /////
            ///tried to make this not as crappy but for some reason it wouldnt work like this:
            ///   if(tbPrice.Text == "" && !double.TryParse(tbPrice.Text, out price) && price < 0)
            /////
            double price = 0;
            if (txtProductToAdd.Text == "")
            {
                lblstatus.Text = "Enter a product name";
            }
            else if (txtPrice.Text == "")

            {
                lblstatus.Text = ("Price is not a vaild amount");
            }
            else if (!double.TryParse(txtPrice.Text, out price))
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
                lblstatus.Text = "Search name cannot be blank";
            }
            else
            {

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoggedIn = false;
            currentUser = null;
            btnLogin.Enabled = true;
            btnLogout.Enabled = false;
            grpLikeDislike.Enabled = false;
        }
    }
}
