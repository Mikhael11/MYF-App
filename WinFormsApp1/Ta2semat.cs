using MYF_APP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Ta2semat : Form
    {
        functions fn = new functions();
        String query;
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
            String category = guna2ComboBox1.Text;
            query = "Select Name from myfdb Where Age = '" + category + "'";
            showItemList(query);
        }
        private void showItemList(String query)
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
            String category = guna2ComboBox1.Text;
            query = "Select itname from items Where category = '" + category + "' and itname like'" + txtraba.Text + "%'";

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
    }
}
