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
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        public FrmDMHH()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmDMHH_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-BA1C3EL\\SQLEXPRESS;" +
               "Initial Catalog=QLBH;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select Manhom,MaHH,TenHH,Dvt,DGvnd,Sanxuat from tblDMHH order by MaHH";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấys về
            grdData.DataSource = dt;
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0];
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            i = grdData.RowCount;  
            grdData.CurrentCell = grdData[0, i-2];
            NapCT();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i <= grdData.RowCount - 2)
            {
                grdData.CurrentCell = grdData[0, i + 1];
            }
            else
            {
                grdData.CurrentCell = grdData[0, 0];
            }
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i > 0)
            {
                grdData.CurrentCell = grdData[0, i - 1];
            }
            else
            {
                grdData.CurrentCell = grdData[0, grdData.RowCount -2];
            }    
            NapCT();
        }

        private void comTentruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "select Distinct"+" " + comTentruong.Text + " From tblDmHH";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGiatri.DataSource = comdt;
            comGiatri.DisplayMember = comTentruong.Text; // trường được hiển thị là tên trường
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            sql = "select Manhom,MaHH,TenHH,Dvt,DGvnd,Sanxuat from tblDMHH"+
                " where "+ comTentruong.Text+"=N'"+ comGiatri.Text+"'";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            dt.Clear();
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấy về
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            sql = "select Manhom,MaHH,TenHH,Dvt,DGvnd,Sanxuat from tblDMHH order by MaHH";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            dt.Clear();// xóa đi dữ liệu đang có
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấys về
            grdData.DataSource = dt;
            grdData.Refresh(); // làm mới lại
            NapCT();
        }

        // i-2 vì số thứ tự chạy từ 0 và nếu i-1 thì nó sẽ nhảy xuống dòng trắng cuối cùng
        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtManhom.Text = grdData.Rows[i].Cells["Manhom"].Value.ToString();
            txtMaHH.Text = grdData.Rows[i].Cells["MaHH"].Value.ToString();
            txtTenHH.Text = grdData.Rows[i].Cells["TenHH"].Value.ToString();
            txtDonvt.Text = grdData.Rows[i].Cells["Dvt"].Value.ToString();
            txtDongia.Text = grdData.Rows[i].Cells["DGvnd"].Value.ToString();
            txtSanxuat.Text = grdData.Rows[i].Cells["Sanxuat"].Value.ToString();
           
        }
    }
}