using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace App1
{
    public partial class Form1 : Form
    {
        public StringReader leitura = null; //Será a leitura do nosso arquivo de texto
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void Salvar()
        {
            try
            {
                //Aqui ele chama a  janela de salvar arquivo e verifica se foi dado um "sim"
                if(this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Criando o arquivo
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                    //"Escrevedor de arquivo" --> precisa para escrever no arquivo criado
                    StreamWriter cfb_streamWriter = new StreamWriter(arquivo);

                    cfb_streamWriter.Flush();

                    //Onde vai começar no arquivo? no início!
                    cfb_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);

                    //Eu estou escrevendo no aruqivo  conteúdo da minha richTextBox
                    cfb_streamWriter.Write(this.richTextBox1.Text);

                    cfb_streamWriter.Flush();
                    cfb_streamWriter.Close();
                }
            }catch(Exception e)
            {
                MessageBox.Show("Erro na criação do arquivo: " + e.Message, "Erro ao gravar", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Abrir()
        {
            this.openFileDialog1.Multiselect = false; //Somente um arquivo pode ser selecionado
            this.openFileDialog1.Title = "Abrir arquivo";
            openFileDialog1.InitialDirectory = @"C:\\Users\\Cliente\\Desktop\\Projetos C#\\PrimeiroAplicativo";
            openFileDialog1.Filter = "(*.TXT)|*.TXT " + "Todos Arquivos(*.*)|*.*";

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader cfb_StreamReader = new StreamReader(arquivo);

                    cfb_StreamReader.BaseStream.Seek(0, SeekOrigin.Begin);

                    this.richTextBox1.Clear();

                    //Enquanto tiver linha, ele vai ler e colocar no nosso arquivo
                    string linha = cfb_StreamReader.ReadLine();

                    while(linha != null)
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = cfb_StreamReader.ReadLine();
                    }

                    cfb_StreamReader.Close();
                }
                catch(Exception e)
                {
                    MessageBox.Show("Erro de leitura" + e.Message, "Erro ao ler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void Copiar()
        {
            //Se existe uma seleção, copia
            if(richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void Colar()
        {
            richTextBox1.Paste();
        }

        private void btn_Colar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void btn_Copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void Negrito()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool negr = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;

            negr = richTextBox1.Font.Bold;

            if(negr == false)
            {
                richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte,FontStyle.Bold); //nome da fonte, tamanho e estilo
            }
            else
            {
                richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular); //nome da fonte, tamanho e estilo

            }

        }

        private void Italico()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool ita = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;

            ita = richTextBox1.Font.Italic;

            if (ita == false)
            {
                richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic); //nome da fonte, tamanho e estilo
            }
            else
            {
                richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic); //nome da fonte, tamanho e estilo

            }

        }
        //Lembre de melhorar o código permitindo que sejam usadas duas fontes simultaneamente
        private void Sublinhado()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool sub = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;

            sub = richTextBox1.Font.Underline;

            if (sub == false)
            {
                //A opção comentada mostra como aplicar mais de uma fonte de uma única vez
                //richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline | FontStly.Bold); 
                richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline); //nome da fonte, tamanho e estilo
            }
            else
            {
                richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline); //nome da fonte, tamanho e estilo

            }

        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void btn_Negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void btn_Italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void btn_Sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void AlinharEsquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void AlinharDireita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void AlinharCentro()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void Justificar()
        {
            richTextBox1.SelectionAlignment = Ve
        }

        private void btn_Esquerda_Click(object sender, EventArgs e)
        {
            AlinharEsquerda();
        }

        private void btn_Direita_Click(object sender, EventArgs e)
        {
            AlinharDireita();
        }

        private void tbn_Justificar_Click(object sender, EventArgs e)
        {

        }

        private void tbn_Centralizar_Click(object sender, EventArgs e)
        {
            AlinharCentro();
        }

        private void Imprimir()
        {
            //PrintDialog abre a janela de impressão
            //Print document é o que efetivamente realiza a impressão

            printDialog1.Document = printDocument1;
            string texto = this.richTextBox1.Text;

            leitura = new StringReader(texto);

            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                //Se ele quer imprimir
                this.printDocument1.Print();
            }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Quantidade de linha por página
            float linhas_pagina = 0;
            float posY = 0;
            int contador = 0;

            float margem_Esquerda = e.MarginBounds.Left - 50;
            float margem_Superior = e.MarginBounds.Top - 50;

            if(margem_Esquerda <5)
            {
                margem_Esquerda = 20;
            }

            if(margem_Superior < 5)
            {
                margem_Superior = 20;
            }

            string linha = null;
            Font fonte = this.richTextBox1.Font;

            SolidBrush pincel = new SolidBrush(Color.Black); //Padrão do pincel

            linhas_pagina = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);

            linha = leitura.ReadLine();

            while(contador < linhas_pagina)
            {
                //Definir o eixo y
                //Escrever a string
                //Incrementar o contador
                posY = margem_Superior + (contador * fonte.GetHeight(e.Graphics));
                e.Graphics.DrawString(linha, fonte, pincel, margem_Esquerda, posY, new StringFormat());
                contador += 1;
                linha = leitura.ReadLine(); //Lendo a próxima linha
            }

            if(linha != null)
            {
                //Se existirem mais linhas, imprima outra página
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }

            pincel.Dispose();
        }
    }
}
