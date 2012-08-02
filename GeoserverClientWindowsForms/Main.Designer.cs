namespace GeoserverClientWindowsForms
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.tbHuisnummer = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbToevoeging = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbAdres = new System.Windows.Forms.RadioButton();
            this.rdbGebouw = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(692, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vuur!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-7, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Postcode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-7, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Huisnummer:";
            // 
            // tbPostcode
            // 
            this.tbPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostcode.Location = new System.Drawing.Point(280, 76);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(424, 55);
            this.tbPostcode.TabIndex = 3;
            this.tbPostcode.Text = "1079MB";
            // 
            // tbHuisnummer
            // 
            this.tbHuisnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHuisnummer.Location = new System.Drawing.Point(280, 168);
            this.tbHuisnummer.Name = "tbHuisnummer";
            this.tbHuisnummer.Size = new System.Drawing.Size(424, 55);
            this.tbHuisnummer.TabIndex = 4;
            this.tbHuisnummer.Text = "1";
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResult.Location = new System.Drawing.Point(20, 559);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(692, 55);
            this.tbResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultaat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-7, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "Toevoeging:";
            // 
            // tbToevoeging
            // 
            this.tbToevoeging.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbToevoeging.Location = new System.Drawing.Point(280, 254);
            this.tbToevoeging.Name = "tbToevoeging";
            this.tbToevoeging.Size = new System.Drawing.Size(424, 55);
            this.tbToevoeging.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(431, 48);
            this.label5.TabIndex = 9;
            this.label5.Text = "Zoek in AGN op adres";
            // 
            // rdbAdres
            // 
            this.rdbAdres.AutoSize = true;
            this.rdbAdres.Checked = true;
            this.rdbAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdres.Location = new System.Drawing.Point(86, 24);
            this.rdbAdres.Name = "rdbAdres";
            this.rdbAdres.Size = new System.Drawing.Size(145, 52);
            this.rdbAdres.TabIndex = 10;
            this.rdbAdres.TabStop = true;
            this.rdbAdres.Text = "adres";
            this.rdbAdres.UseVisualStyleBackColor = true;
            // 
            // rdbGebouw
            // 
            this.rdbGebouw.AutoSize = true;
            this.rdbGebouw.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGebouw.Location = new System.Drawing.Point(368, 24);
            this.rdbGebouw.Name = "rdbGebouw";
            this.rdbGebouw.Size = new System.Drawing.Size(186, 52);
            this.rdbGebouw.TabIndex = 11;
            this.rdbGebouw.Text = "gebouw";
            this.rdbGebouw.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbGebouw);
            this.groupBox1.Controls.Add(this.rdbAdres);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 82);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 626);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbToevoeging);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbHuisnummer);
            this.Controls.Add(this.tbPostcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "AGN adres zoeker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPostcode;
        private System.Windows.Forms.TextBox tbHuisnummer;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbToevoeging;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbAdres;
        private System.Windows.Forms.RadioButton rdbGebouw;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

