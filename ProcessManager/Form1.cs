using System.Diagnostics;

namespace ProcessManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showProcesses();
        }
        public void showProcesses()
        {
            
            dataGridView1.DataSource=Process.GetProcesses().ToList();
            
            //foreach (var process in Process.GetProcesses().ToList())
            //{
            //    dataGridView1.DataSource= process;
            //    //ListViewItem list = new ListViewItem(process.Id.ToString());
            //    //list.SubItems.Add(process.ProcessName);
            //    //list.SubItems.Add(process.HandleCount.ToString());
            //    //list.SubItems.Add(process.Threads.Count.ToString());
            //    //listView1.Items.Add(list);

            //}

        }

    }
}