using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aula_27_28_29_30 {

    //Alt Shift F indenta

    public class Produto {

        //Criação de Variaveis

        public int Codigo { get; set; }

        public string Nome { get; set; }

        public float Preco { get; set; }

        private const string PATH = "Database/produto.csv";

        // Criação de Pasta (Caso não exista) e Arquivo CSV 

        public Produto () {

            string DataBase = PATH.Split ('/') [0];
            if (!Directory.Exists (DataBase)) {
                Directory.CreateDirectory (DataBase);
            }

            //Path no caso é o arquivo
            //Verifica se o arquivo NÃO existe, se não existir ele cria
            if (!File.Exists (PATH)) {
                //Close
                File.Create (PATH).Close ();
            }
        }

        //Método que cadastra novo produto e o "indenta" conforme estabelecido no método "Preparar Linha"

        public void Cadastrar (Produto prod) {
            var linha = new string[] { PrepararLinha (prod) };
            File.AppendAllLines (PATH, linha);
        }

        public List<Produto> Ler () {

            //Criando lista de produtos    

            List<Produto> produtos = new List<Produto> ();

            //read all lines le todos os dados e transforma em um array de string
            string[] linhas = File.ReadAllLines (PATH);

            foreach (var linha in linhas) {

                //separando os dados

                string[] dado = linha.Split (";");

                Produto p = new Produto ();
                p.Codigo = Int32.Parse (Separar (dado[0]));
                p.Nome = Separar (dado[1]);
                p.Preco = float.Parse (Separar (dado[2]));

                //adiciona os produtos 

                produtos.Add (p);

            }
            //organiza
            produtos = produtos.OrderBy (y => y.Nome).ToList ();
            return produtos;
        }

        //remove linha lista
        public void Remover (string _termo) {
            //lista que serve como backup para as linhas csv

            List<string> linhas = new List<string> ();

            using (StreamReader arquivo = new StreamReader (PATH)) {

                string linha;
                while ((linha = arquivo.ReadLine ()) != null) {

                    linhas.Add (linha);
                }
            }

            linhas.RemoveAll (l => l.Contains (_termo));

            //Reescrever csv do zero
            using (StreamWriter output = new StreamWriter (PATH)) {

                foreach (string ln in linhas) {
                    output.Write (ln + "\n");
                }
            }

        }

        public List<Produto> Filtrar (string _nome) {
            return Ler ().FindAll (x => x.Nome == _nome);

        }

        private string Separar (string _coluna) {
            return _coluna.Split ("=") [1];
        }

        //1;Celular;600
        //identação
        public string PrepararLinha (Produto p) {
            return $"Código = {p.Codigo}; Nome = {p.Nome}; Preço = {p.Preco}";
        }
    }

}