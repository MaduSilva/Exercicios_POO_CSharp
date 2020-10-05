using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MVCConsole.Models {

    public class Produto {

        //Criação de Variaveis

        public int Codigo { get; set; }

        public string Nome { get; set; }

        public float Preco { get; set; }

        private const string PATH = "Database/produto.csv";

        public Produto () {

            string DataBase = PATH.Split ('/') [0];
            if (!Directory.Exists (DataBase)) {
                Directory.CreateDirectory (DataBase);
            }

            if (!File.Exists (PATH)) {
              
                File.Create (PATH).Close ();
            }
        }

        public List<Produto> Ler () {

            List<Produto> produtos = new List<Produto> ();

            string[] linhas = File.ReadAllLines (PATH);

            foreach (var linha in linhas) {

                string[] dado = linha.Split (";");

                Produto p = new Produto ();
                p.Codigo = Int32.Parse (Separar (dado[0]));
                p.Nome = Separar (dado[1]);
                p.Preco = float.Parse (Separar (dado[2]));

                produtos.Add (p);

            }

            produtos = produtos.OrderBy (y => y.Nome).ToList ();
            return produtos;
        }

        private string Separar (string _coluna) {
            return _coluna.Split ("=") [1];
        }

    }

}