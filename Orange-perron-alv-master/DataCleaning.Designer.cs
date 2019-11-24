namespace Orange_perron_chido
{
    partial class DataCleaning
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
            this.tablaPrincipal = new System.Windows.Forms.DataGridView();
            this.corregirOutliers = new System.Windows.Forms.Button();
            this.DataWatch = new System.Windows.Forms.Button();
            this.optionsWatch = new System.Windows.Forms.ComboBox();
            this.muestreoNombreArchivo = new System.Windows.Forms.TextBox();
            this.transformacionValores = new System.Windows.Forms.ComboBox();
            this.transformatValor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columns = new System.Windows.Forms.ComboBox();
            this.regresar = new System.Windows.Forms.Button();
            this.nombresColumnas = new System.Windows.Forms.ComboBox();
            this.columna1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaPrincipal
            // 
            this.tablaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPrincipal.Location = new System.Drawing.Point(13, 13);
            this.tablaPrincipal.Name = "tablaPrincipal";
            this.tablaPrincipal.Size = new System.Drawing.Size(907, 286);
            this.tablaPrincipal.TabIndex = 0;
            this.tablaPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPrincipal_CellContentClick);
            // 
            // corregirOutliers
            // 
            this.corregirOutliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.corregirOutliers.FlatAppearance.BorderSize = 0;
            this.corregirOutliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.corregirOutliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.corregirOutliers.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corregirOutliers.ForeColor = System.Drawing.SystemColors.Control;
            this.corregirOutliers.Location = new System.Drawing.Point(46, 454);
            this.corregirOutliers.Name = "corregirOutliers";
            this.corregirOutliers.Size = new System.Drawing.Size(152, 35);
            this.corregirOutliers.TabIndex = 1;
            this.corregirOutliers.Text = "Corregir outliers";
            this.corregirOutliers.UseVisualStyleBackColor = false;
            this.corregirOutliers.Click += new System.EventHandler(this.corregirOutliers_Click);
            // 
            // DataWatch
            // 
            this.DataWatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.DataWatch.FlatAppearance.BorderSize = 0;
            this.DataWatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.DataWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataWatch.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataWatch.ForeColor = System.Drawing.SystemColors.Control;
            this.DataWatch.Location = new System.Drawing.Point(332, 455);
            this.DataWatch.Name = "DataWatch";
            this.DataWatch.Size = new System.Drawing.Size(182, 32);
            this.DataWatch.TabIndex = 2;
            this.DataWatch.Text = "Muestreo de datos";
            this.DataWatch.UseVisualStyleBackColor = false;
            this.DataWatch.Click += new System.EventHandler(this.DataWatch_Click);
            // 
            // optionsWatch
            // 
            this.optionsWatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.optionsWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsWatch.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsWatch.ForeColor = System.Drawing.SystemColors.Window;
            this.optionsWatch.FormattingEnabled = true;
            this.optionsWatch.Location = new System.Drawing.Point(321, 341);
            this.optionsWatch.Name = "optionsWatch";
            this.optionsWatch.Size = new System.Drawing.Size(212, 28);
            this.optionsWatch.TabIndex = 3;
            // 
            // muestreoNombreArchivo
            // 
            this.muestreoNombreArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.muestreoNombreArchivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.muestreoNombreArchivo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muestreoNombreArchivo.Location = new System.Drawing.Point(321, 395);
            this.muestreoNombreArchivo.Name = "muestreoNombreArchivo";
            this.muestreoNombreArchivo.Size = new System.Drawing.Size(212, 27);
            this.muestreoNombreArchivo.TabIndex = 4;
            // 
            // transformacionValores
            // 
            this.transformacionValores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.transformacionValores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transformacionValores.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transformacionValores.ForeColor = System.Drawing.SystemColors.Window;
            this.transformacionValores.FormattingEnabled = true;
            this.transformacionValores.Location = new System.Drawing.Point(656, 394);
            this.transformacionValores.Name = "transformacionValores";
            this.transformacionValores.Size = new System.Drawing.Size(188, 28);
            this.transformacionValores.TabIndex = 5;
            // 
            // transformatValor
            // 
            this.transformatValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.transformatValor.FlatAppearance.BorderSize = 0;
            this.transformatValor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.transformatValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transformatValor.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transformatValor.ForeColor = System.Drawing.SystemColors.Control;
            this.transformatValor.Location = new System.Drawing.Point(688, 451);
            this.transformatValor.Name = "transformatValor";
            this.transformatValor.Size = new System.Drawing.Size(142, 41);
            this.transformatValor.TabIndex = 6;
            this.transformatValor.Text = "Transformar";
            this.transformatValor.UseVisualStyleBackColor = false;
            this.transformatValor.Click += new System.EventHandler(this.transformatValor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(317, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre Archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(317, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo de Muertreo";
            // 
            // columns
            // 
            this.columns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.columns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columns.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columns.ForeColor = System.Drawing.SystemColors.Window;
            this.columns.FormattingEnabled = true;
            this.columns.Location = new System.Drawing.Point(46, 341);
            this.columns.Name = "columns";
            this.columns.Size = new System.Drawing.Size(189, 28);
            this.columns.TabIndex = 9;
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.regresar.FlatAppearance.BorderSize = 0;
            this.regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regresar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresar.ForeColor = System.Drawing.SystemColors.Control;
            this.regresar.Location = new System.Drawing.Point(688, 525);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(189, 36);
            this.regresar.TabIndex = 10;
            this.regresar.Text = "Regresar";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // nombresColumnas
            // 
            this.nombresColumnas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.nombresColumnas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nombresColumnas.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombresColumnas.ForeColor = System.Drawing.SystemColors.Window;
            this.nombresColumnas.FormattingEnabled = true;
            this.nombresColumnas.Location = new System.Drawing.Point(656, 341);
            this.nombresColumnas.Name = "nombresColumnas";
            this.nombresColumnas.Size = new System.Drawing.Size(188, 28);
            this.nombresColumnas.TabIndex = 11;
            // 
            // columna1
            // 
            this.columna1.AutoSize = true;
            this.columna1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columna1.ForeColor = System.Drawing.SystemColors.Control;
            this.columna1.Location = new System.Drawing.Point(42, 318);
            this.columna1.Name = "columna1";
            this.columna1.Size = new System.Drawing.Size(80, 20);
            this.columna1.TabIndex = 12;
            this.columna1.Text = "Columnas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(652, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Columnas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(652, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Reducción de datos";
            // 
            // DataCleaning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(932, 573);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.columna1);
            this.Controls.Add(this.nombresColumnas);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.columns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transformatValor);
            this.Controls.Add(this.transformacionValores);
            this.Controls.Add(this.muestreoNombreArchivo);
            this.Controls.Add(this.optionsWatch);
            this.Controls.Add(this.DataWatch);
            this.Controls.Add(this.corregirOutliers);
            this.Controls.Add(this.tablaPrincipal);
            this.Name = "DataCleaning";
            this.Text = "DataCleaning";
            ((System.ComponentModel.ISupportInitialize)(this.tablaPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaPrincipal;
        private System.Windows.Forms.Button corregirOutliers;
        private System.Windows.Forms.Button DataWatch;
        private System.Windows.Forms.ComboBox optionsWatch;
        private System.Windows.Forms.TextBox muestreoNombreArchivo;
        private System.Windows.Forms.ComboBox transformacionValores;
        private System.Windows.Forms.Button transformatValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox columns;
        private System.Windows.Forms.Button regresar;
        private System.Windows.Forms.ComboBox nombresColumnas;
        private System.Windows.Forms.Label columna1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}