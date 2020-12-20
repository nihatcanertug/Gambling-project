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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblTotal.Text = Form1.RandomNumber.ToString();
            lblAciklama.Text=("\t This is your lucky numbers: \n   \t         [0 1 2 3 4 5] \n ");
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int result;
            Random number = new Random();
            int rand_num = number.Next(0,5);

            int number1 = Convert.ToInt16(txtNumber.Text);
            int bets = Convert.ToInt16(txtBets.Text);

            if ((number1<=5 && number1 >=0) && (bets<=Form1.RandomNumber)) 
            { MessageBox.Show("Good luck...");
                 
            if (rand_num == number1)
            {
                lblKazanan.Text = rand_num.ToString();
                MessageBox.Show(string.Format("{0}£ win!!!", 2 * bets));
                result = Form1.RandomNumber + 2 * bets;
            }
            else
            {
                lblKazanan.Text = rand_num.ToString();
                MessageBox.Show(string.Format("{0}£ lose!!!", bets));
                result= Form1.RandomNumber - bets;
            }
                lblTotal.Text = result.ToString();
            }
            else
            {   if((number1>5 || number1<0) && (bets<Form1.RandomNumber)) {MessageBox.Show("Incorrect entry!! \n Please guess a number between[0 - 5]");
                }
                if ((bets > Form1.RandomNumber)&& (number1 <= 5 && number1 >= 0))
                        
                {
                    MessageBox.Show($"You bet wrong !! \n You can not bet more than {Form1.RandomNumber} £ in your account ..");
                }
                 if((number1 > 5 || number1 < 0) && (bets > Form1.RandomNumber))
                {
                    MessageBox.Show("You entered your number guess and bet incorrectly!!!!");
                }
                    
                    Environment.Exit(0);                
            }
            }
        }

       
    }
    
    

