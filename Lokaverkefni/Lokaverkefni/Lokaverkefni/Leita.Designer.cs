namespace Lokaverkefni
{
    partial class Leita
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
            this.rBID = new System.Windows.Forms.RadioButton();
            this.rBNafn = new System.Windows.Forms.RadioButton();
            this.rBKT = new System.Windows.Forms.RadioButton();
            this.rBHeimilisfang = new System.Windows.Forms.RadioButton();
            this.rBPostnr = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtLeita = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rBID
            // 
            this.rBID.AutoSize = true;
            this.rBID.Location = new System.Drawing.Point(88, 39);
            this.rBID.Name = "rBID";
            this.rBID.Size = new System.Drawing.Size(36, 17);
            this.rBID.TabIndex = 0;
            this.rBID.TabStop = true;
            this.rBID.Text = "ID";
            this.rBID.UseVisualStyleBackColor = true;
            // 
            // rBNafn
            // 
            this.rBNafn.AutoSize = true;
            this.rBNafn.Location = new System.Drawing.Point(188, 62);
            this.rBNafn.Name = "rBNafn";
            this.rBNafn.Size = new System.Drawing.Size(48, 17);
            this.rBNafn.TabIndex = 1;
            this.rBNafn.TabStop = true;
            this.rBNafn.Text = "Nafn";
            this.rBNafn.UseVisualStyleBackColor = true;
            // 
            // rBKT
            // 
            this.rBKT.AutoSize = true;
            this.rBKT.Location = new System.Drawing.Point(88, 62);
            this.rBKT.Name = "rBKT";
            this.rBKT.Size = new System.Drawing.Size(69, 17);
            this.rBKT.TabIndex = 2;
            this.rBKT.TabStop = true;
            this.rBKT.Text = "Kennitala";
            this.rBKT.UseVisualStyleBackColor = true;
            // 
            // rBHeimilisfang
            // 
            this.rBHeimilisfang.AutoSize = true;
            this.rBHeimilisfang.Location = new System.Drawing.Point(88, 85);
            this.rBHeimilisfang.Name = "rBHeimilisfang";
            this.rBHeimilisfang.Size = new System.Drawing.Size(81, 17);
            this.rBHeimilisfang.TabIndex = 3;
            this.rBHeimilisfang.TabStop = true;
            this.rBHeimilisfang.Text = "Heimilisfang";
            this.rBHeimilisfang.UseVisualStyleBackColor = true;
            // 
            // rBPostnr
            // 
            this.rBPostnr.AutoSize = true;
            this.rBPostnr.Location = new System.Drawing.Point(188, 85);
            this.rBPostnr.Name = "rBPostnr";
            this.rBPostnr.Size = new System.Drawing.Size(75, 17);
            this.rBPostnr.TabIndex = 4;
            this.rBPostnr.TabStop = true;
            this.rBPostnr.Text = "Póstnúmer";
            this.rBPostnr.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(77, 230);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtLeita
            // 
            this.txtLeita.Location = new System.Drawing.Point(43, 166);
            this.txtLeita.Name = "txtLeita";
            this.txtLeita.Size = new System.Drawing.Size(267, 20);
            this.txtLeita.TabIndex = 6;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(214, 230);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 298);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(267, 219);
            this.textBox1.TabIndex = 8;
            // 
            // Leita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 529);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtLeita);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rBPostnr);
            this.Controls.Add(this.rBHeimilisfang);
            this.Controls.Add(this.rBKT);
            this.Controls.Add(this.rBNafn);
            this.Controls.Add(this.rBID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Leita";
            this.Text = "Leita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBID;
        private System.Windows.Forms.RadioButton rBNafn;
        private System.Windows.Forms.RadioButton rBKT;
        private System.Windows.Forms.RadioButton rBHeimilisfang;
        private System.Windows.Forms.RadioButton rBPostnr;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtLeita;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textBox1;
    }
}