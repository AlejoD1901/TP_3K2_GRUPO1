
namespace TP_3K2_GRUPO1.Interfaz_Usuario
{
    partial class Clientes
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btAgregarC = new System.Windows.Forms.Button();
            this.btModificarC = new System.Windows.Forms.Button();
            this.btEliminarCliente = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(44, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(116, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(270, 52);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(96, 31);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // btAgregarC
            // 
            this.btAgregarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarC.Location = new System.Drawing.Point(498, 130);
            this.btAgregarC.Name = "btAgregarC";
            this.btAgregarC.Size = new System.Drawing.Size(154, 25);
            this.btAgregarC.TabIndex = 3;
            this.btAgregarC.Text = "Agregar cliente";
            this.btAgregarC.UseVisualStyleBackColor = true;
            this.btAgregarC.Click += new System.EventHandler(this.button1_Click);
            // 
            // btModificarC
            // 
            this.btModificarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificarC.Location = new System.Drawing.Point(498, 161);
            this.btModificarC.Name = "btModificarC";
            this.btModificarC.Size = new System.Drawing.Size(154, 25);
            this.btModificarC.TabIndex = 4;
            this.btModificarC.Text = "Modificar cliente";
            this.btModificarC.UseVisualStyleBackColor = true;
            this.btModificarC.Click += new System.EventHandler(this.button2_Click);
            // 
            // btEliminarCliente
            // 
            this.btEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminarCliente.Location = new System.Drawing.Point(498, 192);
            this.btEliminarCliente.Name = "btEliminarCliente";
            this.btEliminarCliente.Size = new System.Drawing.Size(154, 29);
            this.btEliminarCliente.TabIndex = 5;
            this.btEliminarCliente.Text = "Eliminar cliente";
            this.btEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(576, 295);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(96, 25);
            this.btSalir.TabIndex = 6;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_cliente,
            this.Nombre,
            this.Direccion,
            this.Razon_social});
            this.dataGridView1.Location = new System.Drawing.Point(2, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(478, 128);
            this.dataGridView1.TabIndex = 7;
            // 
            // ID_cliente
            // 
            this.ID_cliente.HeaderText = "ID_cliente";
            this.ID_cliente.MinimumWidth = 6;
            this.ID_cliente.Name = "ID_cliente";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre ";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Codigo Postal";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 130;
            // 
            // Razon_social
            // 
            this.Razon_social.HeaderText = "Razon social";
            this.Razon_social.MinimumWidth = 6;
            this.Razon_social.Name = "Razon_social";
            this.Razon_social.Width = 125;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 332);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btEliminarCliente);
            this.Controls.Add(this.btModificarC);
            this.Controls.Add(this.btAgregarC);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btAgregarC;
        private System.Windows.Forms.Button btModificarC;
        private System.Windows.Forms.Button btEliminarCliente;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razon_social;
    }
}