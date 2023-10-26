using System;

class MathAssignment : Assignment {
    private string _khTextbookSection;
    private string _khProblems;

    public MathAssignment(string khStudentName, string khTopic, string khTextbookSection, string khProblems)
    : base(khStudentName, khTopic) {
        _khTextbookSection = khTextbookSection;
        _khProblems = khProblems;
    }
    
    public string GetHomeworkList() {
        return $"Section {_khTextbookSection} Problems {_khProblems}";
    }
}