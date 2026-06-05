using PhoneBook.Core.Domain.Entities;

namespace PhoneBook.Core.Domain.IRepositories;

public interface IContactRepository
{
    Task AddAsync(ContactEntity contact);

    Task DeleteAsync(int id);
    Task<List<ContactEntity>> GetAllAsync();
    Task<ContactEntity?> GetByIdAsync(int id);

    Task<List<ContactEntity>> GetByTagAsync(string tag);
}
