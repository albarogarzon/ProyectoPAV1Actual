﻿namespace ProyectoPAV1.GUILayer
{
    partial class frmProductos
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
            this.lblMarcaProducto = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.GroupBox();
            this.chkTodas = new System.Windows.Forms.CheckBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboMarcaProducto = new System.Windows.Forms.ComboBox();
            this.grdProductos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarcaProducto
            // 
            this.lblMarcaProducto.AutoSize = true;
            this.lblMarcaProducto.Location = new System.Drawing.Point(20, 24);
            this.lblMarcaProducto.Name = "lblMarcaProducto";
            this.lblMarcaProducto.Size = new System.Drawing.Size(83, 13);
            this.lblMarcaProducto.TabIndex = 5;
            this.lblMarcaProducto.Text = "Marca Producto";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Controls.Add(this.chkTodas);
            this.pnlFiltros.Controls.Add(this.txtNombreProducto);
            this.pnlFiltros.Controls.Add(this.lblNombreProducto);
            this.pnlFiltros.Controls.Add(this.btnConsultar);
            this.pnlFiltros.Controls.Add(this.cboMarcaProducto);
            this.pnlFiltros.Controls.Add(this.lblMarcaProducto);
            this.pnlFiltros.Location = new System.Drawing.Point(12, 12);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(500, 138);
            this.pnlFiltros.TabIndex = 6;
            this.pnlFiltros.TabStop = false;
            this.pnlFiltros.Text = "Filtros";
            // 
            // chkTodas
            // 
            this.chkTodas.AutoSize = true;
            this.chkTodas.Location = new System.Drawing.Point(125, 109);
            this.chkTodas.Name = "chkTodas";
            this.chkTodas.Size = new System.Drawing.Size(56, 17);
            this.chkTodas.TabIndex = 15;
            this.chkTodas.Text = "Todas";
            this.chkTodas.UseVisualStyleBackColor = true;
            this.chkTodas.CheckedChanged += new System.EventHandler(this.chkTodas_CheckedChanged);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(125, 55);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(190, 20);
            this.txtNombreProducto.TabIndex = 14;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(13, 62);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(90, 13);
            this.lblNombreProducto.TabIndex = 13;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(373, 109);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(121, 23);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboMarcaProducto
            // 
            this.cboMarcaProducto.FormattingEnabled = true;
            this.cboMarcaProducto.Location = new System.Drawing.Point(125, 16);
            this.cboMarcaProducto.Name = "cboMarcaProducto";
            this.cboMarcaProducto.Size = new System.Drawing.Size(190, 21);
            this.cboMarcaProducto.TabIndex = 11;
            // 
            // grdProductos
            // 
            this.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductos.Location = new System.Drawing.Point(12, 156);
            this.grdProductos.Name = "grdProductos";
            this.grdProductos.Size = new System.Drawing.Size(659, 320);
            this.grdProductos.TabIndex = 7;
            this.grdProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductos_CellClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 514);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(116, 514);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(222, 514);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 549);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grdProductos);
            this.Controls.Add(this.pnlFiltros);
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMarcaProducto;
        private System.Windows.Forms.GroupBox pnlFiltros;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cboMarcaProducto;
        private System.Windows.Forms.DataGridView grdProductos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chkTodas;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
    }
}