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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tecnico));
            this.terminar = new System.Windows.Forms.Button();
            this.asignar = new System.Windows.Forms.Button();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ti = new System.Windows.Forms.Label();
            this.txtIdtec = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // terminar
            // 
            this.terminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminar.Location = new System.Drawing.Point(272, 64);
            this.terminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.terminar.Name = "terminar";
            this.terminar.Size = new System.Drawing.Size(92, 36);
            this.terminar.TabIndex = 25;
            this.terminar.Text = "Terminar";
            this.terminar.UseVisualStyleBackColor = true;
            this.terminar.Click += new System.EventHandler(this.pendiente_Click);
            // 
            // asignar
            // 
            this.asignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asignar.Location = new System.Drawing.Point(172, 64);
            this.asignar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.asignar.Name = "asignar";
            this.asignar.Size = new System.Drawing.Size(94, 36);
            this.asignar.TabIndex = 22;
            this.asignar.Text = "Asignar";
            this.asignar.UseVisualStyleBackColor = true;
            this.asignar.Click += new System.EventHandler(this.reasignar_Click);
            // 
            // txtTicket
            // 
            this.txtTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket.Location = new System.Drawing.Point(58, 76);
            this.txtTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(84, 26);
            this.txtTicket.TabIndex = 20;
            this.txtTicket.TextChanged += new System.EventHandler(this.txtTicket_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 184);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(654, 217);
            this.dataGridView1.TabIndex = 19;
            // 
            // ti
            // 
            this.ti.AutoSize = true;
            this.ti.BackColor = System.Drawing.Color.Transparent;
            this.ti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ti.ForeColor = System.Drawing.Color.Black;
            this.ti.Location = new System.Drawing.Point(74, 53);
            this.ti.Name = "ti";
            this.ti.Size = new System.Drawing.Size(57, 20);
            this.ti.TabIndex = 18;
            this.ti.Text = "Ticket";
            // 
            // txtIdtec
            // 
            this.txtIdtec.Location = new System.Drawing.Point(59, 141);
            this.txtIdtec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdtec.Name = "txtIdtec";
            this.txtIdtec.Size = new System.Drawing.Size(84, 20);
            this.txtIdtec.TabIndex = 26;
            this.txtIdtec.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(62, 119);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(95, 20);
            this.ID.TabIndex = 27;
            this.ID.Text = "ID Tecnico";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(655, 407);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 28;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AllowDrop = true;
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(718, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 34);
            this.button2.TabIndex = 29;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(772, 454);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtIdtec);
            this.Controls.Add(this.terminar);
            this.Controls.Add(this.asignar);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ti);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}