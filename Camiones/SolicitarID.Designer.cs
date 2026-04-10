namespace Camiones
{
    partial class SolicitarID
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
            button1 = new Button();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(118, 197);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(173, 19);
            label1.TabIndex = 0;
            label1.Text = "Numero del Operador";
            // 
            // txtID
            // 
            txtID.Location = new Point(200, 55);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(118, 124);
            button1.Name = "button1";
            button1.Size = new Size(127, 46);
            button1.TabIndex = 2;
            button1.Text = "Subir Documentos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SolicitarID
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 265);
            Controls.Add(button1);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "SolicitarID";
            Text = "SolicitarID";
            Load += SolicitarID_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtID, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(btnSalir, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private Button button1;
    }
}