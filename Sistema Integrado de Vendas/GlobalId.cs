
namespace Sistema_Integrado_de_Vendas
{
    class GlobalId
    {
        public static int UserId{ get;set;}
        public static int ProdutoId { get; set; }

        public void SetGlobalUserId(int Id)
        {
            UserId = Id;
        }

        public void SetGlobalProdutoId(int Id)
        {
            UserId = Id;
        }
    }
}
