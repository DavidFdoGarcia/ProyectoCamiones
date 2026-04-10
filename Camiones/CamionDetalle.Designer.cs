namespace Camiones
{
    partial class CamionDetalle
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
            components = new System.ComponentModel.Container();
            cmbCamion = new ComboBox();
            Camión = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtIdDetalle = new TextBox();
            label7 = new Label();
            txtSerie = new TextBox();
            txtColor = new TextBox();
            txtAnio = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            txtPlacas = new TextBox();
            ChkActivo = new CheckBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(737, 330);
            btnSalir.Size = new Size(80, 39);
            // 
            // cmbCamion
            // 
            cmbCamion.FormattingEnabled = true;
            cmbCamion.Location = new Point(549, 24);
            cmbCamion.Name = "cmbCamion";
            cmbCamion.Size = new Size(121, 23);
            cmbCamion.TabIndex = 0;
            // 
            // Camión
            // 
            Camión.AutoSize = true;
            Camión.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Camión.Location = new Point(417, 29);
            Camión.Name = "Camión";
            Camión.Size = new Size(68, 19);
            Camión.TabIndex = 1;
            Camión.Text = "Camión";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(409, 187);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 2;
            label1.Text = "Serie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(417, 78);
            label2.Name = "label2";
            label2.Size = new Size(40, 19);
            label2.TabIndex = 3;
            label2.Text = "Año";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(88, 187);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 4;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(88, 132);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 5;
            label4.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(88, 88);
            label5.Name = "label5";
            label5.Size = new Size(60, 19);
            label5.TabIndex = 6;
            label5.Text = "Placas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(88, 28);
            label6.Name = "label6";
            label6.Size = new Size(81, 19);
            label6.TabIndex = 7;
            label6.Text = "ID Detalle";
            label6.Click += label6_Click;
            // 
            // txtIdDetalle
            // 
            txtIdDetalle.Location = new Point(199, 28);
            txtIdDetalle.Name = "txtIdDetalle";
            txtIdDetalle.Size = new Size(100, 23);
            txtIdDetalle.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(417, 128);
            label7.Name = "label7";
            label7.Size = new Size(51, 19);
            label7.TabIndex = 9;
            label7.Text = "Color";
            // 
            // txtSerie
            // 
            txtSerie.Location = new Point(527, 187);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(100, 23);
            txtSerie.TabIndex = 10;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(527, 132);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(100, 23);
            txtColor.TabIndex = 11;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(527, 78);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(100, 23);
            txtAnio.TabIndex = 12;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(199, 187);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 13;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(199, 128);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 14;
            // 
            // txtPlacas
            // 
            txtPlacas.Location = new Point(199, 88);
            txtPlacas.Name = "txtPlacas";
            txtPlacas.Size = new Size(100, 23);
            txtPlacas.TabIndex = 15;
            // 
            // ChkActivo
            // 
            ChkActivo.AutoSize = true;
            ChkActivo.Location = new Point(558, 304);
            ChkActivo.Name = "ChkActivo";
            ChkActivo.Size = new Size(60, 19);
            ChkActivo.TabIndex = 16;
            ChkActivo.Text = "Activo";
            ChkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(737, 203);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 32);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(737, 268);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(88, 32);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CamionDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 389);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(ChkActivo);
            Controls.Add(txtPlacas);
            Controls.Add(txtMarca);
            Controls.Add(txtModelo);
            Controls.Add(txtAnio);
            Controls.Add(txtColor);
            Controls.Add(txtSerie);
            Controls.Add(label7);
            Controls.Add(txtIdDetalle);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Camión);
            Controls.Add(cmbCamion);
            Name = "CamionDetalle";
            Text = "CamionDetalle";
            Load += CamionDetalle_Load;
            Controls.SetChildIndex(cmbCamion, 0);
            Controls.SetChildIndex(Camión, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(txtIdDetalle, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(txtSerie, 0);
            Controls.SetChildIndex(txtColor, 0);
            Controls.SetChildIndex(txtAnio, 0);
            Controls.SetChildIndex(txtModelo, 0);
            Controls.SetChildIndex(txtMarca, 0);
            Controls.SetChildIndex(txtPlacas, 0);
            Controls.SetChildIndex(ChkActivo, 0);
            Controls.SetChildIndex(btnGuardar, 0);
            Controls.SetChildIndex(btnLimpiar, 0);
            Controls.SetChildIndex(btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCamion;
        private Label Camión;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtIdDetalle;
        private Label label7;
        private TextBox txtSerie;
        private TextBox txtColor;
        private TextBox txtAnio;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private TextBox txtPlacas;
        private CheckBox ChkActivo;
        private Button btnGuardar;
        private Button btnLimpiar;
        private ErrorProvider errorProvider1;
    }
}