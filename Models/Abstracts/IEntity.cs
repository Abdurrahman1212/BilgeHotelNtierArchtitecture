using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IEntity<T>
    {
        public int Id { get; set; }
        public T MasterId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DataStasus SelectedStatus { get; set; }
    }
}
