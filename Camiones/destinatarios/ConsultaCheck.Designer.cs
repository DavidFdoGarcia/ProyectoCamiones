namespace Camiones.destinatarios
{
    partial class ConsultaCheck
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
            groupBox1 = new GroupBox();
            btnLimpiarFiltros = new Button();
            btnMostrar = new Button();
            btnBuscar = new Button();
            chkSoloConChecklist = new CheckBox();
            dtpFin = new DateTimePicker();
            label5 = new Label();
            dtpInicio = new DateTimePicker();
            label4 = new Label();
            cmbCamionFiltro = new ComboBox();
            label3 = new Label();
            cmbOperadorFiltro = new ComboBox();
            label2 = new Label();
            txtIdMantenimiento = new TextBox();
            label1 = new Label();
            dgConsultaChecklist = new DataGridView();
            btnAbrirChecklist = new Button();
            btnActualizar = new Button();
            btnVerTicket = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgConsultaChecklist).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(600, 567);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimpiarFiltros);
            groupBox1.Controls.Add(btnMostrar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(chkSoloConChecklist);
            groupBox1.Controls.Add(dtpFin);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpInicio);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbCamionFiltro);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbOperadorFiltro);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIdMantenimiento);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(748, 239);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros de Busqueda";
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.Location = new Point(620, 93);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new Size(94, 59);
            btnLimpiarFiltros.TabIndex = 13;
            btnLimpiarFiltros.Text = "Limpiar Filtros";
            btnLimpiarFiltros.UseVisualStyleBackColor = true;
            btnLimpiarFiltros.Click += btnLimpiarFiltros_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(620, 170);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(94, 63);
            btnMostrar.TabIndex = 12;
            btnMostrar.Text = "Mostrar Todos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(620, 44);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // chkSoloConChecklist
            // 
            chkSoloConChecklist.AutoSize = true;
            chkSoloConChecklist.Location = new Point(345, 156);
            chkSoloConChecklist.Name = "chkSoloConChecklist";
            chkSoloConChecklist.Size = new Size(205, 28);
            chkSoloConChecklist.TabIndex = 10;
            chkSoloConChecklist.Text = "Solo con checklist";
            chkSoloConChecklist.UseVisualStyleBackColor = true;
            // 
            // dtpFin
            // 
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(452, 101);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(129, 30);
            dtpFin.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 101);
            label5.Name = "label5";
            label5.Size = new Size(102, 24);
            label5.TabIndex = 8;
            label5.Text = "Fecha Fin";
            // 
            // dtpInicio
            // 
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(452, 49);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(129, 30);
            dtpInicio.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 49);
            label4.Name = "label4";
            label4.Size = new Size(123, 24);
            label4.TabIndex = 6;
            label4.Text = "Fecha Inicio";
            // 
            // cmbCamionFiltro
            // 
            cmbCamionFiltro.FormattingEnabled = true;
            cmbCamionFiltro.Location = new Point(143, 131);
            cmbCamionFiltro.Name = "cmbCamionFiltro";
            cmbCamionFiltro.Size = new Size(151, 32);
            cmbCamionFiltro.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 145);
            label3.Name = "label3";
            label3.Size = new Size(81, 24);
            label3.TabIndex = 4;
            label3.Text = "Camión";
            // 
            // cmbOperadorFiltro
            // 
            cmbOperadorFiltro.FormattingEnabled = true;
            cmbOperadorFiltro.Location = new Point(154, 93);
            cmbOperadorFiltro.Name = "cmbOperadorFiltro";
            cmbOperadorFiltro.Size = new Size(151, 32);
            cmbOperadorFiltro.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 96);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 2;
            label2.Text = "Operador";
            // 
            // txtIdMantenimiento
            // 
            txtIdMantenimiento.Location = new Point(210, 43);
            txtIdMantenimiento.Name = "txtIdMantenimiento";
            txtIdMantenimiento.Size = new Size(46, 30);
            txtIdMantenimiento.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(174, 24);
            label1.TabIndex = 0;
            label1.Text = "ID Mantenimiento";
            // 
            // dgConsultaChecklist
            // 
            dgConsultaChecklist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgConsultaChecklist.Location = new Point(6, 278);
            dgConsultaChecklist.Name = "dgConsultaChecklist";
            dgConsultaChecklist.RowHeadersWidth = 51;
            dgConsultaChecklist.Size = new Size(757, 244);
            dgConsultaChecklist.TabIndex = 1;
            // 
            // btnAbrirChecklist
            // 
            btnAbrirChecklist.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbrirChecklist.Location = new Point(37, 554);
            btnAbrirChecklist.Name = "btnAbrirChecklist";
            btnAbrirChecklist.Size = new Size(102, 65);
            btnAbrirChecklist.TabIndex = 15;
            btnAbrirChecklist.Text = "Abrir CheckList";
            btnAbrirChecklist.UseVisualStyleBackColor = true;
            btnAbrirChecklist.Click += btnAbrirChecklist_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(322, 554);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(102, 65);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnVerTicket
            // 
            btnVerTicket.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerTicket.Location = new Point(190, 554);
            btnVerTicket.Name = "btnVerTicket";
            btnVerTicket.Size = new Size(69, 65);
            btnVerTicket.TabIndex = 17;
            btnVerTicket.Text = "Ver Ticket";
            btnVerTicket.UseVisualStyleBackColor = true;
            btnVerTicket.Click += btnVerTicket_Click;
            // 
            // ConsultaCheck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 647);
            Controls.Add(btnVerTicket);
            Controls.Add(btnActualizar);
            Controls.Add(btnAbrirChecklist);
            Controls.Add(dgConsultaChecklist);
            Controls.Add(groupBox1);
            Name = "ConsultaCheck";
            Text = "ConsultaCheck";
            Load += ConsultaCheck_Load;
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(dgConsultaChecklist, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(btnAbrirChecklist, 0);
            Controls.SetChildIndex(btnActualizar, 0);
            Controls.SetChildIndex(btnVerTicket, 0);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgConsultaChecklist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtIdMantenimiento;
        private Label label1;
        private ComboBox cmbCamionFiltro;
        private Label label3;
        private ComboBox cmbOperadorFiltro;
        private Label label2;
        private DateTimePicker dtpFin;
        private Label label5;
        private DateTimePicker dtpInicio;
        private Label label4;
        private Button btnLimpiarFiltros;
        private Button btnMostrar;
        private Button btnBuscar;
        private CheckBox chkSoloConChecklist;
        private DataGridView dgConsultaChecklist;
        private Button btnAbrirChecklist;
        private Button btnActualizar;
        private Button btnVerTicket;
    }
}