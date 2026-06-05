using PhoneBook.Core.Application.Dto;

namespace PhoneBook.Core.Application.IService;

public interface IContactService
{
    Task<ContactDto> AddNewContact(string firstName, string lastName, string phoneNum, string tag);
    Task<ContactDto> UpdateContact(string firstName, string lastName, string phoneNum, string tag);
    Task<ContactDto> DeleteContact(string firstName, string lastName, string phoneNum, string tag);
    Task<ContactDto> GetAllContact();
    Task<ContactDto> GetContactBuyTag(string tag);
}
