﻿namespace App1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itálicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Salvar = new System.Windows.Forms.ToolStripButton();
            this.btn_Novo = new System.Windows.Forms.ToolStripButton();
            this.btn_Abrir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Copiar = new System.Windows.Forms.ToolStripButton();
            this.btn_Colar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Negrito = new System.Windows.Forms.ToolStripButton();
            this.btn_Italico = new System.Windows.Forms.ToolStripButton();
            this.btn_Sublinhado = new System.Windows.Forms.ToolStripButton();
            this.btn_Fonte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Esquerda = new System.Windows.Forms.ToolStripButton();
            this.btn_Direita = new System.Windows.Forms.ToolStripButton();
            this.tbn_Justificar = new System.Windows.Forms.ToolStripButton();
            this.tbn_Centralizar = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 405);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.desfazerToolStripMenuItem,
            this.refazerToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.refazerToolStripMenuItem.Text = "Refazer";
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.itálicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem,
            this.alinhamentoToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.negritoToolStripMenuItem.Text = "Negrito";
            this.negritoToolStripMenuItem.Click += new System.EventHandler(this.negritoToolStripMenuItem_Click);
            // 
            // itálicoToolStripMenuItem
            // 
            this.itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            this.itálicoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.itálicoToolStripMenuItem.Text = "Itálico";
            this.itálicoToolStripMenuItem.Click += new System.EventHandler(this.itálicoToolStripMenuItem_Click);
            // 
            // sublinhadoToolStripMenuItem
            // 
            this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
            this.sublinhadoToolStripMenuItem.Click += new System.EventHandler(this.sublinhadoToolStripMenuItem_Click);
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centralizarToolStripMenuItem,
            this.esquerdaToolStripMenuItem,
            this.direitaToolStripMenuItem,
            this.justificarToolStripMenuItem});
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // centralizarToolStripMenuItem
            // 
            this.centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            this.centralizarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.centralizarToolStripMenuItem.Text = "Centralizar";
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.direitaToolStripMenuItem.Text = "Direita";
            // 
            // justificarToolStripMenuItem
            // 
            this.justificarToolStripMenuItem.Name = "justificarToolStripMenuItem";
            this.justificarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.justificarToolStripMenuItem.Text = "Justificar";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Salvar,
            this.btn_Novo,
            this.btn_Abrir,
            this.toolStripSeparator1,
            this.btn_Copiar,
            this.btn_Colar,
            this.toolStripSeparator2,
            this.btn_Negrito,
            this.btn_Italico,
            this.btn_Sublinhado,
            this.btn_Fonte,
            this.toolStripSeparator3,
            this.btn_Esquerda,
            this.btn_Direita,
            this.tbn_Justificar,
            this.tbn_Centralizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Salvar.Image = global::App1.Properties.Resources.save;
            this.btn_Salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(23, 22);
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Novo.Image = global::App1.Properties.Resources.new_document;
            this.btn_Novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(23, 22);
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Abrir.Image = global::App1.Properties.Resources.open;
            this.btn_Abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(23, 22);
            this.btn_Abrir.Text = "Abrir";
            this.btn_Abrir.Click += new System.EventHandler(this.btn_Abrir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Copiar
            // 
            this.btn_Copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Copiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Copiar.Image")));
            this.btn_Copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Copiar.Name = "btn_Copiar";
            this.btn_Copiar.Size = new System.Drawing.Size(23, 22);
            this.btn_Copiar.Text = "Copiar";
            this.btn_Copiar.Click += new System.EventHandler(this.btn_Copiar_Click);
            // 
            // btn_Colar
            // 
            this.btn_Colar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Colar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Colar.Image")));
            this.btn_Colar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Colar.Name = "btn_Colar";
            this.btn_Colar.Size = new System.Drawing.Size(23, 22);
            this.btn_Colar.Text = "Colar";
            this.btn_Colar.Click += new System.EventHandler(this.btn_Colar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Negrito
            // 
            this.btn_Negrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Negrito.Image = global::App1.Properties.Resources.negrito;
            this.btn_Negrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Negrito.Name = "btn_Negrito";
            this.btn_Negrito.Size = new System.Drawing.Size(23, 22);
            this.btn_Negrito.Text = "Negrito";
            this.btn_Negrito.Click += new System.EventHandler(this.btn_Negrito_Click);
            // 
            // btn_Italico
            // 
            this.btn_Italico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Italico.Image = global::App1.Properties.Resources.italico;
            this.btn_Italico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Italico.Name = "btn_Italico";
            this.btn_Italico.Size = new System.Drawing.Size(23, 22);
            this.btn_Italico.Text = "Itálico";
            this.btn_Italico.Click += new System.EventHandler(this.btn_Italico_Click);
            // 
            // btn_Sublinhado
            // 
            this.btn_Sublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Sublinhado.Image = global::App1.Properties.Resources.texto_sublinhado;
            this.btn_Sublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Sublinhado.Name = "btn_Sublinhado";
            this.btn_Sublinhado.Size = new System.Drawing.Size(23, 22);
            this.btn_Sublinhado.Text = "Sublinhado";
            this.btn_Sublinhado.Click += new System.EventHandler(this.btn_Sublinhado_Click);
            // 
            // btn_Fonte
            // 
            this.btn_Fonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Fonte.Image = global::App1.Properties.Resources.font;
            this.btn_Fonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Fonte.Name = "btn_Fonte";
            this.btn_Fonte.Size = new System.Drawing.Size(23, 22);
            this.btn_Fonte.Text = "Fonte";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Esquerda
            // 
            this.btn_Esquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Esquerda.Image = global::App1.Properties.Resources.alinhar_a_esquerda;
            this.btn_Esquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Esquerda.Name = "btn_Esquerda";
            this.btn_Esquerda.Size = new System.Drawing.Size(23, 22);
            this.btn_Esquerda.Text = "Esquerda";
            this.btn_Esquerda.Click += new System.EventHandler(this.btn_Esquerda_Click);
            // 
            // btn_Direita
            // 
            this.btn_Direita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Direita.Image = global::App1.Properties.Resources.alinhar_a_direita;
            this.btn_Direita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Direita.Name = "btn_Direita";
            this.btn_Direita.Size = new System.Drawing.Size(23, 22);
            this.btn_Direita.Text = "Direita";
            this.btn_Direita.Click += new System.EventHandler(this.btn_Direita_Click);
            // 
            // tbn_Justificar
            // 
            this.tbn_Justificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbn_Justificar.Image = global::App1.Properties.Resources.justificar;
            this.tbn_Justificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbn_Justificar.Name = "tbn_Justificar";
            this.tbn_Justificar.Size = new System.Drawing.Size(23, 22);
            this.tbn_Justificar.Text = "Justificar";
            this.tbn_Justificar.Click += new System.EventHandler(this.tbn_Justificar_Click);
            // 
            // tbn_Centralizar
            // 
            this.tbn_Centralizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbn_Centralizar.Image = global::App1.Properties.Resources.simbolo_de_linhas_de_texto_de_paragrafo_centralizado_para_interface;
            this.tbn_Centralizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbn_Centralizar.Name = "tbn_Centralizar";
            this.tbn_Centralizar.Size = new System.Drawing.Size(23, 22);
            this.tbn_Centralizar.Text = "Centralizar";
            this.tbn_Centralizar.Click += new System.EventHandler(this.tbn_Centralizar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Textos - CFB Cursos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itálicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sublinhadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centralizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem justificarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btn_Novo;
        private System.Windows.Forms.ToolStripButton btn_Abrir;
        private System.Windows.Forms.ToolStripButton btn_Salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Copiar;
        private System.Windows.Forms.ToolStripButton btn_Colar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Negrito;
        private System.Windows.Forms.ToolStripButton btn_Italico;
        private System.Windows.Forms.ToolStripButton btn_Sublinhado;
        private System.Windows.Forms.ToolStripButton btn_Fonte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_Esquerda;
        private System.Windows.Forms.ToolStripButton btn_Direita;
        private System.Windows.Forms.ToolStripButton tbn_Justificar;
        private System.Windows.Forms.ToolStripButton tbn_Centralizar;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

