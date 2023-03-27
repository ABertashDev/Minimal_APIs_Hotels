﻿
public class UserRepository : IUserRepository
{

    private List<UserDto> _users => new()
    {
        new UserDto("John", "123"),
        new UserDto("Michael", "123"),
        new UserDto("Megan", "123")
    };

    public UserDto GetUser(UserModel userModel) =>
        _users.FirstOrDefault(
            u => string.Equals(u.UserName, userModel.UserName) && string.Equals(u.Password, userModel.Password)) 
        ?? throw new Exception();
 
}
