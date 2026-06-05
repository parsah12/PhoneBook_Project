using PhoneBook.Core.Application.Dto;
using PhoneBook.Core.Application.IService;
using PhoneBook.Core.Application.Service.Helper;
using PhoneBook.Core.Domain.IRepositories;

namespace PhoneBook.Core.Application.Service.Service;

public class ContactService(IContactRepository contactRepository) : IContactService
{
    private readonly IContactRepository _contactRepository = contactRepository;
    public async Task<ContactDto> AddNewContactAsync(ContactDto contact)
    {

        try
        {
            var entity = contact.ToEntity();
            await _contactRepository.AddAsync(entity);
            return entity.ToDto();
        }
        catch (Exception)
        {

            throw;
        }


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
