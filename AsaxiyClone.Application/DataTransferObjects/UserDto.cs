using AsaxiyClone.Domain.Entities.Enums;

namespace AsaxiyClone.Application.DataTransferObjects;

public record UserDto(
    Guid id,
    string fullName,
    string userName,
    string phoneNumber,
    string email,
    Gender gender,
    string address);