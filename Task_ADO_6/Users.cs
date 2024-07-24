namespace Task_ADO_6;

public class Users
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Pasword { get; set; }
    public bool IsOpen { get; set; } = true;
    public bool Gender { get; set; } = true;
    public DateTime Birthday { get; set; }
    public IEnumerable<Post> posts { get; set; } = [];
    public override string ToString()
    {
        return @$"{Login} {Pasword}";
    }
}
