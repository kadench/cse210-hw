using System;
class Assignment {
    protected string _khStudentName;
    protected string _khTopic;

    public Assignment(string khStudentName, string khTopic) {
        _khStudentName = khStudentName;
        _khTopic = khTopic;

    }
    public string GetStudentName() {
        return _khStudentName;
    }

    public string GetTopic() {
        return _khTopic;
    }
    public string GetSummary() {
        return $"{_khStudentName} - {_khTopic}";
    }
}