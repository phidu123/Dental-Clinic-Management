namespace ThuThuy.App.QuanLyTab
{
    partial class OutItem
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
            this.lbItemName = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.Label();
            this.bCheck = new FontAwesome.Sharp.IconButton();
            this.lbDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNVName
            // 
            this.lbNVName.AutoSize = true;
            this.lbNVName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNVName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNVName.Location = new System.Drawing.Point(24, 14);
            this.lbNVName.Name = "lbNVName";
            this.lbNVName.Size = new System.Drawing.Size(85, 18);
            this.lbNVName.TabIndex = 1;
            this.lbNVName.Text = "Tên Bác Sĩ";
            // 
            // lbItemName
            // 
            this.lbItemName.AutoSize = true;
            this.lbItemName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbItemName.Location = new System.Drawing.Point(205, 14);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(112, 18);
            this.lbItemName.TabIndex = 2;
            this.lbItemName.Text = "Tên Vật Phẩm";
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNumber.Location = new System.Drawing.Point(390, 14);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(74, 18);
            this.lbNumber.TabIndex = 3;
            this.lbNumber.Text = "Số lượng";
            // 
            // bCheck
            // 
            this.bCheck.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.bCheck.IconColor = System.Drawing.Color.DodgerBlue;
            this.bCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bCheck.IconSize = 30;
            this.bCheck.Location = new System.Drawing.Point(635, 4);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(40, 40);
            this.bCheck.TabIndex = 4;
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDate.Location = new System.Drawing.Point(470, 14);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(84, 18);
            this.lbDate.TabIndex = 5;
            this.lbDate.Text = "Ngày xuất";
            // 
            // OutItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.bCheck);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.lbItemName);
            this.Controls.Add(this.lbNVName);
            this.Name = "OutItem";
            this.Size = new System.Drawing.Size(700, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNVName;
        private System.Windows.Forms.Label lbItemName;
        private System.Windows.Forms.Label lbNumber;
        private FontAwesome.Sharp.IconButton bCheck;
        private System.Windows.Forms.Label lbDate;
    }
}
