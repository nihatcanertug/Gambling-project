using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gambling_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int RandomNumber;
        public static  Random spin = new Random();
        int rand_num2 = spin.Next(0,1000);
            
        private void btnLogin_Click(object sender, EventArgs e)
        {

            RandomNumber = rand_num2;
            
            string message = "";
            string username = txtUsername.Text;
            
            string password = txtPassword.Text;
            
            
            if (username == "Admin" && password == "123")
            {
                MessageBox.Show($"Welcome Mr.{username}");
                MessageBox.Show($"This is your daily spin money = {rand_num2}£ ");
                lblDaily.Text = Convert.ToString(rand_num2);
                if (rand_num2 > 0) { message = "You can play Bets !!!"; }
            }
            else
            {
                MessageBox.Show($"I don't recognize you {username}");
                message = "Please Try later!!";
                Environment.Exit(0);
            }
            MessageBox.Show(message);
            Form2 n = new Form2();
            n.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
