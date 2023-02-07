namespace SchoolAPI.Repositories
{
    public class FakePersonRepository
    {
        public int PersonId { get; set; } // do we need it in here?
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? EnrollmentDate { get; set;  }
        public string Discriminator { get; set;  }
    }
}
