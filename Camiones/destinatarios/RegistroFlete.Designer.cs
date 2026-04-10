namespace Camiones.destinatarios
{
    partial class RegistroFlete
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
            cmbViaje = new ComboBox();
            cmbOperador = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            dtEntradaPatio = new DateTimePicker();
            dtTerminoViaje = new DateTimePicker();
            dtInicioViaje = new DateTimePicker();
            dtSalidaPatio = new DateTimePicker();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            chkExt = new CheckBox();
            chkInt = new CheckBox();
            txtObservaciones = new TextBox();
            btnGuardar = new Button();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            dgvRegistros = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1055, 110);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Size = new Size(117, 40);
            // 
            // cmbViaje
            // 
            cmbViaje.FormattingEnabled = true;
            cmbViaje.Location = new Point(84, 18);
            cmbViaje.Margin = new Padding(3, 2, 3, 2);
            cmbViaje.Name = "cmbViaje";
            cmbViaje.Size = new Size(133, 23);
            cmbViaje.TabIndex = 0;
            // 
            // cmbOperador
            // 
            cmbOperador.FormattingEnabled = true;
            cmbOperador.Location = new Point(122, 63);
            cmbOperador.Margin = new Padding(3, 2, 3, 2);
            cmbOperador.Name = "cmbOperador";
            cmbOperador.Size = new Size(133, 23);
            cmbOperador.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(46, 19);
            label1.TabIndex = 2;
            label1.Text = "Viaje";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 63);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 4;
            label3.Text = "Operador";
            // 
            // dtEntradaPatio
            // 
            dtEntradaPatio.Location = new Point(444, 10);
            dtEntradaPatio.Margin = new Padding(3, 2, 3, 2);
            dtEntradaPatio.Name = "dtEntradaPatio";
            dtEntradaPatio.Size = new Size(219, 23);
            dtEntradaPatio.TabIndex = 5;
            // 
            // dtTerminoViaje
            // 
            dtTerminoViaje.Location = new Point(444, 124);
            dtTerminoViaje.Margin = new Padding(3, 2, 3, 2);
            dtTerminoViaje.Name = "dtTerminoViaje";
            dtTerminoViaje.Size = new Size(219, 23);
            dtTerminoViaje.TabIndex = 6;
            // 
            // dtInicioViaje
            // 
            dtInicioViaje.Location = new Point(444, 88);
            dtInicioViaje.Margin = new Padding(3, 2, 3, 2);
            dtInicioViaje.Name = "dtInicioViaje";
            dtInicioViaje.Size = new Size(219, 23);
            dtInicioViaje.TabIndex = 7;
            // 
            // dtSalidaPatio
            // 
            dtSalidaPatio.Location = new Point(444, 47);
            dtSalidaPatio.Margin = new Padding(3, 2, 3, 2);
            dtSalidaPatio.Name = "dtSalidaPatio";
            dtSalidaPatio.Size = new Size(219, 23);
            dtSalidaPatio.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(306, 21);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 9;
            label2.Text = "EntradaPatio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(306, 54);
            label4.Name = "label4";
            label4.Size = new Size(95, 19);
            label4.TabIndex = 10;
            label4.Text = "SalidaPatio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(306, 88);
            label5.Name = "label5";
            label5.Size = new Size(87, 19);
            label5.TabIndex = 11;
            label5.Text = "InicioViaje";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(306, 124);
            label6.Name = "label6";
            label6.Size = new Size(112, 19);
            label6.TabIndex = 12;
            label6.Text = "Termino Viaje";
            // 
            // chkExt
            // 
            chkExt.AutoSize = true;
            chkExt.Location = new Point(50, 128);
            chkExt.Margin = new Padding(3, 2, 3, 2);
            chkExt.Name = "chkExt";
            chkExt.Size = new Size(66, 19);
            chkExt.TabIndex = 13;
            chkExt.Text = "Exterior";
            chkExt.UseVisualStyleBackColor = true;
            chkExt.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chkInt
            // 
            chkInt.AutoSize = true;
            chkInt.Location = new Point(168, 124);
            chkInt.Margin = new Padding(3, 2, 3, 2);
            chkInt.Name = "chkInt";
            chkInt.Size = new Size(64, 19);
            chkInt.TabIndex = 14;
            chkInt.Text = "Interior";
            chkInt.UseVisualStyleBackColor = true;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(815, 18);
            txtObservaciones.Margin = new Padding(3, 2, 3, 2);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(199, 127);
            txtObservaciones.TabIndex = 15;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(1082, 11);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(77, 30);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1082, 77);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(77, 31);
            button2.TabIndex = 18;
            button2.Text = "Baja";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1082, 43);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(77, 32);
            button3.TabIndex = 19;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(685, 47);
            label7.Name = "label7";
            label7.Size = new Size(124, 19);
            label7.TabIndex = 20;
            label7.Text = "Observaciones";
            // 
            // dgvRegistros
            // 
            dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistros.Location = new Point(21, 178);
            dgvRegistros.Margin = new Padding(3, 2, 3, 2);
            dgvRegistros.Name = "dgvRegistros";
            dgvRegistros.RowHeadersWidth = 51;
            dgvRegistros.Size = new Size(1257, 264);
            dgvRegistros.TabIndex = 21;
            // 
            // RegistroFlete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 453);
            Controls.Add(dgvRegistros);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnGuardar);
            Controls.Add(txtObservaciones);
            Controls.Add(chkInt);
            Controls.Add(chkExt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dtSalidaPatio);
            Controls.Add(dtInicioViaje);
            Controls.Add(dtTerminoViaje);
            Controls.Add(dtEntradaPatio);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cmbOperador);
            Controls.Add(cmbViaje);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistroFlete";
            Text = "RegistroFlete";
            Load += RegistroFlete_Load;
            Controls.SetChildIndex(cmbViaje, 0);
            Controls.SetChildIndex(cmbOperador, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(dtEntradaPatio, 0);
            Controls.SetChildIndex(dtTerminoViaje, 0);
            Controls.SetChildIndex(dtInicioViaje, 0);
            Controls.SetChildIndex(dtSalidaPatio, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(chkExt, 0);
            Controls.SetChildIndex(chkInt, 0);
            Controls.SetChildIndex(txtObservaciones, 0);
            Controls.SetChildIndex(btnGuardar, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(button3, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(dgvRegistros, 0);
            Controls.SetChildIndex(btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)dgvRegistros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbViaje;
        private ComboBox cmbOperador;
        private Label label1;
        private Label label3;
        private DateTimePicker dtEntradaPatio;
        private DateTimePicker dtTerminoViaje;
        private DateTimePicker dtInicioViaje;
        private DateTimePicker dtSalidaPatio;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox chkExt;
        private CheckBox chkInt;
        private TextBox txtObservaciones;
        private Button btnGuardar;
        private Button button2;
        private Button button3;
        private Label label7;
        private DataGridView dgvRegistros;
    }
}