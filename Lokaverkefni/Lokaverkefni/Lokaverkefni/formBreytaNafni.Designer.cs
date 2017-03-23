namespace Lokaverkefni
{
    partial class formBreytaNafni
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
            this.txtNafn = new System.Windows.Forms.TextBox();
            this.txtNyttNafn = new System.Windows.Forms.TextBox();
            this.txtTidni = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnBreyta = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNafn
            // 
            this.txtNafn.Location = new System.Drawing.Point(34, 36);
            this.txtNafn.Name = "txtNafn";
            this.txtNafn.Size = new System.Drawing.Size(100, 20);
            this.txtNafn.TabIndex = 0;
            // 
            // txtNyttNafn
            // 
            this.txtNyttNafn.Enabled = false;
            this.txtNyttNafn.Location = new System.Drawing.Point(34, 123);
            this.txtNyttNafn.Name = "txtNyttNafn";
            this.txtNyttNafn.Size = new System.Drawing.Size(100, 20);
            this.txtNyttNafn.TabIndex = 1;
            // 
            // txtTidni
            // 
            this.txtTidni.Enabled = false;
            this.txtTidni.Location = new System.Drawing.Point(161, 123);
            this.txtTidni.Name = "txtTidni";
            this.txtTidni.Size = new System.Drawing.Size(100, 20);
            this.txtTidni.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(161, 168);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnBreyta
            // 
            this.btnBreyta.Location = new System.Drawing.Point(161, 33);
            this.btnBreyta.Name = "btnBreyta";
            this.btnBreyta.Size = new System.Drawing.Size(75, 23);
            this.btnBreyta.TabIndex = 4;
            this.btnBreyta.Text = "Breyta";
            this.btnBreyta.UseVisualStyleBackColor = true;
            this.btnBreyta.Click += new System.EventHandler(this.btnBreyta_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(34, 168);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // formBreytaNafni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 217);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBreyta);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtTidni);
            this.Controls.Add(this.txtNyttNafn);
            this.Controls.Add(this.txtNafn);
            this.Name = "formBreytaNafni";
            this.Text = "Breyta Nafni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNafn;
        private System.Windows.Forms.TextBox txtNyttNafn;
        private System.Windows.Forms.TextBox txtTidni;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnBreyta;
        private System.Windows.Forms.Button btnClose;
    }
}