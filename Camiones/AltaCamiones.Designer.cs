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
            ((System.ComponentModel.ISupportInitialize)Evacio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgConsulta).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1051, 710);
            btnSalir.Margin = new Padding(6, 8, 6, 8);
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(1051, 342);
            btnInsertar.Margin = new Padding(6, 8, 6, 8);
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(1051, 222);
            btnConsultar.Margin = new Padding(6, 8, 6, 8);
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(1051, 582);
            btnBaja.Margin = new Padding(6, 8, 6, 8);
            btnBaja.Click += btnBaja_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(1051, 460);
            btnActualizar.Margin = new Padding(6, 8, 6, 8);
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(53, 120);
            lblTipo.Margin = new Padding(4, 0, 4, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(235, 36);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo de Camión";
            // 
            // txtCamion
            // 
            txtCamion.Location = new Point(299, 122);
            txtCamion.Margin = new Padding(4, 5, 4, 5);
            txtCamion.Name = "txtCamion";
            txtCamion.Size = new Size(485, 31);
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
            dgConsulta.Location = new Point(53, 222);
            dgConsulta.Margin = new Padding(4, 5, 4, 5);
            dgConsulta.Name = "dgConsulta";
            dgConsulta.ReadOnly = true;
            dgConsulta.RowHeadersWidth = 62;
            dgConsulta.Size = new Size(951, 572);
            dgConsulta.TabIndex = 4;
            dgConsulta.Visible = false;
            dgConsulta.CellClick += dgConsulta_CellClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(879, 127);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.Size = new Size(65, 31);
            txtId.TabIndex = 6;
            txtId.Visible = false;
            // 
            // AltaCamiones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 833);
            Controls.Add(txtId);
            Controls.Add(dgConsulta);
            Controls.Add(txtCamion);
            Controls.Add(lblTipo);
            Margin = new Padding(6, 8, 6, 8);
            Name = "AltaCamiones";
            Text = "Alta de Camiones";
            Load += AltaCamiones_Load;
            Controls.SetChildIndex(btnActualizar, 0);
            Controls.SetChildIndex(btnBaja, 0);
            Controls.SetChildIndex(btnConsultar, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(btnInsertar, 0);
            Controls.SetChildIndex(lblTipo, 0);
            Controls.SetChildIndex(txtCamion, 0);
            Controls.SetChildIndex(dgConsulta, 0);
            Controls.SetChildIndex(txtId, 0);
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
    }
}