namespace Programa_Preferencia_de_Actividades
{
    partial class Programa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programa));
            txtNombre = new Label();
            boxNombre = new TextBox();
            gpoActividades = new GroupBox();
            chkLectura = new CheckBox();
            chkProgra = new CheckBox();
            chkArte = new CheckBox();
            chkMusica = new CheckBox();
            chkDeportes = new CheckBox();
            gpoModalidad = new GroupBox();
            radLinea = new RadioButton();
            radHibrida = new RadioButton();
            radPresencial = new RadioButton();
            btnResumen = new Button();
            button2 = new Button();
            txtResu = new TextBox();
            txtResumen = new Label();
            gpoActividades.SuspendLayout();
            gpoModalidad.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(43, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(227, 22);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "Nombre del Estudiante:";
            txtNombre.Click += label1_Click;
            // 
            // boxNombre
            // 
            boxNombre.Location = new Point(320, 40);
            boxNombre.Name = "boxNombre";
            boxNombre.Size = new Size(431, 23);
            boxNombre.TabIndex = 1;
            // 
            // gpoActividades
            // 
            gpoActividades.Controls.Add(chkLectura);
            gpoActividades.Controls.Add(chkProgra);
            gpoActividades.Controls.Add(chkArte);
            gpoActividades.Controls.Add(chkMusica);
            gpoActividades.Controls.Add(chkDeportes);
            gpoActividades.Location = new Point(43, 125);
            gpoActividades.Name = "gpoActividades";
            gpoActividades.Size = new Size(362, 230);
            gpoActividades.TabIndex = 2;
            gpoActividades.TabStop = false;
            gpoActividades.Text = "Actividades Favoritas (elige varias)";
            gpoActividades.Enter += groupBox1_Enter;
            // 
            // chkLectura
            // 
            chkLectura.AutoSize = true;
            chkLectura.Font = new Font("Segoe UI", 12F);
            chkLectura.Location = new Point(25, 197);
            chkLectura.Name = "chkLectura";
            chkLectura.Size = new Size(80, 25);
            chkLectura.TabIndex = 4;
            chkLectura.Text = "Lectura";
            chkLectura.UseVisualStyleBackColor = true;
            // 
            // chkProgra
            // 
            chkProgra.AutoSize = true;
            chkProgra.Font = new Font("Segoe UI", 12F);
            chkProgra.Location = new Point(25, 156);
            chkProgra.Name = "chkProgra";
            chkProgra.Size = new Size(127, 25);
            chkProgra.TabIndex = 3;
            chkProgra.Text = "Programación";
            chkProgra.UseVisualStyleBackColor = true;
            // 
            // chkArte
            // 
            chkArte.AutoSize = true;
            chkArte.Font = new Font("Segoe UI", 12F);
            chkArte.Location = new Point(25, 112);
            chkArte.Name = "chkArte";
            chkArte.Size = new Size(58, 25);
            chkArte.TabIndex = 2;
            chkArte.Text = "Arte";
            chkArte.UseVisualStyleBackColor = true;
            // 
            // chkMusica
            // 
            chkMusica.AutoSize = true;
            chkMusica.Font = new Font("Segoe UI", 12F);
            chkMusica.Location = new Point(25, 69);
            chkMusica.Name = "chkMusica";
            chkMusica.Size = new Size(78, 25);
            chkMusica.TabIndex = 1;
            chkMusica.Text = "Música";
            chkMusica.UseVisualStyleBackColor = true;
            // 
            // chkDeportes
            // 
            chkDeportes.AutoSize = true;
            chkDeportes.Font = new Font("Segoe UI", 12F);
            chkDeportes.Location = new Point(25, 26);
            chkDeportes.Name = "chkDeportes";
            chkDeportes.Size = new Size(92, 25);
            chkDeportes.TabIndex = 0;
            chkDeportes.Text = "Deportes";
            chkDeportes.UseVisualStyleBackColor = true;
            // 
            // gpoModalidad
            // 
            gpoModalidad.Controls.Add(radLinea);
            gpoModalidad.Controls.Add(radHibrida);
            gpoModalidad.Controls.Add(radPresencial);
            gpoModalidad.Location = new Point(463, 125);
            gpoModalidad.Name = "gpoModalidad";
            gpoModalidad.Size = new Size(283, 230);
            gpoModalidad.TabIndex = 3;
            gpoModalidad.TabStop = false;
            gpoModalidad.Text = "Modalidad Preferida (elige una)";
            gpoModalidad.Enter += groupBox1_Enter_1;
            // 
            // radLinea
            // 
            radLinea.AutoSize = true;
            radLinea.Font = new Font("Segoe UI", 14.25F);
            radLinea.Location = new Point(48, 172);
            radLinea.Name = "radLinea";
            radLinea.Size = new Size(97, 29);
            radLinea.TabIndex = 2;
            radLinea.TabStop = true;
            radLinea.Text = "En línea";
            radLinea.UseVisualStyleBackColor = true;
            // 
            // radHibrida
            // 
            radHibrida.AutoSize = true;
            radHibrida.Font = new Font("Segoe UI", 14.25F);
            radHibrida.Location = new Point(48, 108);
            radHibrida.Name = "radHibrida";
            radHibrida.Size = new Size(92, 29);
            radHibrida.TabIndex = 1;
            radHibrida.TabStop = true;
            radHibrida.Text = "Híbrida";
            radHibrida.UseVisualStyleBackColor = true;
            radHibrida.CheckedChanged += radHibrida_CheckedChanged;
            // 
            // radPresencial
            // 
            radPresencial.AutoSize = true;
            radPresencial.Font = new Font("Segoe UI", 14.25F);
            radPresencial.Location = new Point(48, 43);
            radPresencial.Name = "radPresencial";
            radPresencial.Size = new Size(116, 29);
            radPresencial.TabIndex = 0;
            radPresencial.TabStop = true;
            radPresencial.Text = "Presencial";
            radPresencial.UseVisualStyleBackColor = true;
            // 
            // btnResumen
            // 
            btnResumen.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResumen.Location = new Point(350, 389);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(143, 34);
            btnResumen.TabIndex = 4;
            btnResumen.Text = "Botón Resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(566, 390);
            button2.Name = "button2";
            button2.Size = new Size(130, 33);
            button2.TabIndex = 5;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtResu
            // 
            txtResu.Location = new Point(43, 445);
            txtResu.Multiline = true;
            txtResu.Name = "txtResu";
            txtResu.Size = new Size(719, 140);
            txtResu.TabIndex = 6;
            // 
            // txtResumen
            // 
            txtResumen.AutoSize = true;
            txtResumen.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResumen.Location = new Point(43, 408);
            txtResumen.Name = "txtResumen";
            txtResumen.Size = new Size(75, 20);
            txtResumen.TabIndex = 7;
            txtResumen.Text = "Resumen:";
            txtResumen.Click += label1_Click_1;
            // 
            // Programa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 624);
            Controls.Add(txtResumen);
            Controls.Add(txtResu);
            Controls.Add(button2);
            Controls.Add(btnResumen);
            Controls.Add(gpoModalidad);
            Controls.Add(gpoActividades);
            Controls.Add(boxNombre);
            Controls.Add(txtNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Programa";
            Text = "Preferencia de Actividades";
            Load += Programa_Load;
            gpoActividades.ResumeLayout(false);
            gpoActividades.PerformLayout();
            gpoModalidad.ResumeLayout(false);
            gpoModalidad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtNombre;
        private TextBox boxNombre;
        private GroupBox gpoActividades;
        private GroupBox gpoModalidad;
        private CheckBox chkLectura;
        private CheckBox chkProgra;
        private CheckBox chkArte;
        private CheckBox chkMusica;
        private CheckBox chkDeportes;
        private RadioButton radLinea;
        private RadioButton radHibrida;
        private RadioButton radPresencial;
        private Button btnResumen;
        private Button button2;
        private TextBox txtResu;
        private Label txtResumen;
    }
}
