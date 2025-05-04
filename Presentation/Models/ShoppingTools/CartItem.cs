namespace Presentation.Models.ShoppingTools;
public class CartItem
{
    public int ReservationId { get; set; }
    public string RoomDescription { get; set; }
    public decimal Price { get; set; }
    public int Subtotal { get; set; }
}