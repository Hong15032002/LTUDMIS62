
namespace LTUDMIS62
{
    partial class FrmDMHH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdData = new System.Windows.Forms.DataGridView();
            this.Manhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGvnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sanxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtDonvt = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtSanxuat = new System.Windows.Forms.TextBox();
            this.lblManhom = new System.Windows.Forms.Label();
            this.lblMahnag = new System.Windows.Forms.Label();
            this.lblTenhang = new System.Windows.Forms.Label();
            this.txtDvt = new System.Windows.Forms.Label();
            this.lblDongia = new System.Windows.Forms.Label();
            this.lblNuocSX = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comGiatri = new System.Windows.Forms.ComboBox();
            this.comTentruong = new System.Windows.Forms.ComboBox();
            this.CmdEnd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.txtManhom = new System.Windows.Forms.ComboBox();
            this.btnInBC1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Manhom,
            this.MaHH,
            this.TenHH,
            this.Dvt,
            this.DGvnd,
            this.Sanxuat});
            this.grdData.Location = new System.Drawing.Point(12, 12);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 62;
            this.grdData.RowTemplate.Height = 28;
            this.grdData.Size = new System.Drawing.Size(674, 430);
            this.grdData.TabIndex = 0;
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Manhom
            // 
            this.Manhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Manhom.DataPropertyName = "Manhom";
            this.Manhom.HeaderText = "Mã nhóm";
            this.Manhom.MinimumWidth = 8;
            this.Manhom.Name = "Manhom";
            this.Manhom.Width = 111;
            // 
            // MaHH
            // 
            this.MaHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaHH.DataPropertyName = "MaHH";
            this.MaHH.HeaderText = "Mã hàng ";
            this.MaHH.MinimumWidth = 8;
            this.MaHH.Name = "MaHH";
            this.MaHH.Width = 111;
            // 
            // TenHH
            // 
            this.TenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenHH.DataPropertyName = "TenHH";
            this.TenHH.HeaderText = "Tên hàng";
            this.TenHH.MinimumWidth = 8;
            this.TenHH.Name = "TenHH";
            this.TenHH.Width = 112;
            // 
            // Dvt
            // 
            this.Dvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Dvt.DataPropertyName = "Dvt";
            this.Dvt.HeaderText = "Đvt";
            this.Dvt.MinimumWidth = 8;
            this.Dvt.Name = "Dvt";
            this.Dvt.Width = 69;
            // 
            // DGvnd
            // 
            this.DGvnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DGvnd.DataPropertyName = "DGvnd";
            this.DGvnd.HeaderText = "Đơn giá";
            this.DGvnd.MinimumWidth = 8;
            this.DGvnd.Name = "DGvnd";
            // 
            // Sanxuat
            // 
            this.Sanxuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sanxuat.DataPropertyName = "Sanxuat";
            this.Sanxuat.HeaderText = "Nước SX";
            this.Sanxuat.MinimumWidth = 8;
            this.Sanxuat.Name = "Sanxuat";
            this.Sanxuat.Width = 108;
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(854, 262);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(211, 26);
            this.txtMaHH.TabIndex = 2;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(854, 300);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(211, 26);
            this.txtTenHH.TabIndex = 3;
            // 
            // txtDonvt
            // 
            this.txtDonvt.Location = new System.Drawing.Point(854, 337);
            this.txtDonvt.Name = "txtDonvt";
            this.txtDonvt.Size = new System.Drawing.Size(211, 26);
            this.txtDonvt.TabIndex = 4;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(854, 374);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(211, 26);
            this.txtDongia.TabIndex = 5;
            // 
            // txtSanxuat
            // 
            this.txtSanxuat.Location = new System.Drawing.Point(854, 413);
            this.txtSanxuat.Name = "txtSanxuat";
            this.txtSanxuat.Size = new System.Drawing.Size(211, 26);
            this.txtSanxuat.TabIndex = 6;
            // 
            // lblManhom
            // 
            this.lblManhom.AutoSize = true;
            this.lblManhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManhom.Location = new System.Drawing.Point(722, 228);
            this.lblManhom.Name = "lblManhom";
            this.lblManhom.Size = new System.Drawing.Size(94, 25);
            this.lblManhom.TabIndex = 7;
            this.lblManhom.Text = "Mã nhóm";
            this.lblManhom.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMahnag
            // 
            this.lblMahnag.AutoSize = true;
            this.lblMahnag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMahnag.Location = new System.Drawing.Point(722, 263);
            this.lblMahnag.Name = "lblMahnag";
            this.lblMahnag.Size = new System.Drawing.Size(89, 25);
            this.lblMahnag.TabIndex = 8;
            this.lblMahnag.Text = "Mã hàng";
            this.lblMahnag.Click += new System.EventHandler(this.lblMahnag_Click);
            // 
            // lblTenhang
            // 
            this.lblTenhang.AutoSize = true;
            this.lblTenhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenhang.Location = new System.Drawing.Point(722, 301);
            this.lblTenhang.Name = "lblTenhang";
            this.lblTenhang.Size = new System.Drawing.Size(96, 25);
            this.lblTenhang.TabIndex = 9;
            this.lblTenhang.Text = "Tên hàng";
            this.lblTenhang.Click += new System.EventHandler(this.lblTenhang_Click);
            // 
            // txtDvt
            // 
            this.txtDvt.AutoSize = true;
            this.txtDvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDvt.Location = new System.Drawing.Point(722, 338);
            this.txtDvt.Name = "txtDvt";
            this.txtDvt.Size = new System.Drawing.Size(103, 25);
            this.txtDvt.TabIndex = 10;
            this.txtDvt.Text = "Đơn vị tính";
            this.txtDvt.Click += new System.EventHandler(this.txtDvt_Click);
            // 
            // lblDongia
            // 
            this.lblDongia.AutoSize = true;
            this.lblDongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDongia.Location = new System.Drawing.Point(722, 375);
            this.lblDongia.Name = "lblDongia";
            this.lblDongia.Size = new System.Drawing.Size(79, 25);
            this.lblDongia.TabIndex = 11;
            this.lblDongia.Text = "Đơn giá";
            this.lblDongia.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblNuocSX
            // 
            this.lblNuocSX.AutoSize = true;
            this.lblNuocSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuocSX.Location = new System.Drawing.Point(722, 413);
            this.lblNuocSX.Name = "lblNuocSX";
            this.lblNuocSX.Size = new System.Drawing.Size(91, 25);
            this.lblNuocSX.TabIndex = 12;
            this.lblNuocSX.Text = "Nước SX";
            this.lblNuocSX.Click += new System.EventHandler(this.lblNuocSX_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(100, 468);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(101, 52);
            this.btnFirst.TabIndex = 13;
            this.btnFirst.Text = "Đầu";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrv.Location = new System.Drawing.Point(223, 468);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(101, 52);
            this.btnPrv.TabIndex = 14;
            this.btnPrv.Text = "Trước";
            this.btnPrv.UseVisualStyleBackColor = true;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(350, 468);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(101, 52);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(477, 468);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(101, 52);
            this.btnLast.TabIndex = 16;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearFilter);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comGiatri);
            this.groupBox1.Controls.Add(this.comTentruong);
            this.groupBox1.Location = new System.Drawing.Point(727, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 179);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc dữ liệu";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilter.Location = new System.Drawing.Point(176, 94);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(184, 54);
            this.btnClearFilter.TabIndex = 5;
            this.btnClearFilter.Text = "Hủy lọc dữ liệu";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(4, 96);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(148, 52);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Lọc dữ liệu";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giá trị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên trường";
            // 
            // comGiatri
            // 
            this.comGiatri.FormattingEnabled = true;
            this.comGiatri.Location = new System.Drawing.Point(135, 60);
            this.comGiatri.Name = "comGiatri";
            this.comGiatri.Size = new System.Drawing.Size(225, 28);
            this.comGiatri.TabIndex = 1;
            // 
            // comTentruong
            // 
            this.comTentruong.FormattingEnabled = true;
            this.comTentruong.Items.AddRange(new object[] {
            "MaHH",
            "TenHH",
            "Manhom",
            "Sanxuat"});
            this.comTentruong.Location = new System.Drawing.Point(9, 62);
            this.comTentruong.Name = "comTentruong";
            this.comTentruong.Size = new System.Drawing.Size(107, 28);
            this.comTentruong.TabIndex = 0;
            this.comTentruong.SelectedIndexChanged += new System.EventHandler(this.comTentruong_SelectedIndexChanged);
            // 
            // CmdEnd
            // 
            this.CmdEnd.Location = new System.Drawing.Point(1034, 551);
            this.CmdEnd.Name = "CmdEnd";
            this.CmdEnd.Size = new System.Drawing.Size(97, 48);
            this.CmdEnd.TabIndex = 18;
            this.CmdEnd.Text = "Kết thúc";
            this.CmdEnd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(921, 551);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 48);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(808, 551);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 48);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(695, 551);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 48);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddnew
            // 
            this.btnAddnew.Location = new System.Drawing.Point(582, 551);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(97, 48);
            this.btnAddnew.TabIndex = 22;
            this.btnAddnew.Text = "Thêm mới";
            this.btnAddnew.UseVisualStyleBackColor = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // txtManhom
            // 
            this.txtManhom.FormattingEnabled = true;
            this.txtManhom.Location = new System.Drawing.Point(854, 228);
            this.txtManhom.Name = "txtManhom";
            this.txtManhom.Size = new System.Drawing.Size(211, 28);
            this.txtManhom.TabIndex = 23;
            // 
            // btnInBC1
            // 
            this.btnInBC1.BackColor = System.Drawing.Color.Thistle;
            this.btnInBC1.Location = new System.Drawing.Point(853, 445);
            this.btnInBC1.Name = "btnInBC1";
            this.btnInBC1.Size = new System.Drawing.Size(212, 39);
            this.btnInBC1.TabIndex = 24;
            this.btnInBC1.Text = "In kiểm kê theo nhóm hàng";
            this.btnInBC1.UseVisualStyleBackColor = false;
            this.btnInBC1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(599, 509);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 26);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(738, 509);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(120, 26);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(921, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmDMHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1183, 601);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnInBC1);
            this.Controls.Add(this.txtManhom);
            this.Controls.Add(this.btnAddnew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.CmdEnd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrv);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.lblNuocSX);
            this.Controls.Add(this.lblDongia);
            this.Controls.Add(this.txtDvt);
            this.Controls.Add(this.lblTenhang);
            this.Controls.Add(this.lblMahnag);
            this.Controls.Add(this.lblManhom);
            this.Controls.Add(this.txtSanxuat);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.txtDonvt);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.txtMaHH);
            this.Controls.Add(this.grdData);
            this.Name = "FrmDMHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmDMHH";
            this.Load += new System.EventHandler(this.FrmDMHH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGvnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sanxuat;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtDonvt;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtSanxuat;
        private System.Windows.Forms.Label lblManhom;
        private System.Windows.Forms.Label lblMahnag;
        private System.Windows.Forms.Label lblTenhang;
        private System.Windows.Forms.Label txtDvt;
        private System.Windows.Forms.Label lblDongia;
        private System.Windows.Forms.Label lblNuocSX;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comGiatri;
        private System.Windows.Forms.ComboBox comTentruong;
        private System.Windows.Forms.Button CmdEnd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.ComboBox txtManhom;
        private System.Windows.Forms.Button btnInBC1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
    }
}