using System;


namespace Reflection_Demo
{/// <summary>
/// Using Refkection to extract the information about the customerdetails
/// </summary>
    class CustomerDetails
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id
        {
            get; set;
        }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name
        {
            get; set;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerDetails"/> class.
        /// </summary>
        public CustomerDetails(int Id,string name)
        {
            this.Id = Id;
            this.name = name;
        }
        /// <summary>
        /// Prints the identifier.
        /// </summary>
        public void PrintId()
        {
            Console.WriteLine("ID is {0}" + this.Id);
        }
        /// <summary>
        /// Prints the name.
        /// </summary>
        public void PrintName()
        {
            Console.WriteLine("Name is {0}" + this.name);
        }
    }
}

