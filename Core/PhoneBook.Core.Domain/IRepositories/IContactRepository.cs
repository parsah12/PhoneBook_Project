using PhoneBook.Core.Domain.Entities;

namespace PhoneBook.Core.Domain.IRepositories;

public interface IContactRepository
{
    Task AddAsync(ContactEnity contact);

    Task UpdateAsync(ContactEnity contact);

    Task DeleteAsync(int id);

    Task<ContactEnity?> GetByIdAsync(int id);

    Task<List<ContactEnity>> GetByTagAsync(string tag);
}
