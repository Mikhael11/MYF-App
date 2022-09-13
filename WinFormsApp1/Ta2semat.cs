using MYF_APP;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Ta2semat : Form
    {
        readonly functions fn = new functions();
        string query;
        public Ta2semat()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            Add_new_one add_New_One = new Add_new_one();
            add_New_One.Show();
            this.Close();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //query = "Select Name from myfdb Where Age = 'سنة اولى' and Name like'" + txtola.Text + "%'";
            DataSet ds = fn.GetData(query);
            int i;

            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string category = guna2ComboBox1.Text;
            query = "Select Name from myf Where Age = N'" + category + "'";
            showItemList(query);
        }
        private void showItemList(string query)
        {
            DataSet ds = fn.GetData(query);
            int i;
            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void txtraba_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string category = guna2ComboBox1.Text;
            query = "Select Name from myf Where Age = N'" + category + "' and Name like N'" + txtraba.Text + "%'";

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dt = new DataSet())
                        {
                            sda.Fill(dt);
                            int i;
                            for (i = 0; i < dt.Tables[0].Rows.Count; i++)
                            {
                                listBox1.Items.Add(dt.Tables[0].Rows[i][0].ToString());
                            }
                        }
                    }
                }
            }
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnpush_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void btnpuzzle_Click(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();

            var data = listBox2.Items.Cast<string>().ToArray();
            var size = data.Length;

            int boxSize = size / 4;

            int fir = boxSize;
            int sec = boxSize;
            int thi = boxSize;

            int remander = size % 4;

            if (remander > 0)
            {
                fir += 1;
                if (remander > 1)
                {
                    sec += 1;
                    if (remander > 2)
                    {
                        thi += 1;
                    }
                }
            }

            var r = new Random();

            data = data.OrderBy(i => r.Next()).ToArray();

            listBox5.Items.AddRange(data.Take(fir).ToArray());
            listBox6.Items.AddRange(data.Skip(fir).Take(sec).ToArray());
            listBox7.Items.AddRange(data.Skip(fir + sec).Take(thi).ToArray());
            listBox8.Items.AddRange(data.Skip(fir + sec + thi).Take(boxSize).ToArray());
        }
    }
}
