namespace Gestão_Estudantes_Kauã
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eSTUDANTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirEstudanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEstudantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarRemoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cURSOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manhãToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tardeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eSTUDANTEToolStripMenuItem,
            this.cURSOToolStripMenuItem,
            this.nOTASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eSTUDANTEToolStripMenuItem
            // 
            this.eSTUDANTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirEstudanteToolStripMenuItem,
            this.listarEstudantesToolStripMenuItem,
            this.estatísticasToolStripMenuItem,
            this.editarRemoverToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.eSTUDANTEToolStripMenuItem.Name = "eSTUDANTEToolStripMenuItem";
            this.eSTUDANTEToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.eSTUDANTEToolStripMenuItem.Text = "ESTUDANTE";
            // 
            // inserirEstudanteToolStripMenuItem
            // 
            this.inserirEstudanteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inserirEstudanteToolStripMenuItem.Image")));
            this.inserirEstudanteToolStripMenuItem.Name = "inserirEstudanteToolStripMenuItem";
            this.inserirEstudanteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inserirEstudanteToolStripMenuItem.Text = "Inserir Estudante";
            this.inserirEstudanteToolStripMenuItem.Click += new System.EventHandler(this.inserirEstudanteToolStripMenuItem_Click);
            // 
            // listarEstudantesToolStripMenuItem
            // 
            this.listarEstudantesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarEstudantesToolStripMenuItem.Image")));
            this.listarEstudantesToolStripMenuItem.Name = "listarEstudantesToolStripMenuItem";
            this.listarEstudantesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listarEstudantesToolStripMenuItem.Text = "Listar Estudantes";
            // 
            // estatísticasToolStripMenuItem
            // 
            this.estatísticasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("estatísticasToolStripMenuItem.Image")));
            this.estatísticasToolStripMenuItem.Name = "estatísticasToolStripMenuItem";
            this.estatísticasToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.estatísticasToolStripMenuItem.Text = "Estatísticas";
            // 
            // editarRemoverToolStripMenuItem
            // 
            this.editarRemoverToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarRemoverToolStripMenuItem.Image")));
            this.editarRemoverToolStripMenuItem.Name = "editarRemoverToolStripMenuItem";
            this.editarRemoverToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editarRemoverToolStripMenuItem.Text = "Editar/Remover";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripMenuItem.Image")));
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // cURSOToolStripMenuItem
            // 
            this.cURSOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manhãToolStripMenuItem,
            this.tardeToolStripMenuItem,
            this.noiteToolStripMenuItem});
            this.cURSOToolStripMenuItem.Name = "cURSOToolStripMenuItem";
            this.cURSOToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cURSOToolStripMenuItem.Text = "CURSO";
            // 
            // manhãToolStripMenuItem
            // 
            this.manhãToolStripMenuItem.Name = "manhãToolStripMenuItem";
            this.manhãToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.manhãToolStripMenuItem.Text = "Manhã";
            // 
            // tardeToolStripMenuItem
            // 
            this.tardeToolStripMenuItem.Name = "tardeToolStripMenuItem";
            this.tardeToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.tardeToolStripMenuItem.Text = "Tarde";
            // 
            // noiteToolStripMenuItem
            // 
            this.noiteToolStripMenuItem.Name = "noiteToolStripMenuItem";
            this.noiteToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.noiteToolStripMenuItem.Text = "Noite";
            // 
            // nOTASToolStripMenuItem
            // 
            this.nOTASToolStripMenuItem.Name = "nOTASToolStripMenuItem";
            this.nOTASToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.nOTASToolStripMenuItem.Text = "NOTAS";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(73)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(715, 455);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "SGA - Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eSTUDANTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirEstudanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEstudantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarRemoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cURSOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manhãToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tardeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOTASToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}