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
            btnDestinos = new Button();
            btnViajesF = new Button();
            btnRegistro = new Button();
            btnCheckList = new Button();
            btnConsultaChecklist = new Button();
            btnTemas = new Button();
            btnDetalleCamion = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(749, 269);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Size = new Size(112, 48);
            // 
            // btnOperador
            // 
            btnOperador.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOperador.ImageAlign = ContentAlignment.BottomCenter;
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
            btnAltaCamiones.Location = new Point(170, 22);
            btnAltaCamiones.Name = "btnAltaCamiones";
            btnAltaCamiones.Size = new Size(108, 68);
            btnAltaCamiones.TabIndex = 2;
            btnAltaCamiones.Text = "Agregar un Camion";
            btnAltaCamiones.UseVisualStyleBackColor = true;
            btnAltaCamiones.Click += btnAltaCamiones_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(24, 197);
            button1.Name = "button1";
            button1.Size = new Size(145, 80);
            button1.TabIndex = 3;
            button1.Text = "Mantenimiento Camiones";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnDestinos
            // 
            btnDestinos.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDestinos.Location = new Point(749, 115);
            btnDestinos.Name = "btnDestinos";
            btnDestinos.Size = new Size(112, 45);
            btnDestinos.TabIndex = 4;
            btnDestinos.Text = "Destinos";
            btnDestinos.UseVisualStyleBackColor = true;
            btnDestinos.Click += btnDestinos_Click;
            // 
            // btnViajesF
            // 
            btnViajesF.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViajesF.Location = new Point(582, 33);
            btnViajesF.Name = "btnViajesF";
            btnViajesF.Size = new Size(116, 57);
            btnViajesF.TabIndex = 5;
            btnViajesF.Text = "Viajes Fletes";
            btnViajesF.UseVisualStyleBackColor = true;
            btnViajesF.Click += button2_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistro.Location = new Point(731, 26);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(130, 67);
            btnRegistro.TabIndex = 6;
            btnRegistro.Text = "Registro Viajes Fletes";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnCheckList
            // 
            btnCheckList.Location = new Point(0, 0);
            btnCheckList.Name = "btnCheckList";
            btnCheckList.Size = new Size(75, 23);
            btnCheckList.TabIndex = 12;
            // 
            // btnConsultaChecklist
            // 
            btnConsultaChecklist.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultaChecklist.Location = new Point(750, 181);
            btnConsultaChecklist.Name = "btnConsultaChecklist";
            btnConsultaChecklist.Size = new Size(106, 64);
            btnConsultaChecklist.TabIndex = 8;
            btnConsultaChecklist.Text = "Consulta CheckList";
            btnConsultaChecklist.UseVisualStyleBackColor = true;
            btnConsultaChecklist.Click += btnConsultaChecklist_Click;
            // 
            // btnTemas
            // 
            btnTemas.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTemas.ImageAlign = ContentAlignment.BottomCenter;
            btnTemas.Location = new Point(24, 103);
            btnTemas.Name = "btnTemas";
            btnTemas.Size = new Size(116, 57);
            btnTemas.TabIndex = 9;
            btnTemas.Text = "Temas Capacitaciones";
            btnTemas.UseVisualStyleBackColor = true;
            btnTemas.Click += btnTemas_Click;
            // 
            // btnDetalleCamion
            // 
            btnDetalleCamion.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetalleCamion.ImageAlign = ContentAlignment.BottomCenter;
            btnDetalleCamion.Location = new Point(309, 28);
            btnDetalleCamion.Name = "btnDetalleCamion";
            btnDetalleCamion.Size = new Size(116, 57);
            btnDetalleCamion.TabIndex = 10;
            btnDetalleCamion.Text = "Detalles Camion";
            btnDetalleCamion.UseVisualStyleBackColor = true;
            btnDetalleCamion.Click += btnDetalleCamion_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(453, 25);
            button2.Name = "button2";
            button2.Size = new Size(108, 68);
            button2.TabIndex = 11;
            button2.Text = "Camión Asignacion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1465157700_612x612;
            ClientSize = new Size(893, 386);
            Controls.Add(button2);
            Controls.Add(btnDetalleCamion);
            Controls.Add(btnTemas);
            Controls.Add(btnConsultaChecklist);
            Controls.Add(btnCheckList);
            Controls.Add(btnRegistro);
            Controls.Add(btnViajesF);
            Controls.Add(btnDestinos);
            Controls.Add(button1);
            Controls.Add(btnAltaCamiones);
            Controls.Add(btnOperador);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Principal";
            Text = "Principal";
            Load += Principal_Load;
            Controls.SetChildIndex(btnOperador, 0);
            Controls.SetChildIndex(btnAltaCamiones, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(btnDestinos, 0);
            Controls.SetChildIndex(btnViajesF, 0);
            Controls.SetChildIndex(btnRegistro, 0);
            Controls.SetChildIndex(btnCheckList, 0);
            Controls.SetChildIndex(btnConsultaChecklist, 0);
            Controls.SetChildIndex(btnTemas, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(btnDetalleCamion, 0);
            Controls.SetChildIndex(button2, 0);
            ResumeLayout(false);
        }

        #endregion

        private Button btnOperador;
        private Button btnAltaCamiones;
        private Button button1;
        private Button btnDestinos;
        private Button btnViajesF;
        private Button btnRegistro;
        private Button btnCheckList;
        private Button btnConsultaChecklist;
        private Button btnTemas;
        private Button btnDetalleCamion;
        private Button button2;
    }
}