namespace RoomControlsApi.Models.Entities
{
    public class RoomsControl
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; } // "Empty", "Reserved", "Cleaning"
    }
}
