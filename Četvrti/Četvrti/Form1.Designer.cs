namespace Četvrti
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
            this.PoljeZaUnosprvog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GumbUnesi = new System.Windows.Forms.Button();
            this.Rezultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PoljeZaUnosprvog
            // 
            this.PoljeZaUnosprvog.Location = new System.Drawing.Point(242, 45);
            this.PoljeZaUnosprvog.Name = "PoljeZaUnosprvog";
            this.PoljeZaUnosprvog.Size = new System.Drawing.Size(100, 20);
            this.PoljeZaUnosprvog.TabIndex = 0;
            this.PoljeZaUnosprvog.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(136, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unesite prvi:";
            // 
            // GumbUnesi
            // 
            this.GumbUnesi.Location = new System.Drawing.Point(267, 215);
            this.GumbUnesi.Name = "GumbUnesi";
            this.GumbUnesi.Size = new System.Drawing.Size(75, 23);
            this.GumbUnesi.TabIndex = 8;
            this.GumbUnesi.Text = "Unesi";
            this.GumbUnesi.UseVisualStyleBackColor = true;
            this.GumbUnesi.Click += new System.EventHandler(this.GumbUnesi_Click);
            // 
            // Rezultat
            // 
            this.Rezultat.Location = new System.Drawing.Point(549, 117);
            this.Rezultat.Multiline = true;
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.Size = new System.Drawing.Size(199, 196);
            this.Rezultat.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rezultat);
            this.Controls.Add(this.GumbUnesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PoljeZaUnosprvog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PoljeZaUnosprvog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GumbUnesi;
        private System.Windows.Forms.TextBox Rezultat;
    }
}

