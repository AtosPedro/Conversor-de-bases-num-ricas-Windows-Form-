namespace ConversorDeBases
{
    partial class BaseConverterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.txtBinary = new System.Windows.Forms.TextBox();
            this.txtHexa = new System.Windows.Forms.TextBox();
            this.txtOctal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 44);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(391, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Info";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conversor de Bases";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "100101";
            // 
            // txtDecimal
            // 
            this.txtDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.txtDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimal.ForeColor = System.Drawing.Color.White;
            this.txtDecimal.Location = new System.Drawing.Point(33, 110);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(390, 39);
            this.txtDecimal.TabIndex = 3;
            // 
            // txtBinary
            // 
            this.txtBinary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.txtBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinary.ForeColor = System.Drawing.Color.White;
            this.txtBinary.Location = new System.Drawing.Point(33, 214);
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.Size = new System.Drawing.Size(390, 39);
            this.txtBinary.TabIndex = 4;
            // 
            // txtHexa
            // 
            this.txtHexa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.txtHexa.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHexa.ForeColor = System.Drawing.Color.White;
            this.txtHexa.Location = new System.Drawing.Point(33, 323);
            this.txtHexa.Name = "txtHexa";
            this.txtHexa.Size = new System.Drawing.Size(390, 39);
            this.txtHexa.TabIndex = 5;
            // 
            // txtOctal
            // 
            this.txtOctal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.txtOctal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOctal.ForeColor = System.Drawing.Color.White;
            this.txtOctal.Location = new System.Drawing.Point(33, 422);
            this.txtOctal.Name = "txtOctal";
            this.txtOctal.Size = new System.Drawing.Size(390, 39);
            this.txtOctal.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(33, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(178, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Decimal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(178, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Binário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(147, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hexadecimal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(187, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Octal";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(287, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BaseConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(464, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOctal);
            this.Controls.Add(this.txtHexa);
            this.Controls.Add(this.txtBinary);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.panel1);
            this.Name = "BaseConverterForm";
            this.Text = "Conversor de Bases";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtBinary;
        private System.Windows.Forms.TextBox txtHexa;
        private System.Windows.Forms.TextBox txtOctal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}

