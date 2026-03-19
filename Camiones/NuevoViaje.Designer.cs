namespace Camiones
{
    partial class NuevoViaje
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
            btnAgregarViaje = new Button();
            label2 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            txtViajes = new TextBox();
            txtNumero = new TextBox();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(253, 172);
            // 
            // btnAgregarViaje
            // 
            btnAgregarViaje.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarViaje.Location = new Point(101, 172);
            btnAgregarViaje.Name = "btnAgregarViaje";
            btnAgregarViaje.Size = new Size(100, 48);
            btnAgregarViaje.TabIndex = 1;
            btnAgregarViaje.Text = "Agregar Viaje";
            btnAgregarViaje.UseVisualStyleBackColor = true;
            btnAgregarViaje.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 37);
            label2.Name = "label2";
            label2.Size = new Size(173, 19);
            label2.TabIndex = 3;
            label2.Text = "Numero del Operador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 95);
            label3.Name = "label3";
            label3.Size = new Size(143, 19);
            label3.TabIndex = 4;
            label3.Text = "Numero de Viajes";
            // 
            // txtID
            // 
            txtID.Location = new Point(293, 33);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 5;
            // 
            // txtViajes
            // 
            txtViajes.Location = new Point(270, 143);
            txtViajes.Name = "txtViajes";
            txtViajes.Size = new Size(100, 23);
            txtViajes.TabIndex = 6;
            txtViajes.Visible = false;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(253, 95);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 7;
            // 
            // NuevoViaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 249);
            Controls.Add(txtNumero);
            Controls.Add(txtViajes);
            Controls.Add(txtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAgregarViaje);
            Name = "NuevoViaje";
            Text = "NuevoViaje";
            Load += NuevoViaje_Load;
            Controls.SetChildIndex(btnAgregarViaje, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(txtID, 0);
            Controls.SetChildIndex(txtViajes, 0);
            Controls.SetChildIndex(txtNumero, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarViaje;
        private Label label2;
        private Label label3;
        private TextBox txtID;
        private TextBox txtViajes;
        private TextBox txtNumero;
    }
}