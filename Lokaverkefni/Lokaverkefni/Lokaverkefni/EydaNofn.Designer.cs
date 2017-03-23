namespace Lokaverkefni
{
    partial class EydaNofn
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
            this.btnJa = new System.Windows.Forms.Button();
            this.btnNei = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJa
            // 
            this.btnJa.Location = new System.Drawing.Point(25, 159);
            this.btnJa.Name = "btnJa";
            this.btnJa.Size = new System.Drawing.Size(75, 23);
            this.btnJa.TabIndex = 0;
            this.btnJa.Text = "Já";
            this.btnJa.UseVisualStyleBackColor = true;
            this.btnJa.Click += new System.EventHandler(this.btnJa_Click);
            // 
            // btnNei
            // 
            this.btnNei.Location = new System.Drawing.Point(176, 159);
            this.btnNei.Name = "btnNei";
            this.btnNei.Size = new System.Drawing.Size(75, 23);
            this.btnNei.TabIndex = 1;
            this.btnNei.Text = "Nei";
            this.btnNei.UseVisualStyleBackColor = true;
            this.btnNei.Click += new System.EventHandler(this.btnNei_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Viltu eyða öllum \r\ngögnum úr grunninum?\r\n";
            // 
            // EydaNofn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 255);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNei);
            this.Controls.Add(this.btnJa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EydaNofn";
            this.Text = "Eyða nöfnum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJa;
        private System.Windows.Forms.Button btnNei;
        private System.Windows.Forms.Label label1;
    }
}