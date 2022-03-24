using System;

namespace StudentAdminPortal.API.DataModels
{
    //DATA
    public class Address
    {
        public Guid Id { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }

        //Nav Property

        public Guid StudentId { get; set; }
    }
}