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
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(643, 393);
            // 
            // btnInsertar
            // 
            
            // 
            // btnOperador
            // 
            btnOperador.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOperador.Location = new Point(24, 22);
            btnOperador.Name = "btnOperador";
            btnOperador.Size = new Size(150, 73);
            btnOperador.TabIndex = 1;
            btnOperador.Text = "Altas de Operadores";
            btnOperador.UseVisualStyleBackColor = true;
            btnOperador.Click += btnOperador_Click;
            // 
            // btnAltaCamiones
            // 
            btnAltaCamiones.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAltaCamiones.Location = new Point(256, 22);
            btnAltaCamiones.Name = "btnAltaCamiones";
            btnAltaCamiones.Size = new Size(150, 73);
            btnAltaCamiones.TabIndex = 2;
            btnAltaCamiones.Text = "Agregar un Camion";
            btnAltaCamiones.UseVisualStyleBackColor = true;
            btnAltaCamiones.Click += btnAltaCamiones_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1465157700_612x612;
            ClientSize = new Size(806, 466);
            Controls.Add(btnAltaCamiones);
            Controls.Add(btnOperador);
            Name = "Principal";
            Text = "Principal";
            Load += Principal_Load;
   
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(btnOperador, 0);
            Controls.SetChildIndex(btnAltaCamiones, 0);
            ResumeLayout(false);
        }

        #endregion

        private Button btnOperador;
        private Button btnAltaCamiones;
    }
}