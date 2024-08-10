namespace Ecommerce.SharedLib.Auth
{
    public interface IUserProvider
    {
        Guid GetUserId();
    }
}
