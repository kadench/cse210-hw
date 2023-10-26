using System;

class WritingAssignment : Assignment {
    private string _khTitle;

    public WritingAssignment(string khStudentName, string khTopic, string khTitle)
    : base(khStudentName, khTopic) {
        _khTitle = khTitle;
    }

    public string GetWritingInformation() {
        string khStudentName = GetStudentName();

        return $"{_khTitle} by {khStudentName}";
    }
}