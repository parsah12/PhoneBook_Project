using PhoneBook.Core.Application.Dto;
using PhoneBook.Core.Domain.Entities;

namespace PhoneBook.Core.Application.Service.Helper;

public static class Extension
{
    public static ContactDto ToDto(this ContactEntity entity)
    {
        return new ContactDto
        {
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            PhoneNumber = entity.PhoneNumber,
            Tag = entity.Tag
        };
    }
}
