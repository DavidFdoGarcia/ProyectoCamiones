namespace Camiones.formMantenimientos
{
    partial class MenuManteenimiento
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
            button1 = new Button();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(561, 349);
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(204, 99);
            button1.Name = "button1";
            button1.Size = new Size(133, 61);
            button1.TabIndex = 1;
            button1.Text = "Nuevo Mantenimiento";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MenuManteenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "MenuManteenimiento";
            Text = "MenuManteenimiento";
            Load += MenuManteenimiento_Load;
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(button1, 0);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}