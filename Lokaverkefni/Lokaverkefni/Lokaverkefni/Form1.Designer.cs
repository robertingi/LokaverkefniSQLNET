namespace Lokaverkefni
{
    partial class Form1
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
            this.btnSkraNofn = new System.Windows.Forms.Button();
            this.btnSkodaNofn = new System.Windows.Forms.Button();
            this.lblAdgerd = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.btnEydaNofn = new System.Windows.Forms.Button();
            this.btnLeita = new System.Windows.Forms.Button();
            this.btnNafn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSkraNofn
            // 
            this.btnSkraNofn.Location = new System.Drawing.Point(36, 95);
            this.btnSkraNofn.Name = "btnSkraNofn";
            this.btnSkraNofn.Size = new System.Drawing.Size(82, 70);
            this.btnSkraNofn.TabIndex = 0;
            this.btnSkraNofn.Text = "Skrá nöfn";
            this.btnSkraNofn.UseVisualStyleBackColor = true;
            this.btnSkraNofn.Click += new System.EventHandler(this.btnSkraNofn_Click);
            // 
            // btnSkodaNofn
            // 
            this.btnSkodaNofn.Location = new System.Drawing.Point(151, 95);
            this.btnSkodaNofn.Name = "btnSkodaNofn";
            this.btnSkodaNofn.Size = new System.Drawing.Size(82, 70);
            this.btnSkodaNofn.TabIndex = 1;
            this.btnSkodaNofn.Text = "Skoða nöfn";
            this.btnSkodaNofn.UseVisualStyleBackColor = true;
            this.btnSkodaNofn.Click += new System.EventHandler(this.btnSkodaNofn_Click);
            // 
            // lblAdgerd
            // 
            this.lblAdgerd.AutoSize = true;
            this.lblAdgerd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdgerd.Location = new System.Drawing.Point(45, 26);
            this.lblAdgerd.Name = "lblAdgerd";
            this.lblAdgerd.Size = new System.Drawing.Size(174, 31);
            this.lblAdgerd.TabIndex = 2;
            this.lblAdgerd.Text = "Veldu aðgerð";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(119, 209);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 13);
            this.lblText.TabIndex = 3;
            // 
            // btnEydaNofn
            // 
            this.btnEydaNofn.Location = new System.Drawing.Point(36, 179);
            this.btnEydaNofn.Name = "btnEydaNofn";
            this.btnEydaNofn.Size = new System.Drawing.Size(82, 70);
            this.btnEydaNofn.TabIndex = 4;
            this.btnEydaNofn.Text = "Eyða nöfnum";
            this.btnEydaNofn.UseVisualStyleBackColor = true;
            this.btnEydaNofn.Click += new System.EventHandler(this.btnEydaNofn_Click);
            // 
            // btnLeita
            // 
            this.btnLeita.Location = new System.Drawing.Point(151, 179);
            this.btnLeita.Name = "btnLeita";
            this.btnLeita.Size = new System.Drawing.Size(82, 70);
            this.btnLeita.TabIndex = 5;
            this.btnLeita.Text = "Leita";
            this.btnLeita.UseVisualStyleBackColor = true;
            this.btnLeita.Click += new System.EventHandler(this.btnLeita_Click);
            // 
            // btnNafn
            // 
            this.btnNafn.Location = new System.Drawing.Point(255, 180);
            this.btnNafn.Name = "btnNafn";
            this.btnNafn.Size = new System.Drawing.Size(82, 70);
            this.btnNafn.TabIndex = 6;
            this.btnNafn.Text = "Nöfn";
            this.btnNafn.UseVisualStyleBackColor = true;
            this.btnNafn.Click += new System.EventHandler(this.btnNafn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(361, 296);
            this.Controls.Add(this.btnNafn);
            this.Controls.Add(this.btnLeita);
            this.Controls.Add(this.btnEydaNofn);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblAdgerd);
            this.Controls.Add(this.btnSkodaNofn);
            this.Controls.Add(this.btnSkraNofn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gagnagrunnur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSkraNofn;
        private System.Windows.Forms.Button btnSkodaNofn;
        private System.Windows.Forms.Label lblAdgerd;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnEydaNofn;
        private System.Windows.Forms.Button btnLeita;
        private System.Windows.Forms.Button btnNafn;

    }
}

