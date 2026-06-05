using PhoneBook.Core.Application.Dto;
using PhoneBook.Core.Application.IService;

namespace PhoneBook.Core.Application.Service.Service;

public class ContactService : IContactService
{
    public Task<ContactDto> AddNewContact(string firstName, string lastName, string phoneNum, string tag)
    {
        throw new NotImplementedException();
    }

    public Task<ContactDto> DeleteContact(string firstName, string lastName, string phoneNum, string tag)
    {
        throw new NotImplementedException();
    }

    public Task<ContactDto> GetAllContact()
    {
        throw new NotImplementedException();
    }

    public Task<ContactDto> GetContactBuyTag(string tag)
    {
        throw new NotImplementedException();
    }

    public Task<ContactDto> UpdateContact(string firstName, string lastName, string phoneNum, string tag)
    {
        throw new NotImplementedException();
    }
}
