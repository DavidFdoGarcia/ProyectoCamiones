namespace Camiones
{
    partial class AltaCamiones
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
            lblTipo = new Label();
            txtCamion = new TextBox();
            Evacio = new ErrorProvider(components);
            btnConsulta = new Button();
            btnInserta = new Button();
            btnActualiza = new Button();
            button1 = new Button();
            btnGenerarReporte = new Button();
            dgConsulta = new DataGridView();
            txtId = new TextBox();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Evacio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgConsulta).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(943, 414);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Size = new Size(101, 43);
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(35, 26);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(155, 24);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo de Camión";
            // 
            // txtCamion
            // 
            txtCamion.Location = new Point(228, 29);
            txtCamion.Name = "txtCamion";
            txtCamion.Size = new Size(341, 23);
            txtCamion.TabIndex = 3;
            txtCamion.KeyDown += txtTipo_KeyDown;
            // 
            // Evacio
            // 
            Evacio.ContainerControl = this;
            // 
            // btnConsulta
            // 
            btnConsulta.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Evacio.SetIconAlignment(btnConsulta, ErrorIconAlignment.BottomLeft);
            btnConsulta.ImageAlign = ContentAlignment.BottomCenter;
            btnConsulta.Location = new Point(943, 82);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(102, 54);
            btnConsulta.TabIndex = 8;
            btnConsulta.Text = "Buscar Camión";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // btnInserta
            // 
            btnInserta.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Evacio.SetIconAlignment(btnInserta, ErrorIconAlignment.BottomLeft);
            btnInserta.ImageAlign = ContentAlignment.BottomCenter;
            btnInserta.Location = new Point(943, 148);
            btnInserta.Name = "btnInserta";
            btnInserta.Size = new Size(102, 48);
            btnInserta.TabIndex = 9;
            btnInserta.Text = "Nuevo Camión";
            btnInserta.UseVisualStyleBackColor = true;
            btnInserta.Click += btnInserta_Click;
            // 
            // btnActualiza
            // 
            btnActualiza.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Evacio.SetIconAlignment(btnActualiza, ErrorIconAlignment.BottomLeft);
            btnActualiza.ImageAlign = ContentAlignment.BottomCenter;
            btnActualiza.Location = new Point(943, 215);
            btnActualiza.Name = "btnActualiza";
            btnActualiza.Size = new Size(102, 48);
            btnActualiza.TabIndex = 10;
            btnActualiza.Text = "Actualizar Registro";
            btnActualiza.UseVisualStyleBackColor = true;
            btnActualiza.Click += btnActualiza_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Evacio.SetIconAlignment(button1, ErrorIconAlignment.BottomLeft);
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(943, 280);
            button1.Name = "button1";
            button1.Size = new Size(102, 48);
            button1.TabIndex = 11;
            button1.Text = "Baja Camión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Evacio.SetIconAlignment(btnGenerarReporte, ErrorIconAlignment.BottomLeft);
            btnGenerarReporte.ImageAlign = ContentAlignment.BottomCenter;
            btnGenerarReporte.Location = new Point(943, 347);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(102, 48);
            btnGenerarReporte.TabIndex = 12;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // dgConsulta
            // 
            dgConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgConsulta.Location = new Point(21, 145);
            dgConsulta.Name = "dgConsulta";
            dgConsulta.ReadOnly = true;
            dgConsulta.RowHeadersWidth = 62;
            dgConsulta.Size = new Size(666, 343);
            dgConsulta.TabIndex = 4;
            dgConsulta.Visible = false;
            dgConsulta.CellClick += dgConsulta_CellClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(615, 29);
            txtId.Name = "txtId";
            txtId.Size = new Size(47, 23);
            txtId.TabIndex = 6;
            txtId.Visible = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(35, 87);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(400, 23);
            txtBuscar.TabIndex = 7;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // AltaCamiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 530);
            Controls.Add(btnGenerarReporte);
            Controls.Add(button1);
            Controls.Add(btnActualiza);
            Controls.Add(btnInserta);
            Controls.Add(btnConsulta);
            Controls.Add(txtBuscar);
            Controls.Add(txtId);
            Controls.Add(dgConsulta);
            Controls.Add(txtCamion);
            Controls.Add(lblTipo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AltaCamiones";
            Text = "Alta de Camiones";
            Load += AltaCamiones_Load;
            Controls.SetChildIndex(lblTipo, 0);
            Controls.SetChildIndex(txtCamion, 0);
            Controls.SetChildIndex(dgConsulta, 0);
            Controls.SetChildIndex(txtId, 0);
            Controls.SetChildIndex(txtBuscar, 0);
            Controls.SetChildIndex(btnConsulta, 0);
            Controls.SetChildIndex(btnInserta, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(btnActualiza, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(btnGenerarReporte, 0);
            ((System.ComponentModel.ISupportInitialize)Evacio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipo;
        private TextBox txtCamion;
        private ErrorProvider Evacio;
        private DataGridView dgConsulta;
        private TextBox txtId;
        private TextBox txtBuscar;
        private Button btnConsulta;
        private Button btnInserta;
        private Button btnActualiza;
        private Button button1;
        private Button btnGenerarReporte;
    }
}