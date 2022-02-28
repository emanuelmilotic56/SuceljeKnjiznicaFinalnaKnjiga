namespace SučeljeZaEvidencijuKnjiga_EM
{
    partial class PočetniZaslon
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
            this.btnUpisKorisnika = new System.Windows.Forms.Button();
            this.btnUpisKnjiga = new System.Windows.Forms.Button();
            this.btnUpisStanjaKnjiga = new System.Windows.Forms.Button();
            this.btnPregled = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpisKorisnika
            // 
            this.btnUpisKorisnika.Location = new System.Drawing.Point(12, 102);
            this.btnUpisKorisnika.Name = "btnUpisKorisnika";
            this.btnUpisKorisnika.Size = new System.Drawing.Size(214, 177);
            this.btnUpisKorisnika.TabIndex = 0;
            this.btnUpisKorisnika.Text = "Upis korisnika";
            this.btnUpisKorisnika.UseVisualStyleBackColor = true;
            this.btnUpisKorisnika.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpisKnjiga
            // 
            this.btnUpisKnjiga.Location = new System.Drawing.Point(261, 102);
            this.btnUpisKnjiga.Name = "btnUpisKnjiga";
            this.btnUpisKnjiga.Size = new System.Drawing.Size(213, 177);
            this.btnUpisKnjiga.TabIndex = 1;
            this.btnUpisKnjiga.Text = "Upis knjiga";
            this.btnUpisKnjiga.UseVisualStyleBackColor = true;
            this.btnUpisKnjiga.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpisStanjaKnjiga
            // 
            this.btnUpisStanjaKnjiga.Location = new System.Drawing.Point(513, 102);
            this.btnUpisStanjaKnjiga.Name = "btnUpisStanjaKnjiga";
            this.btnUpisStanjaKnjiga.Size = new System.Drawing.Size(258, 177);
            this.btnUpisStanjaKnjiga.TabIndex = 2;
            this.btnUpisStanjaKnjiga.Text = "Nova posudba";
            this.btnUpisStanjaKnjiga.UseVisualStyleBackColor = true;
            this.btnUpisStanjaKnjiga.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPregled
            // 
            this.btnPregled.Location = new System.Drawing.Point(817, 102);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(230, 177);
            this.btnPregled.TabIndex = 3;
            this.btnPregled.Text = "Pregled";
            this.btnPregled.UseVisualStyleBackColor = true;
            this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // PočetniZaslon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 450);
            this.Controls.Add(this.btnPregled);
            this.Controls.Add(this.btnUpisStanjaKnjiga);
            this.Controls.Add(this.btnUpisKnjiga);
            this.Controls.Add(this.btnUpisKorisnika);
            this.Name = "PočetniZaslon";
            this.Text = "PočetniZaslon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpisKorisnika;
        private System.Windows.Forms.Button btnUpisKnjiga;
        private System.Windows.Forms.Button btnUpisStanjaKnjiga;
        private System.Windows.Forms.Button btnPregled;
    }
}