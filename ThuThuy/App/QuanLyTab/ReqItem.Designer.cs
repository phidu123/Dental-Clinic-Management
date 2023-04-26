namespace ThuThuy.App.QuanLyTab
{
    partial class ReqItem
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
            this.lbNVName = new System.Windows.Forms.Label();
            this.bCheck = new FontAwesome.Sharp.IconButton();
            this.lbItName = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNVName
            // 
            this.lbNVName.AutoSize = true;
            this.lbNVName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNVName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNVName.Location = new System.Drawing.Point(17, 12);
            this.lbNVName.Name = "lbNVName";
            this.lbNVName.Size = new System.Drawing.Size(133, 20);
            this.lbNVName.TabIndex = 0;
            this.lbNVName.Text = "Tên Nhân viên";
            // 
            // bCheck
            // 
            this.bCheck.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.bCheck.IconColor = System.Drawing.Color.DodgerBlue;
            this.bCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bCheck.IconSize = 30;
            this.bCheck.Location = new System.Drawing.Point(707, 3);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(40, 40);
            this.bCheck.TabIndex = 1;
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // lbItName
            // 
            this.lbItName.AutoSize = true;
            this.lbItName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbItName.Location = new System.Drawing.Point(343, 11);
            this.lbItName.Name = "lbItName";
            this.lbItName.Size = new System.Drawing.Size(129, 20);
            this.lbItName.TabIndex = 2;
            this.lbItName.Text = "Tên Vật Phẩm";
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNumber.Location = new System.Drawing.Point(523, 12);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(82, 20);
            this.lbNumber.TabIndex = 3;
            this.lbNumber.Text = "số lượng";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPrice.Location = new System.Drawing.Point(611, 12);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(90, 20);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "Tổng tiền";
            // 
            // ReqItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.lbItName);
            this.Controls.Add(this.bCheck);
            this.Controls.Add(this.lbNVName);
            this.Name = "ReqItem";
            this.Size = new System.Drawing.Size(750, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNVName;
        private FontAwesome.Sharp.IconButton bCheck;
        private System.Windows.Forms.Label lbItName;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label lbPrice;
    }
}
