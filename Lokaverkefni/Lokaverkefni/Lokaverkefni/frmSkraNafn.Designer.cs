namespace Lokaverkefni
{
    partial class frmSkraNafn
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
            this.rBStrakur = new System.Windows.Forms.RadioButton();
            this.rBStelpa = new System.Windows.Forms.RadioButton();
            this.txtNafn = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTidni = new System.Windows.Forms.TextBox();
            this.txtEF = new System.Windows.Forms.TextBox();
            this.txtEF2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rBStrakur
            // 
            this.rBStrakur.AutoSize = true;
            this.rBStrakur.Location = new System.Drawing.Point(27, 29);
            this.rBStrakur.Name = "rBStrakur";
            this.rBStrakur.Size = new System.Drawing.Size(59, 17);
            this.rBStrakur.TabIndex = 0;
            this.rBStrakur.TabStop = true;
            this.rBStrakur.Text = "Strákur";
            this.rBStrakur.UseVisualStyleBackColor = true;
            // 
            // rBStelpa
            // 
            this.rBStelpa.AutoSize = true;
            this.rBStelpa.Location = new System.Drawing.Point(155, 29);
            this.rBStelpa.Name = "rBStelpa";
            this.rBStelpa.Size = new System.Drawing.Size(55, 17);
            this.rBStelpa.TabIndex = 1;
            this.rBStelpa.TabStop = true;
            this.rBStelpa.Text = "Stelpa";
            this.rBStelpa.UseVisualStyleBackColor = true;
            // 
            // txtNafn
            // 
            this.txtNafn.Location = new System.Drawing.Point(27, 71);
            this.txtNafn.Name = "txtNafn";
            this.txtNafn.Size = new System.Drawing.Size(142, 20);
            this.txtNafn.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(27, 153);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(135, 153);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTidni
            // 
            this.txtTidni.Location = new System.Drawing.Point(175, 71);
            this.txtTidni.Name = "txtTidni";
            this.txtTidni.Size = new System.Drawing.Size(35, 20);
            this.txtTidni.TabIndex = 5;
            // 
            // txtEF
            // 
            this.txtEF.Location = new System.Drawing.Point(27, 97);
            this.txtEF.Name = "txtEF";
            this.txtEF.Size = new System.Drawing.Size(142, 20);
            this.txtEF.TabIndex = 6;
            // 
            // txtEF2
            // 
            this.txtEF2.Location = new System.Drawing.Point(27, 123);
            this.txtEF2.Name = "txtEF2";
            this.txtEF2.Size = new System.Drawing.Size(142, 20);
            this.txtEF2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Eignarfall";
            // 
            // frmSkraNafn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 249);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEF2);
            this.Controls.Add(this.txtEF);
            this.Controls.Add(this.txtTidni);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNafn);
            this.Controls.Add(this.rBStelpa);
            this.Controls.Add(this.rBStrakur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSkraNafn";
            this.Text = "Skrá Nafn";
            this.Load += new System.EventHandler(this.frmSkraNafn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBStrakur;
        private System.Windows.Forms.RadioButton rBStelpa;
        private System.Windows.Forms.TextBox txtNafn;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtTidni;
        private System.Windows.Forms.TextBox txtEF;
        private System.Windows.Forms.TextBox txtEF2;
        private System.Windows.Forms.Label label1;
    }
}