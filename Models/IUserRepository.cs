
namespace OPG.Models
{
    public interface IUserRepository
    {
        void Login ();
        void SearchProduct ( int product_id );
        void Rate ();

    }
}
