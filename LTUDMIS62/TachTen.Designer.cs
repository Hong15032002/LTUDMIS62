
namespace LTUDMIS62
{
    partial class TachTen
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
            this.components = new System.ComponentModel.Container();
            this.lbkHt = new System.Windows.Forms.Label();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.btnTachHoDem = new System.Windows.Forms.Button();
            this.btnTachDem = new System.Windows.Forms.Button();
            this.btnTachDEMTEN = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbkHt
            // 
            this.lbkHt.AutoSize = true;
            this.lbkHt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkHt.Location = new System.Drawing.Point(24, 44);
            this.lbkHt.Name = "lbkHt";
            this.lbkHt.Size = new System.Drawing.Size(119, 29);
            this.lbkHt.TabIndex = 0;
            this.lbkHt.Text = "Họ và tên:";
            this.lbkHt.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(192, 48);
            this.txtHT.Multiline = true;
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(238, 26);
            this.txtHT.TabIndex = 1;
            this.txtHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnTachHoDem
            // 
            this.btnTachHoDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTachHoDem.Location = new System.Drawing.Point(29, 142);
            this.btnTachHoDem.Name = "btnTachHoDem";
            this.btnTachHoDem.Size = new System.Drawing.Size(189, 51);
            this.btnTachHoDem.TabIndex = 2;
            this.btnTachHoDem.Text = " Tách họ đệm";
            this.btnTachHoDem.UseVisualStyleBackColor = true;
            this.btnTachHoDem.Click += new System.EventHandler(this.btnHoDem_Click);
            // 
            // btnTachDem
            // 
            this.btnTachDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTachDem.Location = new System.Drawing.Point(299, 142);
            this.btnTachDem.Name = "btnTachDem";
            this.btnTachDem.Size = new System.Drawing.Size(189, 51);
            this.btnTachDem.TabIndex = 3;
            this.btnTachDem.Text = "Tách đệm";
            this.btnTachDem.UseVisualStyleBackColor = true;
            this.btnTachDem.Click += new System.EventHandler(this.btnTachDem_Click);
            // 
            // btnTachDEMTEN
            // 
            this.btnTachDEMTEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTachDEMTEN.Location = new System.Drawing.Point(569, 142);
            this.btnTachDEMTEN.Name = "btnTachDEMTEN";
            this.btnTachDEMTEN.Size = new System.Drawing.Size(189, 51);
            this.btnTachDEMTEN.TabIndex = 4;
            this.btnTachDEMTEN.Text = "Tách đệm và tên";
            this.btnTachDEMTEN.UseVisualStyleBackColor = true;
            this.btnTachDEMTEN.Click += new System.EventHandler(this.btnTachDEMTEN_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(703, 399);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(86, 32);
            this.btnEXIT.TabIndex = 5;
            this.btnEXIT.Text = "Đóng";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(36, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kết quả";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 8;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 9;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbkHt);
            this.groupBox1.Controls.Add(this.txtHT);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 106);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập họ và tên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(61, 311);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(31, 20);
            this.lblKQ.TabIndex = 11;
            this.lblKQ.Text = "KQ";
            this.lblKQ.Click += new System.EventHandler(this.lblKQ_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TachTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnTachDEMTEN);
            this.Controls.Add(this.btnTachDem);
            this.Controls.Add(this.btnTachHoDem);
            this.Name = "TachTen";
            this.Text = "TachTen";
            this.Load += new System.EventHandler(this.TachTen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbkHt;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.Button btnTachHoDem;
        private System.Windows.Forms.Button btnTachDem;
        private System.Windows.Forms.Button btnTachDEMTEN;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Timer timer1;
    }
}