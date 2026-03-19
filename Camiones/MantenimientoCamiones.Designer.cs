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
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(905, 482);
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
            label3.Location = new Point(28, 147);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 4;
            label3.Text = "Placas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 201);
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
            label6.Location = new Point(28, 241);
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
            label9.Location = new Point(605, 147);
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
            label11.Location = new Point(605, 310);
            label11.Name = "label11";
            label11.Size = new Size(110, 23);
            label11.TabIndex = 12;
            label11.Text = "Soldaduras";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(605, 216);
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
            dtFecha.Location = new Point(153, 201);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(200, 23);
            dtFecha.TabIndex = 14;
            // 
            // txtPlacas
            // 
            txtPlacas.Location = new Point(163, 150);
            txtPlacas.Name = "txtPlacas";
            txtPlacas.Size = new Size(190, 23);
            txtPlacas.TabIndex = 15;
            // 
            // txtLlantas
            // 
            txtLlantas.Location = new Point(186, 244);
            txtLlantas.Name = "txtLlantas";
            txtLlantas.Size = new Size(190, 23);
            txtLlantas.TabIndex = 16;
            // 
            // txtRetenes
            // 
            txtRetenes.Location = new Point(186, 295);
            txtRetenes.Name = "txtRetenes";
            txtRetenes.Size = new Size(190, 23);
            txtRetenes.TabIndex = 17;
            // 
            // txtFlechas
            // 
            txtFlechas.Location = new Point(186, 350);
            txtFlechas.Name = "txtFlechas";
            txtFlechas.Size = new Size(190, 23);
            txtFlechas.TabIndex = 18;
            // 
            // txtTransmicion
            // 
            txtTransmicion.Location = new Point(186, 409);
            txtTransmicion.Name = "txtTransmicion";
            txtTransmicion.Size = new Size(190, 23);
            txtTransmicion.TabIndex = 19;
            // 
            // txtCarroocerias
            // 
            txtCarroocerias.Location = new Point(186, 482);
            txtCarroocerias.Name = "txtCarroocerias";
            txtCarroocerias.Size = new Size(190, 23);
            txtCarroocerias.TabIndex = 20;
            // 
            // txtMotor
            // 
            txtMotor.Location = new Point(730, 147);
            txtMotor.Name = "txtMotor";
            txtMotor.Size = new Size(190, 23);
            txtMotor.TabIndex = 21;
            // 
            // txtParabrisas
            // 
            txtParabrisas.Location = new Point(741, 219);
            txtParabrisas.Name = "txtParabrisas";
            txtParabrisas.Size = new Size(190, 23);
            txtParabrisas.TabIndex = 22;
            // 
            // txtSoldaduras
            // 
            txtSoldaduras.Location = new Point(761, 310);
            txtSoldaduras.Name = "txtSoldaduras";
            txtSoldaduras.Size = new Size(190, 23);
            txtSoldaduras.TabIndex = 23;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(730, 383);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 24;
            btnInsertar.Text = "button1";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // MantenimientoCamiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 652);
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
            Controls.SetChildIndex(btnSalir, 0);
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
    }
}