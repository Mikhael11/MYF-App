using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYF_APP
{
    public partial class Add_new_one : Form
    {
        functions fn = new functions();
        string query = "";

        public Add_new_one()
        {
            InitializeComponent();
        }

        private void txtCatg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddone_Click(object sender, EventArgs e)
        {
            query = "insert into myfdb (Name,Age,Number,Address) values ('" + txtname.Text + "','" + txtlev.Text + "' , '" + txtnum.Text + "','"+ txtaddress.Text +"')";
            fn.setData(query);
            txtname.Clear();
            txtnum.Clear();
            txtaddress.Clear();
        }
    }
}
