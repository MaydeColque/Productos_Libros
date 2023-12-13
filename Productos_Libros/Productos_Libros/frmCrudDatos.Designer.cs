namespace Productos_Libros
{
    partial class frmCrudDatos
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
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtAnioEdicion = new System.Windows.Forms.TextBox();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtNroEdicion = new System.Windows.Forms.TextBox();
            this.txtImpresiones = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAnioEdicion = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblNroEdicion = new System.Windows.Forms.Label();
            this.lblCantImpresiones = new System.Windows.Forms.Label();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.cBxIdioma = new System.Windows.Forms.ComboBox();
            this.cBxEditorial = new System.Windows.Forms.ComboBox();
            this.cBxAutor = new System.Windows.Forms.ComboBox();
            this.lblIsbnRepetido = new System.Windows.Forms.Label();
            this.lblAlertaTitulo = new System.Windows.Forms.Label();
            this.lblAlertaAutor = new System.Windows.Forms.Label();
            this.lblAlertaEditorial = new System.Windows.Forms.Label();
            this.lblAlertaIdioma = new System.Windows.Forms.Label();
            this.lblAlertaAño = new System.Windows.Forms.Label();
            this.lblAlertaNroEdicion = new System.Windows.Forms.Label();
            this.lblAlertaImpresiones = new System.Windows.Forms.Label();
            this.lblAlertaPaginas = new System.Windows.Forms.Label();
            this.lblAlertaPrecioCompra = new System.Windows.Forms.Label();
            this.lblAlertaPrecioVenta = new System.Windows.Forms.Label();
            this.lblAlertaIsbn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(272, 72);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(379, 26);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(474, 156);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(177, 26);
            this.txtIsbn.TabIndex = 4;
            this.txtIsbn.Leave += new System.EventHandler(this.txtIsbn_Leave);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(474, 332);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(177, 26);
            this.txtPrecioVenta.TabIndex = 10;
            // 
            // txtAnioEdicion
            // 
            this.txtAnioEdicion.Location = new System.Drawing.Point(272, 159);
            this.txtAnioEdicion.Name = "txtAnioEdicion";
            this.txtAnioEdicion.Size = new System.Drawing.Size(153, 26);
            this.txtAnioEdicion.TabIndex = 3;
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(48, 331);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(177, 26);
            this.txtPaginas.TabIndex = 8;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(272, 333);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(153, 26);
            this.txtPrecioCompra.TabIndex = 9;
            // 
            // txtNroEdicion
            // 
            this.txtNroEdicion.Location = new System.Drawing.Point(272, 246);
            this.txtNroEdicion.Name = "txtNroEdicion";
            this.txtNroEdicion.Size = new System.Drawing.Size(153, 26);
            this.txtNroEdicion.TabIndex = 6;
            // 
            // txtImpresiones
            // 
            this.txtImpresiones.Location = new System.Drawing.Point(474, 244);
            this.txtImpresiones.Name = "txtImpresiones";
            this.txtImpresiones.Size = new System.Drawing.Size(177, 26);
            this.txtImpresiones.TabIndex = 7;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAutor.Location = new System.Drawing.Point(44, 34);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(48, 20);
            this.lblAutor.TabIndex = 11;
            this.lblAutor.Text = "Autor";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(542, 422);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 38);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(100)))), ((int)(((byte)(128)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(427, 422);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 38);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEditorial.Location = new System.Drawing.Point(44, 123);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(66, 20);
            this.lblEditorial.TabIndex = 14;
            this.lblEditorial.Text = "Editorial";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblIdioma.Location = new System.Drawing.Point(44, 209);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(57, 20);
            this.lblIdioma.TabIndex = 15;
            this.lblIdioma.Text = "Idioma";
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPaginas.Location = new System.Drawing.Point(44, 300);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(66, 20);
            this.lblPaginas.TabIndex = 16;
            this.lblPaginas.Text = "Páginas";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitulo.Location = new System.Drawing.Point(268, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 20);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Título";
            // 
            // lblAnioEdicion
            // 
            this.lblAnioEdicion.AutoSize = true;
            this.lblAnioEdicion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAnioEdicion.Location = new System.Drawing.Point(268, 123);
            this.lblAnioEdicion.Name = "lblAnioEdicion";
            this.lblAnioEdicion.Size = new System.Drawing.Size(116, 20);
            this.lblAnioEdicion.TabIndex = 18;
            this.lblAnioEdicion.Text = "Año de Edición";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblIsbn.Location = new System.Drawing.Point(470, 123);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(47, 20);
            this.lblIsbn.TabIndex = 19;
            this.lblIsbn.Text = "ISBN";
            // 
            // lblNroEdicion
            // 
            this.lblNroEdicion.AutoSize = true;
            this.lblNroEdicion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNroEdicion.Location = new System.Drawing.Point(268, 209);
            this.lblNroEdicion.Name = "lblNroEdicion";
            this.lblNroEdicion.Size = new System.Drawing.Size(112, 20);
            this.lblNroEdicion.TabIndex = 20;
            this.lblNroEdicion.Text = "Nro de Edición";
            // 
            // lblCantImpresiones
            // 
            this.lblCantImpresiones.AutoSize = true;
            this.lblCantImpresiones.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCantImpresiones.Location = new System.Drawing.Point(470, 209);
            this.lblCantImpresiones.Name = "lblCantImpresiones";
            this.lblCantImpresiones.Size = new System.Drawing.Size(96, 20);
            this.lblCantImpresiones.TabIndex = 21;
            this.lblCantImpresiones.Text = "Impresiones";
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPrecioCompra.Location = new System.Drawing.Point(268, 300);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(113, 20);
            this.lblPrecioCompra.TabIndex = 22;
            this.lblPrecioCompra.Text = "Precio Compra";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPrecioVenta.Location = new System.Drawing.Point(470, 300);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.lblPrecioVenta.TabIndex = 23;
            this.lblPrecioVenta.Text = "Precio Venta";
            // 
            // cBxIdioma
            // 
            this.cBxIdioma.FormattingEnabled = true;
            this.cBxIdioma.Location = new System.Drawing.Point(48, 244);
            this.cBxIdioma.Name = "cBxIdioma";
            this.cBxIdioma.Size = new System.Drawing.Size(177, 28);
            this.cBxIdioma.TabIndex = 5;
            // 
            // cBxEditorial
            // 
            this.cBxEditorial.FormattingEnabled = true;
            this.cBxEditorial.Location = new System.Drawing.Point(48, 157);
            this.cBxEditorial.Name = "cBxEditorial";
            this.cBxEditorial.Size = new System.Drawing.Size(177, 28);
            this.cBxEditorial.TabIndex = 2;
            // 
            // cBxAutor
            // 
            this.cBxAutor.FormattingEnabled = true;
            this.cBxAutor.Location = new System.Drawing.Point(48, 72);
            this.cBxAutor.Name = "cBxAutor";
            this.cBxAutor.Size = new System.Drawing.Size(177, 28);
            this.cBxAutor.TabIndex = 0;
            // 
            // lblIsbnRepetido
            // 
            this.lblIsbnRepetido.AutoSize = true;
            this.lblIsbnRepetido.ForeColor = System.Drawing.Color.IndianRed;
            this.lblIsbnRepetido.Location = new System.Drawing.Point(470, 185);
            this.lblIsbnRepetido.Name = "lblIsbnRepetido";
            this.lblIsbnRepetido.Size = new System.Drawing.Size(110, 20);
            this.lblIsbnRepetido.TabIndex = 27;
            this.lblIsbnRepetido.Text = "* isbn repetido";
            this.lblIsbnRepetido.Visible = false;
            // 
            // lblAlertaTitulo
            // 
            this.lblAlertaTitulo.AutoSize = true;
            this.lblAlertaTitulo.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAlertaTitulo.Location = new System.Drawing.Point(268, 103);
            this.lblAlertaTitulo.Name = "lblAlertaTitulo";
            this.lblAlertaTitulo.Size = new System.Drawing.Size(131, 20);
            this.lblAlertaTitulo.TabIndex = 28;
            this.lblAlertaTitulo.Text = "* ingrese un título";
            this.lblAlertaTitulo.Visible = false;
            // 
            // lblAlertaAutor
            // 
            this.lblAlertaAutor.AutoSize = true;
            this.lblAlertaAutor.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAlertaAutor.Location = new System.Drawing.Point(44, 103);
            this.lblAlertaAutor.Name = "lblAlertaAutor";
            this.lblAlertaAutor.Size = new System.Drawing.Size(157, 20);
            this.lblAlertaAutor.TabIndex = 29;
            this.lblAlertaAutor.Text = "* seleccione un autor";
            this.lblAlertaAutor.Visible = false;
            // 
            // lblAlertaEditorial
            // 
            this.lblAlertaEditorial.AutoSize = true;
            this.lblAlertaEditorial.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAlertaEditorial.Location = new System.Drawing.Point(44, 189);
            this.lblAlertaEditorial.Name = "lblAlertaEditorial";
            this.lblAlertaEditorial.Size = new System.Drawing.Size(184, 20);
            this.lblAlertaEditorial.TabIndex = 30;
            this.lblAlertaEditorial.Text = "* seleccione una editorial";
            this.lblAlertaEditorial.Visible = false;
            // 
            // lblAlertaIdioma
            // 
            this.lblAlertaIdioma.AutoSize = true;
            this.lblAlertaIdioma.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAlertaIdioma.Location = new System.Drawing.Point(44, 275);
            this.lblAlertaIdioma.Name = "lblAlertaIdioma";
            this.lblAlertaIdioma.Size = new System.Drawing.Size(166, 20);
            this.lblAlertaIdioma.TabIndex = 31;
            this.lblAlertaIdioma.Text = "* seleccione un idioma";
            this.lblAlertaIdioma.Visible = false;
            // 
            // lblAlertaAño
            // 
            this.lblAlertaAño.AutoSize = true;
            this.lblAlertaAño.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAlertaAño.Location = new System.Drawing.Point(268, 185);
            this.lblAlertaAño.Name = "lblAlertaAño";
            this.lblAlertaAño.Size = new System.Drawing.Size(124, 20);
            this.lblAlertaAño.TabIndex = 32;
            this.lblAlertaAño.Text = "* ingrese un año";
            this.lblAlertaAño.Visible = false;
            // 
            // lblAlertaNroEdicion
            // 
            this.lblAlertaNroEdicion.AutoSize = true;
            this.lblAlertaNroEdicion.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAlertaNroEdicion.Location = new System.Drawing.Point(268, 275);
            this.lblAlertaNroEdicion.Name = "lblAlertaNroEdicion";
            this.lblAlertaNroEdicion.Size = new System.Drawing.Size(151, 20);
            this.lblAlertaNroEdicion.TabIndex = 33;
            this.lblAlertaNroEdicion.Text = "* ingrese un número";
            this.lblAlertaNroEdicion.Visible = false;
            // 
            // lblAlertaImpresiones
            // 
            this.lblAlertaImpresiones.AutoSize = true;
            this.lblAlertaImpresiones.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAlertaImpresiones.Location = new System.Drawing.Point(470, 273);
            this.lblAlertaImpresiones.Name = "lblAlertaImpresiones";
            this.lblAlertaImpresiones.Size = new System.Drawing.Size(151, 20);
            this.lblAlertaImpresiones.TabIndex = 34;
            this.lblAlertaImpresiones.Text = "* ingrese un número";
            this.lblAlertaImpresiones.Visible = false;
            // 
            // lblAlertaPaginas
            // 
            this.lblAlertaPaginas.AutoSize = true;
            this.lblAlertaPaginas.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAlertaPaginas.Location = new System.Drawing.Point(44, 360);
            this.lblAlertaPaginas.Name = "lblAlertaPaginas";
            this.lblAlertaPaginas.Size = new System.Drawing.Size(151, 20);
            this.lblAlertaPaginas.TabIndex = 35;
            this.lblAlertaPaginas.Text = "* ingrese un número";
            this.lblAlertaPaginas.Visible = false;
            // 
            // lblAlertaPrecioCompra
            // 
            this.lblAlertaPrecioCompra.AutoSize = true;
            this.lblAlertaPrecioCompra.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAlertaPrecioCompra.Location = new System.Drawing.Point(268, 362);
            this.lblAlertaPrecioCompra.Name = "lblAlertaPrecioCompra";
            this.lblAlertaPrecioCompra.Size = new System.Drawing.Size(140, 20);
            this.lblAlertaPrecioCompra.TabIndex = 36;
            this.lblAlertaPrecioCompra.Text = "* ingrese un precio";
            this.lblAlertaPrecioCompra.Visible = false;
            // 
            // lblAlertaPrecioVenta
            // 
            this.lblAlertaPrecioVenta.AutoSize = true;
            this.lblAlertaPrecioVenta.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAlertaPrecioVenta.Location = new System.Drawing.Point(470, 360);
            this.lblAlertaPrecioVenta.Name = "lblAlertaPrecioVenta";
            this.lblAlertaPrecioVenta.Size = new System.Drawing.Size(140, 20);
            this.lblAlertaPrecioVenta.TabIndex = 37;
            this.lblAlertaPrecioVenta.Text = "* ingrese un precio";
            this.lblAlertaPrecioVenta.Visible = false;
            // 
            // lblAlertaIsbn
            // 
            this.lblAlertaIsbn.AutoSize = true;
            this.lblAlertaIsbn.ForeColor = System.Drawing.Color.IndianRed;
            this.lblAlertaIsbn.Location = new System.Drawing.Point(513, 123);
            this.lblAlertaIsbn.Name = "lblAlertaIsbn";
            this.lblAlertaIsbn.Size = new System.Drawing.Size(183, 20);
            this.lblAlertaIsbn.TabIndex = 38;
            this.lblAlertaIsbn.Text = "*Debe tener 14 números";
            this.lblAlertaIsbn.Visible = false;
            // 
            // frmCrudDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(711, 484);
            this.Controls.Add(this.lblAlertaIsbn);
            this.Controls.Add(this.lblAlertaPrecioVenta);
            this.Controls.Add(this.lblAlertaPrecioCompra);
            this.Controls.Add(this.lblAlertaPaginas);
            this.Controls.Add(this.lblAlertaImpresiones);
            this.Controls.Add(this.lblAlertaNroEdicion);
            this.Controls.Add(this.lblAlertaAño);
            this.Controls.Add(this.lblAlertaIdioma);
            this.Controls.Add(this.lblAlertaEditorial);
            this.Controls.Add(this.lblAlertaAutor);
            this.Controls.Add(this.lblAlertaTitulo);
            this.Controls.Add(this.lblIsbnRepetido);
            this.Controls.Add(this.cBxAutor);
            this.Controls.Add(this.cBxEditorial);
            this.Controls.Add(this.cBxIdioma);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.lblPrecioCompra);
            this.Controls.Add(this.lblCantImpresiones);
            this.Controls.Add(this.lblNroEdicion);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.lblAnioEdicion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtImpresiones);
            this.Controls.Add(this.txtNroEdicion);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.txtAnioEdicion);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCrudDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Libro";
            this.Load += new System.EventHandler(this.frmCrudDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtAnioEdicion;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtNroEdicion;
        private System.Windows.Forms.TextBox txtImpresiones;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAnioEdicion;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblNroEdicion;
        private System.Windows.Forms.Label lblCantImpresiones;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.ComboBox cBxIdioma;
        private System.Windows.Forms.ComboBox cBxEditorial;
        private System.Windows.Forms.ComboBox cBxAutor;
        private System.Windows.Forms.Label lblIsbnRepetido;
        private System.Windows.Forms.Label lblAlertaTitulo;
        private System.Windows.Forms.Label lblAlertaAutor;
        private System.Windows.Forms.Label lblAlertaEditorial;
        private System.Windows.Forms.Label lblAlertaIdioma;
        private System.Windows.Forms.Label lblAlertaAño;
        private System.Windows.Forms.Label lblAlertaNroEdicion;
        private System.Windows.Forms.Label lblAlertaImpresiones;
        private System.Windows.Forms.Label lblAlertaPaginas;
        private System.Windows.Forms.Label lblAlertaPrecioCompra;
        private System.Windows.Forms.Label lblAlertaPrecioVenta;
        private System.Windows.Forms.Label lblAlertaIsbn;
    }
}