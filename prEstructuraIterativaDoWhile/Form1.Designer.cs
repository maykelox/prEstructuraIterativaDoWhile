namespace prEstructuraIterativaDoWhile
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btningresar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.txtalumnos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtpromedio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.btningresar);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.txtalumnos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Datos";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(356, 124);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(191, 124);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 3;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(27, 124);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 2;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // txtalumnos
            // 
            this.txtalumnos.Location = new System.Drawing.Point(193, 36);
            this.txtalumnos.Name = "txtalumnos";
            this.txtalumnos.Size = new System.Drawing.Size(153, 23);
            this.txtalumnos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Cantidad De Alumnos:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtpromedio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Promedio";
            // 
            // txtpromedio
            // 
            this.txtpromedio.Location = new System.Drawing.Point(97, 65);
            this.txtpromedio.Name = "txtpromedio";
            this.txtpromedio.Size = new System.Drawing.Size(129, 23);
            this.txtpromedio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Promedio:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 341);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnsalir;
        private Button btningresar;
        private Button btnnuevo;
        private TextBox txtalumnos;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtpromedio;
        private Label label2;
        private EventHandler textBox2_TextChanged;

        public EventHandler Form1_Load { get; private set; }
    }
}