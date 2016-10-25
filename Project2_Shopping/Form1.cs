using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Application.Exit();
            //I think you should do Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dtpExpireDate.Format = DateTimePickerFormat.Custom;
            //dtpExpireDate.CustomFormat = "MM/dd/yyyy";
        }
    }
}
