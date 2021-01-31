namespace OPG.Models
{
    public interface IOrderRepository
    {
        void ViewOrder ();
        void CancelOrder ();
        void UpdateOrder ();
        void CalculatePrice ( int Price );
    }
}
