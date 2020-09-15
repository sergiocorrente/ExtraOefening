namespace ExtraOefening
{
    partial class oef2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOpenBestand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(80, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 173);
            this.listBox1.TabIndex = 0;
            // 
            // btnOpenBestand
            // 
            this.btnOpenBestand.Location = new System.Drawing.Point(60, 218);
            this.btnOpenBestand.Name = "btnOpenBestand";
            this.btnOpenBestand.Size = new System.Drawing.Size(108, 23);
            this.btnOpenBestand.TabIndex = 2;
            this.btnOpenBestand.Text = "Bestand openen";
            this.btnOpenBestand.UseVisualStyleBackColor = true;
            this.btnOpenBestand.Click += new System.EventHandler(this.btnOpenBestand_Click);
            // 
            // oef2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenBestand);
            this.Controls.Add(this.listBox1);
            this.Name = "oef2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOpenBestand;
    }
}