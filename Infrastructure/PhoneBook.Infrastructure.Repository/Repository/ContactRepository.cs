using PhoneBook.Core.Domain.Entities;
using PhoneBook.Core.Domain.IRepositories;

namespace PhoneBook.Infrastructure.Repository.Repository;

public class ContactRepository : IContactRepository
{
    private readonly List<ContactEntity> _contacts = [];
    public Task AddAsync(ContactEntity contact)
    {
        _contacts.Add(contact);

        return Task.CompletedTask;
    }

    public Task DeleteAsync(int id)
    {
        var contact = _contacts
            .FirstOrDefault(x => x.Id == id);

        if (contact is not null)
        {
            _contacts.Remove(contact);
        }

        return Task.CompletedTask;
    }

    public Task<ContactEntity?> GetByIdAsync(int id)
    {
        var contact = _contacts
            .FirstOrDefault(x => x.Id == id);

        return Task.FromResult(contact);
    }

    public Task<List<ContactEntity>> GetByTagAsync(string tag)
    {
        var contacts = _contacts
           .Where(x => x.Tag == tag)
           .ToList();

        return Task.FromResult(contacts);
    }

    public Task UpdateAsync(ContactEntity contact)
    {
        var currentContact = _contacts
           .FirstOrDefault(x => x.Id == contact.Id);

        if (currentContact is null)
            return Task.CompletedTask;

        _contacts.Remove(currentContact);

        _contacts.Add(contact);

        return Task.CompletedTask;
    }
}
