namespace creational.patterns.Builder;

public class Email
{
    public Email()
    {
        To = [];
        Cc = [];
        Bcc = [];
        Attachments = [];
    }
    public string From { get; set; }
    public List<string> To { get; set; }
    public List<string> Cc { get; set; }
    public List<string> Bcc { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public List<string> Attachments { get; set; }
    public void Send()
    {
        Console.WriteLine($"Email was successfully sent from {From} to {string.Join(", ", To)}");
    }
}
