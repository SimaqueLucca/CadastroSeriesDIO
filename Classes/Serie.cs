using System;

namespace CadastroSeriesDIO
{
    public class Serie : EntidadeBase
    {
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";

            retorno += $"Genero: {Genero} + {Environment.NewLine}";
            retorno += $"Titulo: {Titulo} + {Environment.NewLine}";
            retorno += $"Descrição: {Descricao} + {Environment.NewLine}";
            retorno += $"Ano: {Ano} + {Environment.NewLine}";
            retorno += $"Excluído: {Excluido} + {Environment.NewLine}";

            return retorno;
        }

        public string retornaTitulo()
        {
            return Titulo;
        }

        public int retornaId()
        {
            return Id;
        }
        public bool retornaExcluido()
        {
            return Excluido;
        }
        public void Excluir()
        {
            Excluido = true;
        }

    }
}