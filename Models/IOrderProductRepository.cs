namespace OPG.Models
{
    public interface IOrderProductRepository
    {
        void AddProduct ( Product p );
        void RemoveProduct ( int ProductId );
        void CalculatePrice ( int Price );
        public Product FindById ( int ProductId );

    }
}
