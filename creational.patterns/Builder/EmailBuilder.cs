namespace creational.patterns.Builder;

public class EmailBuilder
{
    private readonly Email _email = new();
    public EmailBuilder AddFrom(string from)
    {
        //regex to validate from email address...
        _email.From = from;
        return this;
    }
    public EmailBuilder AddTo(string To)
    {
        //regex to validate from email address...
        _email.To.Add(To);
        return this;
    }
    public EmailBuilder AddCc(string cc)
    {
        //regex to validate from email address...
        _email.Cc.Add(cc);
        return this;
    }
    public EmailBuilder AddBcc(string bcc)
    {
        //regex to validate from email address...
        _email.Bcc.Add(bcc);
        return this;
    }
    public EmailBuilder AddAttachment(string attachment)
    {
        //regex to validate from email address...
        _email.Attachments.Add(attachment);
        return this;
    }
    public EmailBuilder WithSubject(string subject)
    {
        //check subject length and if illegal characters are used...
        _email.Bcc.Add(subject);
        return this;
    }
    public EmailBuilder WithBody(string subject)
    {
        //check subject length and if illegal characters are used...
        _email.Bcc.Add(subject);
        return this;
    }
    public Email Build()
    {
        return _email;
    }
}
