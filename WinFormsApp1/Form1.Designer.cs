namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.edad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.out_edad = new System.Windows.Forms.Label();
            this.in_edad = new System.Windows.Forms.Button();
            this.out_rechazados = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.iterarconfor = new System.Windows.Forms.Button();
            this.botonwhile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edad
            // 
            this.edad.Location = new System.Drawing.Point(105, 112);
            this.edad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(570, 23);
            this.edad.TabIndex = 0;
            this.edad.TextChanged += new System.EventHandler(this.edad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(263, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESA TU EDAD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // out_edad
            // 
            this.out_edad.AutoSize = true;
            this.out_edad.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.out_edad.Location = new System.Drawing.Point(180, 262);
            this.out_edad.Name = "out_edad";
            this.out_edad.Size = new System.Drawing.Size(187, 20);
            this.out_edad.TabIndex = 2;
            this.out_edad.Text = "EDAD DE JUGADORES";
            this.out_edad.Click += new System.EventHandler(this.out_edad_Click);
            // 
            // in_edad
            // 
            this.in_edad.BackColor = System.Drawing.SystemColors.Highlight;
            this.in_edad.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.in_edad.Location = new System.Drawing.Point(90, 155);
            this.in_edad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.in_edad.Name = "in_edad";
            this.in_edad.Size = new System.Drawing.Size(114, 81);
            this.in_edad.TabIndex = 3;
            this.in_edad.Text = "VERIFICAR";
            this.in_edad.UseVisualStyleBackColor = false;
            this.in_edad.Click += new System.EventHandler(this.in_edad_Click);
            // 
            // out_rechazados
            // 
            this.out_rechazados.AutoSize = true;
            this.out_rechazados.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.out_rechazados.Location = new System.Drawing.Point(421, 262);
            this.out_rechazados.Name = "out_rechazados";
            this.out_rechazados.Size = new System.Drawing.Size(228, 20);
            this.out_rechazados.TabIndex = 4;
            this.out_rechazados.Text = "JUGADORES RECHAZADOS";
            this.out_rechazados.Click += new System.EventHandler(this.out_rechazados_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(236, 156);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 79);
            this.button1.TabIndex = 5;
            this.button1.Text = "VERIFICAR CON SWITCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iterarconfor
            // 
            this.iterarconfor.BackColor = System.Drawing.Color.Lime;
            this.iterarconfor.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iterarconfor.Location = new System.Drawing.Point(421, 156);
            this.iterarconfor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iterarconfor.Name = "iterarconfor";
            this.iterarconfor.Size = new System.Drawing.Size(136, 79);
            this.iterarconfor.TabIndex = 6;
            this.iterarconfor.Text = "ITERAR CON FOR";
            this.iterarconfor.UseVisualStyleBackColor = false;
            this.iterarconfor.Click += new System.EventHandler(this.button2_Click);
            // 
            // botonwhile
            // 
            this.botonwhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonwhile.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonwhile.Location = new System.Drawing.Point(606, 156);
            this.botonwhile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonwhile.Name = "botonwhile";
            this.botonwhile.Size = new System.Drawing.Size(88, 78);
            this.botonwhile.TabIndex = 7;
            this.botonwhile.Text = "SWITCH";
            this.botonwhile.UseVisualStyleBackColor = false;
            this.botonwhile.Click += new System.EventHandler(this.botonwhile_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(350, 298);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 517);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botonwhile);
            this.Controls.Add(this.iterarconfor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.out_rechazados);
            this.Controls.Add(this.in_edad);
            this.Controls.Add(this.out_edad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edad);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox edad;
        private Label label1;
        private Label out_edad;
        private Button in_edad;
        private Label out_rechazados;
        private Button button1;
        private Button iterarconfor;
        private Button botonwhile;
        private Button button2;
    }
}