using PhoneBook.Core.Application.Dto;

namespace PhoneBook.Core.Application.IService;

public interface IContactService
{
    Task<ContactDto> AddNewContactAsync(ContactDto contact);

    Task<ContactDto> UpdateContactAsync(int id,ContactDto contact);

    Task DeleteContactAsync(int id);

    Task<List<ContactDto>> GetAllContactsAsync();

    Task<List<ContactDto>> GetContactByTagAsync(string tag);
}
