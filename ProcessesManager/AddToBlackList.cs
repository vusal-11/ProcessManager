using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessesManager
{
    public partial class AddToBlackList : Form
    {
        public AddToBlackList()
        {
            InitializeComponent();
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                timer1.Start();
                this.Close();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Can not added empty task,enter the name !!!");
            }



        }

        void addtaskblacklsit()
        {
            try
            {

                var pr = Process.GetProcessesByName(textBox1.Text);
                pr[0].Kill();

            }
            catch (Exception)
            {
                timer1.Stop();
                MessageBox.Show("This task can not Added to black list");

            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            addtaskblacklsit();
            this.Dispose();

        }
    }
}
