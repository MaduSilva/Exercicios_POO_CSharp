namespace ConsoleUber
{
    public class Usuario
    {
        //resumida
        public string Nome { get; set; }

        //completa
        private int idade; //variavel privada chamada idade, pra manipular por fora da classe cria-se uma publica com o mesmo nome só que maiuscula
        public int Idade
        {
            get { return idade; }
            set {
                if(idade > 0){
                    idade = value;
            } // verifica a idade
        }

    }

        public string Foto { get; set; }

        private string login = "email@email.com";

        private string senha = "bolinhadequeijo2";

        public string LocalizacaoAtual { get; set; }

        public string TokenLogin { get; set; }

        public bool Login(string login, string senha){

            if (this.login == login && this.senha == senha){ // se for diferente de vazio e diferente de null é falso
                TokenLogin = "2h3g2yu1h7s81271236h78k864r567ghm86kj5b6";
                return true;
            }
                return false;

        }

        public void Logout(){
            TokenLogin = "";
        }




}        
}
