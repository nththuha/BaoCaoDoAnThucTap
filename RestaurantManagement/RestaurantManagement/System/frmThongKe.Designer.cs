
namespace RestaurantManagement
{
    partial class frmThongKe
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
            System.Windows.Forms.Label ngayBDLabel;
            System.Windows.Forms.Label ngayKTLabel;
            this.bdsThongKe = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.deNgayBD = new DevExpress.XtraEditors.DateEdit();
            this.deNgayKT = new DevExpress.XtraEditors.DateEdit();
            this.btn_XacNhan = new DevExpress.XtraEditors.SimpleButton();
            ngayBDLabel = new System.Windows.Forms.Label();
            ngayKTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ngayBDLabel
            // 
            ngayBDLabel.AutoSize = true;
            ngayBDLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayBDLabel.Location = new System.Drawing.Point(62, 139);
            ngayBDLabel.Name = "ngayBDLabel";
            ngayBDLabel.Size = new System.Drawing.Size(140, 27);
            ngayBDLabel.TabIndex = 1;
            ngayBDLabel.Text = "Ngày bắt đầu";
            // 
            // ngayKTLabel
            // 
            ngayKTLabel.AutoSize = true;
            ngayKTLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayKTLabel.Location = new System.Drawing.Point(62, 243);
            ngayKTLabel.Name = "ngayKTLabel";
            ngayKTLabel.Size = new System.Drawing.Size(147, 27);
            ngayKTLabel.TabIndex = 3;
            ngayKTLabel.Text = "Ngày kết thúc";
            // 
            // bdsThongKe
            // 
            this.bdsThongKe.DataSource = typeof(RestaurantManagement.Model.ThongKeModel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "THỐNG KÊ DOANH THU THEO THÁNG";
            // 
            // deNgayBD
            // 
            this.deNgayBD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsThongKe, "ngayBD", true));
            this.deNgayBD.EditValue = null;
            this.deNgayBD.Location = new System.Drawing.Point(284, 136);
            this.deNgayBD.Name = "deNgayBD";
            this.deNgayBD.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deNgayBD.Properties.Appearance.Options.UseFont = true;
            this.deNgayBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayBD.Size = new System.Drawing.Size(401, 32);
            this.deNgayBD.TabIndex = 6;
            // 
            // deNgayKT
            // 
            this.deNgayKT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsThongKe, "ngayKT", true));
            this.deNgayKT.EditValue = null;
            this.deNgayKT.Location = new System.Drawing.Point(284, 240);
            this.deNgayKT.Name = "deNgayKT";
            this.deNgayKT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deNgayKT.Properties.Appearance.Options.UseFont = true;
            this.deNgayKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayKT.Size = new System.Drawing.Size(401, 32);
            this.deNgayKT.TabIndex = 7;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhan.Appearance.Options.UseFont = true;
            this.btn_XacNhan.Location = new System.Drawing.Point(264, 340);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(194, 56);
            this.btn_XacNhan.TabIndex = 8;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.deNgayKT);
            this.Controls.Add(this.deNgayBD);
            this.Controls.Add(this.label1);
            this.Controls.Add(ngayKTLabel);
            this.Controls.Add(ngayBDLabel);
            this.Name = "frmThongKe";
            this.Text = "THỐNG KÊ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bdsThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsThongKe;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit deNgayBD;
        private DevExpress.XtraEditors.DateEdit deNgayKT;
        private DevExpress.XtraEditors.SimpleButton btn_XacNhan;
    }
}