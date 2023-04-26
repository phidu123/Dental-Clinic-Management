namespace ThuThuy.App.QuanLyTab
{
    partial class registerItem
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.Label();
            this.bDel = new FontAwesome.Sharp.IconButton();
            this.bSet = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbName.Location = new System.Drawing.Point(19, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(78, 29);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucVu.ForeColor = System.Drawing.SystemColors.Control;
            this.lbChucVu.Location = new System.Drawing.Point(456, 12);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(74, 29);
            this.lbChucVu.TabIndex = 1;
            this.lbChucVu.Text = "Place";
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lbNumber.Location = new System.Drawing.Point(670, 12);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(100, 29);
            this.lbNumber.TabIndex = 2;
            this.lbNumber.Text = "Number";
            // 
            // bDel
            // 
            this.bDel.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.bDel.IconColor = System.Drawing.Color.Black;
            this.bDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bDel.Location = new System.Drawing.Point(930, 0);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(50, 50);
            this.bDel.TabIndex = 3;
            this.bDel.UseVisualStyleBackColor = true;
            // 
            // bSet
            // 
            this.bSet.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.bSet.IconColor = System.Drawing.Color.Black;
            this.bSet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bSet.Location = new System.Drawing.Point(880, 0);
            this.bSet.Name = "bSet";
            this.bSet.Size = new System.Drawing.Size(50, 50);
            this.bSet.TabIndex = 4;
            this.bSet.UseVisualStyleBackColor = true;
            this.bSet.Click += new System.EventHandler(this.bSet_Click);
            // 
            // registerItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.bSet);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.lbChucVu);
            this.Controls.Add(this.lbName);
            this.Name = "registerItem";
            this.Size = new System.Drawing.Size(976, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label lbNumber;
        private FontAwesome.Sharp.IconButton bDel;
        private FontAwesome.Sharp.IconButton bSet;
    }
}
