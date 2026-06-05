using Microsoft.AspNetCore.Mvc;
using PhoneBook.Core.Application.Dto;
using PhoneBook.Core.Application.IService;

namespace PhoneBook.Server.Controllers;

public class PhoneBookController(IContactService contactService) : ControllerBase
{
    private readonly IContactService _contactService = contactService;

  
    [HttpPost]
    [Route("PhoneBook/AddNewContact")]
    public async Task<ContactDto> AddNewContact([FromBody] ContactDto request)
    {
       return await _contactService.AddNewContactAsync(request);
    }
}
