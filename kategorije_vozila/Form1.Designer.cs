namespace kategorije_vozila
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtGodinaproizvodnje = new System.Windows.Forms.TextBox();
            this.txtBrojkotaca = new System.Windows.Forms.TextBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtboxBrojKotača = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnObradi = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(165, 60);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(174, 26);
            this.txtModel.TabIndex = 0;
            this.txtModel.TextChanged += new System.EventHandler(this.txtboxModel_TextChanged);
            // 
            // txtGodinaproizvodnje
            // 
            this.txtGodinaproizvodnje.Location = new System.Drawing.Point(165, 124);
            this.txtGodinaproizvodnje.Name = "txtGodinaproizvodnje";
            this.txtGodinaproizvodnje.Size = new System.Drawing.Size(174, 26);
            this.txtGodinaproizvodnje.TabIndex = 1;
            // 
            // txtBrojkotaca
            // 
            this.txtBrojkotaca.Location = new System.Drawing.Point(165, 174);
            this.txtBrojkotaca.Name = "txtBrojkotaca";
            this.txtBrojkotaca.Size = new System.Drawing.Size(174, 26);
            this.txtBrojkotaca.TabIndex = 2;
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(420, 61);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(307, 184);
            this.txtIspis.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Godina proizvodnje";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(60, 188);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 20);
            this.linkLabel1.TabIndex = 6;
            // 
            // txtboxBrojKotača
            // 
            this.txtboxBrojKotača.AutoSize = true;
            this.txtboxBrojKotača.Location = new System.Drawing.Point(37, 188);
            this.txtboxBrojKotača.Name = "txtboxBrojKotača";
            this.txtboxBrojKotača.Size = new System.Drawing.Size(89, 20);
            this.txtboxBrojKotača.TabIndex = 7;
            this.txtboxBrojKotača.Text = "Broj kotača";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(41, 281);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(103, 31);
            this.btnUnesi.TabIndex = 8;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnObradi
            // 
            this.btnObradi.Location = new System.Drawing.Point(183, 281);
            this.btnObradi.Name = "btnObradi";
            this.btnObradi.Size = new System.Drawing.Size(96, 31);
            this.btnObradi.TabIndex = 9;
            this.btnObradi.Text = "Obradi";
            this.btnObradi.UseVisualStyleBackColor = true;
            this.btnObradi.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(332, 281);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(100, 31);
            this.btnIspis.TabIndex = 10;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnObradi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.txtboxBrojKotača);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.txtBrojkotaca);
            this.Controls.Add(this.txtGodinaproizvodnje);
            this.Controls.Add(this.txtModel);
            this.Name = "Form1";
            this.Text = "Kategorija Vozila";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtGodinaproizvodnje;
        private System.Windows.Forms.TextBox txtBrojkotaca;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label txtboxBrojKotača;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObradi;
        private System.Windows.Forms.Button btnIspis;
    }
}

