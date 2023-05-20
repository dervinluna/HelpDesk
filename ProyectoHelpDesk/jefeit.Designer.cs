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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jefeit));
            this.ti = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.reasignar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.aprobar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ti
            // 
            this.ti.AutoSize = true;
            this.ti.BackColor = System.Drawing.Color.Transparent;
            this.ti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ti.Location = new System.Drawing.Point(22, 7);
            this.ti.Name = "ti";
            this.ti.Size = new System.Drawing.Size(57, 20);
            this.ti.TabIndex = 8;
            this.ti.Text = "Ticket";
            this.ti.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 139);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(654, 217);
            this.dataGridView1.TabIndex = 12;
            // 
            // txtTicket
            // 
            this.txtTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket.Location = new System.Drawing.Point(9, 30);
            this.txtTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(84, 26);
            this.txtTicket.TabIndex = 13;
            this.txtTicket.TextChanged += new System.EventHandler(this.txtTicket_TextChanged);
            // 
            // reasignar
            // 
            this.reasignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasignar.Location = new System.Drawing.Point(123, 23);
            this.reasignar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reasignar.Name = "reasignar";
            this.reasignar.Size = new System.Drawing.Size(94, 36);
            this.reasignar.TabIndex = 14;
            this.reasignar.Text = "Reasignar";
            this.reasignar.UseVisualStyleBackColor = true;
            this.reasignar.Click += new System.EventHandler(this.reasignar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(392, 21);
            this.cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(88, 36);
            this.cancelar.TabIndex = 14;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aprobar
            // 
            this.aprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprobar.Location = new System.Drawing.Point(264, 21);
            this.aprobar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aprobar.Name = "aprobar";
            this.aprobar.Size = new System.Drawing.Size(83, 36);
            this.aprobar.TabIndex = 15;
            this.aprobar.Text = "Aprobar";
            this.aprobar.UseVisualStyleBackColor = true;
            this.aprobar.Click += new System.EventHandler(this.aprobar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(532, 374);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AllowDrop = true;
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(664, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // jefeit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(718, 421);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aprobar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.reasignar);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ti);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}