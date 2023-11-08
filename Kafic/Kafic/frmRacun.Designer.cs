namespace Kafic
{
    partial class frmRacun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRacun));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKonobarIme = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsbPonuda = new System.Windows.Forms.ListBox();
            this.lsbRacun = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnIzdajRacun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kafic.Properties.Resources.konobar;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblKonobarIme
            // 
            this.lblKonobarIme.AutoSize = true;
            this.lblKonobarIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKonobarIme.Location = new System.Drawing.Point(178, 125);
            this.lblKonobarIme.Name = "lblKonobarIme";
            this.lblKonobarIme.Size = new System.Drawing.Size(207, 37);
            this.lblKonobarIme.TabIndex = 1;
            this.lblKonobarIme.Text = "Ime i prezime";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDodaj, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUkloni, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnIzdajRacun, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 180);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(697, 456);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsbPonuda);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(307, 404);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ponuda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsbRacun);
            this.groupBox2.Location = new System.Drawing.Point(385, 3);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(309, 404);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Račun";
            // 
            // lsbPonuda
            // 
            this.lsbPonuda.FormattingEnabled = true;
            this.lsbPonuda.ItemHeight = 20;
            this.lsbPonuda.Location = new System.Drawing.Point(6, 25);
            this.lsbPonuda.Name = "lsbPonuda";
            this.lsbPonuda.Size = new System.Drawing.Size(301, 364);
            this.lsbPonuda.TabIndex = 0;
            // 
            // lsbRacun
            // 
            this.lsbRacun.FormattingEnabled = true;
            this.lsbRacun.ItemHeight = 20;
            this.lsbRacun.Location = new System.Drawing.Point(0, 25);
            this.lsbRacun.Name = "lsbRacun";
            this.lsbRacun.Size = new System.Drawing.Size(309, 364);
            this.lsbRacun.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDodaj.Location = new System.Drawing.Point(316, 162);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(63, 40);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = ">>";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUkloni
            // 
            this.btnUkloni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUkloni.Location = new System.Drawing.Point(316, 208);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(63, 45);
            this.btnUkloni.TabIndex = 3;
            this.btnUkloni.Text = "<<";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnIzdajRacun
            // 
            this.btnIzdajRacun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnIzdajRacun, 3);
            this.btnIzdajRacun.Location = new System.Drawing.Point(282, 413);
            this.btnIzdajRacun.Name = "btnIzdajRacun";
            this.btnIzdajRacun.Size = new System.Drawing.Size(132, 40);
            this.btnIzdajRacun.TabIndex = 4;
            this.btnIzdajRacun.Text = "Izdaj račun";
            this.btnIzdajRacun.UseVisualStyleBackColor = true;
            this.btnIzdajRacun.Click += new System.EventHandler(this.btnIzdajRacun_Click);
            // 
            // frmRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 648);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblKonobarIme);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRacun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Račun - ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblKonobarIme;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lsbPonuda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lsbRacun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnIzdajRacun;
    }
}