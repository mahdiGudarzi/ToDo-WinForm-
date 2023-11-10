using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace ToDo
{
    public partial class ToDoList : Form
    {
        private MyDatabase myDatabase = new MyDatabase();
        private string selectedItem;
        public ToDoList()
        {
            InitializeComponent();
            List<string> tableNames = myDatabase.GetTableNames();
            foreach (string name in tableNames)
            {
                if (!string.IsNullOrEmpty(name))
                {
                    var tmp = name.Replace("_", " ");
                    LoadTask.Items.Add(tmp);
                }
            }
        }


        #region llist box and items !

        // بعد از انتخاب ایتم  تمام تسک های ان نمایش داده میشود 

        private void LoadTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LoadTask.SelectedItem != null)
            {
                checkedListBox1.Items.Clear();
                var temp =LoadTask.SelectedItem.ToString();
                this.selectedItem = temp.Replace(" ", "_");
                foreach (var a in myDatabase.GetTask(this.selectedItem))
                {
                    if (!string.IsNullOrEmpty(a))
                    {
                        var tmp = a.Replace("_", " ");
                        checkedListBox1.Items.Add(tmp);
                    }
                    panel1.Visible = true;
                }
            }
        }

        // اضافه کردن ایتم به لیست باکس
        private void Addlistbtn_Click(object sender, EventArgs e)
        {

            string itemName = ShowInputDialog("نامی برای لیست انتخاب کنید ");
            if (!string.IsNullOrEmpty(itemName))
            {
                LoadTask.Items.Add(itemName);
                itemName = itemName.Replace(' ', '_');
                myDatabase.CreateTableIfNotExists(itemName);
            }


        }

        // پاک کردن  ایتم در لیست باکس
        
        private void Rmovebtnlist_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            try
            {
                if (LoadTask.SelectedIndex != -1)
                {
                    string itemName = LoadTask.SelectedItem.ToString();
                    LoadTask.Items.RemoveAt(LoadTask.SelectedIndex);
                    itemName = itemName.Replace(" ", "_");
                    myDatabase.RemoveTableIfExists(itemName);
                    this.selectedItem = string.Empty;
                }
                else
                {
                    throw new Exception("یک لیست را انتخاب کنید ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region check list and tasks!
        // اضافه کردن ایتم به چک لیست
        private void AddbtnTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(selectedItem))
                {
                    string itemname = ShowInputDialog("اضافه کردن تسک ");

                    if (!string.IsNullOrEmpty(itemname))
                    {
                        checkedListBox1.Items.Add(itemname);
                        itemname = itemname.Replace(" ", "_");
                        myDatabase.InsertTask(selectedItem, itemname);

                    }
                }
                else
                {
                    throw new Exception(" لطفا یک لیست را انتخاب کنید ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // پاک کردن تسک ها ی  تیک خورده در چک لیست
        private void RemoveBtnTask_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(selectedItem))
                {

                    bool isChecked = false;
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    {

                        if (checkedListBox1.GetItemChecked(i))
                        {
                            var tmp = checkedListBox1.Items[i].ToString();
                            tmp = tmp.Replace(' ', '_');
                            myDatabase.RemoveTask(this.selectedItem, tmp);
                            checkedListBox1.Items.RemoveAt(i);
                            i--;
                            isChecked = true;
                        }

                    }

                    if (!isChecked)
                    {
                        MessageBox.Show("تسکی انتخاب نشده است", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    throw new Exception(" لطفا یک لیست را انتخاب کنید ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion


       
        private string ShowInputDialog(string title)
        {
            AskForm tempForm = new AskForm(title);
            tempForm.StartPosition = FormStartPosition.CenterParent;
            tempForm.ShowDialog();
            return tempForm.iTask;
        }

    }
}