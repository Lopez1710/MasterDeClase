
namespace Denis01.Vista
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFORMACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeUsuaiosYPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioYPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coneccionesBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.listaDeUsuaiosYPassToolStripMenuItem,
            this.coneccionesBDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNFORMACIONToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // iNFORMACIONToolStripMenuItem
            // 
            this.iNFORMACIONToolStripMenuItem.Name = "iNFORMACIONToolStripMenuItem";
            this.iNFORMACIONToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.iNFORMACIONToolStripMenuItem.Text = "INFORMACION";
            this.iNFORMACIONToolStripMenuItem.Click += new System.EventHandler(this.iNFORMACIONToolStripMenuItem_Click);
            // 
            // listaDeUsuaiosYPassToolStripMenuItem
            // 
            this.listaDeUsuaiosYPassToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioYPassToolStripMenuItem});
            this.listaDeUsuaiosYPassToolStripMenuItem.Name = "listaDeUsuaiosYPassToolStripMenuItem";
            this.listaDeUsuaiosYPassToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.listaDeUsuaiosYPassToolStripMenuItem.Text = "Lista de Usuaios";
            // 
            // usuarioYPassToolStripMenuItem
            // 
            this.usuarioYPassToolStripMenuItem.Name = "usuarioYPassToolStripMenuItem";
            this.usuarioYPassToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.usuarioYPassToolStripMenuItem.Text = "USUARIO Y PASS";
            this.usuarioYPassToolStripMenuItem.Click += new System.EventHandler(this.usuarioYPassToolStripMenuItem_Click);
            // 
            // coneccionesBDToolStripMenuItem
            // 
            this.coneccionesBDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDToolStripMenuItem});
            this.coneccionesBDToolStripMenuItem.Name = "coneccionesBDToolStripMenuItem";
            this.coneccionesBDToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.coneccionesBDToolStripMenuItem.Text = "Conecciones BD";
            // 
            // cRUDToolStripMenuItem
            // 
            this.cRUDToolStripMenuItem.Name = "cRUDToolStripMenuItem";
            this.cRUDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cRUDToolStripMenuItem.Text = "CRUD";
            this.cRUDToolStripMenuItem.Click += new System.EventHandler(this.cRUDToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 280);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFORMACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeUsuaiosYPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioYPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coneccionesBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDToolStripMenuItem;
    }
}