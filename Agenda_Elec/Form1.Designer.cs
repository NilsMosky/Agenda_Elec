using System;

namespace Agenda_Elec
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
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.Apellidos = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tbFechNacimiento = new System.Windows.Forms.TextBox();
            this.FechaNacimiento = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.Label();
            this.tbNumMovil = new System.Windows.Forms.TextBox();
            this.NumMovil = new System.Windows.Forms.Label();
            this.tbNumTelefono = new System.Windows.Forms.TextBox();
            this.NumTelefono = new System.Windows.Forms.Label();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.EstadoCivil = new System.Windows.Forms.Label();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.Genero = new System.Windows.Forms.Label();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(166, 82);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(134, 23);
            this.tbNombres.TabIndex = 3;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(166, 116);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(134, 23);
            this.tbApellidos.TabIndex = 5;
            // 
            // Apellidos
            // 
            this.Apellidos.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellidos.Location = new System.Drawing.Point(66, 120);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(81, 19);
            this.Apellidos.TabIndex = 4;
            this.Apellidos.Text = "Apellido/s:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(174, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(255, 22);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(336, 22);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tbFechNacimiento
            // 
            this.tbFechNacimiento.Location = new System.Drawing.Point(166, 153);
            this.tbFechNacimiento.Name = "tbFechNacimiento";
            this.tbFechNacimiento.Size = new System.Drawing.Size(134, 23);
            this.tbFechNacimiento.TabIndex = 11;
            this.tbFechNacimiento.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaNacimiento.Location = new System.Drawing.Point(21, 156);
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Size = new System.Drawing.Size(135, 20);
            this.FechaNacimiento.TabIndex = 10;
            this.FechaNacimiento.Text = "Fech. Nacimiento: ";
            this.FechaNacimiento.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(166, 182);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(134, 23);
            this.tbDireccion.TabIndex = 13;
            // 
            // Direccion
            // 
            this.Direccion.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion.Location = new System.Drawing.Point(66, 184);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(81, 20);
            this.Direccion.TabIndex = 12;
            this.Direccion.Text = "Dirección:";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(166, 216);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(134, 23);
            this.tbCorreo.TabIndex = 15;
            this.tbCorreo.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Correo
            // 
            this.Correo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.Location = new System.Drawing.Point(81, 213);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(66, 26);
            this.Correo.TabIndex = 14;
            this.Correo.Text = "Correo:";
            this.Correo.Click += new System.EventHandler(this.Correo_Click);
            // 
            // tbNumMovil
            // 
            this.tbNumMovil.Location = new System.Drawing.Point(166, 245);
            this.tbNumMovil.Name = "tbNumMovil";
            this.tbNumMovil.Size = new System.Drawing.Size(134, 23);
            this.tbNumMovil.TabIndex = 17;
            this.tbNumMovil.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // NumMovil
            // 
            this.NumMovil.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumMovil.Location = new System.Drawing.Point(57, 248);
            this.NumMovil.Name = "NumMovil";
            this.NumMovil.Size = new System.Drawing.Size(90, 20);
            this.NumMovil.TabIndex = 16;
            this.NumMovil.Text = "Num. Móvil:";
            this.NumMovil.Click += new System.EventHandler(this.NumeroMovil_Click);
            // 
            // tbNumTelefono
            // 
            this.tbNumTelefono.Location = new System.Drawing.Point(166, 281);
            this.tbNumTelefono.Name = "tbNumTelefono";
            this.tbNumTelefono.Size = new System.Drawing.Size(134, 23);
            this.tbNumTelefono.TabIndex = 19;
            // 
            // NumTelefono
            // 
            this.NumTelefono.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumTelefono.Location = new System.Drawing.Point(39, 286);
            this.NumTelefono.Name = "NumTelefono";
            this.NumTelefono.Size = new System.Drawing.Size(108, 18);
            this.NumTelefono.TabIndex = 18;
            this.NumTelefono.Text = "Num. Telefono:";
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(411, 161);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(100, 23);
            this.tbEstado.TabIndex = 21;
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoCivil.Location = new System.Drawing.Point(314, 165);
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.Size = new System.Drawing.Size(88, 19);
            this.EstadoCivil.TabIndex = 20;
            this.EstadoCivil.Text = "Estado Civil:";
            // 
            // tbGenero
            // 
            this.tbGenero.Location = new System.Drawing.Point(411, 132);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(100, 23);
            this.tbGenero.TabIndex = 23;
            // 
            // Genero
            // 
            this.Genero.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genero.Location = new System.Drawing.Point(335, 138);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(51, 17);
            this.Genero.TabIndex = 22;
            this.Genero.Text = "Genero:";
            // 
            // dgvContactos
            // 
            this.dgvContactos.AllowUserToAddRows = false;
            this.dgvContactos.AllowUserToDeleteRows = false;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContactos.Location = new System.Drawing.Point(327, 190);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.ReadOnly = true;
            this.dgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactos.Size = new System.Drawing.Size(725, 407);
            this.dgvContactos.TabIndex = 24;
            this.dgvContactos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactos_CellContentClick);
            this.dgvContactos.DoubleClick += new System.EventHandler(this.dgvContactos_DoubleClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre/s:";
            this.label1.Click += new System.EventHandler(this.Nombres_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(93, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(12, 22);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 26;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1064, 729);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.tbGenero);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.EstadoCivil);
            this.Controls.Add(this.tbNumTelefono);
            this.Controls.Add(this.NumTelefono);
            this.Controls.Add(this.tbNumMovil);
            this.Controls.Add(this.NumMovil);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.tbFechNacimiento);
            this.Controls.Add(this.FechaNacimiento);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombres);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Nombre/s:";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NumeroMovil_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label Apellidos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox tbFechNacimiento;
        private System.Windows.Forms.Label FechaNacimiento;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label Correo;
        private System.Windows.Forms.TextBox tbNumMovil;
        private System.Windows.Forms.Label NumMovil;
        private System.Windows.Forms.TextBox tbNumTelefono;
        private System.Windows.Forms.Label NumTelefono;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.Label EstadoCivil;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.Label Genero;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnNuevo;
    }
}

