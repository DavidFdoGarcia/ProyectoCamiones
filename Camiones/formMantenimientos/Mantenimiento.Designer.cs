namespace Camiones.formMantenimientos
{
    partial class Mantenimiento
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
            cmbOperador = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnNuevo = new Button();
            cmbServicio = new ComboBox();
            label3 = new Label();
            txtCantidad = new TextBox();
            label4 = new Label();
            btnnServicio = new Button();
            dgDetalle = new DataGridView();
            txtTotal = new TextBox();
            button1 = new Button();
            label5 = new Label();
            btnCheck = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1023, 453);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Size = new Size(122, 38);
            // 
            // cmbCamion
            // 
            cmbCamion.FormattingEnabled = true;
            cmbCamion.Location = new Point(237, 56);
            cmbCamion.Margin = new Padding(2, 2, 2, 2);
            cmbCamion.Name = "cmbCamion";
            cmbCamion.Size = new Size(129, 23);
            cmbCamion.TabIndex = 0;
            // 
            // cmbOperador
            // 
            cmbOperador.FormattingEnabled = true;
            cmbOperador.Location = new Point(237, 140);
            cmbOperador.Margin = new Padding(2, 2, 2, 2);
            cmbOperador.Name = "cmbOperador";
            cmbOperador.Size = new Size(129, 23);
            cmbOperador.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 58);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 19);
            label1.TabIndex = 2;
            label1.Text = "Camión";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 143);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 3;
            label2.Text = "Operador";
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(479, 80);
            btnNuevo.Margin = new Padding(2, 2, 2, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(136, 64);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Crear Mantenimiento";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // cmbServicio
            // 
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Location = new Point(654, 265);
            cmbServicio.Margin = new Padding(2, 2, 2, 2);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(129, 23);
            cmbServicio.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(519, 265);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 6;
            label3.Text = "Servicio";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(516, 370);
            txtCantidad.Margin = new Padding(2, 2, 2, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(106, 23);
            txtCantidad.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(396, 370);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 8;
            label4.Text = "Cantidad";
            // 
            // btnnServicio
            // 
            btnnServicio.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnnServicio.Location = new Point(878, 256);
            btnnServicio.Margin = new Padding(2, 2, 2, 2);
            btnnServicio.Name = "btnnServicio";
            btnnServicio.Size = new Size(136, 64);
            btnnServicio.TabIndex = 9;
            btnnServicio.Text = "Agregar Servicio";
            btnnServicio.UseVisualStyleBackColor = true;
            btnnServicio.Click += btnnServicio_Click;
            // 
            // dgDetalle
            // 
            dgDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDetalle.Location = new Point(911, 98);
            dgDetalle.Margin = new Padding(2, 2, 2, 2);
            dgDetalle.Name = "dgDetalle";
            dgDetalle.RowHeadersWidth = 62;
            dgDetalle.Size = new Size(252, 135);
            dgDetalle.TabIndex = 10;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(686, 434);
            txtTotal.Margin = new Padding(2, 2, 2, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(106, 23);
            txtTotal.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(39, 291);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(136, 64);
            button1.TabIndex = 13;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(610, 438);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 19);
            label5.TabIndex = 14;
            label5.Text = "Total";
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.Location = new Point(858, 347);
            btnCheck.Margin = new Padding(2, 2, 2, 2);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(136, 64);
            btnCheck.TabIndex = 15;
            btnCheck.Text = "Checklist";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Mantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 549);
            Controls.Add(btnCheck);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(txtTotal);
            Controls.Add(dgDetalle);
            Controls.Add(btnnServicio);
            Controls.Add(label4);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(cmbServicio);
            Controls.Add(btnNuevo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbOperador);
            Controls.Add(cmbCamion);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Mantenimiento";
            Text = "Mantenimiento";
            Load += Mantenimiento_Load;
            Controls.SetChildIndex(cmbCamion, 0);
            Controls.SetChildIndex(cmbOperador, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(btnNuevo, 0);
            Controls.SetChildIndex(cmbServicio, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtCantidad, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(btnnServicio, 0);
            Controls.SetChildIndex(dgDetalle, 0);
            Controls.SetChildIndex(txtTotal, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(btnCheck, 0);
            ((System.ComponentModel.ISupportInitialize)dgDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCamion;
        private ComboBox cmbOperador;
        private Label label1;
        private Label label2;
        private Button btnNuevo;
        private ComboBox cmbServicio;
        private Label label3;
        private TextBox txtCantidad;
        private Label label4;
        private Button btnnServicio;
        private DataGridView dgDetalle;
        private TextBox txtTotal;
        private Button button1;
        private Label label5;
        private Button btnCheck;
        private ErrorProvider errorProvider1;
    }
}