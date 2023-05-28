namespace ProcessesManager
{
    partial class AddTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxaddtask = new System.Windows.Forms.TextBox();
            this.submtbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxaddtask
            // 
            this.textBoxaddtask.Location = new System.Drawing.Point(194, 41);
            this.textBoxaddtask.Name = "textBoxaddtask";
            this.textBoxaddtask.Size = new System.Drawing.Size(322, 27);
            this.textBoxaddtask.TabIndex = 0;
            // 
            // submtbutton
            // 
            this.submtbutton.Location = new System.Drawing.Point(255, 83);
            this.submtbutton.Name = "submtbutton";
            this.submtbutton.Size = new System.Drawing.Size(94, 29);
            this.submtbutton.TabIndex = 1;
            this.submtbutton.Text = "Submit";
            this.submtbutton.UseVisualStyleBackColor = true;
            this.submtbutton.Click += new System.EventHandler(this.submtbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Task Name";
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 133);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submtbutton);
            this.Controls.Add(this.textBoxaddtask);
            this.Name = "AddTaskForm";
            this.Text = "AddTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxaddtask;
        private Button submtbutton;
        private Label label1;
    }
}