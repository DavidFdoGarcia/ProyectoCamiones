namespace Camiones
{
    partial class MenuOperador
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
            btnNuevoOperador = new Button();
            btnNuevaCapacitacion = new Button();
            btnNuevoViaje = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(525, 312);
            // 
            // btnNuevoOperador
            // 
            btnNuevoOperador.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoOperador.Location = new Point(157, 37);
            btnNuevoOperador.Name = "btnNuevoOperador";
            btnNuevoOperador.Size = new Size(75, 51);
            btnNuevoOperador.TabIndex = 1;
            btnNuevoOperador.Text = "Nuevo Operador";
            btnNuevoOperador.UseVisualStyleBackColor = true;
            btnNuevoOperador.Click += btnNuevoOperador_Click;
            // 
            // btnNuevaCapacitacion
            // 
            btnNuevaCapacitacion.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevaCapacitacion.Location = new Point(157, 108);
            btnNuevaCapacitacion.Name = "btnNuevaCapacitacion";
            btnNuevaCapacitacion.Size = new Size(75, 51);
            btnNuevaCapacitacion.TabIndex = 2;
            btnNuevaCapacitacion.Text = "Nueva Capacitacion";
            btnNuevaCapacitacion.UseVisualStyleBackColor = true;
            btnNuevaCapacitacion.Click += btnNuevaCapacitacion_Click;
            // 
            // btnNuevoViaje
            // 
            btnNuevoViaje.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoViaje.Location = new Point(157, 176);
            btnNuevoViaje.Name = "btnNuevoViaje";
            btnNuevoViaje.Size = new Size(75, 51);
            btnNuevoViaje.TabIndex = 3;
            btnNuevoViaje.Text = "Nuevo Viaje";
            btnNuevoViaje.UseVisualStyleBackColor = true;
            btnNuevoViaje.Click += btnNuevoViaje_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(157, 246);
            button1.Name = "button1";
            button1.Size = new Size(87, 61);
            button1.TabIndex = 4;
            button1.Text = "Consultar Operador";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MenuOperador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnNuevoViaje);
            Controls.Add(btnNuevaCapacitacion);
            Controls.Add(btnNuevoOperador);
            Name = "MenuOperador";
            Text = "MenuOperador";
            Load += MenuOperador_Load;
            Controls.SetChildIndex(btnNuevoOperador, 0);
            Controls.SetChildIndex(btnNuevaCapacitacion, 0);
            Controls.SetChildIndex(btnNuevoViaje, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(btnSalir, 0);
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevoOperador;
        private Button btnNuevaCapacitacion;
        private Button btnNuevoViaje;
        private Button button1;
    }
}