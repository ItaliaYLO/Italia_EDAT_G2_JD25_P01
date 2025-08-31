namespace frmDatosAleatorios
{
    partial class frmDatosAleatorios
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
            btnPrueba = new Button();
            fecha = new DateTimePicker();
            seguro = new CheckBox();
            grupo = new ComboBox();
            label1 = new Label();
            nombre = new TextBox();
            label2 = new Label();
            numero = new TextBox();
            label3 = new Label();
            masculino = new RadioButton();
            femenino = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            sueldo = new TextBox();
            SuspendLayout();
            // 
            // btnPrueba
            // 
            btnPrueba.Location = new Point(279, 341);
            btnPrueba.Name = "btnPrueba";
            btnPrueba.Size = new Size(259, 32);
            btnPrueba.TabIndex = 0;
            btnPrueba.Text = "Generar Datos Aleatorios";
            btnPrueba.UseVisualStyleBackColor = true;
            btnPrueba.Click += btnPrueba_Click;
            // 
            // fecha
            // 
            fecha.Location = new Point(211, 99);
            fecha.Name = "fecha";
            fecha.Size = new Size(297, 27);
            fecha.TabIndex = 1;
            fecha.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // seguro
            // 
            seguro.AutoSize = true;
            seguro.Location = new Point(336, 298);
            seguro.Name = "seguro";
            seguro.Size = new Size(132, 24);
            seguro.TabIndex = 2;
            seguro.Text = "Seguro Medico";
            seguro.UseVisualStyleBackColor = true;
            // 
            // grupo
            // 
            grupo.FormattingEnabled = true;
            grupo.Location = new Point(167, 214);
            grupo.Name = "grupo";
            grupo.Size = new Size(81, 28);
            grupo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 21);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // nombre
            // 
            nombre.Location = new Point(125, 18);
            nombre.Name = "nombre";
            nombre.Size = new Size(190, 27);
            nombre.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 61);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 6;
            label2.Text = "Numero";
            // 
            // numero
            // 
            numero.Location = new Point(125, 54);
            numero.Name = "numero";
            numero.Size = new Size(196, 27);
            numero.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 104);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 8;
            label3.Text = "Fecha de Nacimiento";
            // 
            // masculino
            // 
            masculino.AutoSize = true;
            masculino.Location = new Point(277, 137);
            masculino.Name = "masculino";
            masculino.Size = new Size(97, 24);
            masculino.TabIndex = 9;
            masculino.TabStop = true;
            masculino.Text = "Masculino";
            masculino.UseVisualStyleBackColor = true;
            // 
            // femenino
            // 
            femenino.AutoSize = true;
            femenino.Location = new Point(279, 167);
            femenino.Name = "femenino";
            femenino.Size = new Size(95, 24);
            femenino.TabIndex = 10;
            femenino.TabStop = true;
            femenino.Text = "Femenino";
            femenino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 217);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 11;
            label4.Text = "Grupo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 251);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 12;
            label5.Text = "Sueldo";
            // 
            // sueldo
            // 
            sueldo.Location = new Point(167, 248);
            sueldo.Name = "sueldo";
            sueldo.Size = new Size(170, 27);
            sueldo.TabIndex = 13;
            // 
            // frmDatosAleatorios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sueldo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(femenino);
            Controls.Add(masculino);
            Controls.Add(label3);
            Controls.Add(numero);
            Controls.Add(label2);
            Controls.Add(nombre);
            Controls.Add(label1);
            Controls.Add(grupo);
            Controls.Add(seguro);
            Controls.Add(fecha);
            Controls.Add(btnPrueba);
            Name = "frmDatosAleatorios";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrueba;
        private DateTimePicker fecha;
        private CheckBox seguro;
        private ComboBox grupo;
        private Label label1;
        private TextBox nombre;
        private Label label2;
        private TextBox numero;
        private Label label3;
        private RadioButton masculino;
        private RadioButton femenino;
        private Label label4;
        private Label label5;
        private TextBox sueldo;
    }
}
