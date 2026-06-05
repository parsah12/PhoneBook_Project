using Microsoft.AspNetCore.Mvc;
using PhoneBook.Core.Application.Dto;
using PhoneBook.Core.Application.IService;

namespace PhoneBook.Server.Controllers;

public class PhoneBookController(IContactService contactService) : ControllerBase
{
    private readonly IContactService _contactService = contactService;


    [HttpPost]
    [Route("PhoneBook/AddNewContact")]
    public async Task<ContactDto> AddNewContact([FromBody] ContactDto request) => await _contactService.AddNewContactAsync(request);


    [HttpGet]
    [Route("PhoneBook/GetAllContact")]
    public async Task<List<ContactDto>> GetAllContact() => await _contactService.GetAllContactsAsync();

    [HttpDelete]
    [Route("PhoneBook/DeleteContactById")]
    public async Task DeleteId(int id) => await _contactService.DeleteContactAsync(id);

    [HttpPost]
    [Route("PhoneBook/UpdateContact")]
    public async Task<ContactDto> UpdateContactAsync([FromBody] ContactDto request)
        => await _contactService.UpdateContactAsync(request.Id, request.FirstName, request.LastName, request.PhoneNumber, request.Tag);

    [HttpGet]
    [Route("PhoneBook/GetContactByTag")]
    public async Task<List<ContactDto>> GetContactByTag(string tag) => await _contactService.GetContactByTagAsync(tag);
}
