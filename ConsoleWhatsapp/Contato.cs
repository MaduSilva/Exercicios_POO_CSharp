namespace ConsoleWhatsapp {
    public class Contato {


        //get set ajuda a eliminar o warning de não utilizar determinada variável 
        //utiliza a propriedade PascalCase - ambas iniciais são maiusculas 
        //PascalCase se utiliza com get;set; e metodos
        //CamelCase se utiliza quando estiver declarando uma varíavel no objeto 
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Contato () {

        }

        public Contato (string _nome, string _telefone) {

            this.Nome = _nome;
            this.Telefone = _telefone;

        }
    }
}