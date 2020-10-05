namespace Ifood
{
    public class Restaurante
    {
        public string NomeRestaurante { get; set; }

        public string EnderecoRestaurante { get; set; }

         public Restaurante(string _nome, string _endereco){
            this.NomeRestaurante = _nome;
            this.EnderecoRestaurante = _endereco;
        }

        public string MostrarDados(){
            return $"Selecionado: {NomeRestaurante} \nLocalizado em: {EnderecoRestaurante}\n";
        }


    }
}