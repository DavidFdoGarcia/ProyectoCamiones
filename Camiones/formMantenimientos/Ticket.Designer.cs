namespace Camiones.formMantenimientos
{
    partial class Ticket
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
            dgDetalle = new DataGridView();
            lblCamion = new Label();
            lblOperador = new Label();
            lblTotal = new Label();
            btnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgDetalle).BeginInit();
            SuspendLayout();
            // 
            // dgDetalle
            // 
            dgDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDetalle.Location = new Point(194, 129);
            dgDetalle.Name = "dgDetalle";
            dgDetalle.Size = new Size(240, 150);
            dgDetalle.TabIndex = 0;
            // 
            // lblCamion
            // 
            lblCamion.AutoSize = true;
            lblCamion.Location = new Point(585, 216);
            lblCamion.Name = "lblCamion";
            lblCamion.Size = new Size(38, 15);
            lblCamion.TabIndex = 1;
            lblCamion.Text = "label1";
            // 
            // lblOperador
            // 
            lblOperador.AutoSize = true;
            lblOperador.Location = new Point(585, 325);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(38, 15);
            lblOperador.TabIndex = 2;
            lblOperador.Text = "label2";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(585, 395);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "label1";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(215, 405);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 4;
            btnImprimir.Text = "button1";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 578);
            Controls.Add(btnImprimir);
            Controls.Add(lblTotal);
            Controls.Add(lblOperador);
            Controls.Add(lblCamion);
            Controls.Add(dgDetalle);
            Name = "Ticket";
            Text = "Ticket";
            Load += Ticket_Load;
            ((System.ComponentModel.ISupportInitialize)dgDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgDetalle;
        private Label lblCamion;
        private Label lblOperador;
        private Label lblTotal;
        private Button btnImprimir;
    }
}