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
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        Boolean addnewfLag; 
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
            sql = "select Manhom,MaHH,TenHH,Dvt,Dgvnd,Sanxuat from tblDMHH"+
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
            sql = "select MaNhom,MaHH,TenHH,Dvt,DGvnd,Sanxuat from tblDMHH order by MaHH";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            dt.Clear();// xóa đi dữ liệu đang có
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấys về
            grdData.DataSource = dt;
            grdData.Refresh(); // làm mới lại
            NapCT();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời? Y/N", "Xác nhận"+
                " yêu cầu",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
           // hiện ra bảng hỏi có chắc chắn xóa không
            {
                sql = "delete from tblDMHH where MaHH ='" + txtMaHH.Text + "'"; // xóa dữ liệu trên sql
                //sql = "delete from tblDMHH where MaHH ='" + txtMaHH.Text + "'";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                grdData.Rows.RemoveAt(grdData.CurrentRow.Index); // xóa dòng hiện thời( xóa dòng với chỉ số bao nhiêu) trên bảng của c#
                NapCT(); // nạp lại chi tiết

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Hãy thực hiện mọi mong muốn trên ô lưới, " +
                "kết thúc bấm nút Cập nhật", "Thông báo", MessageBoxButtons.OK);
            btnUpdate.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (addnewfLag == false)
            {
                // chỗ này là cập nhật sửa chữa
            }    
            else
            {
                // chỗ này là cập nhật thêm mới
                addnewfLag = false;
                sql = "insert into tblDMHH (MaNhom,MaHH,TenHH,Dvt,Dgvnd,Sanxuat)" +
                    "Values ('" + txtManhom.Text + "','" + txtMaHH.Text + "',N'" +
                    txtTenHH.Text + "',N'" + txtDvt.Text + "'," + txtDongia.Text + ",N'"
                    + txtSanxuat.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                // nạp dữ liệu bản ghi vừa thêm vào ô cuối cùng của ô lưới
                grdData.Rows[i].Cells["Manhom"].Value = txtManhom.Text ;
                grdData.Rows[i].Cells["MaHH"].Value = txtMaHH.Text ;
                grdData.Rows[i].Cells["TenHH"].Value = txtTenHH.Text ;
                grdData.Rows[i].Cells["Dvt"].Value = txtDonvt.Text ;
                grdData.Rows[i].Cells["DGvnd"].Value = txtDongia.Text ;
                grdData.Rows[i].Cells["Sanxuat"].Value = txtSanxuat.Text ;
            }
            btnUpdate.Enabled = false;
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            sql = "select MaNhom,MaHH,TenHH,Dvt,DGvnd,Sanxuat from tblDMHH order by MaHH";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            dt.Clear();// xóa đi dữ liệu đang có
            da.Fill(dt); // dt là nơi chứa dữ liệu dataAdapter lấys về
            grdData.DataSource = dt;
            NapCT();
            grdData.CurrentCell = grdData[0, grdData.RowCount - 1]; // di chuyển bản ghi hiện thời đến dòng cuối cùng
            NapCT();
            MessageBox.Show("Hãy nhập nội dung bản ghi mới, kết thúc ấn Cập nhật!");
            txtManhom.Focus();// chuyển con trỏ soạn thảo đến mã nhóm
            addnewfLag = true;
            btnUpdate.Enabled = true;
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