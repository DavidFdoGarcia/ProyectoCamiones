namespace Camiones
{
    partial class Operadores
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
            lblNombre = new Label();
            lblMaterno = new Label();
            lblPaterno = new Label();
            txtNombre = new TextBox();
            txtPaterno = new TextBox();
            txtMaterno = new TextBox();
            lblLicencia = new Label();
            lblApto = new Label();
            lblDomicilio = new Label();
            lblINE = new Label();
            lblCURP = new Label();
            lblCondiciones = new Label();
            openFileDialog1 = new OpenFileDialog();
            rbAntiSI = new RadioButton();
            lblAnti = new Label();
            rbContratoNO = new RadioButton();
            rbContratoSI = new RadioButton();
            gbAntidoping = new Panel();
            rbAntiNO = new RadioButton();
            gbAptoMedico = new Panel();
            rbdAptoNO = new RadioButton();
            rbAptoSi = new RadioButton();
            gbContrato = new Panel();
            gbLicencia = new Panel();
            rbdlicenciNO = new RadioButton();
            rbLicenciaSI = new RadioButton();
            txtINE = new TextBox();
            TXTcurp = new TextBox();
            txtDomicilio = new TextBox();
            btnInserta = new Button();
            button1 = new Button();
            txtID = new TextBox();
            txtLicencia = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            gbAntidoping.SuspendLayout();
            gbAptoMedico.SuspendLayout();
            gbContrato.SuspendLayout();
            gbLicencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(714, 464);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Size = new Size(98, 48);
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(35, 47);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(74, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaterno
            // 
            lblMaterno.AutoSize = true;
            lblMaterno.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaterno.Location = new Point(36, 130);
            lblMaterno.Name = "lblMaterno";
            lblMaterno.Size = new Size(146, 25);
            lblMaterno.TabIndex = 2;
            lblMaterno.Text = "Apellido Materno";
            lblMaterno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPaterno
            // 
            lblPaterno.AutoSize = true;
            lblPaterno.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaterno.Location = new Point(35, 87);
            lblPaterno.Name = "lblPaterno";
            lblPaterno.Size = new Size(142, 25);
            lblPaterno.TabIndex = 3;
            lblPaterno.Text = "Apellido Paterno";
            lblPaterno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(400, 23);
            txtNombre.TabIndex = 4;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(192, 87);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(400, 23);
            txtPaterno.TabIndex = 5;
            txtPaterno.KeyPress += txtPaterno_KeyPress;
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(202, 130);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(400, 23);
            txtMaterno.TabIndex = 6;
            txtMaterno.TextChanged += txtMaterno_TextChanged;
            txtMaterno.KeyPress += txtMaterno_KeyPress;
            // 
            // lblLicencia
            // 
            lblLicencia.AutoSize = true;
            lblLicencia.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLicencia.Location = new Point(35, 171);
            lblLicencia.Name = "lblLicencia";
            lblLicencia.Size = new Size(78, 25);
            lblLicencia.TabIndex = 7;
            lblLicencia.Text = "Licencia";
            lblLicencia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblApto
            // 
            lblApto.AutoSize = true;
            lblApto.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApto.Location = new Point(36, 212);
            lblApto.Name = "lblApto";
            lblApto.Size = new Size(110, 25);
            lblApto.TabIndex = 8;
            lblApto.Text = "Apto medico";
            lblApto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDomicilio.Location = new Point(36, 256);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(83, 25);
            lblDomicilio.TabIndex = 9;
            lblDomicilio.Text = "Domicilio";
            lblDomicilio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblINE
            // 
            lblINE.AutoSize = true;
            lblINE.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblINE.Location = new Point(36, 296);
            lblINE.Name = "lblINE";
            lblINE.Size = new Size(39, 25);
            lblINE.TabIndex = 11;
            lblINE.Text = "INE";
            lblINE.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCURP
            // 
            lblCURP.AutoSize = true;
            lblCURP.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCURP.Location = new Point(35, 342);
            lblCURP.Name = "lblCURP";
            lblCURP.Size = new Size(59, 25);
            lblCURP.TabIndex = 14;
            lblCURP.Text = "CURP";
            lblCURP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCondiciones
            // 
            lblCondiciones.AutoSize = true;
            lblCondiciones.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCondiciones.Location = new Point(36, 445);
            lblCondiciones.Name = "lblCondiciones";
            lblCondiciones.Size = new Size(145, 25);
            lblCondiciones.TabIndex = 16;
            lblCondiciones.Text = "Contrato Laboral";
            lblCondiciones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // rbAntiSI
            // 
            rbAntiSI.AutoSize = true;
            rbAntiSI.Location = new Point(13, 14);
            rbAntiSI.Name = "rbAntiSI";
            rbAntiSI.Size = new Size(34, 19);
            rbAntiSI.TabIndex = 34;
            rbAntiSI.Text = "SI";
            rbAntiSI.UseVisualStyleBackColor = true;
            rbAntiSI.CheckedChanged += rdbAntiSI_CheckedChanged;
            // 
            // lblAnti
            // 
            lblAnti.AutoSize = true;
            lblAnti.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnti.Location = new Point(35, 384);
            lblAnti.Name = "lblAnti";
            lblAnti.Size = new Size(96, 25);
            lblAnti.TabIndex = 13;
            lblAnti.Text = "Antidoping";
            lblAnti.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbContratoNO
            // 
            rbContratoNO.AutoSize = true;
            rbContratoNO.Location = new Point(75, 14);
            rbContratoNO.Name = "rbContratoNO";
            rbContratoNO.Size = new Size(43, 19);
            rbContratoNO.TabIndex = 43;
            rbContratoNO.Text = "NO";
            rbContratoNO.UseVisualStyleBackColor = true;
            // 
            // rbContratoSI
            // 
            rbContratoSI.AutoSize = true;
            rbContratoSI.Location = new Point(19, 14);
            rbContratoSI.Name = "rbContratoSI";
            rbContratoSI.Size = new Size(34, 19);
            rbContratoSI.TabIndex = 42;
            rbContratoSI.Text = "SI";
            rbContratoSI.UseVisualStyleBackColor = true;
            rbContratoSI.CheckedChanged += rbContratoSI_CheckedChanged;
            // 
            // gbAntidoping
            // 
            gbAntidoping.Controls.Add(rbAntiNO);
            gbAntidoping.Controls.Add(rbAntiSI);
            gbAntidoping.Location = new Point(202, 373);
            gbAntidoping.Name = "gbAntidoping";
            gbAntidoping.Size = new Size(264, 38);
            gbAntidoping.TabIndex = 45;
            // 
            // rbAntiNO
            // 
            rbAntiNO.AutoSize = true;
            rbAntiNO.Checked = true;
            rbAntiNO.Location = new Point(69, 13);
            rbAntiNO.Name = "rbAntiNO";
            rbAntiNO.Size = new Size(43, 19);
            rbAntiNO.TabIndex = 35;
            rbAntiNO.TabStop = true;
            rbAntiNO.Text = "NO";
            rbAntiNO.UseVisualStyleBackColor = true;
            // 
            // gbAptoMedico
            // 
            gbAptoMedico.Controls.Add(rbdAptoNO);
            gbAptoMedico.Controls.Add(rbAptoSi);
            gbAptoMedico.Location = new Point(154, 205);
            gbAptoMedico.Name = "gbAptoMedico";
            gbAptoMedico.Size = new Size(279, 40);
            gbAptoMedico.TabIndex = 46;
            // 
            // rbdAptoNO
            // 
            rbdAptoNO.AutoSize = true;
            rbdAptoNO.Checked = true;
            rbdAptoNO.Location = new Point(69, 13);
            rbdAptoNO.Name = "rbdAptoNO";
            rbdAptoNO.Size = new Size(43, 19);
            rbdAptoNO.TabIndex = 35;
            rbdAptoNO.TabStop = true;
            rbdAptoNO.Text = "NO";
            rbdAptoNO.UseVisualStyleBackColor = true;
            // 
            // rbAptoSi
            // 
            rbAptoSi.AutoSize = true;
            rbAptoSi.Location = new Point(13, 13);
            rbAptoSi.Name = "rbAptoSi";
            rbAptoSi.Size = new Size(34, 19);
            rbAptoSi.TabIndex = 34;
            rbAptoSi.Text = "SI";
            rbAptoSi.UseVisualStyleBackColor = true;
            rbAptoSi.CheckedChanged += rbdAptoSI_CheckedChanged;
            // 
            // gbContrato
            // 
            gbContrato.BackColor = SystemColors.MenuBar;
            gbContrato.Controls.Add(rbContratoSI);
            gbContrato.Controls.Add(rbContratoNO);
            gbContrato.Location = new Point(247, 450);
            gbContrato.Name = "gbContrato";
            gbContrato.Size = new Size(291, 39);
            gbContrato.TabIndex = 49;
            // 
            // gbLicencia
            // 
            gbLicencia.Controls.Add(rbdlicenciNO);
            gbLicencia.Controls.Add(rbLicenciaSI);
            gbLicencia.Location = new Point(146, 162);
            gbLicencia.Name = "gbLicencia";
            gbLicencia.Size = new Size(256, 37);
            gbLicencia.TabIndex = 47;
            // 
            // rbdlicenciNO
            // 
            rbdlicenciNO.AutoSize = true;
            rbdlicenciNO.Checked = true;
            rbdlicenciNO.Location = new Point(69, 13);
            rbdlicenciNO.Name = "rbdlicenciNO";
            rbdlicenciNO.Size = new Size(43, 19);
            rbdlicenciNO.TabIndex = 35;
            rbdlicenciNO.TabStop = true;
            rbdlicenciNO.Text = "NO";
            rbdlicenciNO.UseVisualStyleBackColor = true;
            // 
            // rbLicenciaSI
            // 
            rbLicenciaSI.AutoSize = true;
            rbLicenciaSI.Location = new Point(13, 13);
            rbLicenciaSI.Name = "rbLicenciaSI";
            rbLicenciaSI.Size = new Size(34, 19);
            rbLicenciaSI.TabIndex = 34;
            rbLicenciaSI.Text = "SI";
            rbLicenciaSI.UseVisualStyleBackColor = true;
            rbLicenciaSI.CheckedChanged += rbLicenciaSI_CheckedChanged;
            // 
            // txtINE
            // 
            txtINE.Location = new Point(125, 296);
            txtINE.Name = "txtINE";
            txtINE.Size = new Size(277, 23);
            txtINE.TabIndex = 51;
            txtINE.TextChanged += txtINE_TextChanged;
            txtINE.KeyPress += txtINE_KeyPress;
            // 
            // TXTcurp
            // 
            TXTcurp.Location = new Point(116, 342);
            TXTcurp.Name = "TXTcurp";
            TXTcurp.Size = new Size(288, 23);
            TXTcurp.TabIndex = 52;
            TXTcurp.TextChanged += TXTcurp_TextChanged;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(137, 261);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(455, 23);
            txtDomicilio.TabIndex = 53;
            // 
            // btnInserta
            // 
            btnInserta.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserta.Location = new Point(716, 333);
            btnInserta.Name = "btnInserta";
            btnInserta.Size = new Size(96, 47);
            btnInserta.TabIndex = 69;
            btnInserta.Text = "Nuevo Operador";
            btnInserta.UseVisualStyleBackColor = true;
            btnInserta.Click += btnInserta_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(695, 400);
            button1.Name = "button1";
            button1.Size = new Size(117, 47);
            button1.TabIndex = 77;
            button1.Text = "Subir Documentos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // txtID
            // 
            txtID.Location = new Point(154, 12);
            txtID.Name = "txtID";
            txtID.Size = new Size(455, 23);
            txtID.TabIndex = 78;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtLicencia
            // 
            txtLicencia.Location = new Point(426, 162);
            txtLicencia.Name = "txtLicencia";
            txtLicencia.Size = new Size(244, 23);
            txtLicencia.TabIndex = 79;
            txtLicencia.KeyPress += txtLicencia_KeyPress;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Operadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            BackgroundImage = Properties.Resources.istockphoto_1465157700_612x612;
            ClientSize = new Size(837, 552);
            Controls.Add(txtLicencia);
            Controls.Add(txtID);
            Controls.Add(button1);
            Controls.Add(btnInserta);
            Controls.Add(txtDomicilio);
            Controls.Add(TXTcurp);
            Controls.Add(txtINE);
            Controls.Add(gbLicencia);
            Controls.Add(gbAptoMedico);
            Controls.Add(gbContrato);
            Controls.Add(gbAntidoping);
            Controls.Add(lblCondiciones);
            Controls.Add(lblCURP);
            Controls.Add(lblAnti);
            Controls.Add(lblINE);
            Controls.Add(lblDomicilio);
            Controls.Add(lblApto);
            Controls.Add(lblLicencia);
            Controls.Add(txtMaterno);
            Controls.Add(txtPaterno);
            Controls.Add(txtNombre);
            Controls.Add(lblPaterno);
            Controls.Add(lblMaterno);
            Controls.Add(lblNombre);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Operadores";
            Text = "Operadores";
            Load += Operadores_Load;
            Controls.SetChildIndex(lblNombre, 0);
            Controls.SetChildIndex(lblMaterno, 0);
            Controls.SetChildIndex(lblPaterno, 0);
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtPaterno, 0);
            Controls.SetChildIndex(txtMaterno, 0);
            Controls.SetChildIndex(lblLicencia, 0);
            Controls.SetChildIndex(lblApto, 0);
            Controls.SetChildIndex(lblDomicilio, 0);
            Controls.SetChildIndex(lblINE, 0);
            Controls.SetChildIndex(lblAnti, 0);
            Controls.SetChildIndex(lblCURP, 0);
            Controls.SetChildIndex(lblCondiciones, 0);
            Controls.SetChildIndex(gbAntidoping, 0);
            Controls.SetChildIndex(gbContrato, 0);
            Controls.SetChildIndex(gbAptoMedico, 0);
            Controls.SetChildIndex(gbLicencia, 0);
            Controls.SetChildIndex(txtINE, 0);
            Controls.SetChildIndex(TXTcurp, 0);
            Controls.SetChildIndex(txtDomicilio, 0);
            Controls.SetChildIndex(btnInserta, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(txtID, 0);
            Controls.SetChildIndex(txtLicencia, 0);
            gbAntidoping.ResumeLayout(false);
            gbAntidoping.PerformLayout();
            gbAptoMedico.ResumeLayout(false);
            gbAptoMedico.PerformLayout();
            gbContrato.ResumeLayout(false);
            gbContrato.PerformLayout();
            gbLicencia.ResumeLayout(false);
            gbLicencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblMaterno;
        private Label lblPaterno;
        private TextBox txtNombre;
        private TextBox txtPaterno;
        private TextBox txtMaterno;
        private Label lblLicencia;
        private Label lblApto;
        private Label lblDomicilio;
        private Label lblINE;
        private Label lblCURP;
        private Label lblCondiciones;
        private OpenFileDialog openFileDialog1;
        private RadioButton rbAntiSI;
        private Label lblAnti;
        private RadioButton rbContratoNO;
        private RadioButton rbContratoSI;
        private Panel panel1;
        private Panel gbAptoMedico;
        private RadioButton rbdAptoNO;
        private RadioButton rbAptoSi;
        private Panel gbContrato;
        private Panel gbLicencia;
        private RadioButton rbdlicenciNO;
        private RadioButton rbLicenciaSI;
        private TextBox txtINE;
        private TextBox TXTcurp;
        private TextBox txtDomicilio;
        private Button btnInserta;
        private RadioButton rbAntiNO;
        private Button button1;
        private TextBox txtID;
        private TextBox txtLicencia;
        private ErrorProvider errorProvider1;
        protected Panel gbAntidoping;
    }
}