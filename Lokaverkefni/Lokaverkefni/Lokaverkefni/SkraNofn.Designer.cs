namespace Lokaverkefni
{
    partial class SkraNofn
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
            this.btnSkra = new System.Windows.Forms.Button();
            this.txtKK = new System.Windows.Forms.TextBox();
            this.txtAldurMin = new System.Windows.Forms.TextBox();
            this.txtAldurMax = new System.Windows.Forms.TextBox();
            this.lblFjoldiKK = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtKVK = new System.Windows.Forms.TextBox();
            this.lblFjoldiKVK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSkra
            // 
            this.btnSkra.Location = new System.Drawing.Point(188, 9);
            this.btnSkra.Name = "btnSkra";
            this.btnSkra.Size = new System.Drawing.Size(75, 53);
            this.btnSkra.TabIndex = 0;
            this.btnSkra.Text = "Skrá";
            this.btnSkra.UseVisualStyleBackColor = true;
            this.btnSkra.Click += new System.EventHandler(this.btnSkra_Click);
            // 
            // txtKK
            // 
            this.txtKK.Location = new System.Drawing.Point(28, 32);
            this.txtKK.Name = "txtKK";
            this.txtKK.Size = new System.Drawing.Size(41, 20);
            this.txtKK.TabIndex = 1;
            // 
            // txtAldurMin
            // 
            this.txtAldurMin.Location = new System.Drawing.Point(28, 78);
            this.txtAldurMin.Name = "txtAldurMin";
            this.txtAldurMin.Size = new System.Drawing.Size(41, 20);
            this.txtAldurMin.TabIndex = 2;
            // 
            // txtAldurMax
            // 
            this.txtAldurMax.Location = new System.Drawing.Point(95, 78);
            this.txtAldurMax.Name = "txtAldurMax";
            this.txtAldurMax.Size = new System.Drawing.Size(41, 20);
            this.txtAldurMax.TabIndex = 3;
            // 
            // lblFjoldiKK
            // 
            this.lblFjoldiKK.AutoSize = true;
            this.lblFjoldiKK.Location = new System.Drawing.Point(25, 9);
            this.lblFjoldiKK.Name = "lblFjoldiKK";
            this.lblFjoldiKK.Size = new System.Drawing.Size(57, 13);
            this.lblFjoldiKK.TabIndex = 4;
            this.lblFjoldiKK.Text = "Fjöldi karla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Á aldrinum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "til";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(188, 75);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtKVK
            // 
            this.txtKVK.Location = new System.Drawing.Point(95, 32);
            this.txtKVK.Name = "txtKVK";
            this.txtKVK.Size = new System.Drawing.Size(41, 20);
            this.txtKVK.TabIndex = 8;
            // 
            // lblFjoldiKVK
            // 
            this.lblFjoldiKVK.AutoSize = true;
            this.lblFjoldiKVK.Location = new System.Drawing.Point(92, 9);
            this.lblFjoldiKVK.Name = "lblFjoldiKVK";
            this.lblFjoldiKVK.Size = new System.Drawing.Size(70, 13);
            this.lblFjoldiKVK.TabIndex = 9;
            this.lblFjoldiKVK.Text = "Fjöldi kvenna";
            // 
            // SkraNofn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 123);
            this.Controls.Add(this.lblFjoldiKVK);
            this.Controls.Add(this.txtKVK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFjoldiKK);
            this.Controls.Add(this.txtAldurMax);
            this.Controls.Add(this.txtAldurMin);
            this.Controls.Add(this.txtKK);
            this.Controls.Add(this.btnSkra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SkraNofn";
            this.Text = "Skrá Nöfn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSkra;
        private System.Windows.Forms.TextBox txtKK;
        private System.Windows.Forms.TextBox txtAldurMin;
        private System.Windows.Forms.TextBox txtAldurMax;
        private System.Windows.Forms.Label lblFjoldiKK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtKVK;
        private System.Windows.Forms.Label lblFjoldiKVK;
    }
}