namespace Clase_1
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_Placa = new System.Windows.Forms.TextBox();
            this.cbx_Marca = new System.Windows.Forms.ComboBox();
            this.nric_Modelo = new System.Windows.Forms.NumericUpDown();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInformacion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTotalPeaje = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPeajePromedioMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlacaMayorPeaje = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.gbx_Vehiculo = new System.Windows.Forms.GroupBox();
            this.lbl_Modelo = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.lbl_Placa = new System.Windows.Forms.Label();
            this.gbx_Peaje = new System.Windows.Forms.GroupBox();
            this.dtm_Fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_Destino = new System.Windows.Forms.Label();
            this.cbx_Destino = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.PLACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESTINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEAJE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_TotalDestino = new System.Windows.Forms.Label();
            this.lbl_TitleTotalDestino = new System.Windows.Forms.Label();
            this.lbl_TitleTotalPromedioMarca = new System.Windows.Forms.Label();
            this.lbl_TitlePlacaMayorPeaje = new System.Windows.Forms.Label();
            this.lbl_TotalPromedioMarca = new System.Windows.Forms.Label();
            this.lbl_PlacaMayorPeaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nric_Modelo)).BeginInit();
            this.menuPrincipal.SuspendLayout();
            this.gbx_Vehiculo.SuspendLayout();
            this.gbx_Peaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_Placa
            // 
            this.tbx_Placa.Location = new System.Drawing.Point(82, 16);
            this.tbx_Placa.Name = "tbx_Placa";
            this.tbx_Placa.Size = new System.Drawing.Size(121, 20);
            this.tbx_Placa.TabIndex = 0;
            // 
            // cbx_Marca
            // 
            this.cbx_Marca.FormattingEnabled = true;
            this.cbx_Marca.Items.AddRange(new object[] {
            "TOYOTA",
            "NISSAN",
            "IZUZU",
            "AUDI",
            "MERCEDEZ",
            "SUZUKI",
            "MITSUBISHI"});
            this.cbx_Marca.Location = new System.Drawing.Point(82, 42);
            this.cbx_Marca.Name = "cbx_Marca";
            this.cbx_Marca.Size = new System.Drawing.Size(121, 21);
            this.cbx_Marca.TabIndex = 1;
            // 
            // nric_Modelo
            // 
            this.nric_Modelo.Location = new System.Drawing.Point(83, 69);
            this.nric_Modelo.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nric_Modelo.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.nric_Modelo.Name = "nric_Modelo";
            this.nric_Modelo.Size = new System.Drawing.Size(120, 20);
            this.nric_Modelo.TabIndex = 2;
            this.nric_Modelo.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnInformacion,
            this.btnSalir});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(712, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(73, 20);
            this.btnGuardar.Text = "GUARDAR";
            // 
            // btnInformacion
            // 
            this.btnInformacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTotalPeaje,
            this.btnPeajePromedioMarca,
            this.btnPlacaMayorPeaje});
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(101, 20);
            this.btnInformacion.Text = "INFORMACION";
            // 
            // btnTotalPeaje
            // 
            this.btnTotalPeaje.Name = "btnTotalPeaje";
            this.btnTotalPeaje.Size = new System.Drawing.Size(240, 22);
            this.btnTotalPeaje.Text = "TOTAL PEAJE";
            // 
            // btnPeajePromedioMarca
            // 
            this.btnPeajePromedioMarca.Name = "btnPeajePromedioMarca";
            this.btnPeajePromedioMarca.Size = new System.Drawing.Size(240, 22);
            this.btnPeajePromedioMarca.Text = "PEAJE PROMEDIO POR MARCA";
            // 
            // btnPlacaMayorPeaje
            // 
            this.btnPlacaMayorPeaje.Name = "btnPlacaMayorPeaje";
            this.btnPlacaMayorPeaje.Size = new System.Drawing.Size(240, 22);
            this.btnPlacaMayorPeaje.Text = "PLACA MAYOR PEAJE PAGADO";
            // 
            // btnSalir
            // 
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 20);
            this.btnSalir.Text = "SALIR";
            //This.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Uighur", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 24);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(688, 69);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "CONTROL DE PEAJES";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbx_Vehiculo
            // 
            this.gbx_Vehiculo.Controls.Add(this.lbl_Modelo);
            this.gbx_Vehiculo.Controls.Add(this.lbl_Marca);
            this.gbx_Vehiculo.Controls.Add(this.nric_Modelo);
            this.gbx_Vehiculo.Controls.Add(this.lbl_Placa);
            this.gbx_Vehiculo.Controls.Add(this.cbx_Marca);
            this.gbx_Vehiculo.Controls.Add(this.tbx_Placa);
            this.gbx_Vehiculo.Location = new System.Drawing.Point(110, 113);
            this.gbx_Vehiculo.Name = "gbx_Vehiculo";
            this.gbx_Vehiculo.Size = new System.Drawing.Size(212, 112);
            this.gbx_Vehiculo.TabIndex = 5;
            this.gbx_Vehiculo.TabStop = false;
            this.gbx_Vehiculo.Text = "DATOS DEL VEHÍCULO";
            // 
            // lbl_Modelo
            // 
            this.lbl_Modelo.AutoSize = true;
            this.lbl_Modelo.Location = new System.Drawing.Point(7, 73);
            this.lbl_Modelo.Name = "lbl_Modelo";
            this.lbl_Modelo.Size = new System.Drawing.Size(53, 13);
            this.lbl_Modelo.TabIndex = 2;
            this.lbl_Modelo.Text = "MODELO";
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Location = new System.Drawing.Point(7, 47);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(45, 13);
            this.lbl_Marca.TabIndex = 1;
            this.lbl_Marca.Text = "MARCA";
            // 
            // lbl_Placa
            // 
            this.lbl_Placa.AutoSize = true;
            this.lbl_Placa.Location = new System.Drawing.Point(6, 20);
            this.lbl_Placa.Name = "lbl_Placa";
            this.lbl_Placa.Size = new System.Drawing.Size(41, 13);
            this.lbl_Placa.TabIndex = 0;
            this.lbl_Placa.Text = "PLACA";
            // 
            // gbx_Peaje
            // 
            this.gbx_Peaje.Controls.Add(this.dtm_Fecha);
            this.gbx_Peaje.Controls.Add(this.lbl_Fecha);
            this.gbx_Peaje.Controls.Add(this.lbl_Destino);
            this.gbx_Peaje.Controls.Add(this.cbx_Destino);
            this.gbx_Peaje.Location = new System.Drawing.Point(328, 113);
            this.gbx_Peaje.Name = "gbx_Peaje";
            this.gbx_Peaje.Size = new System.Drawing.Size(270, 112);
            this.gbx_Peaje.TabIndex = 6;
            this.gbx_Peaje.TabStop = false;
            this.gbx_Peaje.Text = "DATOS DE PEAJE";
            // 
            // dtm_Fecha
            // 
            this.dtm_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_Fecha.Location = new System.Drawing.Point(66, 63);
            this.dtm_Fecha.Name = "dtm_Fecha";
            this.dtm_Fecha.Size = new System.Drawing.Size(200, 20);
            this.dtm_Fecha.TabIndex = 7;
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(6, 66);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(42, 13);
            this.lbl_Fecha.TabIndex = 1;
            this.lbl_Fecha.Text = "FECHA";
            // 
            // lbl_Destino
            // 
            this.lbl_Destino.AutoSize = true;
            this.lbl_Destino.Location = new System.Drawing.Point(6, 23);
            this.lbl_Destino.Name = "lbl_Destino";
            this.lbl_Destino.Size = new System.Drawing.Size(55, 13);
            this.lbl_Destino.TabIndex = 0;
            this.lbl_Destino.Text = "DESTINO";
            // 
            // cbx_Destino
            // 
            this.cbx_Destino.FormattingEnabled = true;
            this.cbx_Destino.Items.AddRange(new object[] {
            "CBBA",
            "SUC",
            "BEN",
            "TJA"});
            this.cbx_Destino.Location = new System.Drawing.Point(66, 20);
            this.cbx_Destino.Name = "cbx_Destino";
            this.cbx_Destino.Size = new System.Drawing.Size(200, 21);
            this.cbx_Destino.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PLACA,
            this.MARCA,
            this.MODELO,
            this.DESTINO,
            this.FECHA,
            this.PEAJE});
            this.dataGridView.Location = new System.Drawing.Point(12, 238);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(688, 142);
            this.dataGridView.TabIndex = 7;
            // 
            // PLACA
            // 
            this.PLACA.HeaderText = "PLACA";
            this.PLACA.Name = "PLACA";
            // 
            // MARCA
            // 
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            // 
            // MODELO
            // 
            this.MODELO.HeaderText = "MODELO";
            this.MODELO.Name = "MODELO";
            // 
            // DESTINO
            // 
            this.DESTINO.HeaderText = "DESTINO";
            this.DESTINO.Name = "DESTINO";
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // PEAJE
            // 
            this.PEAJE.HeaderText = "PEAJE";
            this.PEAJE.Name = "PEAJE";
            // 
            // lbl_TotalDestino
            // 
            this.lbl_TotalDestino.AutoSize = true;
            this.lbl_TotalDestino.Location = new System.Drawing.Point(136, 413);
            this.lbl_TotalDestino.Name = "lbl_TotalDestino";
            this.lbl_TotalDestino.Size = new System.Drawing.Size(13, 13);
            this.lbl_TotalDestino.TabIndex = 8;
            this.lbl_TotalDestino.Text = "0";
            // 
            // lbl_TitleTotalDestino
            // 
            this.lbl_TitleTotalDestino.AutoSize = true;
            this.lbl_TitleTotalDestino.Location = new System.Drawing.Point(107, 396);
            this.lbl_TitleTotalDestino.Name = "lbl_TitleTotalDestino";
            this.lbl_TitleTotalDestino.Size = new System.Drawing.Size(86, 13);
            this.lbl_TitleTotalDestino.TabIndex = 11;
            this.lbl_TitleTotalDestino.Text = "Total por destino";
            // 
            // lbl_TitleTotalPromedioMarca
            // 
            this.lbl_TitleTotalPromedioMarca.AutoSize = true;
            this.lbl_TitleTotalPromedioMarca.Location = new System.Drawing.Point(281, 396);
            this.lbl_TitleTotalPromedioMarca.Name = "lbl_TitleTotalPromedioMarca";
            this.lbl_TitleTotalPromedioMarca.Size = new System.Drawing.Size(127, 13);
            this.lbl_TitleTotalPromedioMarca.TabIndex = 12;
            this.lbl_TitleTotalPromedioMarca.Text = "Total promedio por marca";
            // 
            // lbl_TitlePlacaMayorPeaje
            // 
            this.lbl_TitlePlacaMayorPeaje.AutoSize = true;
            this.lbl_TitlePlacaMayorPeaje.Location = new System.Drawing.Point(467, 396);
            this.lbl_TitlePlacaMayorPeaje.Name = "lbl_TitlePlacaMayorPeaje";
            this.lbl_TitlePlacaMayorPeaje.Size = new System.Drawing.Size(94, 13);
            this.lbl_TitlePlacaMayorPeaje.TabIndex = 13;
            this.lbl_TitlePlacaMayorPeaje.Text = "Placa mayor peaje";
            // 
            // lbl_TotalPromedioMarca
            // 
            this.lbl_TotalPromedioMarca.AutoSize = true;
            this.lbl_TotalPromedioMarca.Location = new System.Drawing.Point(344, 413);
            this.lbl_TotalPromedioMarca.Name = "lbl_TotalPromedioMarca";
            this.lbl_TotalPromedioMarca.Size = new System.Drawing.Size(13, 13);
            this.lbl_TotalPromedioMarca.TabIndex = 14;
            this.lbl_TotalPromedioMarca.Text = "0";
            // 
            // lbl_PlacaMayorPeaje
            // 
            this.lbl_PlacaMayorPeaje.AutoSize = true;
            this.lbl_PlacaMayorPeaje.Location = new System.Drawing.Point(504, 413);
            this.lbl_PlacaMayorPeaje.Name = "lbl_PlacaMayorPeaje";
            this.lbl_PlacaMayorPeaje.Size = new System.Drawing.Size(13, 13);
            this.lbl_PlacaMayorPeaje.TabIndex = 15;
            this.lbl_PlacaMayorPeaje.Text = "0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 449);
            this.Controls.Add(this.lbl_PlacaMayorPeaje);
            this.Controls.Add(this.lbl_TotalPromedioMarca);
            this.Controls.Add(this.lbl_TitlePlacaMayorPeaje);
            this.Controls.Add(this.lbl_TitleTotalPromedioMarca);
            this.Controls.Add(this.lbl_TitleTotalDestino);
            this.Controls.Add(this.lbl_TotalDestino);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.gbx_Peaje);
            this.Controls.Add(this.gbx_Vehiculo);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmMain";
            this.Text = "CRUD";
            ((System.ComponentModel.ISupportInitialize)(this.nric_Modelo)).EndInit();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.gbx_Vehiculo.ResumeLayout(false);
            this.gbx_Vehiculo.PerformLayout();
            this.gbx_Peaje.ResumeLayout(false);
            this.gbx_Peaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Placa;
        private System.Windows.Forms.ComboBox cbx_Marca;
        private System.Windows.Forms.NumericUpDown nric_Modelo;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem btnGuardar;
        private System.Windows.Forms.ToolStripMenuItem btnInformacion;
        private System.Windows.Forms.ToolStripMenuItem btnTotalPeaje;
        private System.Windows.Forms.ToolStripMenuItem btnPeajePromedioMarca;
        private System.Windows.Forms.ToolStripMenuItem btnPlacaMayorPeaje;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox gbx_Vehiculo;
        private System.Windows.Forms.Label lbl_Modelo;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Label lbl_Placa;
        private System.Windows.Forms.GroupBox gbx_Peaje;
        private System.Windows.Forms.DateTimePicker dtm_Fecha;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Destino;
        private System.Windows.Forms.ComboBox cbx_Destino;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lbl_TotalDestino;
        private System.Windows.Forms.Label lbl_TitleTotalDestino;
        private System.Windows.Forms.Label lbl_TitleTotalPromedioMarca;
        private System.Windows.Forms.Label lbl_TitlePlacaMayorPeaje;
        private System.Windows.Forms.Label lbl_TotalPromedioMarca;
        private System.Windows.Forms.Label lbl_PlacaMayorPeaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESTINO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEAJE;
    }
}

