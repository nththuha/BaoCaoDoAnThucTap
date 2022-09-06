
namespace RestaurantManagement
{
    partial class mesPhongBan
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
            this.lb_Tittle = new System.Windows.Forms.Label();
            this.btn_Phong = new System.Windows.Forms.Button();
            this.btn_Ban = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Tittle
            // 
            this.lb_Tittle.AutoSize = true;
            this.lb_Tittle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tittle.Location = new System.Drawing.Point(51, 46);
            this.lb_Tittle.Name = "lb_Tittle";
            this.lb_Tittle.Size = new System.Drawing.Size(322, 27);
            this.lb_Tittle.TabIndex = 0;
            this.lb_Tittle.Text = "Bạn muốn thêm phòng hay bàn?";
            // 
            // btn_Phong
            // 
            this.btn_Phong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Phong.Location = new System.Drawing.Point(56, 117);
            this.btn_Phong.Name = "btn_Phong";
            this.btn_Phong.Size = new System.Drawing.Size(115, 38);
            this.btn_Phong.TabIndex = 1;
            this.btn_Phong.Text = "Phòng";
            this.btn_Phong.UseVisualStyleBackColor = true;
            this.btn_Phong.Click += new System.EventHandler(this.btn_Phong_Click);
            // 
            // btn_Ban
            // 
            this.btn_Ban.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ban.Location = new System.Drawing.Point(244, 117);
            this.btn_Ban.Name = "btn_Ban";
            this.btn_Ban.Size = new System.Drawing.Size(115, 38);
            this.btn_Ban.TabIndex = 2;
            this.btn_Ban.Text = "Bàn";
            this.btn_Ban.UseVisualStyleBackColor = true;
            this.btn_Ban.Click += new System.EventHandler(this.btn_Ban_Click);
            // 
            // mesPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 198);
            this.Controls.Add(this.btn_Ban);
            this.Controls.Add(this.btn_Phong);
            this.Controls.Add(this.lb_Tittle);
            this.Name = "mesPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác nhận";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mesPhongBan_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Phong;
        private System.Windows.Forms.Button btn_Ban;
        public System.Windows.Forms.Label lb_Tittle;
    }
}