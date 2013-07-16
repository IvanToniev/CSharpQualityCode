using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("The grade must be non-negative!");
        }
        if(grade == null)
        {
            throw new ArgumentNullException("The grade can't be null!");
        }
        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("The minimum grade must be non-negative!");
        }
        if (minGrade == null)
        {
            throw new ArgumentNullException("The minimum grade can't be null!");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException("The maximum grade must be bigger than the minimum!");
        }
        if (maxGrade == null)
        {
            throw new ArgumentNullException("The maximum grade can't be null!");
        }
        if (comments == null || comments == "")
        {
            throw new ArgumentException("The comments can't be empty!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
