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
        List<Deals> Deals;
        string currentUser;
        const string USERS_FILE = "users.dat";
        const string DEALS_FILE = "deals.dat";
        bool LoggedIn = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //sets the min date to the current date
            dtpExpireDate.MinDate = DateTime.Today;

            StreamReader inputFile;

            //this try block gets user information from the users file
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

            Deals = new List<Deals>();

            //I created temperary variables to make the code easier to understand
            string dealName;
            double price;
            string date;
            
            
            //This try block reads from the deals file and adds the information to a deals object and deals list object
            try
            {
                inputFile = new StreamReader(DEALS_FILE);
                while (!inputFile.EndOfStream)
                {
                    int totalLikes;
                    int totalDislikes;
                    //reads file and splits the string after a comma
                    string entireLine = inputFile.ReadLine();
                    string[] fields = entireLine.Split(',');
                    dealName = fields[0];
                    price = double.Parse(fields[1]);
                    date = fields[2];
                    //set a string array equal to fields [3] which I know to be the likes and split it on the plus sign
                    string[] likes = fields[3].Split('+');
                    //This if statement determines if something is in the likes position
                    //if nothing is there it sets total likes to 0, otherwise it sets 
                    //total likes to the count of the array.
                    if (fields[3] == "")
                    {
                        totalLikes = 0;
                    }
                    else
                    {
                        totalLikes = likes.Count();
                    }

                    //set a string array equal to fields [4] which I know to be the dislikes and split it on the plus sign
                    string[] dislikes = fields[4].Split('+');

                    //This if statement determines if something is in the dislikes position
                    //if nothing is there it sets total dislikes to 0, otherwise it sets 
                    //total dislikes to the count of the array.
                    if (fields[4]=="")
                    {
                        totalDislikes = 0;
                    }
                    else
                    {
                        totalDislikes = dislikes.Count();
                    }
                    

                    Deals newDeal = new Deals(dealName,price,date,totalLikes,totalDislikes);
                    Deals.Add(newDeal);
                }

                inputFile.Close();
            }
            catch (Exception)
            {

                lblstatus.Text = "Error reading deals file";
            }
            if (Deals.Count<=0)
            {
                lstDeals.Items.Add("No Deals at this Time");
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

        private void Display()
        {
            lstDeals.Items.Clear();
                foreach (var deal in Deals)
                {
                    lstDeals.Items.Add(deal.ToString());
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

                lblstatus.Text = "Error writing to user file";
                return;
            }

            lblstatus.Text = "User added successfully";




        }

        private void btnAddDeal_Click(object sender, EventArgs e)
        {
            
            double price = 0;
            string product =txtProductToAdd.Text;
            string date = dtpExpireDate.Value.Date.ToString();
            
            if (product == "")
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
            Deals newDeal = new Deals(product, price, date, 0, 0);
            Deals.Add(newDeal);

            StreamWriter outputFile = new StreamWriter(DEALS_FILE);
            try
            {
                //need to think of a way to write all users that like/dislike a product
                //foreach (var deal in Deals)
                //{
                //    outputFile.WriteLine(deal.MProduct+","+deal.MPrice.ToString()+","+deal.MDate+",,");
                //}
                outputFile.Close();


            }
            catch (Exception)
            {

                lblstatus.Text = "Error writing to deals file";
                return;
            }

            lblstatus.Text = "Deal added";


            Display();


        }

        private void btnSearchDeal_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                lblstatus.Text = "Search name cannot be blank";
            }
            else
            {
                //searches the listbox to find a deal using an input of a string
                string stDeal = tbSearch.Text;
                int index = lstDeals.FindString(stDeal, -1);
                if (index != -1)
                {
                    lstDeals.SetSelected(index, true);
                   
                }
                else
                {
                    lblstatus.Text = "Item not Found";
                }
               
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
