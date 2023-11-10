using System.Drawing;
using System.Windows.Forms;

namespace ToDo
{
    partial class ToDoList
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
            this.LoadTask = new System.Windows.Forms.ListBox();
            this.Addlistbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.RemoveBtnTask = new System.Windows.Forms.Button();
            this.AddbtnTask = new System.Windows.Forms.Button();
            this.Rmovebtnlist = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadTask
            // 
            this.LoadTask.FormattingEnabled = true;
            this.LoadTask.Location = new System.Drawing.Point(12, 28);
            this.LoadTask.Name = "LoadTask";
            this.LoadTask.Size = new System.Drawing.Size(124, 355);
            this.LoadTask.TabIndex = 0;
            this.LoadTask.SelectedIndexChanged += new System.EventHandler(this.LoadTask_SelectedIndexChanged);
            this.LoadTask.Font = new Font("Arial", 12);
            this.LoadTask.ForeColor = Color.Black;
            this.LoadTask.BorderStyle = BorderStyle.FixedSingle;
            this.LoadTask.BackColor = Color.White;
            // 
            // Addlistbtn
            // 
            this.Addlistbtn.Location = new System.Drawing.Point(12, 400);
            this.Addlistbtn.Name = "Addlistbtn";
            this.Addlistbtn.Size = new System.Drawing.Size(83, 23);
            this.Addlistbtn.TabIndex = 1;
            this.Addlistbtn.Text = "افزودن";
            this.Addlistbtn.UseVisualStyleBackColor = true;
            this.Addlistbtn.Click += new System.EventHandler(this.Addlistbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.RemoveBtnTask);
            this.panel1.Controls.Add(this.AddbtnTask);
            this.panel1.Location = new System.Drawing.Point(142, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 355);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 20);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(613, 289);
            this.checkedListBox1.TabIndex = 3;
            // 
            // RemoveBtnTask
            // 
            this.RemoveBtnTask.Location = new System.Drawing.Point(446, 315);
            this.RemoveBtnTask.Name = "RemoveBtnTask";
            this.RemoveBtnTask.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtnTask.TabIndex = 2;
            this.RemoveBtnTask.Text = "پاک کردن";
            this.RemoveBtnTask.UseVisualStyleBackColor = true;
            this.RemoveBtnTask.Click += new System.EventHandler(this.RemoveBtnTask_Click);
            // 
            // AddbtnTask
            // 
            this.AddbtnTask.Location = new System.Drawing.Point(541, 315);
            this.AddbtnTask.Name = "AddbtnTask";
            this.AddbtnTask.Size = new System.Drawing.Size(75, 23);
            this.AddbtnTask.TabIndex = 1;
            this.AddbtnTask.Text = "افزودن";
            this.AddbtnTask.UseVisualStyleBackColor = true;
            this.AddbtnTask.Click += new System.EventHandler(this.AddbtnTask_Click);
            // 
            // Rmovebtnlist
            // 
            this.Rmovebtnlist.Location = new System.Drawing.Point(119, 400);
            this.Rmovebtnlist.Name = "Rmovebtnlist";
            this.Rmovebtnlist.Size = new System.Drawing.Size(84, 23);
            this.Rmovebtnlist.TabIndex = 3;
            this.Rmovebtnlist.Text = "پاک کردن";
            this.Rmovebtnlist.UseVisualStyleBackColor = true;
            this.Rmovebtnlist.Click += new System.EventHandler(this.Rmovebtnlist_Click);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rmovebtnlist);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Addlistbtn);
            this.Controls.Add(this.LoadTask);
            this.Name = "ToDoList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "دفتر وظایف";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LoadTask;
        private System.Windows.Forms.Button Addlistbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Rmovebtnlist;
        private System.Windows.Forms.Button RemoveBtnTask;
        private System.Windows.Forms.Button AddbtnTask;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

