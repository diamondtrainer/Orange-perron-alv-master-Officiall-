namespace Orange_perron_chido
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.accionadorArchivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaPrincipal = new System.Windows.Forms.DataGridView();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.SaveNewFile = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.deleteRow = new System.Windows.Forms.Button();
            this.DataSetName = new System.Windows.Forms.Label();
            this.rowsQuantity = new System.Windows.Forms.Label();
            this.ColumnQuantity = new System.Windows.Forms.Label();
            this.missingValues = new System.Windows.Forms.Label();
            this.proportion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnBi = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.columnToAutomatic = new System.Windows.Forms.ComboBox();
            this.DevelopAnalyse = new System.Windows.Forms.Button();
            this.AlgoritmNames = new System.Windows.Forms.ComboBox();
            this.metodology = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnedit = new System.Windows.Forms.Button();
            this.CBAtr2 = new System.Windows.Forms.ComboBox();
            this.lblOutDom = new System.Windows.Forms.Label();
            this.lblVFP = new System.Windows.Forms.Label();
            this.lblVF = new System.Windows.Forms.Label();
            this.lblTipe = new System.Windows.Forms.Label();
            this.txtnewnom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BTNEli = new System.Windows.Forms.Button();
            this.CBAtr = new System.Windows.Forms.ComboBox();
            this.txtvDefault = new System.Windows.Forms.TextBox();
            this.lblval = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.TXTDom = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.CBTipo = new System.Windows.Forms.ComboBox();
            this.lbldom = new System.Windows.Forms.Button();
            this.lbltipo = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Button();
            this.txtK = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPrincipal)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accionadorArchivo
            // 
            this.accionadorArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.accionadorArchivo.FlatAppearance.BorderSize = 0;
            this.accionadorArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.accionadorArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accionadorArchivo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accionadorArchivo.ForeColor = System.Drawing.SystemColors.Control;
            this.accionadorArchivo.Location = new System.Drawing.Point(0, 28);
            this.accionadorArchivo.Name = "accionadorArchivo";
            this.accionadorArchivo.Size = new System.Drawing.Size(139, 29);
            this.accionadorArchivo.TabIndex = 0;
            this.accionadorArchivo.Text = "Abrir Archivo";
            this.accionadorArchivo.UseVisualStyleBackColor = false;
            this.accionadorArchivo.Click += new System.EventHandler(this.accionadorArchivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(367, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ORANGE PERRON CHIDO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tablaPrincipal
            // 
            this.tablaPrincipal.AllowUserToOrderColumns = true;
            this.tablaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaPrincipal.DefaultCellStyle = dataGridViewCellStyle1;
            this.tablaPrincipal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tablaPrincipal.Location = new System.Drawing.Point(145, 40);
            this.tablaPrincipal.Name = "tablaPrincipal";
            this.tablaPrincipal.RowTemplate.Height = 25;
            this.tablaPrincipal.Size = new System.Drawing.Size(655, 261);
            this.tablaPrincipal.TabIndex = 2;
            this.tablaPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPrincipal_CellContentClick);
            // 
            // SaveChanges
            // 
            this.SaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SaveChanges.FlatAppearance.BorderSize = 0;
            this.SaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChanges.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChanges.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveChanges.Location = new System.Drawing.Point(0, 75);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(139, 26);
            this.SaveChanges.TabIndex = 3;
            this.SaveChanges.Text = "Guardar";
            this.SaveChanges.UseVisualStyleBackColor = false;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // SaveNewFile
            // 
            this.SaveNewFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SaveNewFile.FlatAppearance.BorderSize = 0;
            this.SaveNewFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SaveNewFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.SaveNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveNewFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveNewFile.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveNewFile.Location = new System.Drawing.Point(3, 117);
            this.SaveNewFile.Name = "SaveNewFile";
            this.SaveNewFile.Size = new System.Drawing.Size(136, 26);
            this.SaveNewFile.TabIndex = 4;
            this.SaveNewFile.Text = "Guardar Como";
            this.SaveNewFile.UseVisualStyleBackColor = false;
            this.SaveNewFile.Click += new System.EventHandler(this.SaveNewFile_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit.Location = new System.Drawing.Point(0, 162);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(139, 24);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Salir";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // deleteRow
            // 
            this.deleteRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.deleteRow.FlatAppearance.BorderSize = 0;
            this.deleteRow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.deleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRow.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRow.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteRow.Location = new System.Drawing.Point(689, 1);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(111, 34);
            this.deleteRow.TabIndex = 6;
            this.deleteRow.Text = "Eliminar";
            this.deleteRow.UseVisualStyleBackColor = false;
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // DataSetName
            // 
            this.DataSetName.AutoSize = true;
            this.DataSetName.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSetName.ForeColor = System.Drawing.SystemColors.Control;
            this.DataSetName.Location = new System.Drawing.Point(158, 331);
            this.DataSetName.Name = "DataSetName";
            this.DataSetName.Size = new System.Drawing.Size(33, 20);
            this.DataSetName.TabIndex = 7;
            this.DataSetName.Text = "xxx";
            // 
            // rowsQuantity
            // 
            this.rowsQuantity.AutoSize = true;
            this.rowsQuantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowsQuantity.ForeColor = System.Drawing.SystemColors.Control;
            this.rowsQuantity.Location = new System.Drawing.Point(158, 374);
            this.rowsQuantity.Name = "rowsQuantity";
            this.rowsQuantity.Size = new System.Drawing.Size(18, 20);
            this.rowsQuantity.TabIndex = 8;
            this.rowsQuantity.Text = "0";
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.AutoSize = true;
            this.ColumnQuantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnQuantity.ForeColor = System.Drawing.SystemColors.Control;
            this.ColumnQuantity.Location = new System.Drawing.Point(340, 331);
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.Size = new System.Drawing.Size(18, 20);
            this.ColumnQuantity.TabIndex = 9;
            this.ColumnQuantity.Text = "0";
            // 
            // missingValues
            // 
            this.missingValues.AutoSize = true;
            this.missingValues.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missingValues.ForeColor = System.Drawing.SystemColors.Control;
            this.missingValues.Location = new System.Drawing.Point(340, 374);
            this.missingValues.Name = "missingValues";
            this.missingValues.Size = new System.Drawing.Size(18, 20);
            this.missingValues.TabIndex = 10;
            this.missingValues.Text = "0";
            // 
            // proportion
            // 
            this.proportion.AutoSize = true;
            this.proportion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proportion.ForeColor = System.Drawing.SystemColors.Control;
            this.proportion.Location = new System.Drawing.Point(158, 418);
            this.proportion.Name = "proportion";
            this.proportion.Size = new System.Drawing.Size(18, 20);
            this.proportion.TabIndex = 11;
            this.proportion.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(158, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre del archivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(158, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Instancias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(340, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Atributos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(340, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Atributos faltantes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(158, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Proporción de valores faltantes";
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.btnBi);
            this.MenuVertical.Controls.Add(this.button3);
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.accionadorArchivo);
            this.MenuVertical.Controls.Add(this.SaveChanges);
            this.MenuVertical.Controls.Add(this.SaveNewFile);
            this.MenuVertical.Controls.Add(this.Exit);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(142, 450);
            this.MenuVertical.TabIndex = 18;
            // 
            // btnBi
            // 
            this.btnBi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBi.FlatAppearance.BorderSize = 0;
            this.btnBi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBi.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBi.Location = new System.Drawing.Point(3, 385);
            this.btnBi.Name = "btnBi";
            this.btnBi.Size = new System.Drawing.Size(136, 50);
            this.btnBi.TabIndex = 13;
            this.btnBi.Text = "Analisis Bivariable";
            this.btnBi.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(3, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 50);
            this.button3.TabIndex = 12;
            this.button3.Text = "Agregar Instancia";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(3, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 58);
            this.button2.TabIndex = 11;
            this.button2.Text = "Agregar Atributo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(3, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "Eliminar Atributo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // columnToAutomatic
            // 
            this.columnToAutomatic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.columnToAutomatic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnToAutomatic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnToAutomatic.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnToAutomatic.ForeColor = System.Drawing.SystemColors.Window;
            this.columnToAutomatic.FormattingEnabled = true;
            this.columnToAutomatic.Location = new System.Drawing.Point(624, 341);
            this.columnToAutomatic.Name = "columnToAutomatic";
            this.columnToAutomatic.Size = new System.Drawing.Size(164, 28);
            this.columnToAutomatic.TabIndex = 19;
            // 
            // DevelopAnalyse
            // 
            this.DevelopAnalyse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.DevelopAnalyse.FlatAppearance.BorderSize = 0;
            this.DevelopAnalyse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.DevelopAnalyse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DevelopAnalyse.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevelopAnalyse.ForeColor = System.Drawing.SystemColors.Control;
            this.DevelopAnalyse.Location = new System.Drawing.Point(679, 412);
            this.DevelopAnalyse.Name = "DevelopAnalyse";
            this.DevelopAnalyse.Size = new System.Drawing.Size(121, 38);
            this.DevelopAnalyse.TabIndex = 20;
            this.DevelopAnalyse.Text = "Analizar";
            this.DevelopAnalyse.UseVisualStyleBackColor = false;
            this.DevelopAnalyse.Click += new System.EventHandler(this.DevelopAnalyse_Click);
            // 
            // AlgoritmNames
            // 
            this.AlgoritmNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.AlgoritmNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlgoritmNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlgoritmNames.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlgoritmNames.ForeColor = System.Drawing.SystemColors.Window;
            this.AlgoritmNames.FormattingEnabled = true;
            this.AlgoritmNames.Location = new System.Drawing.Point(624, 374);
            this.AlgoritmNames.Name = "AlgoritmNames";
            this.AlgoritmNames.Size = new System.Drawing.Size(164, 28);
            this.AlgoritmNames.TabIndex = 21;
            // 
            // metodology
            // 
            this.metodology.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.metodology.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metodology.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metodology.ForeColor = System.Drawing.SystemColors.Window;
            this.metodology.FormattingEnabled = true;
            this.metodology.Location = new System.Drawing.Point(624, 307);
            this.metodology.Name = "metodology";
            this.metodology.Size = new System.Drawing.Size(102, 28);
            this.metodology.TabIndex = 22;
            this.metodology.SelectedIndexChanged += new System.EventHandler(this.metodology_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(513, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Metodología";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(513, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Algoritmo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(513, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Clase";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.CBAtr2);
            this.groupBox1.Controls.Add(this.lblOutDom);
            this.groupBox1.Controls.Add(this.lblVFP);
            this.groupBox1.Controls.Add(this.lblVF);
            this.groupBox1.Controls.Add(this.lblTipe);
            this.groupBox1.Controls.Add(this.txtnewnom);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(834, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 184);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atributo";
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnedit.FlatAppearance.BorderSize = 0;
            this.btnedit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnedit.Location = new System.Drawing.Point(182, 155);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(30, 27);
            this.btnedit.TabIndex = 43;
            this.btnedit.Text = "Agregar";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // CBAtr2
            // 
            this.CBAtr2.FormattingEnabled = true;
            this.CBAtr2.Location = new System.Drawing.Point(77, 18);
            this.CBAtr2.Name = "CBAtr2";
            this.CBAtr2.Size = new System.Drawing.Size(123, 21);
            this.CBAtr2.TabIndex = 45;
            this.CBAtr2.SelectedIndexChanged += new System.EventHandler(this.CBAtr2_SelectedIndexChanged);
            // 
            // lblOutDom
            // 
            this.lblOutDom.AutoSize = true;
            this.lblOutDom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutDom.Location = new System.Drawing.Point(88, 105);
            this.lblOutDom.Name = "lblOutDom";
            this.lblOutDom.Size = new System.Drawing.Size(22, 20);
            this.lblOutDom.TabIndex = 44;
            this.lblOutDom.Text = "0 ";
            // 
            // lblVFP
            // 
            this.lblVFP.AutoSize = true;
            this.lblVFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVFP.Location = new System.Drawing.Point(135, 75);
            this.lblVFP.Name = "lblVFP";
            this.lblVFP.Size = new System.Drawing.Size(32, 20);
            this.lblVFP.TabIndex = 43;
            this.lblVFP.Text = "0%";
            // 
            // lblVF
            // 
            this.lblVF.AutoSize = true;
            this.lblVF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVF.Location = new System.Drawing.Point(87, 75);
            this.lblVF.Name = "lblVF";
            this.lblVF.Size = new System.Drawing.Size(18, 20);
            this.lblVF.TabIndex = 42;
            this.lblVF.Text = "0";
            // 
            // lblTipe
            // 
            this.lblTipe.AutoSize = true;
            this.lblTipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipe.Location = new System.Drawing.Point(88, 49);
            this.lblTipe.Name = "lblTipe";
            this.lblTipe.Size = new System.Drawing.Size(102, 20);
            this.lblTipe.TabIndex = 41;
            this.lblTipe.Text = "Desconocido";
            // 
            // txtnewnom
            // 
            this.txtnewnom.Location = new System.Drawing.Point(77, 160);
            this.txtnewnom.Name = "txtnewnom";
            this.txtnewnom.Size = new System.Drawing.Size(104, 20);
            this.txtnewnom.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Nombre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "F/D";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "V/F";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tipo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nombre";
            // 
            // BTNEli
            // 
            this.BTNEli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BTNEli.FlatAppearance.BorderSize = 0;
            this.BTNEli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BTNEli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEli.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEli.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNEli.Location = new System.Drawing.Point(926, 215);
            this.BTNEli.Name = "BTNEli";
            this.BTNEli.Size = new System.Drawing.Size(108, 33);
            this.BTNEli.TabIndex = 41;
            this.BTNEli.Text = "Eliminar";
            this.BTNEli.UseVisualStyleBackColor = false;
            this.BTNEli.Click += new System.EventHandler(this.BTNEli_Click_1);
            // 
            // CBAtr
            // 
            this.CBAtr.FormattingEnabled = true;
            this.CBAtr.Location = new System.Drawing.Point(925, 188);
            this.CBAtr.Name = "CBAtr";
            this.CBAtr.Size = new System.Drawing.Size(121, 21);
            this.CBAtr.TabIndex = 40;
            // 
            // txtvDefault
            // 
            this.txtvDefault.Location = new System.Drawing.Point(926, 123);
            this.txtvDefault.Name = "txtvDefault";
            this.txtvDefault.Size = new System.Drawing.Size(122, 20);
            this.txtvDefault.TabIndex = 39;
            // 
            // lblval
            // 
            this.lblval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lblval.FlatAppearance.BorderSize = 0;
            this.lblval.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.lblval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblval.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblval.ForeColor = System.Drawing.SystemColors.Control;
            this.lblval.Location = new System.Drawing.Point(829, 117);
            this.lblval.Name = "lblval";
            this.lblval.Size = new System.Drawing.Size(86, 26);
            this.lblval.TabIndex = 38;
            this.lblval.Text = "Valor";
            this.lblval.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(893, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 33);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // TXTDom
            // 
            this.TXTDom.Location = new System.Drawing.Point(925, 85);
            this.TXTDom.Name = "TXTDom";
            this.TXTDom.Size = new System.Drawing.Size(122, 20);
            this.TXTDom.TabIndex = 36;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(926, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(122, 20);
            this.txtName.TabIndex = 35;
            // 
            // CBTipo
            // 
            this.CBTipo.FormattingEnabled = true;
            this.CBTipo.Items.AddRange(new object[] {
            "Numerico",
            "Categorico"});
            this.CBTipo.Location = new System.Drawing.Point(925, 52);
            this.CBTipo.Name = "CBTipo";
            this.CBTipo.Size = new System.Drawing.Size(123, 21);
            this.CBTipo.TabIndex = 34;
            // 
            // lbldom
            // 
            this.lbldom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lbldom.FlatAppearance.BorderSize = 0;
            this.lbldom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.lbldom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbldom.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldom.ForeColor = System.Drawing.SystemColors.Control;
            this.lbldom.Location = new System.Drawing.Point(828, 85);
            this.lbldom.Name = "lbldom";
            this.lbldom.Size = new System.Drawing.Size(86, 26);
            this.lbldom.TabIndex = 33;
            this.lbldom.Text = "Dominio";
            this.lbldom.UseVisualStyleBackColor = false;
            // 
            // lbltipo
            // 
            this.lbltipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lbltipo.FlatAppearance.BorderSize = 0;
            this.lbltipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.lbltipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltipo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltipo.Location = new System.Drawing.Point(828, 42);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(86, 37);
            this.lbltipo.TabIndex = 32;
            this.lbltipo.Text = "Tipo";
            this.lbltipo.UseVisualStyleBackColor = false;
            // 
            // lblnombre
            // 
            this.lblnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lblnombre.FlatAppearance.BorderSize = 0;
            this.lblnombre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.lblnombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblnombre.Location = new System.Drawing.Point(828, 10);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(86, 26);
            this.lblnombre.TabIndex = 31;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.UseVisualStyleBackColor = false;
            // 
            // txtK
            // 
            this.txtK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtK.Location = new System.Drawing.Point(732, 307);
            this.txtK.Multiline = true;
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(56, 28);
            this.txtK.TabIndex = 43;
            this.txtK.Text = "2";
            this.txtK.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNEli);
            this.Controls.Add(this.CBAtr);
            this.Controls.Add(this.txtvDefault);
            this.Controls.Add(this.lblval);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.TXTDom);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.CBTipo);
            this.Controls.Add(this.lbldom);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.metodology);
            this.Controls.Add(this.AlgoritmNames);
            this.Controls.Add(this.DevelopAnalyse);
            this.Controls.Add(this.columnToAutomatic);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.proportion);
            this.Controls.Add(this.missingValues);
            this.Controls.Add(this.ColumnQuantity);
            this.Controls.Add(this.rowsQuantity);
            this.Controls.Add(this.DataSetName);
            this.Controls.Add(this.deleteRow);
            this.Controls.Add(this.tablaPrincipal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablaPrincipal)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accionadorArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaPrincipal;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Button SaveNewFile;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button deleteRow;
        private System.Windows.Forms.Label DataSetName;
        private System.Windows.Forms.Label rowsQuantity;
        private System.Windows.Forms.Label ColumnQuantity;
        private System.Windows.Forms.Label missingValues;
        private System.Windows.Forms.Label proportion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.ComboBox columnToAutomatic;
        private System.Windows.Forms.Button DevelopAnalyse;
        private System.Windows.Forms.ComboBox AlgoritmNames;
        private System.Windows.Forms.ComboBox metodology;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BTNEli;
        private System.Windows.Forms.ComboBox CBAtr;
        private System.Windows.Forms.TextBox txtvDefault;
        private System.Windows.Forms.Button lblval;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox TXTDom;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox CBTipo;
        private System.Windows.Forms.Button lbldom;
        private System.Windows.Forms.Button lbltipo;
        private System.Windows.Forms.Button lblnombre;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.ComboBox CBAtr2;
        private System.Windows.Forms.Label lblOutDom;
        private System.Windows.Forms.Label lblVFP;
        private System.Windows.Forms.Label lblVF;
        private System.Windows.Forms.Label lblTipe;
        private System.Windows.Forms.TextBox txtnewnom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtK;
    }
}

