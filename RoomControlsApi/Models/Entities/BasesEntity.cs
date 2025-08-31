using Models.Enums;

namespace RoomControlsApi.Models.Entities
{
    public class BasesEntity
    {
        public BasesEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStasus.Inserted;
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStasus Status { get; set; }
    }
}
