namespace PhoneBook.Core.Domain.Entities;

public class ContactEntity
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Tag { get; set; }


    public ContactEntity(
      string firstName,
      string lastName,
      string phoneNumber,
      string tag)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Tag = tag;
    }

    public void Update(
        string? firstName,
        string? lastName,
        string? phoneNumber,
        string? tag)
    {
        if (!string.IsNullOrWhiteSpace(firstName))
            FirstName = firstName;

        if (!string.IsNullOrWhiteSpace(lastName))
            LastName = lastName;

        if (!string.IsNullOrWhiteSpace(phoneNumber))
            PhoneNumber = phoneNumber;

        if (!string.IsNullOrWhiteSpace(tag))
            Tag = tag;
    }
}


