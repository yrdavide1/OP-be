using OP_beModel.Entities;

namespace OP_be.DTOs
{
    public class UserDTO
    {
        public long PersonId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? FullName { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Email { get; set; }
        public int PhoneNumber { get; set; }
        public string? Gender { get; set; }
        public bool? IsUser { get; set; }

        public UserDTO() { }

        public UserDTO(User original)
        {
            PersonId = original.PersonId;
            Firstname = original.Firstname;
            Lastname = original.Lastname;
            FullName = original.FullName;
            Gender = original.Gender;
            PhoneNumber = original.PhoneNumber;
            DateOfBirth = original.DateOfBirth;
            Address = original.Address;
            City = original.City;
            Email = original.Email;
            IsUser = original.IsUser;
        }
    }
}
