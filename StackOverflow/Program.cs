// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Post post = new Post("Title", "Description");
post.UpVote();
post.UpVote();
post.UpVote();
Console.WriteLine($"Votes: {post.Score}");
post.DownVote();
Console.WriteLine($"Votes: {post.Score}");
public class Post
{
    public string Title { get; set; }
    public string Description { get; set; }
    private readonly DateTime created;
    public int Score { get; set; }
    public Post()
    {
        this.Score = 0;
        this.created = DateTime.Now; 
    }

    public Post(string title, string description) : this()
    {
        this.Title = title;
        this.Description = description;
    }

    public void UpVote() { this.Score += 1; }

    public void DownVote() { this.Score -= 1;}

}

