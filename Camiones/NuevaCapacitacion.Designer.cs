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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 99);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "ID del Operador";
            label1.Click += label1_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(229, 91);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(441, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 143);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnCapacitacion
            // 
            btnCapacitacion.Location = new Point(297, 290);
            btnCapacitacion.Name = "btnCapacitacion";
            btnCapacitacion.Size = new Size(134, 54);
            btnCapacitacion.TabIndex = 3;
            btnCapacitacion.Text = "Agregar Capacitacion";
            btnCapacitacion.UseVisualStyleBackColor = true;
            btnCapacitacion.Click += btnCapacitacion_Click;
            // 
            // txtCap
            // 
            txtCap.Location = new Point(229, 215);
            txtCap.Name = "txtCap";
            txtCap.Size = new Size(100, 23);
            txtCap.TabIndex = 4;
            // 
            // NuevaCapacitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCap);
            Controls.Add(btnCapacitacion);
            Controls.Add(pictureBox1);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "NuevaCapacitacion";
            Text = "NuevaCapacitacion";
            Load += NuevaCapacitacion_Load;
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
    }
}