namespace Task_ADO_6;

public class Tags
{
    public int Id { get; set; }
    public string Tag { get; set; }
    public IEnumerable<Post> posts { get; set; } = [];
}
