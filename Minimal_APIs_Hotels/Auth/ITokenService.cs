
public interface ITokenService
{
    public string GetToken(string key, string issuer, UserDto user);

}

