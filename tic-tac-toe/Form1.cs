using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

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
            Button[] ButtonArray = Controls
            .OfType<Button>()
            .ToArray();
        }
        int turn = 0;
        bool[] wasPressed = new bool[5];
        
        
        string ButtonText()
        {
            
            {
                turn++;
                if (turn % 2 == 0)
                    return "O";
                else
                    return "X";

            }
           
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {

            if (wasPressed[0] == false)
            {
                button1.Text = ButtonText();
                wasPressed[0] = true;
            }
           
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(turn);
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        
    }
}
