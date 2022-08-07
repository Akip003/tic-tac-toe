using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            int i = 0;
            while(i>wasPressed.Length)
            {
                wasPressed[i] = false;
            }
            ButtonArray = Controls
            .OfType<Button>()
            .ToArray();
            Array.Reverse(ButtonArray);
            foreach  (Button button in ButtonArray)
            {
                button.Text = (Convert.ToString(i++));
            }
        }
        int turn = 0;
        bool[] wasPressed = new bool[9];
        Button[] ButtonArray;


        void ButtonText(int btn)
        {
            
            {
                if (wasPressed[btn - 1]==false)
                {
                    wasPressed[btn - 1] = true;
                    if(turn%2==0)
                        ButtonArray[btn - 1].Text = "X";
                    else
                        ButtonArray[btn - 1].Text = "O";
                    turn++;
                }

            }
           
        }
        
        
        



        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(turn);
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonText(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonText(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonText(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonText(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonText(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonText(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonText(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonText(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonText(9);
        }
    }
}
