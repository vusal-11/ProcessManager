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
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void submtbutton_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            if (textBoxaddtask.Text.Length > 0)
            {

                try
                {
                    process.StartInfo = new ProcessStartInfo(textBoxaddtask.Text);
                    process.Start();
                }
                catch (Exception)
                {
                    MessageBox.Show("This task can not Added");
                }
                this.Close();
            }
            else MessageBox.Show("Text is empty.Enter task name !!!");

        }
    }
}
