using AsaxiyClone.Application.DataTransferObjects;

namespace AsaxiyClone.Application.Services;

public interface IUserService
{
    ValueTask<UserDto> CreateUserAync(UserForCreationDto userForCreationDto);
}