namespace Camiones.formMantenimientos
{
    partial class ConsultaFactura
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
            label2 = new Label();
            cmbNombre = new ComboBox();
            label1 = new Label();
            txtID = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1079, 581);
            btnSalir.Click += btnSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(83, 101);
            label2.Name = "label2";
            label2.Size = new Size(161, 19);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Usuario";
            // 
            // cmbNombre
            // 
            cmbNombre.FormattingEnabled = true;
            cmbNombre.Location = new Point(289, 97);
            cmbNombre.Name = "cmbNombre";
            cmbNombre.Size = new Size(234, 23);
            cmbNombre.TabIndex = 3;
            cmbNombre.SelectedIndexChanged += cmbNombre_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 56);
            label1.Name = "label1";
            label1.Size = new Size(161, 19);
            label1.TabIndex = 0;
            label1.Text = "Numero del Usuario";
            // 
            // txtID
            // 
            txtID.Location = new Point(289, 59);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(854, 378);
            dataGridView1.TabIndex = 5;
            // 
            // ConsultaFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 666);
            Controls.Add(dataGridView1);
            Controls.Add(txtID);
            Controls.Add(cmbNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultaFactura";
            Text = "ConsultaFactura";
            Load += ConsultaFactura_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(cmbNombre, 0);
            Controls.SetChildIndex(txtID, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ComboBox cmbNombre;
        private Label label1;
        private TextBox txtID;
        private DataGridView dataGridView1;
    }
}