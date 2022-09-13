namespace WinFormsApp1
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtName.Text=="myf" && txtPass.Text == "myf2023")

            {
                Ta2semat ta2Semat = new Ta2semat();
                ta2Semat.Show();
                this.Hide();
            }
            else
            {
                string message = "Wrong Cardinalities";
                string title = "ERROR";
                MessageBox.Show(message, title);
            }
        }
    }
}