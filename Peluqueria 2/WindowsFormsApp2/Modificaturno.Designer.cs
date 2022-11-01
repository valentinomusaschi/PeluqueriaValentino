namespace WindowsFormsApp2
{
    partial class Modificaturno
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TexBoxidcliente = new System.Windows.Forms.TextBox();
            this.TexBoxfecha = new System.Windows.Forms.TextBox();
            this.Texboxcosto = new System.Windows.Forms.TextBox();
            this.TexBoxid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(394, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(567, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 31);
            this.label5.TabIndex = 19;
            this.label5.Text = "Turnos modificar";
            // 
            // TexBoxidcliente
            // 
            this.TexBoxidcliente.Location = new System.Drawing.Point(299, 195);
            this.TexBoxidcliente.Name = "TexBoxidcliente";
            this.TexBoxidcliente.Size = new System.Drawing.Size(100, 20);
            this.TexBoxidcliente.TabIndex = 18;
            this.TexBoxidcliente.TextChanged += new System.EventHandler(this.TexBoxidpersona_TextChanged);
            // 
            // TexBoxfecha
            // 
            this.TexBoxfecha.Location = new System.Drawing.Point(299, 302);
            this.TexBoxfecha.Name = "TexBoxfecha";
            this.TexBoxfecha.Size = new System.Drawing.Size(100, 20);
            this.TexBoxfecha.TabIndex = 17;
            this.TexBoxfecha.TextChanged += new System.EventHandler(this.fecha_TextChanged);
            // 
            // Texboxcosto
            // 
            this.Texboxcosto.Location = new System.Drawing.Point(299, 246);
            this.Texboxcosto.Name = "Texboxcosto";
            this.Texboxcosto.Size = new System.Drawing.Size(100, 20);
            this.Texboxcosto.TabIndex = 16;
            this.Texboxcosto.TextChanged += new System.EventHandler(this.Texboxcosto_TextChanged);
            // 
            // TexBoxid
            // 
            this.TexBoxid.Location = new System.Drawing.Point(299, 137);
            this.TexBoxid.Name = "TexBoxid";
            this.TexBoxid.Size = new System.Drawing.Size(100, 20);
            this.TexBoxid.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(60, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "costo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "id cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(60, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.pwlu_3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(491, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 229);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Modificaturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TexBoxidcliente);
            this.Controls.Add(this.TexBoxfecha);
            this.Controls.Add(this.Texboxcosto);
            this.Controls.Add(this.TexBoxid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Modificaturno";
            this.Text = "Modificaturno";
            this.Load += new System.EventHandler(this.Modificaturno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TexBoxidcliente;
        private System.Windows.Forms.TextBox TexBoxfecha;
        private System.Windows.Forms.TextBox Texboxcosto;
        private System.Windows.Forms.TextBox TexBoxid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}