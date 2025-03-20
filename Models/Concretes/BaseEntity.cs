using Models.Enums;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Abstracts
{
    public abstract class BaseEntity : IEntity<string>
    {
        protected BaseEntity()
        {
            CreatedDate = DateTime.Now;
            EntryDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            SelectedStatus = DataStasus.Active;
            MasterId = Guid.NewGuid().ToString();
            UpdatedComputerName=System.Environment.MachineName;

        }
        public int Id { get; set; }
        public string MasterId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DataStasus SelectedStatus { get; set; }
        public string UpdatedComputerName { get; set; }
    }
}
