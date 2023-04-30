using PXLPRO2023Shoppers24.Models;

namespace PXLPRO2023Shoppers24.Data.Cart
{
    public interface IShoppingCartBase<T> where T : class
    {
        T AddItemToCart(T entity);
    }
}
