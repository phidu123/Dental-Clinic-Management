namespace ThuThuy.App.QuanLyTab
{
    partial class ItemsKho
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
            this.name = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.dateUp = new System.Windows.Forms.Label();
            this.dateRequest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Snow;
            this.name.Location = new System.Drawing.Point(21, 4);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(109, 23);
            this.name.TabIndex = 0;
            this.name.Text = "Tên Vật tư";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.ForeColor = System.Drawing.SystemColors.Control;
            this.number.Location = new System.Drawing.Point(285, 4);
            this.number.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(34, 23);
            this.number.TabIndex = 1;
            this.number.Text = "00";
            // 
            // dateUp
            // 
            this.dateUp.AutoSize = true;
            this.dateUp.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateUp.ForeColor = System.Drawing.SystemColors.Control;
            this.dateUp.Location = new System.Drawing.Point(527, 4);
            this.dateUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateUp.Name = "dateUp";
            this.dateUp.Size = new System.Drawing.Size(152, 23);
            this.dateUp.TabIndex = 2;
            this.dateUp.Text = "Ngày Cập Nhật";
            // 
            // dateRequest
            // 
            this.dateRequest.AutoSize = true;
            this.dateRequest.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRequest.ForeColor = System.Drawing.SystemColors.Control;
            this.dateRequest.Location = new System.Drawing.Point(848, 4);
            this.dateRequest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateRequest.Name = "dateRequest";
            this.dateRequest.Size = new System.Drawing.Size(268, 23);
            this.dateRequest.TabIndex = 3;
            this.dateRequest.Text = "TÊN NHÂN VIÊN CẬP NHẬT";
            // 
            // ItemsKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.dateRequest);
            this.Controls.Add(this.dateUp);
            this.Controls.Add(this.number);
            this.Controls.Add(this.name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ItemsKho";
            this.Size = new System.Drawing.Size(1152, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label dateUp;
        private System.Windows.Forms.Label dateRequest;
    }
}
