namespace Camiones
{
    partial class Base
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalir = new Button();
            btnInsertar = new Button();
            btnConsultar = new Button();
            btnBaja = new Button();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(480, 154);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 50);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.Location = new Point(320, 154);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(140, 50);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(152, 154);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(140, 50);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnBaja
            // 
            btnBaja.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaja.Location = new Point(152, 226);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(140, 50);
            btnBaja.TabIndex = 3;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(320, 226);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(140, 50);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // Base
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = Properties.Resources.istockphoto_1465157700_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(641, 361);
            Controls.Add(btnActualizar);
            Controls.Add(btnBaja);
            Controls.Add(btnConsultar);
            Controls.Add(btnInsertar);
            Controls.Add(btnSalir);
            Name = "Base";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        protected internal Button btnSalir;
        protected internal Button btnInsertar;
        protected internal Button btnConsultar;
        protected internal Button btnBaja;
        protected internal Button btnActualizar;
    }
}
