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
            dgConsulta = new DataGridView();
            txtId = new TextBox();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Evacio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgConsulta).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(736, 426);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(736, 205);
            btnInsertar.Margin = new Padding(4, 5, 4, 5);
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(736, 133);
            btnConsultar.Margin = new Padding(4, 5, 4, 5);
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(736, 349);
            btnBaja.Margin = new Padding(4, 5, 4, 5);
            btnBaja.Click += btnBaja_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(736, 276);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(494, 78);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Size = new Size(146, 29);
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(704, 39);
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
            ClientSize = new Size(905, 500);
            Controls.Add(txtBuscar);
            Controls.Add(txtId);
            Controls.Add(dgConsulta);
            Controls.Add(txtCamion);
            Controls.Add(lblTipo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AltaCamiones";
            Text = "Alta de Camiones";
            Load += AltaCamiones_Load;
            Controls.SetChildIndex(btnGenerar, 0);
            Controls.SetChildIndex(lblTipo, 0);
            Controls.SetChildIndex(txtCamion, 0);
            Controls.SetChildIndex(dgConsulta, 0);
            Controls.SetChildIndex(txtId, 0);
            Controls.SetChildIndex(txtBuscar, 0);
            Controls.SetChildIndex(btnBuscar, 0);
            Controls.SetChildIndex(btnActualizar, 0);
            Controls.SetChildIndex(btnBaja, 0);
            Controls.SetChildIndex(btnConsultar, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(btnInsertar, 0);
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
    }
}