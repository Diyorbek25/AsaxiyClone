using AsaxiyClone.Domain.Entities.Enums;

namespace AsaxiyClone.Application.DataTransferObjects;

public record UserForCreationDto(
    string fullName,
    string userName,
    string phoneNumber,
    string email,
    Gender gender,
    string address,
    short postalCode);