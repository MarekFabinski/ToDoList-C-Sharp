using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if(DailyBook.Checked && DailyBrush.Checked && DailyCode.Checked && DailyExeEvening.Checked && DailyExeMorning.Checked && DailyLetter.Checked && DailyMemes.Checked && DailyStudy.Checked)
            {
                labelDaily.Text = ("You Rock!");
            }
            else
            {
                MessageBox.Show("Looks like you still haven't finished all your daily tasks");
            }
            if(TwiceBath.Checked && TwiceBike.Checked && TwiceDesk.Checked && TwiceEmail.Checked && TwiceRoom.Checked && TwiceRun.Checked && TwiceShop.Checked && TwiceTrash.Checked)
            {
                labelTwice.Text = ("Good job!");
            }
            else
            {
                MessageBox.Show("Make sure to complete your twice a week tasks");
            }
            if(OnceCook.Checked && OnceFriends.Checked && OnceGranddad.Checked && OnceLaundry.Checked && OnceMom.Checked)
            {
                labelOnce.Text = ("Well done!");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
