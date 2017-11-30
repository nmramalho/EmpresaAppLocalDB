namespace EmpresaApp
{
    partial class FormImportarCSV
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
            this.labelLocalFicheiro = new System.Windows.Forms.Label();
            this.textBoxLocalizacaoCSV = new System.Windows.Forms.TextBox();
            this.ButtonProcurarrCSV = new System.Windows.Forms.Button();
            this.buttonAbirCSV = new System.Windows.Forms.Button();
            this.textBoxConteudoCSV = new System.Windows.Forms.TextBox();
            this.comboBoxTabela = new System.Windows.Forms.ComboBox();
            this.buttonImportarCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLocalFicheiro
            // 
            this.labelLocalFicheiro.AutoSize = true;
            this.labelLocalFicheiro.Location = new System.Drawing.Point(13, 22);
            this.labelLocalFicheiro.Name = "labelLocalFicheiro";
            this.labelLocalFicheiro.Size = new System.Drawing.Size(143, 13);
            this.labelLocalFicheiro.TabIndex = 0;
            this.labelLocalFicheiro.Text = "Localização do ficheiro CSV:";
            // 
            // textBoxLocalizacaoCSV
            // 
            this.textBoxLocalizacaoCSV.Location = new System.Drawing.Point(162, 19);
            this.textBoxLocalizacaoCSV.Name = "textBoxLocalizacaoCSV";
            this.textBoxLocalizacaoCSV.Size = new System.Drawing.Size(275, 20);
            this.textBoxLocalizacaoCSV.TabIndex = 1;
            // 
            // ButtonProcurarrCSV
            // 
            this.ButtonProcurarrCSV.Location = new System.Drawing.Point(457, 19);
            this.ButtonProcurarrCSV.Name = "ButtonProcurarrCSV";
            this.ButtonProcurarrCSV.Size = new System.Drawing.Size(75, 23);
            this.ButtonProcurarrCSV.TabIndex = 2;
            this.ButtonProcurarrCSV.Text = "Procurar";
            this.ButtonProcurarrCSV.UseVisualStyleBackColor = true;
            this.ButtonProcurarrCSV.Click += new System.EventHandler(this.ButtonProcurarrCSV_Click);
            // 
            // buttonAbirCSV
            // 
            this.buttonAbirCSV.Location = new System.Drawing.Point(457, 49);
            this.buttonAbirCSV.Name = "buttonAbirCSV";
            this.buttonAbirCSV.Size = new System.Drawing.Size(75, 23);
            this.buttonAbirCSV.TabIndex = 3;
            this.buttonAbirCSV.Text = "Abrir";
            this.buttonAbirCSV.UseVisualStyleBackColor = true;
            this.buttonAbirCSV.Click += new System.EventHandler(this.buttonAbirCSV_Click);
            // 
            // textBoxConteudoCSV
            // 
            this.textBoxConteudoCSV.AcceptsReturn = true;
            this.textBoxConteudoCSV.AcceptsTab = true;
            this.textBoxConteudoCSV.Location = new System.Drawing.Point(16, 120);
            this.textBoxConteudoCSV.Multiline = true;
            this.textBoxConteudoCSV.Name = "textBoxConteudoCSV";
            this.textBoxConteudoCSV.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxConteudoCSV.Size = new System.Drawing.Size(531, 202);
            this.textBoxConteudoCSV.TabIndex = 4;
            this.textBoxConteudoCSV.WordWrap = false;
            // 
            // comboBoxTabela
            // 
            this.comboBoxTabela.FormattingEnabled = true;
            this.comboBoxTabela.Items.AddRange(new object[] {
            " - Selecionar tabela destino -",
            "Departamento",
            "Funcionario"});
            this.comboBoxTabela.Location = new System.Drawing.Point(16, 337);
            this.comboBoxTabela.Name = "comboBoxTabela";
            this.comboBoxTabela.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTabela.TabIndex = 5;
            // 
            // buttonImportarCSV
            // 
            this.buttonImportarCSV.Location = new System.Drawing.Point(471, 334);
            this.buttonImportarCSV.Name = "buttonImportarCSV";
            this.buttonImportarCSV.Size = new System.Drawing.Size(75, 23);
            this.buttonImportarCSV.TabIndex = 6;
            this.buttonImportarCSV.Text = "Importar";
            this.buttonImportarCSV.UseVisualStyleBackColor = true;
            this.buttonImportarCSV.Click += new System.EventHandler(this.buttonImportarCSV_Click);
            // 
            // FormImportarCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 381);
            this.Controls.Add(this.buttonImportarCSV);
            this.Controls.Add(this.comboBoxTabela);
            this.Controls.Add(this.textBoxConteudoCSV);
            this.Controls.Add(this.buttonAbirCSV);
            this.Controls.Add(this.ButtonProcurarrCSV);
            this.Controls.Add(this.textBoxLocalizacaoCSV);
            this.Controls.Add(this.labelLocalFicheiro);
            this.Name = "FormImportarCSV";
            this.Text = "Importar ficheiro CSV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLocalFicheiro;
        private System.Windows.Forms.TextBox textBoxLocalizacaoCSV;
        private System.Windows.Forms.Button ButtonProcurarrCSV;
        private System.Windows.Forms.Button buttonAbirCSV;
        private System.Windows.Forms.TextBox textBoxConteudoCSV;
        private System.Windows.Forms.ComboBox comboBoxTabela;
        private System.Windows.Forms.Button buttonImportarCSV;
    }
}