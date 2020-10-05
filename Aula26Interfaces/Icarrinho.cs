namespace Aula26Interface
{
    public interface Icarrinho
    {
         //CRUD - Create Read Update Delete, Criar Ler Alterar e Excluir//

        //mapeamento de metodos
         void Listar();

         void Cadastrar(Produto produto);

         void Alterar(int _codigo, Produto _produtoalterado);

         void Deletar(Produto produto);
    }
}