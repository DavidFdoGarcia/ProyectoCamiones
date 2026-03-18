namespace Camiones
{
    partial class NuevaCapacitacion
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
            txtID = new TextBox();
            pictureBox1 = new PictureBox();
            btnCapacitacion = new Button();
            txtCap = new TextBox();
            txtNumero = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(397, 118);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 33);
            label1.Name = "label1";
            label1.Size = new Size(128, 19);
            label1.TabIndex = 0;
            label1.Text = "ID del Operador";
            label1.Click += label1_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(229, 33);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 77);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // btnCapacitacion
            // 
            btnCapacitacion.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapacitacion.Location = new Point(397, 33);
            btnCapacitacion.Name = "btnCapacitacion";
            btnCapacitacion.Size = new Size(140, 61);
            btnCapacitacion.TabIndex = 3;
            btnCapacitacion.Text = "Agregar Capacitacion";
            btnCapacitacion.UseVisualStyleBackColor = true;
            btnCapacitacion.Click += btnCapacitacion_Click;
            // 
            // txtCap
            // 
            txtCap.Location = new Point(212, 156);
            txtCap.Name = "txtCap";
            txtCap.Size = new Size(100, 23);
            txtCap.TabIndex = 4;
            txtCap.Visible = false;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(264, 91);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(215, 19);
            label2.TabIndex = 5;
            label2.Text = "Número de Capacitaciones";
            // 
            // NuevaCapacitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 254);
            Controls.Add(txtNumero);
            Controls.Add(label2);
            Controls.Add(txtCap);
            Controls.Add(btnCapacitacion);
            Controls.Add(pictureBox1);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "NuevaCapacitacion";
            Text = "NuevaCapacitacion";
            Load += NuevaCapacitacion_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtID, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(btnCapacitacion, 0);
            Controls.SetChildIndex(txtCap, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtNumero, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private PictureBox pictureBox1;
        private Button btnCapacitacion;
        private TextBox txtCap;
        private TextBox txtNumero;
        private Label label2;
    }
}