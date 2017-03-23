namespace Lokaverkefni
{
    partial class formNafn
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStrakar = new System.Windows.Forms.Button();
            this.btnStelpur = new System.Windows.Forms.Button();
            this.btnEydaNafni = new System.Windows.Forms.Button();
            this.btnFaNofn = new System.Windows.Forms.Button();
            this.btnSkraNafn = new System.Windows.Forms.Button();
            this.btnBreytaNafni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(491, 375);
            this.textBox1.TabIndex = 0;
            // 
            // btnStrakar
            // 
            this.btnStrakar.Location = new System.Drawing.Point(509, 42);
            this.btnStrakar.Name = "btnStrakar";
            this.btnStrakar.Size = new System.Drawing.Size(75, 23);
            this.btnStrakar.TabIndex = 1;
            this.btnStrakar.Text = "Strákar";
            this.btnStrakar.UseVisualStyleBackColor = true;
            this.btnStrakar.Click += new System.EventHandler(this.btnStrakar_Click);
            // 
            // btnStelpur
            // 
            this.btnStelpur.Location = new System.Drawing.Point(509, 13);
            this.btnStelpur.Name = "btnStelpur";
            this.btnStelpur.Size = new System.Drawing.Size(75, 23);
            this.btnStelpur.TabIndex = 2;
            this.btnStelpur.Text = "Stelpur";
            this.btnStelpur.UseVisualStyleBackColor = true;
            this.btnStelpur.Click += new System.EventHandler(this.btnStelpur_Click);
            // 
            // btnEydaNafni
            // 
            this.btnEydaNafni.Location = new System.Drawing.Point(509, 132);
            this.btnEydaNafni.Name = "btnEydaNafni";
            this.btnEydaNafni.Size = new System.Drawing.Size(75, 23);
            this.btnEydaNafni.TabIndex = 3;
            this.btnEydaNafni.Text = "Eyða nafni";
            this.btnEydaNafni.UseVisualStyleBackColor = true;
            this.btnEydaNafni.Click += new System.EventHandler(this.btnEydaNafni_Click);
            // 
            // btnFaNofn
            // 
            this.btnFaNofn.Location = new System.Drawing.Point(470, 432);
            this.btnFaNofn.Name = "btnFaNofn";
            this.btnFaNofn.Size = new System.Drawing.Size(114, 23);
            this.btnFaNofn.TabIndex = 4;
            this.btnFaNofn.Text = "Endurstilla nöfn";
            this.btnFaNofn.UseVisualStyleBackColor = true;
            this.btnFaNofn.Click += new System.EventHandler(this.btnFaNofn_Click);
            // 
            // btnSkraNafn
            // 
            this.btnSkraNafn.Location = new System.Drawing.Point(509, 161);
            this.btnSkraNafn.Name = "btnSkraNafn";
            this.btnSkraNafn.Size = new System.Drawing.Size(75, 23);
            this.btnSkraNafn.TabIndex = 5;
            this.btnSkraNafn.Text = "Skrá Nafn";
            this.btnSkraNafn.UseVisualStyleBackColor = true;
            this.btnSkraNafn.Click += new System.EventHandler(this.btnSkraNafn_Click);
            // 
            // btnBreytaNafni
            // 
            this.btnBreytaNafni.Location = new System.Drawing.Point(509, 190);
            this.btnBreytaNafni.Name = "btnBreytaNafni";
            this.btnBreytaNafni.Size = new System.Drawing.Size(75, 23);
            this.btnBreytaNafni.TabIndex = 6;
            this.btnBreytaNafni.Text = "Breyta Nafni";
            this.btnBreytaNafni.UseVisualStyleBackColor = true;
            this.btnBreytaNafni.Click += new System.EventHandler(this.btnBreytaNafni_Click);
            // 
            // formNafn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 480);
            this.Controls.Add(this.btnBreytaNafni);
            this.Controls.Add(this.btnSkraNafn);
            this.Controls.Add(this.btnFaNofn);
            this.Controls.Add(this.btnEydaNafni);
            this.Controls.Add(this.btnStelpur);
            this.Controls.Add(this.btnStrakar);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formNafn";
            this.Text = "Nöfn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStrakar;
        private System.Windows.Forms.Button btnStelpur;
        private System.Windows.Forms.Button btnEydaNafni;
        private System.Windows.Forms.Button btnFaNofn;
        private System.Windows.Forms.Button btnSkraNafn;
        private System.Windows.Forms.Button btnBreytaNafni;
    }
}