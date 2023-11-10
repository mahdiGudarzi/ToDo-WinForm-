using System;
using System.Windows.Forms;


namespace ToDo
{
    public partial class AskForm : Form
    {
        public string iTask;
       
        public AskForm( string tilte)
        {
            InitializeComponent();
            this.Text = tilte;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt.Text) || !string.IsNullOrWhiteSpace(txt.Text))
                {
                    this.iTask = txt.Text;
                    this.Close();
                }
                else
                {
                    throw new Exception(" لطفا متنی را وارد کنید ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
