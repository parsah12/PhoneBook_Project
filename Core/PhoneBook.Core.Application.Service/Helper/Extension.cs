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
        return new ContactEntity(
            dto.FirstName ?? string.Empty,
            dto.LastName ?? string.Empty,
            dto.PhoneNumber ?? string.Empty,
            dto.Tag ?? string.Empty)
        {
            Id = dto.Id 
        };
    }
}
