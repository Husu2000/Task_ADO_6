namespace Task_ADO_6;

public class Post
{
    public int Id { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string? Text { get; set; }
    public string? ImagePath { get; set; }

    public IEnumerable<Tags> tags { get; set; } = [];

    public override string ToString()
    {
        return $@"{Text}";
    }
}
