using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        //Atributo
        private Genero Genero { get; set;}
        private string Titulo { get; set;}
        private string Descricao { get; set;}
        private int Ano { get; set;}
        private bool Excluido {get; set;}
        public bool Favorito { get; set;}

        //Metodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
            this.Favorito = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido + Environment.NewLine;
            retorno += "Favorito: " + this.Favorito;

            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public bool retornaFavorito()
        {
            return this.Favorito;
        }

        public void Exclui() {
            this.Excluido = true;
        }


        public void Favoritar() {
           this.Favorito = !this.Favorito;

           if (this.Favorito == true) {
               Console.WriteLine("Adicionado aos Favoritos");
           } else {
               Console.WriteLine("Removido dos Favoritos");
           }
        }

    }
}