namespace ConsoleWhatsapp {
    public interface IAgenda {
        void Listar ();

        void Cadastrar (Contato _contato);

        void Excluir (Contato _contato);
    }
}