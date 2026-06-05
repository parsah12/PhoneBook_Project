namespace PhoneBook.Core.Application.Dto;

public class ContactDto
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Tag { get; set; }
}
