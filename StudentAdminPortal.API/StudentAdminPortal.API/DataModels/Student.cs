using System;

namespace StudentAdminPortal.API.DataModels
{
    // Data
    public class Student
    {
        public Guid Id { get; set; }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string email { get; set; }
        public long Mobile { get; set; }
        public string ProfileImageUrl { get; set; }
        public Guid GenderId { get; set; }

        //Nav PRoperties

        public Gender Gender { get; set; }
        public Address Address { get; set; }





    }
}
