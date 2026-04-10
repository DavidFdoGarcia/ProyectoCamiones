namespace Camiones.destinatarios
{
    partial class Checklist
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
            txtIdRegistroViaje = new TextBox();
            label2 = new Label();
            txtOperador = new TextBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            label4 = new Label();
            cmbTipoRevision = new ComboBox();
            groupBox1 = new GroupBox();
            dgvInterior = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            btnEvidencia1 = new DataGridViewButtonColumn();
            groupBox3 = new GroupBox();
            dgvExterior = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnEvidencia2 = new DataGridViewButtonColumn();
            btnGuardar = new Button();
            button1 = new Button();
            button2 = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            btnEvidenciaInterior = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInterior).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExterior).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(538, 422);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 21);
            label1.Name = "label1";
            label1.Size = new Size(166, 24);
            label1.TabIndex = 0;
            label1.Text = "ID Registro Viaje";
            // 
            // txtIdRegistroViaje
            // 
            txtIdRegistroViaje.Enabled = false;
            txtIdRegistroViaje.Location = new Point(210, 21);
            txtIdRegistroViaje.Name = "txtIdRegistroViaje";
            txtIdRegistroViaje.Size = new Size(125, 27);
            txtIdRegistroViaje.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 63);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 2;
            label2.Text = "Operador";
            label2.Click += label2_Click;
            // 
            // txtOperador
            // 
            txtOperador.Enabled = false;
            txtOperador.Location = new Point(210, 63);
            txtOperador.Name = "txtOperador";
            txtOperador.Size = new Size(125, 27);
            txtOperador.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(382, 21);
            label3.Name = "label3";
            label3.Size = new Size(67, 24);
            label3.TabIndex = 4;
            label3.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(499, 18);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(382, 66);
            label4.Name = "label4";
            label4.Size = new Size(168, 24);
            label4.TabIndex = 6;
            label4.Text = "Tipo de Revisión";
            // 
            // cmbTipoRevision
            // 
            cmbTipoRevision.FormattingEnabled = true;
            cmbTipoRevision.Items.AddRange(new object[] { "salida", "entrada", "general" });
            cmbTipoRevision.Location = new Point(582, 66);
            cmbTipoRevision.Name = "cmbTipoRevision";
            cmbTipoRevision.Size = new Size(151, 28);
            cmbTipoRevision.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvInterior);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(725, 255);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Check list interior";
            // 
            // dgvInterior
            // 
            dgvInterior.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInterior.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, btnEvidencia1 });
            dgvInterior.Location = new Point(25, 62);
            dgvInterior.Name = "dgvInterior";
            dgvInterior.RowHeadersWidth = 51;
            dgvInterior.Size = new Size(567, 178);
            dgvInterior.TabIndex = 2;
            dgvInterior.CellContentClick += dgvInterior_CellContentClick;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Concepto";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Comentario";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Evidencia";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // btnEvidencia1
            // 
            btnEvidencia1.HeaderText = "Accion";
            btnEvidencia1.MinimumWidth = 6;
            btnEvidencia1.Name = "btnEvidencia1";
            btnEvidencia1.Width = 125;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvExterior);
            groupBox3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(772, 184);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(624, 227);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Check list Exterior";
            // 
            // dgvExterior
            // 
            dgvExterior.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExterior.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, btnEvidencia2 });
            dgvExterior.Location = new Point(6, 34);
            dgvExterior.Name = "dgvExterior";
            dgvExterior.RowHeadersWidth = 51;
            dgvExterior.Size = new Size(575, 188);
            dgvExterior.TabIndex = 0;
            dgvExterior.CellContentClick += dgvExterior_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Concepto";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Comentario";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Evidencia";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // btnEvidencia2
            // 
            btnEvidencia2.HeaderText = "Accion";
            btnEvidencia2.MinimumWidth = 6;
            btnEvidencia2.Name = "btnEvidencia2";
            btnEvidencia2.Resizable = DataGridViewTriState.True;
            btnEvidencia2.SortMode = DataGridViewColumnSortMode.Automatic;
            btnEvidencia2.Width = 125;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(318, 456);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(96, 33);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(35, 456);
            button1.Name = "button1";
            button1.Size = new Size(96, 33);
            button1.TabIndex = 11;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(176, 456);
            button2.Name = "button2";
            button2.Size = new Size(96, 33);
            button2.TabIndex = 12;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Concepto";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Comentario";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Evidencia";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // btnEvidenciaInterior
            // 
            btnEvidenciaInterior.HeaderText = "Accion";
            btnEvidenciaInterior.MinimumWidth = 6;
            btnEvidenciaInterior.Name = "btnEvidenciaInterior";
            btnEvidenciaInterior.Width = 125;
            // 
            // Checklist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 505);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(cmbTipoRevision);
            Controls.Add(label4);
            Controls.Add(dtpFecha);
            Controls.Add(label3);
            Controls.Add(txtOperador);
            Controls.Add(label2);
            Controls.Add(txtIdRegistroViaje);
            Controls.Add(label1);
            Name = "Checklist";
            Text = "Checklist";
            Load += Checklist_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtIdRegistroViaje, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtOperador, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(dtpFecha, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(cmbTipoRevision, 0);
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(groupBox3, 0);
            Controls.SetChildIndex(btnGuardar, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(btnSalir, 0);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInterior).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExterior).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdRegistroViaje;
        private Label label2;
        private TextBox txtOperador;
        private Label label3;
        private DateTimePicker dtpFecha;
        private Label label4;
        private ComboBox cmbTipoRevision;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private DataGridView CheckExt;
        private DataGridView dgvInterior;
        private Button btnGuardar;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn Concepto;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Comentario;
        private DataGridViewTextBoxColumn Evidencia;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn btnEvidenciaInterior;
        private DataGridView dgvExterior;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn btnEvidencia2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewButtonColumn btnEvidencia1;
    }
}