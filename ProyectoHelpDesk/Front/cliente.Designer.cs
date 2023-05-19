namespace ProyectoHelpDesk.Front
{
    partial class cliente
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
            this.textBDescripcion = new System.Windows.Forms.TextBox();
            this.textBIdCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBDescripcion
            // 
            this.textBDescripcion.Location = new System.Drawing.Point(269, 118);
            this.textBDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBDescripcion.Name = "textBDescripcion";
            this.textBDescripcion.Size = new System.Drawing.Size(360, 22);
            this.textBDescripcion.TabIndex = 0;
            this.textBDescripcion.TextChanged += new System.EventHandler(this.textBDescripcion_TextChanged);
            // 
            // textBIdCliente
            // 
            this.textBIdCliente.Location = new System.Drawing.Point(269, 150);
            this.textBIdCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBIdCliente.Name = "textBIdCliente";
            this.textBIdCliente.Size = new System.Drawing.Size(132, 22);
            this.textBIdCliente.TabIndex = 2;
            this.textBIdCliente.TextChanged += new System.EventHandler(this.textBIdCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripcion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id Cliente";
            this.label2.UseMnemonic = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 218);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hacer solicitud";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBIdCliente);
            this.Controls.Add(this.textBDescripcion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBDescripcion;
        private System.Windows.Forms.TextBox textBIdCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}