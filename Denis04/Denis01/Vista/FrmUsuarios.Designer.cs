
namespace Denis01.Vista
{
    partial class FrmUsuarios
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.BtbUpdate = new System.Windows.Forms.Button();
            this.DtgUsuarios = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(62, 504);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(127, 41);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(184, 38);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(229, 20);
            this.TxtId.TabIndex = 7;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(184, 93);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(229, 20);
            this.TxtNombre.TabIndex = 8;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(184, 137);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(229, 20);
            this.TxtApellido.TabIndex = 9;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(184, 187);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(229, 20);
            this.TxtEdad.TabIndex = 10;
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(184, 234);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(229, 20);
            this.TxtPass.TabIndex = 11;
            // 
            // BtbUpdate
            // 
            this.BtbUpdate.Location = new System.Drawing.Point(394, 504);
            this.BtbUpdate.Name = "BtbUpdate";
            this.BtbUpdate.Size = new System.Drawing.Size(95, 41);
            this.BtbUpdate.TabIndex = 12;
            this.BtbUpdate.Text = "Actualizar";
            this.BtbUpdate.UseVisualStyleBackColor = true;
            this.BtbUpdate.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DtgUsuarios
            // 
            this.DtgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DtgUsuarios.Location = new System.Drawing.Point(12, 299);
            this.DtgUsuarios.Name = "DtgUsuarios";
            this.DtgUsuarios.Size = new System.Drawing.Size(512, 150);
            this.DtgUsuarios.TabIndex = 13;
            this.DtgUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgUsuarios_CellClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Id";
            this.Column5.Name = "Column5";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Usuarios";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Edad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Password";
            this.Column4.Name = "Column4";
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 579);
            this.Controls.Add(this.DtgUsuarios);
            this.Controls.Add(this.BtbUpdate);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnAgregar);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Button BtbUpdate;
        private System.Windows.Forms.DataGridView DtgUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}