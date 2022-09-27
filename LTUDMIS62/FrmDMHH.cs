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


    public partial class FrmDMHH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql, constr;
        public FrmDMHH()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void FrmDMHH_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-BA1C3EL\\SQLEXPRESS;" +
               "Initial Catalog=QLBH;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select * from tblDMHH order by MaHH";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấys về
            grdData.DataSource = dt;
        }
    }
}