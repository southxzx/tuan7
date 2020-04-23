using bt_tuan7.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt_tuan7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        User_Bus ub = new User_Bus();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String condition;
            condition = " username ='" + txt_username.Text + "' AND current_password ='" + txt_password.Text + "'";
            DataTable dt = new DataTable();
            try
            {
                dt = ub.getUser(condition);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công, mời bạn đăng nhập lại!");
                    
                }
            }
            catch (FormatException err)
            {
                MessageBox.Show("Lỗi" + err);
            }
            catch (SqlException err)
            {
                MessageBox.Show("Lỗi " + err);
            }
        }
    }
}
