using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameAlgorhitms
{
    public partial class GameForm : Form
    {
        
        public GameForm()
        {
            InitializeComponent();
            //label1.Click += new label_Click;
            //label2.Click += new label_Click;
            //label3.Click += new label_Click;
            //label4.Click += new label_Click;
            //label5.Click += new label_Click;
            //label6.Click += new label_Click;
            //label7.Click += new label_Click;
            //label8.Click += new label_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            changeColor();
           
        }


        public void changeColor()
        {
            foreach (Control labelControl in this.Controls)
            {
                if (labelControl is Label)
                {
                    labelControl.BackColor = Color.CornflowerBlue;
                }
            }
        } 
        private void generalLabel_Click(object sender, EventArgs e)
        {

            Label label = sender as Label;
            if (label.BackColor == Color.CornflowerBlue) { 
            label.BackColor = Color.Red;
            }

        }
        private void checkWinner()
        {

        }
    }
}
