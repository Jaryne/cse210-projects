public class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        // return _studentName + " " + _topic; <- string concatenation
        return $"{_studentName} - {_topic}"; // string interpolation
    }
}
