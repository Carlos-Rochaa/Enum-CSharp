using System;


namespace Enumerações_e_composição.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        public Department()
        { 

        }

        public Department(string name) 
        {
            Name = name; 
        }
    }
}
