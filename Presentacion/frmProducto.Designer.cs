namespace Presentacion
{
    partial class frmProducto
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
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.pnlSup = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnSubirImg = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblCate = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.lblImg = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.barraEstado = new System.Windows.Forms.StatusStrip();
            this.lblBarraEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.pnlSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            this.pnlLateral.SuspendLayout();
            this.barraEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCategoria
            // 
            this.cboCategoria.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(15, 328);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(163, 21);
            this.cboCategoria.TabIndex = 5;
            this.cboCategoria.MouseEnter += new System.EventHandler(this.cboCategoria_MouseEnter);
            this.cboCategoria.MouseLeave += new System.EventHandler(this.pbMinimizar_MouseLeave);
            // 
            // pnlSup
            // 
            this.pnlSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(134)))));
            this.pnlSup.Controls.Add(this.lblTitulo);
            this.pnlSup.Controls.Add(this.pbMinimizar);
            this.pnlSup.Controls.Add(this.pbSalir);
            this.pnlSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSup.Location = new System.Drawing.Point(0, 0);
            this.pnlSup.Name = "pnlSup";
            this.pnlSup.Size = new System.Drawing.Size(617, 43);
            this.pnlSup.TabIndex = 3;
            this.pnlSup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSup_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(208, 25);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "AGREGAR PRODUCTO";
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizar.Image = global::Presentacion.Properties.Resources.minimize_thewindow_theapplication_2872;
            this.pbMinimizar.Location = new System.Drawing.Point(538, 3);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(32, 35);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 1;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            this.pbMinimizar.MouseEnter += new System.EventHandler(this.pbMinimizar_MouseEnter);
            this.pbMinimizar.MouseLeave += new System.EventHandler(this.pbMinimizar_MouseLeave);
            // 
            // pbSalir
            // 
            this.pbSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalir.Image = global::Presentacion.Properties.Resources.closewindowapplication_cerca_ventan_2874;
            this.pbSalir.Location = new System.Drawing.Point(576, 3);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(32, 35);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalir.TabIndex = 2;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            this.pbSalir.MouseEnter += new System.EventHandler(this.pbSalir_MouseEnter);
            this.pbSalir.MouseLeave += new System.EventHandler(this.pbMinimizar_MouseLeave);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCodigo.Location = new System.Drawing.Point(11, 42);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 20);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código";
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCod.Location = new System.Drawing.Point(15, 68);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(163, 20);
            this.txtCod.TabIndex = 0;
            this.txtCod.MouseEnter += new System.EventHandler(this.txtCod_MouseEnter);
            this.txtCod.MouseLeave += new System.EventHandler(this.pbMinimizar_MouseLeave);
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(107)))));
            this.pnlLateral.Controls.Add(this.btnSubirImg);
            this.pnlLateral.Controls.Add(this.btnCancelar);
            this.pnlLateral.Controls.Add(this.btnAceptar);
            this.pnlLateral.Controls.Add(this.lblMarca);
            this.pnlLateral.Controls.Add(this.cboMarca);
            this.pnlLateral.Controls.Add(this.lblCate);
            this.pnlLateral.Controls.Add(this.txtPrecio);
            this.pnlLateral.Controls.Add(this.lblPrecio);
            this.pnlLateral.Controls.Add(this.cboCategoria);
            this.pnlLateral.Controls.Add(this.txtImg);
            this.pnlLateral.Controls.Add(this.lblImg);
            this.pnlLateral.Controls.Add(this.txtDesc);
            this.pnlLateral.Controls.Add(this.lblDesc);
            this.pnlLateral.Controls.Add(this.txtNombre);
            this.pnlLateral.Controls.Add(this.lblNombre);
            this.pnlLateral.Controls.Add(this.txtCod);
            this.pnlLateral.Controls.Add(this.lblCodigo);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLateral.Location = new System.Drawing.Point(427, 43);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(190, 529);
            this.pnlLateral.TabIndex = 8;
            // 
            // btnSubirImg
            // 
            this.btnSubirImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirImg.Location = new System.Drawing.Point(150, 224);
            this.btnSubirImg.Name = "btnSubirImg";
            this.btnSubirImg.Size = new System.Drawing.Size(28, 20);
            this.btnSubirImg.TabIndex = 17;
            this.btnSubirImg.Text = "+";
            this.btnSubirImg.UseVisualStyleBackColor = true;
            this.btnSubirImg.Click += new System.EventHandler(this.btnSubirImg_Click);
            this.btnSubirImg.MouseEnter += new System.EventHandler(this.btnSubirImg_MouseEnter);
            this.btnSubirImg.MouseLeave += new System.EventHandler(this.pbMinimizar_MouseLeave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(134)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(144)))), ((int)(((byte)(221)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(0, 484);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(190, 43);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.pbSalir_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.pbMinimizar_MouseLeave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(134)))));
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(144)))), ((int)(((byte)(221)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(0, 441);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(190, 43);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseEnter += new System.EventHandler(this.btnAceptar_MouseEnter);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.pbMinimizar_MouseLeave);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMarca.Location = new System.Drawing.Point(11, 355);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 20);
            this.lblMarca.TabIndex = 16;
            this.lblMarca.Text = "Marca";
            // 
            // cboMarca
            // 
            this.cboMarca.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(15, 381);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(163, 21);
            this.cboMarca.TabIndex = 6;
            this.cboMarca.MouseEnter += new System.EventHandler(this.cboMarca_MouseEnter);
            this.cboMarca.MouseLeave += new System.EventHandler(this.pbMinimizar_MouseLeave);
            // 
            // lblCate
            // 
            this.lblCate.AutoSize = true;
            this.lblCate.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCate.Location = new System.Drawing.Point(11, 302);
            this.lblCate.Name = "lblCate";
            this.lblCate.Size = new System.Drawing.Size(74, 20);
            this.lblCate.TabIndex = 14;
            this.lblCate.Text = "Categoría";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(15, 276);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(163, 20);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.MouseEnter += new System.EventHandler(this.txtPrecio_MouseEnter);
            this.txtPrecio.MouseLeave += new System.EventHandler(this.pbMinimizar_MouseLeave);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrecio.Location = new System.Drawing.Point(11, 250);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(50, 20);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio";
            // 
            // txtImg
            // 
            this.txtImg.BackColor = System.Drawing.Color.Gainsboro;
            this.txtImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImg.Location = new System.Drawing.Point(15, 224);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(128, 20);
            this.txtImg.TabIndex = 3;
            this.txtImg.Leave += new System.EventHandler(this.txtImg_Leave);
            this.txtImg.MouseEnter += new System.EventHandler(this.txtImg_MouseEnter);
            this.txtImg.MouseLeave += new System.EventHandler(this.pbMinimizar_MouseLeave);
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImg.ForeColor = System.Drawing.SystemColors.Control;
            this.lblImg.Location = new System.Drawing.Point(11, 198);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(59, 20);
            this.lblImg.TabIndex = 10;
            this.lblImg.Text = "Imágen";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.Location = new System.Drawing.Point(15, 172);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(163, 20);
            this.txtDesc.TabIndex = 2;
            this.txtDesc.MouseEnter += new System.EventHandler(this.txtDesc_MouseEnter);
            this.txtDesc.MouseLeave += new System.EventHandler(this.pbMinimizar_MouseLeave);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDesc.Location = new System.Drawing.Point(11, 146);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(87, 20);
            this.lblDesc.TabIndex = 8;
            this.lblDesc.Text = "Descripción";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(15, 120);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.MouseEnter += new System.EventHandler(this.txtNombre_MouseEnter);
            this.txtNombre.MouseLeave += new System.EventHandler(this.pbMinimizar_MouseLeave);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(11, 94);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // barraEstado
            // 
            this.barraEstado.BackColor = System.Drawing.Color.Silver;
            this.barraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBarraEstado});
            this.barraEstado.Location = new System.Drawing.Point(0, 550);
            this.barraEstado.Name = "barraEstado";
            this.barraEstado.Size = new System.Drawing.Size(427, 22);
            this.barraEstado.TabIndex = 10;
            this.barraEstado.Text = "statusStrip1";
            // 
            // lblBarraEstado
            // 
            this.lblBarraEstado.Name = "lblBarraEstado";
            this.lblBarraEstado.Size = new System.Drawing.Size(35, 17);
            this.lblBarraEstado.Text = "Listo.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(107)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 507);
            this.panel1.TabIndex = 11;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(23, 60);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(389, 480);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 9;
            this.pbImagen.TabStop = false;
            this.pbImagen.MouseEnter += new System.EventHandler(this.pbImagen_MouseEnter);
            this.pbImagen.MouseLeave += new System.EventHandler(this.pbMinimizar_MouseLeave);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(617, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barraEstado);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlSup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(617, 572);
            this.MinimumSize = new System.Drawing.Size(617, 572);
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.pnlSup.ResumeLayout(false);
            this.pnlSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            this.pnlLateral.ResumeLayout(false);
            this.pnlLateral.PerformLayout();
            this.barraEstado.ResumeLayout(false);
            this.barraEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Panel pnlSup;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Label lblCate;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbSalir;
        private System.Windows.Forms.StatusStrip barraEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblBarraEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSubirImg;
    }
}