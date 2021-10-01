using System;

namespace DIO.series
{
    public class Serie : ClasseBase
    {
        
        private Genero Genero { get; set; }

        private string Titulo { get; set; }
        
        private string Descricao { get; set; }
        
        private int Ano { get; set; }
        
        private bool Excluido = false;

        public Serie(int id, string titulo, Genero genero, string descricao, int ano)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Genero = genero;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;

        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }
    
        public int RetornaId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }


        public bool RetornaExcluido()
        {
            return this.Excluido;
        }
    }


}
