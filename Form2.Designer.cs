namespace proyecto1
{
    partial class Form2
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
            this.dgvDB2 = new System.Windows.Forms.DataGridView();
            this.txtfiltarbd2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvtbldetalles = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttbldetalle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtbldetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDB2
            // 
            this.dgvDB2.AllowUserToAddRows = false;
            this.dgvDB2.AllowUserToDeleteRows = false;
            this.dgvDB2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDB2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDB2.Location = new System.Drawing.Point(12, 119);
            this.dgvDB2.Name = "dgvDB2";
            this.dgvDB2.ReadOnly = true;
            this.dgvDB2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDB2.Size = new System.Drawing.Size(925, 304);
            this.dgvDB2.TabIndex = 0;
            this.dgvDB2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvDB2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDB2_CellContentDoubleClick);
            // 
            // txtfiltarbd2
            // 
            this.txtfiltarbd2.Location = new System.Drawing.Point(12, 51);
            this.txtfiltarbd2.Name = "txtfiltarbd2";
            this.txtfiltarbd2.Size = new System.Drawing.Size(126, 20);
            this.txtfiltarbd2.TabIndex = 1;
            this.txtfiltarbd2.TextChanged += new System.EventHandler(this.txtfiltarbd2_TextChanged);
            this.txtfiltarbd2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfiltarbd2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "C_NO_TARJETA";
            // 
            // dgvtbldetalles
            // 
            this.dgvtbldetalles.AllowUserToAddRows = false;
            this.dgvtbldetalles.AllowUserToDeleteRows = false;
            this.dgvtbldetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvtbldetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtbldetalles.Location = new System.Drawing.Point(12, 494);
            this.dgvtbldetalles.Name = "dgvtbldetalles";
            this.dgvtbldetalles.ReadOnly = true;
            this.dgvtbldetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtbldetalles.Size = new System.Drawing.Size(925, 304);
            this.dgvtbldetalles.TabIndex = 3;
            this.dgvtbldetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dgvtbldetalles.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtbldetalles_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(770, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tabla TBL_CABECERA_EST_TC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(779, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tabla TBL_DETALLE_EST_TC";
            // 
            // txttbldetalle
            // 
            this.txttbldetalle.Location = new System.Drawing.Point(12, 463);
            this.txttbldetalle.Name = "txttbldetalle";
            this.txttbldetalle.Size = new System.Drawing.Size(126, 20);
            this.txttbldetalle.TabIndex = 6;
            this.txttbldetalle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txttbldetalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttbldetalle_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "D_NO_TARJETA";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 814);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttbldetalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvtbldetalles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfiltarbd2);
            this.Controls.Add(this.dgvDB2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtbldetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDB2;
        private System.Windows.Forms.TextBox txtfiltarbd2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvtbldetalles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttbldetalle;
        private System.Windows.Forms.Label label4;
    }
}