namespace ProcessesManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addtaskbutton = new System.Windows.Forms.Button();
            this.endtaskbutton = new System.Windows.Forms.Button();
            this.addblackbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(28, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(678, 362);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "HandleCount";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ThreadsCount";
            this.columnHeader4.Width = 120;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Threads :";
            // 
            // addtaskbutton
            // 
            this.addtaskbutton.Location = new System.Drawing.Point(465, 410);
            this.addtaskbutton.Name = "addtaskbutton";
            this.addtaskbutton.Size = new System.Drawing.Size(93, 41);
            this.addtaskbutton.TabIndex = 3;
            this.addtaskbutton.Text = "Add Task";
            this.addtaskbutton.UseVisualStyleBackColor = true;
            this.addtaskbutton.Click += new System.EventHandler(this.addtaskbutton_Click);
            // 
            // endtaskbutton
            // 
            this.endtaskbutton.Location = new System.Drawing.Point(589, 410);
            this.endtaskbutton.Name = "endtaskbutton";
            this.endtaskbutton.Size = new System.Drawing.Size(88, 41);
            this.endtaskbutton.TabIndex = 4;
            this.endtaskbutton.Text = "End Task";
            this.endtaskbutton.UseVisualStyleBackColor = true;
            this.endtaskbutton.Click += new System.EventHandler(this.endtaskbutton_Click);
            // 
            // addblackbtn
            // 
            this.addblackbtn.Location = new System.Drawing.Point(699, 410);
            this.addblackbtn.Name = "addblackbtn";
            this.addblackbtn.Size = new System.Drawing.Size(147, 41);
            this.addblackbtn.TabIndex = 5;
            this.addblackbtn.Text = "Add to BlackList";
            this.addblackbtn.UseVisualStyleBackColor = true;
            this.addblackbtn.Click += new System.EventHandler(this.addblackbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 522);
            this.Controls.Add(this.addblackbtn);
            this.Controls.Add(this.endtaskbutton);
            this.Controls.Add(this.addtaskbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "ProcessManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Button addtaskbutton;
        private Button endtaskbutton;
        private Button addblackbtn;
    }
}