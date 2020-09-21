using System;

namespace Test.Core.Model
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserId { get; set; }
    }
}
