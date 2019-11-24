namespace Orange_perron_chido
{
    partial class OneRAK
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
            this.listaReglas = new System.Windows.Forms.DataGridView();
            this.nombreReglas = new System.Windows.Forms.Label();
            this.regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaReglas)).BeginInit();
            this.SuspendLayout();
            // 
            // listaReglas
            // 
            this.listaReglas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaReglas.Location = new System.Drawing.Point(12, 50);
            this.listaReglas.Name = "listaReglas";
            this.listaReglas.Size = new System.Drawing.Size(776, 132);
            this.listaReglas.TabIndex = 0;
            // 
            // nombreReglas
            // 
            this.nombreReglas.AutoSize = true;
            this.nombreReglas.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreReglas.ForeColor = System.Drawing.SystemColors.Control;
            this.nombreReglas.Location = new System.Drawing.Point(330, 9);
            this.nombreReglas.Name = "nombreReglas";
            this.nombreReglas.Size = new System.Drawing.Size(53, 20);
            this.nombreReglas.TabIndex = 1;
            this.nombreReglas.Text = "label1";
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.regresar.FlatAppearance.BorderSize = 0;
            this.regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regresar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresar.ForeColor = System.Drawing.SystemColors.Control;
            this.regresar.Location = new System.Drawing.Point(671, 406);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(117, 32);
            this.regresar.TabIndex = 2;
            this.regresar.Text = "Regresar";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // OneRAK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.nombreReglas);
            this.Controls.Add(this.listaReglas);
            this.Name = "OneRAK";
            this.Text = "OneRAK";
            this.Load += new System.EventHandler(this.OneRAK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaReglas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listaReglas;
        private System.Windows.Forms.Label nombreReglas;
        private System.Windows.Forms.Button regresar;
    }
}