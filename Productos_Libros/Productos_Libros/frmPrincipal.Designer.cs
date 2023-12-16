namespace Productos_Libros
{
    partial class frmPrincipal
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
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.btnNuevoLibro = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.grupListados = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCriterios = new System.Windows.Forms.Label();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.cBoxCriterios = new System.Windows.Forms.ComboBox();
            this.cBoxOrdenarPor = new System.Windows.Forms.ComboBox();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiarBuscador = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.grupListados.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLibros
            // 
            this.dgvLibros.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLibros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLibros.GridColor = System.Drawing.Color.Snow;
            this.dgvLibros.Location = new System.Drawing.Point(162, 78);
            this.dgvLibros.MultiSelect = false;
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLibros.RowHeadersWidth = 62;
            this.dgvLibros.RowTemplate.Height = 28;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(1289, 500);
            this.dgvLibros.TabIndex = 0;
            // 
            // btnNuevoLibro
            // 
            this.btnNuevoLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(100)))), ((int)(((byte)(128)))));
            this.btnNuevoLibro.FlatAppearance.BorderSize = 0;
            this.btnNuevoLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoLibro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoLibro.Location = new System.Drawing.Point(27, 540);
            this.btnNuevoLibro.Name = "btnNuevoLibro";
            this.btnNuevoLibro.Size = new System.Drawing.Size(109, 38);
            this.btnNuevoLibro.TabIndex = 1;
            this.btnNuevoLibro.Text = "Nuevo Libro";
            this.btnNuevoLibro.UseVisualStyleBackColor = false;
            this.btnNuevoLibro.Click += new System.EventHandler(this.btnNuevoLibro_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscador.Location = new System.Drawing.Point(1103, 29);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(297, 26);
            this.txtBuscador.TabIndex = 2;
            this.txtBuscador.Text = "Buscar";
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            this.txtBuscador.Enter += new System.EventHandler(this.txtBuscador_Enter);
            // 
            // grupListados
            // 
            this.grupListados.Controls.Add(this.button1);
            this.grupListados.Controls.Add(this.lblCriterios);
            this.grupListados.Controls.Add(this.lblOrdenar);
            this.grupListados.Controls.Add(this.cBoxCriterios);
            this.grupListados.Controls.Add(this.cBoxOrdenarPor);
            this.grupListados.Location = new System.Drawing.Point(27, 605);
            this.grupListados.Name = "grupListados";
            this.grupListados.Size = new System.Drawing.Size(1424, 100);
            this.grupListados.TabIndex = 3;
            this.grupListados.TabStop = false;
            this.grupListados.Text = "Generar Listados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1236, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generar Listado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCriterios
            // 
            this.lblCriterios.AutoSize = true;
            this.lblCriterios.Location = new System.Drawing.Point(792, 49);
            this.lblCriterios.Name = "lblCriterios";
            this.lblCriterios.Size = new System.Drawing.Size(71, 20);
            this.lblCriterios.TabIndex = 3;
            this.lblCriterios.Text = "Criterios:\r\n";
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Location = new System.Drawing.Point(378, 49);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(98, 20);
            this.lblOrdenar.TabIndex = 2;
            this.lblOrdenar.Text = "Ordenar por:";
            // 
            // cBoxCriterios
            // 
            this.cBoxCriterios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCriterios.FormattingEnabled = true;
            this.cBoxCriterios.Location = new System.Drawing.Point(941, 45);
            this.cBoxCriterios.Name = "cBoxCriterios";
            this.cBoxCriterios.Size = new System.Drawing.Size(172, 28);
            this.cBoxCriterios.TabIndex = 1;
            this.cBoxCriterios.SelectedIndexChanged += new System.EventHandler(this.cBoxCriterios_SelectedIndexChanged);
            // 
            // cBoxOrdenarPor
            // 
            this.cBoxOrdenarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxOrdenarPor.FormattingEnabled = true;
            this.cBoxOrdenarPor.Location = new System.Drawing.Point(554, 45);
            this.cBoxOrdenarPor.Name = "cBoxOrdenarPor";
            this.cBoxOrdenarPor.Size = new System.Drawing.Size(160, 28);
            this.cBoxOrdenarPor.TabIndex = 0;
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerDetalle.FlatAppearance.BorderSize = 0;
            this.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnVerDetalle.Location = new System.Drawing.Point(27, 78);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(109, 31);
            this.btnVerDetalle.TabIndex = 4;
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnModificar.Location = new System.Drawing.Point(27, 126);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 31);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEliminar.Location = new System.Drawing.Point(27, 172);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 31);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiarBuscador
            // 
            this.btnLimpiarBuscador.BackColor = System.Drawing.Color.Brown;
            this.btnLimpiarBuscador.FlatAppearance.BorderSize = 0;
            this.btnLimpiarBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBuscador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarBuscador.Location = new System.Drawing.Point(1422, 27);
            this.btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            this.btnLimpiarBuscador.Size = new System.Drawing.Size(29, 31);
            this.btnLimpiarBuscador.TabIndex = 7;
            this.btnLimpiarBuscador.Text = "x";
            this.btnLimpiarBuscador.UseVisualStyleBackColor = false;
            this.btnLimpiarBuscador.Click += new System.EventHandler(this.btnLimpiarBuscador_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1633, 824);
            this.Controls.Add(this.btnLimpiarBuscador);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.grupListados);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.btnNuevoLibro);
            this.Controls.Add(this.dgvLibros);
            this.MinimumSize = new System.Drawing.Size(1300, 850);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Libros";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.grupListados.ResumeLayout(false);
            this.grupListados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Button btnNuevoLibro;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.GroupBox grupListados;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.ComboBox cBoxCriterios;
        private System.Windows.Forms.ComboBox cBoxOrdenarPor;
        private System.Windows.Forms.Label lblCriterios;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiarBuscador;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
    }
}

