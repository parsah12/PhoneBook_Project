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
    }

    public async Task DeleteContactAsync(int id)
    {
        try
        {
            var contact = await _contactRepository.GetByIdAsync(id);

            if (contact is null)
            {
                throw new Exception("Contact not found");
            }

            await _contactRepository.DeleteAsync(id);
        }
        catch (Exception)
        {

            throw;
        }

    }

    public async Task<List<ContactDto>> GetAllContactsAsync()
    {

        try
        {
            var contacts = await _contactRepository.GetAllAsync();

            return contacts
                .Select(x => x.ToDto())
                .ToList();
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<List<ContactDto>> GetContactByTagAsync(string tag)
    {
        try
        {
            var contacts = await _contactRepository.GetByTagAsync(tag);

            return contacts
                .Select(x => x.ToDto())
                .ToList();
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<ContactDto> UpdateContactAsync(int id, string? firstName, string? lastName, string? phoneNumber, string? tag)
    {
        var contact = await _contactRepository.GetByIdAsync(id);

        if (contact is null)
            throw new Exception("Contact not found");

        contact.Update(
            firstName,
            lastName,
            phoneNumber,
            tag);

        return contact.ToDto();
    }
}
