namespace Camiones
{
    partial class Principal
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
            btnOperador = new Button();
            btnAltaCamiones = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(643, 393);
            // 
            // btnOperador
            // 
            btnOperador.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOperador.Location = new Point(24, 22);
            btnOperador.Name = "btnOperador";
            btnOperador.Size = new Size(116, 57);
            btnOperador.TabIndex = 1;
            btnOperador.Text = " Operadores";
            btnOperador.UseVisualStyleBackColor = true;
            btnOperador.Click += btnOperador_Click;
            // 
            // btnAltaCamiones
            // 
            btnAltaCamiones.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAltaCamiones.Location = new Point(171, 22);
            btnAltaCamiones.Name = "btnAltaCamiones";
            btnAltaCamiones.Size = new Size(102, 57);
            btnAltaCamiones.TabIndex = 2;
            btnAltaCamiones.Text = "Agregar un Camion";
            btnAltaCamiones.UseVisualStyleBackColor = true;
            btnAltaCamiones.Click += btnAltaCamiones_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(308, 22);
            button1.Name = "button1";
            button1.Size = new Size(145, 80);
            button1.TabIndex = 3;
            button1.Text = "Mantenimiento Camiones";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1465157700_612x612;
            ClientSize = new Size(806, 466);
            Controls.Add(button1);
            Controls.Add(btnAltaCamiones);
            Controls.Add(btnOperador);
            Name = "Principal";
            Text = "Principal";
            Load += Principal_Load;
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(btnOperador, 0);
            Controls.SetChildIndex(btnAltaCamiones, 0);
            Controls.SetChildIndex(button1, 0);
            ResumeLayout(false);
        }

        #endregion

        private Button btnOperador;
        private Button btnAltaCamiones;
        private Button button1;
    }
}