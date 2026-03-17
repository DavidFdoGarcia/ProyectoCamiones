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
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(686, 257);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(200, 83);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.Location = new Point(457, 257);
            btnInsertar.Margin = new Padding(4, 5, 4, 5);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(200, 83);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(217, 257);
            btnConsultar.Margin = new Padding(4, 5, 4, 5);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(200, 83);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnBaja
            // 
            btnBaja.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaja.Location = new Point(217, 377);
            btnBaja.Margin = new Padding(4, 5, 4, 5);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(200, 83);
            btnBaja.TabIndex = 3;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(457, 377);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(200, 83);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(217, 147);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(200, 83);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // Base
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = Properties.Resources.istockphoto_1465157700_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(916, 602);
            Controls.Add(btnBuscar);
            Controls.Add(btnActualizar);
            Controls.Add(btnBaja);
            Controls.Add(btnConsultar);
            Controls.Add(btnInsertar);
            Controls.Add(btnSalir);
            Margin = new Padding(4, 5, 4, 5);
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
        protected internal Button btnBuscar;
    }
}
