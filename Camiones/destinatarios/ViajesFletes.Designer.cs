namespace Camiones.destinatarios
{
    partial class ViajesFletes
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
            label1 = new Label();
            cmbDestinatario = new ComboBox();
            label2 = new Label();
            dtFecha = new DateTimePicker();
            txtNumeroRemision = new TextBox();
            label3 = new Label();
            txtOrigen = new TextBox();
            txtDestino = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCartaPorte = new TextBox();
            label9 = new Label();
            txtRegistroViaje = new TextBox();
            btnGuardar = new Button();
            dgvViajes = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvViajes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(816, 101);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Size = new Size(122, 38);
            // 
            // cmbCamion
            // 
            cmbCamion.FormattingEnabled = true;
            cmbCamion.Location = new Point(126, 13);
            cmbCamion.Margin = new Padding(3, 2, 3, 2);
            cmbCamion.Name = "cmbCamion";
            cmbCamion.Size = new Size(133, 23);
            cmbCamion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 16);
            label1.Name = "label1";
            label1.Size = new Size(63, 18);
            label1.TabIndex = 2;
            label1.Text = "Camión";
            // 
            // cmbDestinatario
            // 
            cmbDestinatario.FormattingEnabled = true;
            cmbDestinatario.Location = new Point(152, 56);
            cmbDestinatario.Margin = new Padding(3, 2, 3, 2);
            cmbDestinatario.Name = "cmbDestinatario";
            cmbDestinatario.Size = new Size(133, 23);
            cmbDestinatario.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 60);
            label2.Name = "label2";
            label2.Size = new Size(62, 18);
            label2.TabIndex = 4;
            label2.Text = "Destino";
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(66, 101);
            dtFecha.Margin = new Padding(3, 2, 3, 2);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(219, 23);
            dtFecha.TabIndex = 5;
            // 
            // txtNumeroRemision
            // 
            txtNumeroRemision.Location = new Point(440, 10);
            txtNumeroRemision.Margin = new Padding(3, 2, 3, 2);
            txtNumeroRemision.Name = "txtNumeroRemision";
            txtNumeroRemision.Size = new Size(110, 23);
            txtNumeroRemision.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(320, 10);
            label3.Name = "label3";
            label3.Size = new Size(74, 18);
            label3.TabIndex = 7;
            label3.Text = "Remisión";
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(440, 50);
            txtOrigen.Margin = new Padding(3, 2, 3, 2);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(110, 23);
            txtOrigen.TabIndex = 8;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(440, 90);
            txtDestino.Margin = new Padding(3, 2, 3, 2);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(110, 23);
            txtDestino.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(320, 92);
            label4.Name = "label4";
            label4.Size = new Size(62, 18);
            label4.TabIndex = 10;
            label4.Text = "Destino";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(320, 50);
            label5.Name = "label5";
            label5.Size = new Size(55, 18);
            label5.TabIndex = 11;
            label5.Text = "Origen";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(590, 16);
            label6.Name = "label6";
            label6.Size = new Size(89, 18);
            label6.TabIndex = 17;
            label6.Text = "Carta Porte";
            // 
            // txtCartaPorte
            // 
            txtCartaPorte.Location = new Point(718, 19);
            txtCartaPorte.Margin = new Padding(3, 2, 3, 2);
            txtCartaPorte.Name = "txtCartaPorte";
            txtCartaPorte.Size = new Size(110, 23);
            txtCartaPorte.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(590, 56);
            label9.Name = "label9";
            label9.Size = new Size(107, 18);
            label9.TabIndex = 19;
            label9.Text = "Registro Viaje";
            // 
            // txtRegistroViaje
            // 
            txtRegistroViaje.Location = new Point(725, 56);
            txtRegistroViaje.Margin = new Padding(3, 2, 3, 2);
            txtRegistroViaje.Name = "txtRegistroViaje";
            txtRegistroViaje.Size = new Size(110, 23);
            txtRegistroViaje.TabIndex = 18;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(650, 101);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 35);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvViajes
            // 
            dgvViajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViajes.Location = new Point(12, 151);
            dgvViajes.Margin = new Padding(3, 2, 3, 2);
            dgvViajes.Name = "dgvViajes";
            dgvViajes.RowHeadersWidth = 51;
            dgvViajes.Size = new Size(985, 192);
            dgvViajes.TabIndex = 21;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ViajesFletes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 351);
            Controls.Add(dgvViajes);
            Controls.Add(btnGuardar);
            Controls.Add(label9);
            Controls.Add(txtRegistroViaje);
            Controls.Add(label6);
            Controls.Add(txtCartaPorte);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDestino);
            Controls.Add(txtOrigen);
            Controls.Add(label3);
            Controls.Add(txtNumeroRemision);
            Controls.Add(dtFecha);
            Controls.Add(label2);
            Controls.Add(cmbDestinatario);
            Controls.Add(label1);
            Controls.Add(cmbCamion);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViajesFletes";
            Text = "ViajesFletes";
            Load += ViajesFletes_Load;
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(cmbCamion, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(cmbDestinatario, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(dtFecha, 0);
            Controls.SetChildIndex(txtNumeroRemision, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtOrigen, 0);
            Controls.SetChildIndex(txtDestino, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtCartaPorte, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(txtRegistroViaje, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(btnGuardar, 0);
            Controls.SetChildIndex(dgvViajes, 0);
            ((System.ComponentModel.ISupportInitialize)dgvViajes).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCamion;
        private Label label1;
        private ComboBox cmbDestinatario;
        private Label label2;
        private DateTimePicker dtFecha;
        private TextBox txtNumeroRemision;
        private Label label3;
        private TextBox txtOrigen;
        private TextBox txtDestino;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCartaPorte;
        private Label label9;
        private TextBox txtRegistroViaje;
        private Button btnGuardar;
        private DataGridView dgvViajes;
        private ErrorProvider errorProvider1;
    }
}