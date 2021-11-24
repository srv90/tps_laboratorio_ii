
namespace FormGimnasio
{
    partial class FrmGym
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSocio = new System.Windows.Forms.Button();
            this.btnGuardarListadoTxt = new System.Windows.Forms.Button();
            this.lblCapacidadSocios = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tmHora = new System.Windows.Forms.Timer(this.components);
            this.lblInscriptos = new System.Windows.Forms.Label();
            this.lblNumLibres = new System.Windows.Forms.Label();
            this.btnGuardarListadoXml = new System.Windows.Forms.Button();
            this.lblLibres = new System.Windows.Forms.Label();
            this.lstSocios = new System.Windows.Forms.ListBox();
            this.lblTotalFacturado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSocio
            // 
            this.btnSocio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSocio.Location = new System.Drawing.Point(6, 349);
            this.btnSocio.Name = "btnSocio";
            this.btnSocio.Size = new System.Drawing.Size(62, 66);
            this.btnSocio.TabIndex = 1;
            this.btnSocio.Text = "Añadir socio";
            this.btnSocio.UseVisualStyleBackColor = true;
            this.btnSocio.Click += new System.EventHandler(this.btnSocio_Click);
            // 
            // btnGuardarListadoTxt
            // 
            this.btnGuardarListadoTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarListadoTxt.Location = new System.Drawing.Point(363, 351);
            this.btnGuardarListadoTxt.Name = "btnGuardarListadoTxt";
            this.btnGuardarListadoTxt.Size = new System.Drawing.Size(99, 66);
            this.btnGuardarListadoTxt.TabIndex = 3;
            this.btnGuardarListadoTxt.Text = "Guardar listado en texto";
            this.btnGuardarListadoTxt.UseVisualStyleBackColor = true;
            this.btnGuardarListadoTxt.Click += new System.EventHandler(this.btnGuardarListadoTxt_Click_1);
            // 
            // lblCapacidadSocios
            // 
            this.lblCapacidadSocios.AutoSize = true;
            this.lblCapacidadSocios.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCapacidadSocios.Location = new System.Drawing.Point(12, 9);
            this.lblCapacidadSocios.Name = "lblCapacidadSocios";
            this.lblCapacidadSocios.Size = new System.Drawing.Size(193, 25);
            this.lblCapacidadSocios.TabIndex = 4;
            this.lblCapacidadSocios.Text = "Capacidad de socios: ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(74, 350);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(63, 66);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar socio";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHora.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHora.Location = new System.Drawing.Point(615, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(65, 25);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "label1";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFecha.Location = new System.Drawing.Point(615, 38);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 25);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "label1";
            // 
            // tmHora
            // 
            this.tmHora.Enabled = true;
            this.tmHora.Tick += new System.EventHandler(this.tmHora_Tick);
            // 
            // lblInscriptos
            // 
            this.lblInscriptos.AutoSize = true;
            this.lblInscriptos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInscriptos.Location = new System.Drawing.Point(12, 38);
            this.lblInscriptos.Name = "lblInscriptos";
            this.lblInscriptos.Size = new System.Drawing.Size(148, 25);
            this.lblInscriptos.TabIndex = 8;
            this.lblInscriptos.Text = "Capacidad libre:";
            // 
            // lblNumLibres
            // 
            this.lblNumLibres.AutoSize = true;
            this.lblNumLibres.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumLibres.Location = new System.Drawing.Point(166, 39);
            this.lblNumLibres.Name = "lblNumLibres";
            this.lblNumLibres.Size = new System.Drawing.Size(0, 25);
            this.lblNumLibres.TabIndex = 9;
            // 
            // btnGuardarListadoXml
            // 
            this.btnGuardarListadoXml.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarListadoXml.Location = new System.Drawing.Point(230, 352);
            this.btnGuardarListadoXml.Name = "btnGuardarListadoXml";
            this.btnGuardarListadoXml.Size = new System.Drawing.Size(112, 65);
            this.btnGuardarListadoXml.TabIndex = 11;
            this.btnGuardarListadoXml.Text = "Guardar listado en XML";
            this.btnGuardarListadoXml.UseVisualStyleBackColor = true;
            this.btnGuardarListadoXml.Click += new System.EventHandler(this.btnGuardarListadoXml_Click);
            // 
            // lblLibres
            // 
            this.lblLibres.AutoSize = true;
            this.lblLibres.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLibres.Location = new System.Drawing.Point(166, 35);
            this.lblLibres.Name = "lblLibres";
            this.lblLibres.Size = new System.Drawing.Size(0, 25);
            this.lblLibres.TabIndex = 12;
            // 
            // lstSocios
            // 
            this.lstSocios.FormattingEnabled = true;
            this.lstSocios.ItemHeight = 15;
            this.lstSocios.Location = new System.Drawing.Point(12, 105);
            this.lstSocios.Name = "lstSocios";
            this.lstSocios.Size = new System.Drawing.Size(825, 229);
            this.lstSocios.TabIndex = 13;
            // 
            // lblTotalFacturado
            // 
            this.lblTotalFacturado.AutoSize = true;
            this.lblTotalFacturado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalFacturado.Location = new System.Drawing.Point(64, 63);
            this.lblTotalFacturado.Name = "lblTotalFacturado";
            this.lblTotalFacturado.Size = new System.Drawing.Size(63, 25);
            this.lblTotalFacturado.TabIndex = 14;
            this.lblTotalFacturado.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFiltro.Location = new System.Drawing.Point(615, 379);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.PlaceholderText = "Apellido/Nombre/Estatus/Pase";
            this.txtFiltro.Size = new System.Drawing.Size(222, 27);
            this.txtFiltro.TabIndex = 16;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(615, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Filtrar datos";
            // 
            // btnInformes
            // 
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInformes.Location = new System.Drawing.Point(491, 349);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(99, 66);
            this.btnInformes.TabIndex = 18;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Location = new System.Drawing.Point(143, 351);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(62, 66);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar socio";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FrmGym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(849, 456);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalFacturado);
            this.Controls.Add(this.lstSocios);
            this.Controls.Add(this.lblLibres);
            this.Controls.Add(this.btnGuardarListadoXml);
            this.Controls.Add(this.lblNumLibres);
            this.Controls.Add(this.lblInscriptos);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblCapacidadSocios);
            this.Controls.Add(this.btnGuardarListadoTxt);
            this.Controls.Add(this.btnSocio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmGym";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiGimnasio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGym_FormClosing);
            this.Load += new System.EventHandler(this.frmGym_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSocio;
        private System.Windows.Forms.Button btnGuardarListadoTxt;
        private System.Windows.Forms.Label lblCapacidadSocios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer tmHora;
        private System.Windows.Forms.Label lblInscriptos;
        private System.Windows.Forms.Label lblNumLibres;
        private System.Windows.Forms.Button btnGuardarListadoXml;
        private System.Windows.Forms.Label lblLibres;
        private System.Windows.Forms.ListBox lstSocios;
        private System.Windows.Forms.Label lblTotalFacturado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnEditar;
    }
}

