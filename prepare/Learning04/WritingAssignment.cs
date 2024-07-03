public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }

    private string GetStudentName()
    {
        // This method is used to access the student name since it is private in the base class
        return GetSummary().Split(" - ")[0];
    }
}
