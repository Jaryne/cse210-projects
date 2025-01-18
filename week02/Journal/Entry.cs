public class Entry
{
    public string _prompt;
    public string _response;
    public string _date;
    public string _firstName; // Exceeding requirement!! This is for multiple users to enter in the same journal.
    public string _lastName;

    public Entry(string prompt, string response, string firstName, string lastName)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now.ToString("MM-dd-yyyy HH:mm");
        _firstName = firstName;
        _lastName = lastName;
    }

    public override string ToString()
    {
        return $"{_date} | {_prompt} | {_response} | By: {_firstName} {_lastName}";
    }
}