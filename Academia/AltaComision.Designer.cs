namespace Academia
{
    partial class AltaComision
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            comboPlan = new System.Windows.Forms.ComboBox();
            txtDescripcion = new System.Windows.Forms.TextBox();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            btnAceptar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(156, 68);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Año de Especialidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(29, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(29, 67);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Plan";
            // 
            // comboPlan
            // 
            comboPlan.FormattingEnabled = true;
            comboPlan.Location = new System.Drawing.Point(29, 85);
            comboPlan.Name = "comboPlan";
            comboPlan.Size = new System.Drawing.Size(121, 23);
            comboPlan.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(29, 40);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(247, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(156, 86);
            numericUpDown1.Maximum = new decimal(new int[] { 2050, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1930, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(120, 23);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new System.Drawing.Point(204, 135);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(123, 135);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(42, 135);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // AltaComision
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(305, 187);
            Controls.Add(button1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(numericUpDown1);
            Controls.Add(txtDescripcion);
            Controls.Add(comboPlan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AltaComision";
            Text = "AltaComision";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboPlan;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
    }
}