namespace Controle_de_Estoque
{
    partial class frm_telainicial
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoAtualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_menu = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1.SuspendLayout();
            this.ms_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 26);
            // 
            // vendasToolStripMenuItem1
            // 
            this.vendasToolStripMenuItem1.ForeColor = System.Drawing.Color.Red;
            this.vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            this.vendasToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.vendasToolStripMenuItem1.Text = "Vendas";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVendaToolStripMenuItem,
            this.cadastrarClienteToolStripMenuItem});
            this.vendasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.vendasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // registrarVendaToolStripMenuItem
            // 
            this.registrarVendaToolStripMenuItem.Name = "registrarVendaToolStripMenuItem";
            this.registrarVendaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.registrarVendaToolStripMenuItem.Text = "Registrar Venda";
            this.registrarVendaToolStripMenuItem.Click += new System.EventHandler(this.registrarVendaToolStripMenuItem_Click);
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar Cliente";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCompraToolStripMenuItem,
            this.cadastrarFornecedorToolStripMenuItem});
            this.comprasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // registrarCompraToolStripMenuItem
            // 
            this.registrarCompraToolStripMenuItem.Name = "registrarCompraToolStripMenuItem";
            this.registrarCompraToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.registrarCompraToolStripMenuItem.Text = "Registrar Compra";
            // 
            // cadastrarFornecedorToolStripMenuItem
            // 
            this.cadastrarFornecedorToolStripMenuItem.Name = "cadastrarFornecedorToolStripMenuItem";
            this.cadastrarFornecedorToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cadastrarFornecedorToolStripMenuItem.Text = "Cadastrar Fornecedor";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volumeDeComprasToolStripMenuItem,
            this.volumeDeVendasToolStripMenuItem,
            this.saldoAtualToolStripMenuItem});
            this.relatoriosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            this.relatoriosToolStripMenuItem.Click += new System.EventHandler(this.relatoriosToolStripMenuItem_Click);
            // 
            // volumeDeComprasToolStripMenuItem
            // 
            this.volumeDeComprasToolStripMenuItem.Name = "volumeDeComprasToolStripMenuItem";
            this.volumeDeComprasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.volumeDeComprasToolStripMenuItem.Text = "Volume de Compras";
            // 
            // volumeDeVendasToolStripMenuItem
            // 
            this.volumeDeVendasToolStripMenuItem.Name = "volumeDeVendasToolStripMenuItem";
            this.volumeDeVendasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.volumeDeVendasToolStripMenuItem.Text = "Volume de Vendas";
            // 
            // saldoAtualToolStripMenuItem
            // 
            this.saldoAtualToolStripMenuItem.Name = "saldoAtualToolStripMenuItem";
            this.saldoAtualToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saldoAtualToolStripMenuItem.Text = "Saldo Atual";
            // 
            // administraçãoToolStripMenuItem
            // 
            this.administraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuarioToolStripMenuItem});
            this.administraçãoToolStripMenuItem.Enabled = false;
            this.administraçãoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.administraçãoToolStripMenuItem.Name = "administraçãoToolStripMenuItem";
            this.administraçãoToolStripMenuItem.Size = new System.Drawing.Size(101, 23);
            this.administraçãoToolStripMenuItem.Text = "Administração";
            // 
            // cadastrarUsuarioToolStripMenuItem
            // 
            this.cadastrarUsuarioToolStripMenuItem.Name = "cadastrarUsuarioToolStripMenuItem";
            this.cadastrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.cadastrarUsuarioToolStripMenuItem.Text = "Cadastrar Usuario";
            // 
            // ms_menu
            // 
            this.ms_menu.AutoSize = false;
            this.ms_menu.BackColor = System.Drawing.Color.DarkGray;
            this.ms_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ms_menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ms_menu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_menu.GripMargin = new System.Windows.Forms.Padding(5, 0, 0, 2);
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.administraçãoToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.relatoriosToolStripMenuItem});
            this.ms_menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ms_menu.Location = new System.Drawing.Point(0, 413);
            this.ms_menu.Margin = new System.Windows.Forms.Padding(5, 5, 50, 50);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Padding = new System.Windows.Forms.Padding(15, 2, 0, 2);
            this.ms_menu.Size = new System.Drawing.Size(906, 27);
            this.ms_menu.TabIndex = 1;
            this.ms_menu.Text = "Opçoes";
            this.ms_menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ms_menu_ItemClicked);
            // 
            // frm_telainicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(906, 440);
            this.Controls.Add(this.ms_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_menu;
            this.Name = "frm_telainicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela inicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicial_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ms_menu.ResumeLayout(false);
            this.ms_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldoAtualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.MenuStrip ms_menu;
    }
}