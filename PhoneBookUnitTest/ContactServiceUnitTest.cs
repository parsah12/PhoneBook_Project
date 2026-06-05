using FluentAssertions;
using Moq;
using PhoneBook.Core.Application.Dto;
using PhoneBook.Core.Application.Service.Service;
using PhoneBook.Core.Domain.Entities;
using PhoneBook.Core.Domain.IRepositories;
using PhoneBook.Core.Application.Service.Helper;

public class ContactServiceTests
{
    private readonly Mock<IContactRepository> _contactRepository;
    private readonly ContactService _contactService;

    public ContactServiceTests()
    {
        _contactRepository = new Mock<IContactRepository>();

        _contactService = new ContactService(
            _contactRepository.Object);
    }

    [Fact]
    public async Task GetContactByTagAsync_Should_Return_Contacts()
    {
        // Arrange

        var contacts = new List<ContactEntity>
        {
            new ContactEntity(
                "Parsa",
                "Hedayati",
                "09120000000",
                "Friend")
            {
                Id = 1
            },

            new ContactEntity(
                "Ali",
                "Ahmadi",
                "09350000000",
                "Friend")
            {
                Id = 2
            }
        };

        _contactRepository
            .Setup(x => x.GetByTagAsync("Friend"))
            .ReturnsAsync(contacts);

        // Act

        var result = await _contactService
            .GetContactByTagAsync("Friend");

        // Assert

        result.Should().HaveCount(2);

        result[0].FirstName.Should().Be("Parsa");

        result[1].FirstName.Should().Be("Ali");
    }


    [Fact]
    public async Task AddNewContactAsync_Should_Add_Contact()
    {
        // Arrange
        var contactDto = new ContactDto
        {
            FirstName = "Parsa",
            LastName = "Hedayati",
            PhoneNumber = "09120000000",
            Tag = "Friend"
        };

        var expectedEntity = contactDto.ToEntity();
        expectedEntity.Id = 1;

        
        _contactRepository
            .Setup(x => x.AddAsync(It.IsAny<ContactEntity>()))
            .Returns(Task.CompletedTask); 

        _contactRepository
            .Setup(x => x.GetByIdAsync(It.IsAny<int>()))
            .ReturnsAsync(expectedEntity);

        // Act
        var result = await _contactService.AddNewContactAsync(contactDto);

        // Assert
        result.Should().NotBeNull();
        result.FirstName.Should().Be("Parsa");
        result.Tag.Should().Be("Friend");
    }

    [Fact]
    public async Task DeleteContactAsync_Should_Call_Delete()
    {
        // Arrange

        var contact = new ContactEntity(
            "Parsa",
            "Hedayati",
            "09120000000",
            "Friend")
        {
            Id = 1
        };

        _contactRepository
            .Setup(x => x.GetByIdAsync(1))
            .ReturnsAsync(contact);

        // Act

        await _contactService.DeleteContactAsync(1);

        // Assert

        _contactRepository.Verify(
            x => x.DeleteAsync(1),
            Times.Once);
    }

    [Fact]
    public async Task UpdateContactAsync_Should_Update_Contact()
    {
        // Arrange

        var contact = new ContactEntity(
            "Parsa",
            "Hedayati",
            "09120000000",
            "Friend")
        {
            Id = 1
        };

        _contactRepository
            .Setup(x => x.GetByIdAsync(1))
            .ReturnsAsync(contact);

        // Act

        var result = await _contactService.UpdateContactAsync(
            1,
            "Parsa-New",
            null,
            null,
            null);

        // Assert

        result.FirstName.Should().Be("Parsa-New");
    }
}