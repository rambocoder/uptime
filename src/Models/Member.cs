using System;

namespace uptime.Models
{
    public class Member
    {
        public string Name { get; set; }
        public Guid Id { get; set; }

        public Member()
        {
            
        }
        public Member(string name) : this()
        {
            this.Name = name;
        }

        public Member(string name, Guid id) : this(name)
        {
            this.Id = id;
        }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}