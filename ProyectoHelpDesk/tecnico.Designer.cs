namespace ProyectoHelpDesk
{
    partial class tecnico
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
            this.terminar = new System.Windows.Forms.Button();
            this.asignar = new System.Windows.Forms.Button();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ti = new System.Windows.Forms.Label();
            this.txtIdtec = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // terminar
            // 
            this.terminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminar.Location = new System.Drawing.Point(362, 79);
            this.terminar.Name = "terminar";
            this.terminar.Size = new System.Drawing.Size(123, 44);
            this.terminar.TabIndex = 25;
            this.terminar.Text = "Terminar";
            this.terminar.UseVisualStyleBackColor = true;
            this.terminar.Click += new System.EventHandler(this.pendiente_Click);
            // 
            // asignar
            // 
            this.asignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asignar.Location = new System.Drawing.Point(230, 79);
            this.asignar.Name = "asignar";
            this.asignar.Size = new System.Drawing.Size(126, 44);
            this.asignar.TabIndex = 22;
            this.asignar.Text = "Asignar";
            this.asignar.UseVisualStyleBackColor = true;
            this.asignar.Click += new System.EventHandler(this.reasignar_Click);
            // 
            // txtTicket
            // 
            this.txtTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket.Location = new System.Drawing.Point(78, 93);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(111, 30);
            this.txtTicket.TabIndex = 20;
            this.txtTicket.TextChanged += new System.EventHandler(this.txtTicket_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 267);
            this.dataGridView1.TabIndex = 19;
            // 
            // ti
            // 
            this.ti.AutoSize = true;
            this.ti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ti.Location = new System.Drawing.Point(99, 65);
            this.ti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ti.Name = "ti";
            this.ti.Size = new System.Drawing.Size(65, 25);
            this.ti.TabIndex = 18;
            this.ti.Text = "Ticket";
            // 
            // txtIdtec
            // 
            this.txtIdtec.Location = new System.Drawing.Point(79, 174);
            this.txtIdtec.Name = "txtIdtec";
            this.txtIdtec.Size = new System.Drawing.Size(111, 22);
            this.txtIdtec.TabIndex = 26;
            this.txtIdtec.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(83, 146);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(106, 25);
            this.ID.TabIndex = 27;
            this.ID.Text = "ID Tecnico";
            // 
            // tecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 559);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtIdtec);
            this.Controls.Add(this.terminar);
            this.Controls.Add(this.asignar);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ti);
            this.Name = "tecnico";
            this.Text = "tecnico";
            this.Load += new System.EventHandler(this.tecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button terminar;
        private System.Windows.Forms.Button asignar;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ti;
        private System.Windows.Forms.TextBox txtIdtec;
        private System.Windows.Forms.Label ID;
    }
}