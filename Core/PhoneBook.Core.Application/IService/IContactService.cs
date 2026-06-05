using PhoneBook.Core.Application.Dto;

namespace PhoneBook.Core.Application.IService;

public interface IContactService
{
    Task<ContactDto> AddNewContactAsync(ContactDto contact);
    Task<ContactDto> UpdateContactAsync(int id, string? firstName, string? lastName, string? phoneNumber, string? tag);
    Task DeleteContactAsync(int id);

    Task<List<ContactDto>> GetAllContactsAsync();

    Task<List<ContactDto>> GetContactByTagAsync(string tag);
}
