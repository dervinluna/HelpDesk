namespace ProyectoHelpDesk
{
    partial class jefeit
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
            this.ti = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.reasignar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.aprobar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ti
            // 
            this.ti.AutoSize = true;
            this.ti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ti.Location = new System.Drawing.Point(29, 9);
            this.ti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ti.Name = "ti";
            this.ti.Size = new System.Drawing.Size(65, 25);
            this.ti.TabIndex = 8;
            this.ti.Text = "Ticket";
            this.ti.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 267);
            this.dataGridView1.TabIndex = 12;
            // 
            // txtTicket
            // 
            this.txtTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket.Location = new System.Drawing.Point(12, 37);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(111, 30);
            this.txtTicket.TabIndex = 13;
            this.txtTicket.TextChanged += new System.EventHandler(this.txtTicket_TextChanged);
            // 
            // reasignar
            // 
            this.reasignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasignar.Location = new System.Drawing.Point(164, 23);
            this.reasignar.Name = "reasignar";
            this.reasignar.Size = new System.Drawing.Size(126, 44);
            this.reasignar.TabIndex = 14;
            this.reasignar.Text = "Reasignar";
            this.reasignar.UseVisualStyleBackColor = true;
            this.reasignar.Click += new System.EventHandler(this.reasignar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(522, 23);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(117, 44);
            this.cancelar.TabIndex = 14;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aprobar
            // 
            this.aprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprobar.Location = new System.Drawing.Point(352, 23);
            this.aprobar.Name = "aprobar";
            this.aprobar.Size = new System.Drawing.Size(111, 44);
            this.aprobar.TabIndex = 15;
            this.aprobar.Text = "Aprobar";
            this.aprobar.UseVisualStyleBackColor = true;
            this.aprobar.Click += new System.EventHandler(this.aprobar_Click);
            // 
            // jefeit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 518);
            this.Controls.Add(this.aprobar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.reasignar);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ti);
            this.Name = "jefeit";
            this.Text = "jefeit";
            this.Load += new System.EventHandler(this.jefeit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ti;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.Button reasignar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aprobar;
    }
}