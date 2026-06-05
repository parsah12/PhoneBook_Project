using PhoneBook.Core.Application.Dto;
using PhoneBook.Core.Domain.Entities;

namespace PhoneBook.Core.Application.Service.Helper;

public static class Extension
{
    public static ContactDto ToDto(this ContactEntity entity)
    {
        return new ContactDto
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            PhoneNumber = entity.PhoneNumber,
            Tag = entity.Tag
        };
    }

    public static ContactEntity ToEntity(this ContactDto dto)
    {
        return new ContactEntity
        {
            Id = dto.Id,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            PhoneNumber = dto.PhoneNumber,
            Tag = dto.Tag
        };
           
    }
}
