using System.Diagnostics;

namespace ProcessesManager
{
    public partial class Form1 : Form
    {
        Process process = null;
        public Form1()
        {
            InitializeComponent();
            showProcesses();
            timer1.Start();



        }


        public void showProcesses()
        {
            foreach (var process in Process.GetProcesses().ToList())
            {
                ListViewItem list = new ListViewItem(process.Id.ToString());
                list.SubItems.Add(process.ProcessName);
                list.SubItems.Add(process.HandleCount.ToString());
                list.SubItems.Add(process.Threads.Count.ToString());
                listView1.Items.Add(list);

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] process = Process.GetProcesses();
            int sum = 0;
            foreach (var item in process)
            {
                sum += item.Threads.Count;
            }
            label1.Text = sum.ToString();

        }


        private void addtaskbutton_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm();
            addTaskForm.ShowDialog();
            listView1.Items.Clear();
            showProcesses();
        }

        private void endtaskbutton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                try
                {

                    var pr = Process.GetProcessesByName(listView1.SelectedItems[0].SubItems[1].Text);
                    pr[0].Kill();
                    listView1.Items.Clear();
                    showProcesses();
                }
                catch (Exception)
                {
                    MessageBox.Show("Can not found This task");

                }

            }
            else MessageBox.Show("You shoud Choise task before remove");

        }

        private void addblackbtn_Click(object sender, EventArgs e)
        {
            AddToBlackList addToBlack=new AddToBlackList();
            addToBlack.ShowDialog();
            listView1.Items.Clear();
            showProcesses();
        }
    }
}