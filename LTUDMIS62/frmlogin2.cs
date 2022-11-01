using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LTUDMIS62
{
    public partial class frmlogin2 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql, constr, username, userright;
        int i = 0;
        public frmlogin2()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            sql = "select * from tblPass where username = '" + txtUser.Text +
                "'and Password = '" + txtPass.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                //đăng nhập thành công
                username = dt.Rows[0][0].ToString(); // username sẽ lấy giá tị ở dòng 0, cột 0 ở data table
                userright = dt.Rows[0][2].ToString(); // ueserright lấy giá trị ở dòng 0, cột 2
                frmMain f = new frmMain(username, userright);
                f.Show();
                this.Hide();
            }
            else
            {
                // đăng nhập thất bại
                i++;
                if(i>3)
                {
                    MessageBox.Show("Bạn đã đăng nhập sai quá 3 lần! Chương trình kết thúc!");
                    Application.Exit();
                }
                else
                {
                    i++;
                    MessageBox.Show("Đăng nhập thất bại. Hãy kiểm tra!");
                    txtUser.Focus();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnend_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmlogin2_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-BA1C3EL\\SQLEXPRESS;Initial Catalog=QLBH;Persist Security Info=True;User ID=httt62;Password=hong";
            conn.ConnectionString = constr;
            conn.Open();
        }
    }
}
