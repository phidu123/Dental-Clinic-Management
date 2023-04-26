namespace ThuThuy.App.QuanLyTab
{
    partial class Kho
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelList = new Guna.UI2.WinForms.Guna2Panel();
            this.listKho = new Guna.UI2.WinForms.Guna2Button();
            this.listOrder = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // panelList
            // 
            this.panelList.BackColor = System.Drawing.Color.AliceBlue;
            this.panelList.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.panelList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelList.Location = new System.Drawing.Point(0, 0);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(1545, 500);
            this.panelList.TabIndex = 0;
            // 
            // listKho
            // 
            this.listKho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.listKho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.listKho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.listKho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.listKho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listKho.ForeColor = System.Drawing.Color.White;
            this.listKho.Location = new System.Drawing.Point(398, 550);
            this.listKho.Name = "listKho";
            this.listKho.Size = new System.Drawing.Size(198, 45);
            this.listKho.TabIndex = 1;
            this.listKho.Text = "Xem danh sách kho";
            this.listKho.Click += new System.EventHandler(this.listKho_Click);
            // 
            // listOrder
            // 
            this.listOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.listOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.listOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.listOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.listOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listOrder.ForeColor = System.Drawing.Color.White;
            this.listOrder.Location = new System.Drawing.Point(963, 550);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(194, 45);
            this.listOrder.TabIndex = 2;
            this.listOrder.Text = "Danh sách yêu cầu mua";
            this.listOrder.Click += new System.EventHandler(this.listOrder_Click);
            // 
            // Kho
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Blue;
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.listKho);
            this.Controls.Add(this.panelList);
            this.Name = "Kho";
            this.Size = new System.Drawing.Size(1545, 650);
            this.Load += new System.EventHandler(this.Kho_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelList;
        private Guna.UI2.WinForms.Guna2Button listKho;
        private Guna.UI2.WinForms.Guna2Button listOrder;
    }
}
