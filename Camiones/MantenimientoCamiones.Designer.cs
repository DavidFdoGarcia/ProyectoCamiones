namespace Camiones
{
    partial class MantenimientoCamiones
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
            cmbCamion = new ComboBox();
            cmbOperador = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dtFecha = new DateTimePicker();
            txtPlacas = new TextBox();
            txtLlantas = new TextBox();
            txtRetenes = new TextBox();
            txtFlechas = new TextBox();
            txtTransmicion = new TextBox();
            txtCarroocerias = new TextBox();
            txtMotor = new TextBox();
            txtParabrisas = new TextBox();
            txtSoldaduras = new TextBox();
            btnInsertar = new Button();
            btnFactura = new Button();
            label13 = new Label();
            txtID = new TextBox();
            label14 = new Label();
            label15 = new Label();
            txtCostoCarrocerias = new TextBox();
            txtCostoTransmicion = new TextBox();
            txtCostosFlechas = new TextBox();
            txtCostosRetenes = new TextBox();
            txtCostoLlantas = new TextBox();
            txtCostoSoldadura = new TextBox();
            txtCostoParabrisas = new TextBox();
            txtCostoMotor = new TextBox();
            label16 = new Label();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(810, 108);
            btnSalir.Size = new Size(84, 35);
            // 
            // cmbCamion
            // 
            cmbCamion.FormattingEnabled = true;
            cmbCamion.Location = new Point(204, 28);
            cmbCamion.Name = "cmbCamion";
            cmbCamion.Size = new Size(159, 23);
            cmbCamion.TabIndex = 0;
            // 
            // cmbOperador
            // 
            cmbOperador.FormattingEnabled = true;
            cmbOperador.Location = new Point(242, 81);
            cmbOperador.Name = "cmbOperador";
            cmbOperador.Size = new Size(169, 23);
            cmbOperador.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 25);
            label1.Name = "label1";
            label1.Size = new Size(147, 23);
            label1.TabIndex = 2;
            label1.Text = "Tipo de Camión";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 81);
            label2.Name = "label2";
            label2.Size = new Size(198, 23);
            label2.TabIndex = 3;
            label2.Text = "Nombre del Operador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 171);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 4;
            label3.Text = "Placas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 125);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 5;
            label4.Text = "Fecha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 295);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 6;
            label5.Text = "Retenes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 255);
            label6.Name = "label6";
            label6.Size = new Size(70, 23);
            label6.TabIndex = 7;
            label6.Text = "llantas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(28, 409);
            label7.Name = "label7";
            label7.Size = new Size(119, 23);
            label7.TabIndex = 8;
            label7.Text = "Transmición";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 350);
            label8.Name = "label8";
            label8.Size = new Size(80, 23);
            label8.TabIndex = 9;
            label8.Text = "Flechas";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(583, 278);
            label9.Name = "label9";
            label9.Size = new Size(61, 23);
            label9.TabIndex = 10;
            label9.Text = "Motor";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(28, 482);
            label10.Name = "label10";
            label10.Size = new Size(114, 23);
            label10.TabIndex = 11;
            label10.Text = "Carrocerias";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(583, 441);
            label11.Name = "label11";
            label11.Size = new Size(110, 23);
            label11.TabIndex = 12;
            label11.Text = "Soldaduras";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(583, 347);
            label12.Name = "label12";
            label12.Size = new Size(105, 23);
            label12.TabIndex = 13;
            label12.Text = "Parabrisas";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(127, 125);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(223, 23);
            dtFecha.TabIndex = 14;
            // 
            // txtPlacas
            // 
            txtPlacas.Location = new Point(127, 174);
            txtPlacas.Name = "txtPlacas";
            txtPlacas.Size = new Size(208, 23);
            txtPlacas.TabIndex = 15;
            // 
            // txtLlantas
            // 
            txtLlantas.Location = new Point(186, 244);
            txtLlantas.Name = "txtLlantas";
            txtLlantas.Size = new Size(69, 23);
            txtLlantas.TabIndex = 16;
            // 
            // txtRetenes
            // 
            txtRetenes.Location = new Point(186, 295);
            txtRetenes.Name = "txtRetenes";
            txtRetenes.Size = new Size(69, 23);
            txtRetenes.TabIndex = 17;
            // 
            // txtFlechas
            // 
            txtFlechas.Location = new Point(186, 350);
            txtFlechas.Name = "txtFlechas";
            txtFlechas.Size = new Size(69, 23);
            txtFlechas.TabIndex = 18;
            // 
            // txtTransmicion
            // 
            txtTransmicion.Location = new Point(186, 409);
            txtTransmicion.Name = "txtTransmicion";
            txtTransmicion.Size = new Size(69, 23);
            txtTransmicion.TabIndex = 19;
            // 
            // txtCarroocerias
            // 
            txtCarroocerias.Location = new Point(186, 482);
            txtCarroocerias.Name = "txtCarroocerias";
            txtCarroocerias.Size = new Size(69, 23);
            txtCarroocerias.TabIndex = 20;
            // 
            // txtMotor
            // 
            txtMotor.Location = new Point(708, 278);
            txtMotor.Name = "txtMotor";
            txtMotor.Size = new Size(63, 23);
            txtMotor.TabIndex = 21;
            // 
            // txtParabrisas
            // 
            txtParabrisas.Location = new Point(719, 350);
            txtParabrisas.Name = "txtParabrisas";
            txtParabrisas.Size = new Size(52, 23);
            txtParabrisas.TabIndex = 22;
            // 
            // txtSoldaduras
            // 
            txtSoldaduras.Location = new Point(739, 441);
            txtSoldaduras.Name = "txtSoldaduras";
            txtSoldaduras.Size = new Size(60, 23);
            txtSoldaduras.TabIndex = 23;
            // 
            // btnInsertar
            // 
            btnInsertar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.Location = new Point(687, 67);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(84, 38);
            btnInsertar.TabIndex = 24;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnFactura
            // 
            btnFactura.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFactura.Location = new Point(690, 133);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(81, 61);
            btnFactura.TabIndex = 25;
            btnFactura.Text = "Generar Factura";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(655, 28);
            label13.Name = "label13";
            label13.Size = new Size(180, 23);
            label13.TabIndex = 26;
            label13.Text = "Numero de Factura";
            // 
            // txtID
            // 
            txtID.Location = new Point(860, 25);
            txtID.Name = "txtID";
            txtID.Size = new Size(91, 23);
            txtID.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(301, 200);
            label14.Name = "label14";
            label14.Size = new Size(156, 23);
            label14.TabIndex = 28;
            label14.Text = "Costos Unitarios";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(810, 213);
            label15.Name = "label15";
            label15.Size = new Size(156, 23);
            label15.TabIndex = 29;
            label15.Text = "Costos Unitarios";
            // 
            // txtCostoCarrocerias
            // 
            txtCostoCarrocerias.Location = new Point(333, 485);
            txtCostoCarrocerias.Name = "txtCostoCarrocerias";
            txtCostoCarrocerias.Size = new Size(69, 23);
            txtCostoCarrocerias.TabIndex = 34;
            // 
            // txtCostoTransmicion
            // 
            txtCostoTransmicion.Location = new Point(333, 412);
            txtCostoTransmicion.Name = "txtCostoTransmicion";
            txtCostoTransmicion.Size = new Size(69, 23);
            txtCostoTransmicion.TabIndex = 33;
            // 
            // txtCostosFlechas
            // 
            txtCostosFlechas.Location = new Point(333, 353);
            txtCostosFlechas.Name = "txtCostosFlechas";
            txtCostosFlechas.Size = new Size(69, 23);
            txtCostosFlechas.TabIndex = 32;
            // 
            // txtCostosRetenes
            // 
            txtCostosRetenes.Location = new Point(333, 298);
            txtCostosRetenes.Name = "txtCostosRetenes";
            txtCostosRetenes.Size = new Size(69, 23);
            txtCostosRetenes.TabIndex = 31;
            // 
            // txtCostoLlantas
            // 
            txtCostoLlantas.Location = new Point(333, 247);
            txtCostoLlantas.Name = "txtCostoLlantas";
            txtCostoLlantas.Size = new Size(69, 23);
            txtCostoLlantas.TabIndex = 30;
            // 
            // txtCostoSoldadura
            // 
            txtCostoSoldadura.Location = new Point(860, 444);
            txtCostoSoldadura.Name = "txtCostoSoldadura";
            txtCostoSoldadura.Size = new Size(60, 23);
            txtCostoSoldadura.TabIndex = 37;
            // 
            // txtCostoParabrisas
            // 
            txtCostoParabrisas.Location = new Point(871, 350);
            txtCostoParabrisas.Name = "txtCostoParabrisas";
            txtCostoParabrisas.Size = new Size(52, 23);
            txtCostoParabrisas.TabIndex = 36;
            // 
            // txtCostoMotor
            // 
            txtCostoMotor.Location = new Point(860, 278);
            txtCostoMotor.Name = "txtCostoMotor";
            txtCostoMotor.Size = new Size(63, 23);
            txtCostoMotor.TabIndex = 35;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(583, 501);
            label16.Name = "label16";
            label16.Size = new Size(133, 23);
            label16.TabIndex = 38;
            label16.Text = "Calcular Total";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(775, 501);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(60, 23);
            txtTotal.TabIndex = 39;
            // 
            // MantenimientoCamiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 553);
            Controls.Add(txtTotal);
            Controls.Add(label16);
            Controls.Add(txtCostoSoldadura);
            Controls.Add(txtCostoParabrisas);
            Controls.Add(txtCostoMotor);
            Controls.Add(txtCostoCarrocerias);
            Controls.Add(txtCostoTransmicion);
            Controls.Add(txtCostosFlechas);
            Controls.Add(txtCostosRetenes);
            Controls.Add(txtCostoLlantas);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(txtID);
            Controls.Add(label13);
            Controls.Add(btnFactura);
            Controls.Add(btnInsertar);
            Controls.Add(txtSoldaduras);
            Controls.Add(txtParabrisas);
            Controls.Add(txtMotor);
            Controls.Add(txtCarroocerias);
            Controls.Add(txtTransmicion);
            Controls.Add(txtFlechas);
            Controls.Add(txtRetenes);
            Controls.Add(txtLlantas);
            Controls.Add(txtPlacas);
            Controls.Add(dtFecha);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbOperador);
            Controls.Add(cmbCamion);
            Name = "MantenimientoCamiones";
            Text = "MantenimientoCamiones";
            Load += MantenimientoCamiones_Load;
            Controls.SetChildIndex(cmbCamion, 0);
            Controls.SetChildIndex(cmbOperador, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(label10, 0);
            Controls.SetChildIndex(label11, 0);
            Controls.SetChildIndex(label12, 0);
            Controls.SetChildIndex(dtFecha, 0);
            Controls.SetChildIndex(txtPlacas, 0);
            Controls.SetChildIndex(txtLlantas, 0);
            Controls.SetChildIndex(txtRetenes, 0);
            Controls.SetChildIndex(txtFlechas, 0);
            Controls.SetChildIndex(txtTransmicion, 0);
            Controls.SetChildIndex(txtCarroocerias, 0);
            Controls.SetChildIndex(txtMotor, 0);
            Controls.SetChildIndex(txtParabrisas, 0);
            Controls.SetChildIndex(txtSoldaduras, 0);
            Controls.SetChildIndex(btnInsertar, 0);
            Controls.SetChildIndex(btnFactura, 0);
            Controls.SetChildIndex(label13, 0);
            Controls.SetChildIndex(txtID, 0);
            Controls.SetChildIndex(label14, 0);
            Controls.SetChildIndex(label15, 0);
            Controls.SetChildIndex(txtCostoLlantas, 0);
            Controls.SetChildIndex(txtCostosRetenes, 0);
            Controls.SetChildIndex(txtCostosFlechas, 0);
            Controls.SetChildIndex(txtCostoTransmicion, 0);
            Controls.SetChildIndex(txtCostoCarrocerias, 0);
            Controls.SetChildIndex(txtCostoMotor, 0);
            Controls.SetChildIndex(txtCostoParabrisas, 0);
            Controls.SetChildIndex(txtCostoSoldadura, 0);
            Controls.SetChildIndex(label16, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(txtTotal, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCamion;
        private ComboBox cmbOperador;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DateTimePicker dtFecha;
        private TextBox txtPlacas;
        private TextBox txtLlantas;
        private TextBox txtRetenes;
        private TextBox txtFlechas;
        private TextBox txtTransmicion;
        private TextBox txtCarroocerias;
        private TextBox txtMotor;
        private TextBox txtParabrisas;
        private TextBox txtSoldaduras;
        private Button btnInsertar;
        private Button btnFactura;
        private Label label13;
        private TextBox txtID;
        private Label label14;
        private Label label15;
        private TextBox txtCostoCarrocerias;
        private TextBox txtCostoTransmicion;
        private TextBox txtCostosFlechas;
        private TextBox txtCostosRetenes;
        private TextBox txtCostoLlantas;
        private TextBox txtCostoSoldadura;
        private TextBox txtCostoParabrisas;
        private TextBox txtCostoMotor;
        private Label label16;
        private TextBox txtTotal;
    }
}