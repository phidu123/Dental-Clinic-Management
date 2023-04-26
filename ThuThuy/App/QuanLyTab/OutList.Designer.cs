namespace ThuThuy.App
{
    partial class OutList
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
            this.pChecked = new System.Windows.Forms.FlowLayoutPanel();
            this.pUnchecked = new System.Windows.Forms.FlowLayoutPanel();
            this.bRe = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // pChecked
            // 
            this.pChecked.BackColor = System.Drawing.Color.MintCream;
            this.pChecked.Dock = System.Windows.Forms.DockStyle.Right;
            this.pChecked.Location = new System.Drawing.Point(745, 0);
            this.pChecked.Name = "pChecked";
            this.pChecked.Size = new System.Drawing.Size(700, 500);
            this.pChecked.TabIndex = 7;
            // 
            // pUnchecked
            // 
            this.pUnchecked.BackColor = System.Drawing.Color.MintCream;
            this.pUnchecked.Dock = System.Windows.Forms.DockStyle.Left;
            this.pUnchecked.Location = new System.Drawing.Point(0, 0);
            this.pUnchecked.Name = "pUnchecked";
            this.pUnchecked.Size = new System.Drawing.Size(700, 500);
            this.pUnchecked.TabIndex = 6;
            // 
            // bRe
            // 
            this.bRe.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.bRe.IconColor = System.Drawing.Color.Black;
            this.bRe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bRe.IconSize = 30;
            this.bRe.Location = new System.Drawing.Point(703, 223);
            this.bRe.Name = "bRe";
            this.bRe.Size = new System.Drawing.Size(40, 40);
            this.bRe.TabIndex = 8;
            this.bRe.UseVisualStyleBackColor = true;
            this.bRe.Click += new System.EventHandler(this.bRe_Click);
            // 
            // OutList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.bRe);
            this.Controls.Add(this.pChecked);
            this.Controls.Add(this.pUnchecked);
            this.Name = "OutList";
            this.Size = new System.Drawing.Size(1445, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pChecked;
        private System.Windows.Forms.FlowLayoutPanel pUnchecked;
        private FontAwesome.Sharp.IconButton bRe;
    }
}
