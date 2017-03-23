namespace Lokaverkefni
{
    partial class frmEydaNafni
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
            this.rBStrakar = new System.Windows.Forms.RadioButton();
            this.rBStelpur = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtEyda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rBStrakar
            // 
            this.rBStrakar.AutoSize = true;
            this.rBStrakar.Location = new System.Drawing.Point(39, 12);
            this.rBStrakar.Name = "rBStrakar";
            this.rBStrakar.Size = new System.Drawing.Size(59, 17);
            this.rBStrakar.TabIndex = 0;
            this.rBStrakar.TabStop = true;
            this.rBStrakar.Text = "Strákur";
            this.rBStrakar.UseVisualStyleBackColor = true;
            // 
            // rBStelpur
            // 
            this.rBStelpur.AutoSize = true;
            this.rBStelpur.Location = new System.Drawing.Point(39, 35);
            this.rBStelpur.Name = "rBStelpur";
            this.rBStelpur.Size = new System.Drawing.Size(55, 17);
            this.rBStelpur.TabIndex = 1;
            this.rBStelpur.TabStop = true;
            this.rBStelpur.Text = "Stelpa";
            this.rBStelpur.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(39, 130);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(157, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtEyda
            // 
            this.txtEyda.Location = new System.Drawing.Point(39, 80);
            this.txtEyda.Name = "txtEyda";
            this.txtEyda.Size = new System.Drawing.Size(100, 20);
            this.txtEyda.TabIndex = 4;
            // 
            // frmEydaNafni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 186);
            this.Controls.Add(this.txtEyda);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rBStelpur);
            this.Controls.Add(this.rBStrakar);
            this.Name = "frmEydaNafni";
            this.Text = "Eyða Nafni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBStrakar;
        private System.Windows.Forms.RadioButton rBStelpur;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtEyda;
    }
}