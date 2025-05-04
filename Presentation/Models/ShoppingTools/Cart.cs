using Newtonsoft.Json;
using Presentation.Controllers;
using Presentation.Models.ShoppingTools;

[Serializable]
public class Cart
{
    public Cart()
    {
        _myCart = new Dictionary<int, CartItem>();
    }

    [JsonProperty("_myCart")]
    readonly Dictionary<int, CartItem> _myCart;

    [JsonProperty("GetCartItems")]
    public List<CartItem> GetCartItems
    {
        get
        {
            return _myCart.Values.ToList();
        }

    }
    public void AddToCart(CartItem item)
    {
        if (_myCart.ContainsKey(item.ReservationId))
        {
            _myCart[item.ReservationId].Price++;
            return;
        }
        _myCart.Add(item.ReservationId, item);
    }

    public void Increase(int id)
    {
        _myCart[id].Subtotal++;
    }

    public void Decrease(int id)
    {
        _myCart[id].Subtotal--;
        if (_myCart[id].Subtotal == 0) _myCart.Remove(id); //Dictionary'deki remove metodu, verdiginiz anahtardaki veriyi siler...
    }

    public void RemoveFromCart(int id)
    {
        _myCart.Remove(id);
    }

    [JsonProperty("TotalPrice")]
    public decimal TotalPrice
    {
        get
        {
            return _myCart.Values.Sum(x => x.Subtotal);
        }
    }

}