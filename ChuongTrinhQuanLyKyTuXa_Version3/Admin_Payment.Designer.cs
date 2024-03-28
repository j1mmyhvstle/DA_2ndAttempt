namespace ChuongTrinhQuanLyKyTuXa_Version3
{
    partial class Admin_Payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.btn_thanhtoan = new Guna.UI2.WinForms.Guna2Button();
            this.lb_sophong = new System.Windows.Forms.Label();
            this.txt_RoomNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGridView_adminpayment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lb_tieude = new System.Windows.Forms.Label();
            this.txt_Tienthanhtoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_tienthanhtoan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_adminpayment)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BorderColor = System.Drawing.Color.White;
            this.btn_Search.BorderRadius = 15;
            this.btn_Search.BorderThickness = 1;
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_Search.Location = new System.Drawing.Point(544, 84);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.PressedColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Search.Size = new System.Drawing.Size(148, 45);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.BorderColor = System.Drawing.Color.White;
            this.btn_thanhtoan.BorderRadius = 15;
            this.btn_thanhtoan.BorderThickness = 1;
            this.btn_thanhtoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_thanhtoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_thanhtoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_thanhtoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_thanhtoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btn_thanhtoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_thanhtoan.ForeColor = System.Drawing.Color.White;
            this.btn_thanhtoan.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_thanhtoan.Location = new System.Drawing.Point(544, 393);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.PressedColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_thanhtoan.Size = new System.Drawing.Size(148, 45);
            this.btn_thanhtoan.TabIndex = 6;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // lb_sophong
            // 
            this.lb_sophong.BackColor = System.Drawing.Color.Transparent;
            this.lb_sophong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sophong.ForeColor = System.Drawing.Color.Black;
            this.lb_sophong.Location = new System.Drawing.Point(98, 84);
            this.lb_sophong.Name = "lb_sophong";
            this.lb_sophong.Size = new System.Drawing.Size(179, 23);
            this.lb_sophong.TabIndex = 5;
            this.lb_sophong.Text = "Số phòng: ";
            // 
            // txt_RoomNo
            // 
            this.txt_RoomNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txt_RoomNo.BorderRadius = 15;
            this.txt_RoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_RoomNo.DefaultText = "";
            this.txt_RoomNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_RoomNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_RoomNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_RoomNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_RoomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_RoomNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_RoomNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_RoomNo.Location = new System.Drawing.Point(283, 84);
            this.txt_RoomNo.Name = "txt_RoomNo";
            this.txt_RoomNo.PasswordChar = '\0';
            this.txt_RoomNo.PlaceholderText = "";
            this.txt_RoomNo.SelectedText = "";
            this.txt_RoomNo.Size = new System.Drawing.Size(255, 36);
            this.txt_RoomNo.TabIndex = 4;
            // 
            // DataGridView_adminpayment
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridView_adminpayment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_adminpayment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_adminpayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_adminpayment.ColumnHeadersHeight = 4;
            this.DataGridView_adminpayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_adminpayment.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_adminpayment.GridColor = System.Drawing.Color.Black;
            this.DataGridView_adminpayment.Location = new System.Drawing.Point(92, 139);
            this.DataGridView_adminpayment.Name = "DataGridView_adminpayment";
            this.DataGridView_adminpayment.RowHeadersVisible = false;
            this.DataGridView_adminpayment.RowHeadersWidth = 51;
            this.DataGridView_adminpayment.RowTemplate.Height = 28;
            this.DataGridView_adminpayment.Size = new System.Drawing.Size(600, 235);
            this.DataGridView_adminpayment.TabIndex = 3;
            this.DataGridView_adminpayment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_adminpayment.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_adminpayment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_adminpayment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_adminpayment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_adminpayment.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridView_adminpayment.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.DataGridView_adminpayment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_adminpayment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_adminpayment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DataGridView_adminpayment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_adminpayment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_adminpayment.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridView_adminpayment.ThemeStyle.ReadOnly = false;
            this.DataGridView_adminpayment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_adminpayment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_adminpayment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DataGridView_adminpayment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_adminpayment.ThemeStyle.RowsStyle.Height = 28;
            this.DataGridView_adminpayment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_adminpayment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_adminpayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_adminpayment_CellContentClick);
            // 
            // lb_tieude
            // 
            this.lb_tieude.BackColor = System.Drawing.Color.Transparent;
            this.lb_tieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tieude.ForeColor = System.Drawing.Color.Black;
            this.lb_tieude.Location = new System.Drawing.Point(110, 27);
            this.lb_tieude.Name = "lb_tieude";
            this.lb_tieude.Size = new System.Drawing.Size(567, 36);
            this.lb_tieude.TabIndex = 2;
            this.lb_tieude.Text = "GỬI YÊU CẦU THANH TOÁN TIỀN PHÒNG";
            // 
            // txt_Tienthanhtoan
            // 
            this.txt_Tienthanhtoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txt_Tienthanhtoan.BorderRadius = 15;
            this.txt_Tienthanhtoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Tienthanhtoan.DefaultText = "";
            this.txt_Tienthanhtoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Tienthanhtoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Tienthanhtoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Tienthanhtoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Tienthanhtoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Tienthanhtoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Tienthanhtoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Tienthanhtoan.Location = new System.Drawing.Point(283, 393);
            this.txt_Tienthanhtoan.Name = "txt_Tienthanhtoan";
            this.txt_Tienthanhtoan.PasswordChar = '\0';
            this.txt_Tienthanhtoan.PlaceholderText = "";
            this.txt_Tienthanhtoan.SelectedText = "";
            this.txt_Tienthanhtoan.Size = new System.Drawing.Size(255, 36);
            this.txt_Tienthanhtoan.TabIndex = 1;
            this.txt_Tienthanhtoan.TextChanged += new System.EventHandler(this.txt_Tienthanhtoan_TextChanged);
            // 
            // lb_tienthanhtoan
            // 
            this.lb_tienthanhtoan.BackColor = System.Drawing.Color.Transparent;
            this.lb_tienthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tienthanhtoan.ForeColor = System.Drawing.Color.Black;
            this.lb_tienthanhtoan.Location = new System.Drawing.Point(98, 393);
            this.lb_tienthanhtoan.Name = "lb_tienthanhtoan";
            this.lb_tienthanhtoan.Size = new System.Drawing.Size(179, 23);
            this.lb_tienthanhtoan.TabIndex = 0;
            this.lb_tienthanhtoan.Text = "Số tiền thanh toán: ";
            // 
            // Admin_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 478);
            this.Controls.Add(this.lb_tienthanhtoan);
            this.Controls.Add(this.txt_Tienthanhtoan);
            this.Controls.Add(this.lb_tieude);
            this.Controls.Add(this.DataGridView_adminpayment);
            this.Controls.Add(this.txt_RoomNo);
            this.Controls.Add(this.lb_sophong);
            this.Controls.Add(this.btn_thanhtoan);
            this.Controls.Add(this.btn_Search);
            this.Name = "Admin_Payment";
            this.Load += new System.EventHandler(this.Admin_Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_adminpayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private Guna.UI2.WinForms.Guna2Button btn_thanhtoan;
        private System.Windows.Forms.Label lb_sophong;
        private Guna.UI2.WinForms.Guna2TextBox txt_RoomNo;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_adminpayment;
        private System.Windows.Forms.Label lb_tieude;
        private Guna.UI2.WinForms.Guna2TextBox txt_Tienthanhtoan;
        private System.Windows.Forms.Label lb_tienthanhtoan;
    }
}