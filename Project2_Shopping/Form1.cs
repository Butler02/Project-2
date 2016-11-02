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
        List<string> mUserLikes;
        List<string> mUserDislikes;
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
                    mUserDislikes = new List<string>();
                    mUserLikes = new List<string>();
                    //reads file and splits the string after a comma
                    string entireLine = inputFile.ReadLine();
                    string[] fields = entireLine.Split(',');
                    dealName = fields[0];
                    price = double.Parse(fields[1]);
                    date = fields[2];
                    //converts fields[2] to datetime so that you can compare the current date to the expire date
                    
                    //set a string array equal to fields [3] which I know to be the likes and split it on the plus sign
                    string[] likes=new string[] { "" };
                    if (fields[3] != "")
                    {
                        likes = fields[3].Split('+');
                    }
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
                    foreach (var like in likes)
                    {
                        mUserLikes.Add(like);
                    }


                    //set a string array equal to fields [4] which I know to be the dislikes and split it on the plus sign
                    
                    string[] dislikes=new string[] { "" };
                    if (fields[4]!="")
                    {
                        dislikes = fields[4].Split('+');
                    }
                    
                    //This if statement determines if something is in the dislikes position
                    //if nothing is there it sets total dislikes to 0, otherwise it sets 
                    //total dislikes to the count of the array.
                    if (fields[4] == "")
                    {
                        totalDislikes = 0;
                    }
                    else
                    {
                        totalDislikes = dislikes.Count();
                    }
                    foreach (var dislike in dislikes)
                    {
                        mUserDislikes.Add(dislike);
                    }

                    Deals newDeal = new Deals(dealName, price, date, mUserLikes, mUserDislikes, fields[3], fields[4]);
                    DateTime currentdate = DateTime.Today;
                    DateTime expire = Convert.ToDateTime(date);
                    //compares the exire date to the current date.
                    //will not populate the list box with expired items
                    if (expire >= currentdate)
                    {                        
                        Deals.Add(newDeal);
                    }
                    
                }

                inputFile.Close();
            }
            catch (Exception)
            {

                lblstatus.Text = "Error reading deals file";
            }
            if (Deals.Count <= 0)
            {
                lstDeals.Items.Add("No Deals at this Time");
            }
            else
            {
                Display();
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
            

            if (users.Contains(loginText))
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

        private void Display()
        {
            lstDeals.Items.Clear();
            foreach (var deal in Deals)
            {
                lstDeals.Items.Add(deal.ToString());
            }


        }

        private void Write()
        {
            StreamWriter outputFile = new StreamWriter(DEALS_FILE);
            try
            {
                //should run through the deals count - 1 times
                for (int i = 0; i < Deals.Count -2; i++)
                {
                    //should run through the liset of deals user like count -
                    for (int j = 0; j < Deals[i].UserLikes[j].Count() - 2; j++)
                    {

                         MessageBox.Show((Deals[i].UserLikes[j].Count() - 1).ToString());
                        //this adds the token + sign to the  user likes until it gets to the 
                        //count length then it does not add one
                        if (j != (Deals[i].UserLikes[j].Count() - 2))
                        {
                            Deals[i].MWriteLikes += Deals[i].UserLikes[j] + "+";
                        }
                        else
                        {
                            Deals[i].MWriteLikes += Deals[i].UserLikes[j];
                        }
                    }

                }
               // works the same as above
                for (int i = 0; i < Deals.Count -2; i++)
                {
                    for (int j = 0; j < Deals[i].UserDislikes[j].Count() - 2; j++)
                    {
                        if (Deals[i].UserDislikes[j] == "")
                        {
                            //writeLikes = "";
                            break;//this may need to be a return
                        }
                        if (j != Deals[i].UserDislikes[j].Count() - 2)
                        {
                            Deals[i].MWriteDislikes += Deals[i].UserDislikes[j] + "+";
                        }
                        else
                        {
                            Deals[i].MWriteDislikes += Deals[i].UserDislikes[j];
                        }

                    }

                }

                foreach (var deal in Deals)
                {
                    if (deal.UserLikes == null)
                    {

                    }
                    outputFile.WriteLine(deal.MProduct + "," + deal.MPrice.ToString("f") + "," + deal.MDate + "," + deal.MWriteLikes + "," + deal.MWriteDislikes);
                }
                outputFile.Close();


            }
            catch (Exception ex)
            {

                lblstatus.Text = "Error writing to deals file";
                return;
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string newUser = txtAddUsername.Text;
            if (newUser.Trim() == "")
            {
                lblstatus.Text = "Enter a username";
                txtAddUsername.Focus();
                return;

            }

            foreach (var user in users)
            {
                if (txtAddUsername.Text == user)
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
            string product = txtProductToAdd.Text;
            string date = dtpExpireDate.Value.ToString("MM/dd/yyyy");

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
            foreach (var item in Deals)
            {
                if (item.MProduct == product)
                {
                    lblstatus.Text = "You cannot have duplicate product names";
                    txtProductToAdd.Text = "";
                    txtProductToAdd.Focus();
                    return;
                }

            }
            mUserLikes = new List<string>();
            mUserDislikes = new List<string>();
            mUserLikes.Add("");
            mUserDislikes.Add("");
            Deals newDeal = new Deals(product, price, date, mUserLikes, mUserDislikes,"","");
            Deals.Add(newDeal);

            Write();

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

        private void btnChoose_Click(object sender, EventArgs e)
        {
            string writeLikes;
            string writeDislikes;
            int selectedIndex = lstDeals.SelectedIndex;
            if (selectedIndex<0)
            {
                lblstatus.Text = "No deal selected";
                return;
            } 

            //decision structure if user has chosen to like a deal
            if (radLikeDeal.Checked)
            {
                if (Deals[selectedIndex].UserLikes.Contains(currentUser))
                {
                    lblstatus.Text = "You already liked this deal";
                    return;
                }
                //suppose to check if user has already chosen another choice
                if (!Deals[selectedIndex].UserLikes.Contains(currentUser)&& Deals[selectedIndex].UserDislikes.Contains(currentUser))
                {
                    Deals[selectedIndex].UserDislikes.Remove(currentUser);
                }


                //this write will not work properly if user changes decision
                //need to figure out way to remove or write to the writedislike/like
                if (Deals[selectedIndex].UserLikes.Count > 0)
                {
                    Deals[selectedIndex].MWriteLikes = "+" + currentUser;
                }
                else
                {
                    Deals[selectedIndex].MWriteLikes = currentUser;
                }
                Deals[selectedIndex].UserLikes.Add(currentUser);
                lblstatus.Text = "You now liked this deal";
            }
            //decision structure if user has chosen to dislike a deal
            else if (radDislikeDeal.Checked)
            {
                if (Deals[selectedIndex].UserDislikes.Contains(currentUser))
                {
                    lblstatus.Text = "You already disliked this deal";
                    return;
                }
                if (Deals[selectedIndex].UserLikes.Contains(currentUser) && !Deals[selectedIndex].UserDislikes.Contains(currentUser))
                {
                    Deals[selectedIndex].UserLikes.Remove(currentUser);
                }
                Deals[selectedIndex].UserDislikes.Add(currentUser);
                lblstatus.Text = "You disliked this deal";

                //this write will not work properly if user changes decision
                //need to figure out way to remove or write to the writedislike/like
                //if (Deals[selectedIndex].MDislikes>1)
                //{
                //    Deals[selectedIndex].MWriteDislikes += "+"+currentUser;
                //}
                //else
                //{
                //    Deals[selectedIndex].MWriteDislikes += currentUser;
                //}
            }

            Write();
            Display();


        }

        //makes sure all current deals that are not past date are saved to file when closed
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Write();
        }
    }
}
