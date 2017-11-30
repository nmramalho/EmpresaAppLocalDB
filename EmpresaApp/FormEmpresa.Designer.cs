namespace EmpresaApp
{
    partial class FormEmpresa
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
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFicheiroImportarCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNovoDepartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxDepartamentos = new System.Windows.Forms.GroupBox();
            this.buttonAtualizarDepartamento = new System.Windows.Forms.Button();
            this.ButtonApagar = new System.Windows.Forms.Button();
            this.buttonProcurarDepartamento = new System.Windows.Forms.Button();
            this.buttonCriarDepartamento = new System.Windows.Forms.Button();
            this.textBoxProcurarDepartamento = new System.Windows.Forms.TextBox();
            this.textBoxNomeDepartamento = new System.Windows.Forms.TextBox();
            this.textBoxIdDepartamento = new System.Windows.Forms.TextBox();
            this.labelProcurarDepartamento = new System.Windows.Forms.Label();
            this.dataGridViewDepartamentos = new System.Windows.Forms.DataGridView();
            this.labelNomeDepartamento = new System.Windows.Forms.Label();
            this.labelIdDepartamento = new System.Windows.Forms.Label();
            this.menuStripPrincipal.SuspendLayout();
            this.groupBoxDepartamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripPrincipal.Size = new System.Drawing.Size(500, 24);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStripPrincipal";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSair,
            this.MenuFicheiroImportarCSV});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // MenuItemSair
            // 
            this.MenuItemSair.Name = "MenuItemSair";
            this.MenuItemSair.Size = new System.Drawing.Size(187, 22);
            this.MenuItemSair.Text = "Sair";
            this.MenuItemSair.Click += new System.EventHandler(this.MenuItemSair_Click);
            // 
            // MenuFicheiroImportarCSV
            // 
            this.MenuFicheiroImportarCSV.Name = "MenuFicheiroImportarCSV";
            this.MenuFicheiroImportarCSV.Size = new System.Drawing.Size(187, 22);
            this.MenuFicheiroImportarCSV.Text = "Importar ficheiro CSV";
            this.MenuFicheiroImportarCSV.Click += new System.EventHandler(this.MenuFicheiroImportarCSV_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNovoDepartamento});
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // MenuNovoDepartamento
            // 
            this.MenuNovoDepartamento.Name = "MenuNovoDepartamento";
            this.MenuNovoDepartamento.Size = new System.Drawing.Size(103, 22);
            this.MenuNovoDepartamento.Text = "Novo";
            this.MenuNovoDepartamento.Click += new System.EventHandler(this.MenuNovoDepartamento_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // groupBoxDepartamentos
            // 
            this.groupBoxDepartamentos.Controls.Add(this.buttonAtualizarDepartamento);
            this.groupBoxDepartamentos.Controls.Add(this.ButtonApagar);
            this.groupBoxDepartamentos.Controls.Add(this.buttonProcurarDepartamento);
            this.groupBoxDepartamentos.Controls.Add(this.buttonCriarDepartamento);
            this.groupBoxDepartamentos.Controls.Add(this.textBoxProcurarDepartamento);
            this.groupBoxDepartamentos.Controls.Add(this.textBoxNomeDepartamento);
            this.groupBoxDepartamentos.Controls.Add(this.textBoxIdDepartamento);
            this.groupBoxDepartamentos.Controls.Add(this.labelProcurarDepartamento);
            this.groupBoxDepartamentos.Controls.Add(this.dataGridViewDepartamentos);
            this.groupBoxDepartamentos.Controls.Add(this.labelNomeDepartamento);
            this.groupBoxDepartamentos.Controls.Add(this.labelIdDepartamento);
            this.groupBoxDepartamentos.Location = new System.Drawing.Point(9, 35);
            this.groupBoxDepartamentos.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDepartamentos.Name = "groupBoxDepartamentos";
            this.groupBoxDepartamentos.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDepartamentos.Size = new System.Drawing.Size(484, 336);
            this.groupBoxDepartamentos.TabIndex = 1;
            this.groupBoxDepartamentos.TabStop = false;
            this.groupBoxDepartamentos.Text = "Departamentos";
            // 
            // buttonAtualizarDepartamento
            // 
            this.buttonAtualizarDepartamento.Location = new System.Drawing.Point(406, 50);
            this.buttonAtualizarDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAtualizarDepartamento.Name = "buttonAtualizarDepartamento";
            this.buttonAtualizarDepartamento.Size = new System.Drawing.Size(72, 29);
            this.buttonAtualizarDepartamento.TabIndex = 10;
            this.buttonAtualizarDepartamento.Text = "Atualizar";
            this.buttonAtualizarDepartamento.UseVisualStyleBackColor = true;
            this.buttonAtualizarDepartamento.Click += new System.EventHandler(this.buttonAtualizarDepartamento_Click);
            // 
            // ButtonApagar
            // 
            this.ButtonApagar.Location = new System.Drawing.Point(405, 84);
            this.ButtonApagar.Name = "ButtonApagar";
            this.ButtonApagar.Size = new System.Drawing.Size(72, 28);
            this.ButtonApagar.TabIndex = 9;
            this.ButtonApagar.Text = "Apagar";
            this.ButtonApagar.UseVisualStyleBackColor = true;
            this.ButtonApagar.Click += new System.EventHandler(this.ButtonApagar_Click);
            // 
            // buttonProcurarDepartamento
            // 
            this.buttonProcurarDepartamento.Location = new System.Drawing.Point(214, 99);
            this.buttonProcurarDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProcurarDepartamento.Name = "buttonProcurarDepartamento";
            this.buttonProcurarDepartamento.Size = new System.Drawing.Size(113, 21);
            this.buttonProcurarDepartamento.TabIndex = 8;
            this.buttonProcurarDepartamento.Text = "Procurar";
            this.buttonProcurarDepartamento.UseVisualStyleBackColor = true;
            this.buttonProcurarDepartamento.Click += new System.EventHandler(this.buttonProcurarDepartamento_Click);
            // 
            // buttonCriarDepartamento
            // 
            this.buttonCriarDepartamento.Location = new System.Drawing.Point(406, 17);
            this.buttonCriarDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCriarDepartamento.Name = "buttonCriarDepartamento";
            this.buttonCriarDepartamento.Size = new System.Drawing.Size(72, 29);
            this.buttonCriarDepartamento.TabIndex = 7;
            this.buttonCriarDepartamento.Text = "Criar";
            this.buttonCriarDepartamento.UseVisualStyleBackColor = true;
            this.buttonCriarDepartamento.Click += new System.EventHandler(this.ButtonCriarDepartamento_Click);
            // 
            // textBoxProcurarDepartamento
            // 
            this.textBoxProcurarDepartamento.Location = new System.Drawing.Point(57, 100);
            this.textBoxProcurarDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProcurarDepartamento.Name = "textBoxProcurarDepartamento";
            this.textBoxProcurarDepartamento.Size = new System.Drawing.Size(146, 20);
            this.textBoxProcurarDepartamento.TabIndex = 6;
            // 
            // textBoxNomeDepartamento
            // 
            this.textBoxNomeDepartamento.Location = new System.Drawing.Point(129, 47);
            this.textBoxNomeDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomeDepartamento.Name = "textBoxNomeDepartamento";
            this.textBoxNomeDepartamento.Size = new System.Drawing.Size(198, 20);
            this.textBoxNomeDepartamento.TabIndex = 5;
            // 
            // textBoxIdDepartamento
            // 
            this.textBoxIdDepartamento.Location = new System.Drawing.Point(96, 23);
            this.textBoxIdDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIdDepartamento.Name = "textBoxIdDepartamento";
            this.textBoxIdDepartamento.Size = new System.Drawing.Size(76, 20);
            this.textBoxIdDepartamento.TabIndex = 4;
            // 
            // labelProcurarDepartamento
            // 
            this.labelProcurarDepartamento.AutoSize = true;
            this.labelProcurarDepartamento.Location = new System.Drawing.Point(4, 100);
            this.labelProcurarDepartamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProcurarDepartamento.Name = "labelProcurarDepartamento";
            this.labelProcurarDepartamento.Size = new System.Drawing.Size(47, 13);
            this.labelProcurarDepartamento.TabIndex = 3;
            this.labelProcurarDepartamento.Text = "Procurar";
            // 
            // dataGridViewDepartamentos
            // 
            this.dataGridViewDepartamentos.AllowUserToAddRows = false;
            this.dataGridViewDepartamentos.AllowUserToDeleteRows = false;
            this.dataGridViewDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartamentos.Location = new System.Drawing.Point(4, 127);
            this.dataGridViewDepartamentos.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDepartamentos.Name = "dataGridViewDepartamentos";
            this.dataGridViewDepartamentos.ReadOnly = true;
            this.dataGridViewDepartamentos.RowTemplate.Height = 24;
            this.dataGridViewDepartamentos.Size = new System.Drawing.Size(473, 205);
            this.dataGridViewDepartamentos.TabIndex = 2;
            this.dataGridViewDepartamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartamentos_CellClick);
            // 
            // labelNomeDepartamento
            // 
            this.labelNomeDepartamento.AutoSize = true;
            this.labelNomeDepartamento.Location = new System.Drawing.Point(4, 47);
            this.labelNomeDepartamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomeDepartamento.Name = "labelNomeDepartamento";
            this.labelNomeDepartamento.Size = new System.Drawing.Size(120, 13);
            this.labelNomeDepartamento.TabIndex = 1;
            this.labelNomeDepartamento.Text = "Nome do Departamento";
            // 
            // labelIdDepartamento
            // 
            this.labelIdDepartamento.AutoSize = true;
            this.labelIdDepartamento.Location = new System.Drawing.Point(4, 23);
            this.labelIdDepartamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdDepartamento.Name = "labelIdDepartamento";
            this.labelIdDepartamento.Size = new System.Drawing.Size(88, 13);
            this.labelIdDepartamento.TabIndex = 0;
            this.labelIdDepartamento.Text = "ID (exemplo: RH)";
            // 
            // FormEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 376);
            this.Controls.Add(this.groupBoxDepartamentos);
            this.Controls.Add(this.menuStripPrincipal);
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEmpresa";
            this.Text = "Empresa";
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.groupBoxDepartamentos.ResumeLayout(false);
            this.groupBoxDepartamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;

        private System.Windows.Forms.GroupBox groupBoxDepartamentos;

        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSair;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuNovoDepartamento;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        
        private System.Windows.Forms.Button buttonProcurarDepartamento;
        private System.Windows.Forms.Button buttonCriarDepartamento;
        private System.Windows.Forms.Button ButtonApagar;
        private System.Windows.Forms.Button buttonAtualizarDepartamento;

        private System.Windows.Forms.TextBox textBoxProcurarDepartamento;
        private System.Windows.Forms.TextBox textBoxNomeDepartamento;
        private System.Windows.Forms.TextBox textBoxIdDepartamento;

        private System.Windows.Forms.Label labelProcurarDepartamento;
        private System.Windows.Forms.Label labelNomeDepartamento;
        private System.Windows.Forms.Label labelIdDepartamento;

        private System.Windows.Forms.DataGridView dataGridViewDepartamentos;
        private System.Windows.Forms.ToolStripMenuItem MenuFicheiroImportarCSV;
    }
}

