using System; 

//Class for user entry
class Entry
{
    public DateTime Time { get; private set; }
    public string Question { get; private set; }
    public string Response { get; private set; }

    public Entry(string question, string response)
    {
        Time = DateTime.Now;
        Question = question;
        Response = response;
    }

    public Entry(string question, string response, DateTime time)
    {
        Time = time;
        Question = question;
        Response = response;
    }
}
