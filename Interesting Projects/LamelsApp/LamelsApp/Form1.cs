using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LamelsApp
{
    public partial class Laminator : Form
    {
        public Laminator()
        {
            InitializeComponent();
        }

        private void klient_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && klient.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                
            }
        }

        private void kvadratiStek_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && kvadratiStek.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void lameliStek_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && lameliStek.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            //counting m^2 of 1 lamel
            double lamelSquare = double.Parse(kvadratiStek.Text) / double.Parse(lameliStek.Text);
            //numbers of lamels
            double lamels = double.Parse(klient.Text) / lamelSquare;
            //counting full stack's
            int finalStacks = (int)lamels / int.Parse(lameliStek.Text);
            double current = (finalStacks * int.Parse(lameliStek.Text)) * lamelSquare;

            //stack's are founded lets found the rest
            double rest = double.Parse(klient.Text) - current;
            double restLamels = rest / lamelSquare;
            int finalLamels = (int)restLamels + 1;
            int test = finalLamels;
            //for write to the system
            double sistem = current + finalLamels * lamelSquare;
            
            label1.Text = finalStacks.ToString(); //stacks
            label10.Text = test.ToString(); //lamels
            label2.Text = sistem.ToString(); //for the system
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
