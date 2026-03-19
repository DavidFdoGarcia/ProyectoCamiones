namespace Camiones
{
    partial class VerOperador
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
            txtNombre = new TextBox();
            txtLicencia = new TextBox();
            txtMaterno = new TextBox();
            txtPaterno = new TextBox();
            txtDomicilio = new TextBox();
            txtINE = new TextBox();
            txtCURP = new TextBox();
            panel1 = new Panel();
            rbAptoNo = new RadioButton();
            rbAptoSi = new RadioButton();
            panel2 = new Panel();
            rbContratoNo = new RadioButton();
            rbContratoSi = new RadioButton();
            panel3 = new Panel();
            rbAntiNo = new RadioButton();
            rbAntiSi = new RadioButton();
            pictureBox1 = new PictureBox();
            txtID = new TextBox();
            label11 = new Label();
            btnConsultar = new Button();
            btnGenerar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(661, 552);
            btnSalir.Size = new Size(83, 34);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 79);
            label1.Name = "label1";
            label1.Size = new Size(70, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 576);
            label2.Name = "label2";
            label2.Size = new Size(138, 19);
            label2.TabIndex = 1;
            label2.Text = "Contrato Laboral";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 405);
            label3.Name = "label3";
            label3.Size = new Size(36, 19);
            label3.TabIndex = 2;
            label3.Text = "INE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 351);
            label4.Name = "label4";
            label4.Size = new Size(80, 19);
            label4.TabIndex = 3;
            label4.Text = "Domicilio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 303);
            label5.Name = "label5";
            label5.Size = new Size(104, 19);
            label5.TabIndex = 4;
            label5.Text = "Apto Medico";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 237);
            label6.Name = "label6";
            label6.Size = new Size(73, 19);
            label6.TabIndex = 5;
            label6.Text = "Licencia";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 177);
            label7.Name = "label7";
            label7.Size = new Size(137, 19);
            label7.TabIndex = 6;
            label7.Text = "Apellido Materno";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(25, 129);
            label8.Name = "label8";
            label8.Size = new Size(135, 19);
            label8.TabIndex = 7;
            label8.Text = "Apellido Paterno";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 514);
            label9.Name = "label9";
            label9.Size = new Size(97, 19);
            label9.TabIndex = 8;
            label9.Text = "Antiidoping";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(25, 462);
            label10.Name = "label10";
            label10.Size = new Size(56, 19);
            label10.TabIndex = 9;
            label10.Text = "CURP";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(157, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(325, 23);
            txtNombre.TabIndex = 10;
            // 
            // txtLicencia
            // 
            txtLicencia.Location = new Point(174, 225);
            txtLicencia.Name = "txtLicencia";
            txtLicencia.Size = new Size(325, 23);
            txtLicencia.TabIndex = 11;
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(189, 177);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(325, 23);
            txtMaterno.TabIndex = 12;
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(189, 129);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(325, 23);
            txtPaterno.TabIndex = 13;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(157, 351);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(325, 23);
            txtDomicilio.TabIndex = 14;
            // 
            // txtINE
            // 
            txtINE.Location = new Point(157, 401);
            txtINE.Name = "txtINE";
            txtINE.Size = new Size(325, 23);
            txtINE.TabIndex = 15;
            // 
            // txtCURP
            // 
            txtCURP.Location = new Point(157, 462);
            txtCURP.Name = "txtCURP";
            txtCURP.Size = new Size(325, 23);
            txtCURP.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbAptoNo);
            panel1.Controls.Add(rbAptoSi);
            panel1.Location = new Point(197, 280);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 42);
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint;
            // 
            // rbAptoNo
            // 
            rbAptoNo.AutoSize = true;
            rbAptoNo.Location = new Point(97, 14);
            rbAptoNo.Name = "rbAptoNo";
            rbAptoNo.Size = new Size(41, 19);
            rbAptoNo.TabIndex = 1;
            rbAptoNo.TabStop = true;
            rbAptoNo.Text = "No";
            rbAptoNo.UseVisualStyleBackColor = true;
            rbAptoNo.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbAptoSi
            // 
            rbAptoSi.AutoSize = true;
            rbAptoSi.Location = new Point(25, 14);
            rbAptoSi.Name = "rbAptoSi";
            rbAptoSi.Size = new Size(34, 19);
            rbAptoSi.TabIndex = 0;
            rbAptoSi.TabStop = true;
            rbAptoSi.Text = "Si";
            rbAptoSi.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(rbContratoNo);
            panel2.Controls.Add(rbContratoSi);
            panel2.Location = new Point(197, 553);
            panel2.Name = "panel2";
            panel2.Size = new Size(157, 42);
            panel2.TabIndex = 18;
            // 
            // rbContratoNo
            // 
            rbContratoNo.AutoSize = true;
            rbContratoNo.Location = new Point(97, 14);
            rbContratoNo.Name = "rbContratoNo";
            rbContratoNo.Size = new Size(41, 19);
            rbContratoNo.TabIndex = 1;
            rbContratoNo.TabStop = true;
            rbContratoNo.Text = "No";
            rbContratoNo.UseVisualStyleBackColor = true;
            // 
            // rbContratoSi
            // 
            rbContratoSi.AutoSize = true;
            rbContratoSi.Location = new Point(25, 14);
            rbContratoSi.Name = "rbContratoSi";
            rbContratoSi.Size = new Size(34, 19);
            rbContratoSi.TabIndex = 0;
            rbContratoSi.TabStop = true;
            rbContratoSi.Text = "Si";
            rbContratoSi.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(rbAntiNo);
            panel3.Controls.Add(rbAntiSi);
            panel3.Location = new Point(197, 491);
            panel3.Name = "panel3";
            panel3.Size = new Size(157, 42);
            panel3.TabIndex = 18;
            // 
            // rbAntiNo
            // 
            rbAntiNo.AutoSize = true;
            rbAntiNo.Location = new Point(97, 14);
            rbAntiNo.Name = "rbAntiNo";
            rbAntiNo.Size = new Size(41, 19);
            rbAntiNo.TabIndex = 1;
            rbAntiNo.TabStop = true;
            rbAntiNo.Text = "No";
            rbAntiNo.UseVisualStyleBackColor = true;
            // 
            // rbAntiSi
            // 
            rbAntiSi.AutoSize = true;
            rbAntiSi.Location = new Point(25, 14);
            rbAntiSi.Name = "rbAntiSi";
            rbAntiSi.Size = new Size(34, 19);
            rbAntiSi.TabIndex = 0;
            rbAntiSi.TabStop = true;
            rbAntiSi.Text = "Si";
            rbAntiSi.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(590, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 136);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // txtID
            // 
            txtID.Location = new Point(222, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(61, 23);
            txtID.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(25, 26);
            label11.Name = "label11";
            label11.Size = new Size(173, 19);
            label11.TabIndex = 21;
            label11.Text = "Numero del Operador";
            label11.Click += label11_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(661, 401);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(95, 37);
            btnConsultar.TabIndex = 22;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.Location = new Point(661, 472);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(83, 46);
            btnGenerar.TabIndex = 23;
            btnGenerar.Text = "Generar Reporte";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // VerOperador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 636);
            Controls.Add(btnGenerar);
            Controls.Add(btnConsultar);
            Controls.Add(label11);
            Controls.Add(txtID);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(txtCURP);
            Controls.Add(txtINE);
            Controls.Add(txtDomicilio);
            Controls.Add(txtPaterno);
            Controls.Add(txtMaterno);
            Controls.Add(txtLicencia);
            Controls.Add(txtNombre);
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
            Name = "VerOperador";
            Text = "VerOperador";
            Load += VerOperador_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(label10, 0);
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtLicencia, 0);
            Controls.SetChildIndex(txtMaterno, 0);
            Controls.SetChildIndex(txtPaterno, 0);
            Controls.SetChildIndex(txtDomicilio, 0);
            Controls.SetChildIndex(txtINE, 0);
            Controls.SetChildIndex(txtCURP, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(txtID, 0);
            Controls.SetChildIndex(label11, 0);
            Controls.SetChildIndex(btnConsultar, 0);
            Controls.SetChildIndex(btnGenerar, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private TextBox txtNombre;
        private TextBox txtLicencia;
        private TextBox txtMaterno;
        private TextBox txtPaterno;
        private TextBox txtDomicilio;
        private TextBox txtINE;
        private TextBox txtCURP;
        private Panel panel1;
        private RadioButton rbAptoNo;
        private RadioButton rbAptoSi;
        private Panel panel2;
        private Panel panel3;
        private RadioButton rbAntiNo;
        private RadioButton rbAntiSi;
        private RadioButton rbContratoNo;
        private RadioButton rbContratoSi;
        private PictureBox pictureBox1;
        private TextBox txtID;
        private Label label11;
        private Button btnConsultar;
        private Button btnGenerar;
    }
}