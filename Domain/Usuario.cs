namespace ProdutosApi.Domain;

public class Usuario
{
    public string User { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }

    public Usuario()
    {
    }

    {
        User = user;
        Password = password;
        Role = role;
    }
}