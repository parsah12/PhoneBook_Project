using PhoneBook.Core.Application.Dto;
using PhoneBook.Core.Application.IService;

namespace PhoneBook.Core.Application.Service.Service;

public class ContactService : IContactService
{
    public Task<ContactDto> AddNewContactAsync(ContactDto contact)
    {
        throw new NotImplementedException();
    }

    public Task DeleteContactAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ContactDto>> GetAllContactsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<ContactDto>> GetContactByTagAsync(string tag)
    {
        throw new NotImplementedException();
    }

    public Task<ContactDto> UpdateContactAsync(int id, ContactDto contact)
    {
        throw new NotImplementedException();
    }
}
