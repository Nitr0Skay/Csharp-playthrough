using System;
using System.Runtime.InteropServices;

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;
int[] sophiaGrades = [ sophia1, sophia2, sophia3, sophia4, sophia5 ];

int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;
int[] andrewGrades = [ andrew1, andrew2, andrew3, andrew4, andrew5 ];

int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;
int[] emmaGrades = [ emma1, emma2, emma3, emma4, emma5 ];

int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;
int[] loganGrades = [ logan1, logan2, logan3, logan4, logan5 ];

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;


string[] studentNames = [ "Sophia", "Andrew", "Emma", "Logan" ];
int[][] gradeBook = [ sophiaGrades, andrewGrades, emmaGrades, loganGrades ];
decimal[] studentScore = new decimal[studentNames.Length];
string currentStudentLetterGrade = "";

// sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
// emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
// loganSum = logan1 + logan2 + logan3 + logan4 + logan5;
int iterator = 0;
Console.WriteLine("Student\t\tGrade\n");
foreach(string student in studentNames)
{
    if (student == "Sophia")
    {
        foreach(int grade in gradeBook[iterator])
        {
            sophiaSum += grade;
        }
        sophiaScore = (decimal)sophiaSum / currentAssignments;
        studentScore[iterator] = sophiaScore;
    } else if(student == "Andrew")
    {
        foreach(int grade in gradeBook[iterator])
        {
            andrewSum += grade;
        }
        andrewScore = (decimal)andrewSum / currentAssignments;
        studentScore[iterator] = andrewScore;
    } else if(student == "Emma")
    {
        foreach(int grade in gradeBook[iterator])
        {
            emmaSum += grade;
        }
        emmaScore = (decimal)emmaSum / currentAssignments;
        studentScore[iterator] = emmaScore;
    } else if(student == "Logan")
    {
        foreach(int grade in gradeBook[iterator])
        {
            loganSum += grade;
        }

        loganScore = (decimal)loganSum / currentAssignments;
        studentScore[iterator] = loganScore;
    }

    decimal currentStudentGrade = studentScore[iterator];
    if(currentStudentGrade >= 97)
    {
        currentStudentLetterGrade = "A+";
    } else if(currentStudentGrade >= 93)
    {
        currentStudentLetterGrade = "A";
    } else if(currentStudentGrade >= 90)
    {
        currentStudentLetterGrade = "A-";
    } else if(currentStudentGrade >= 87)
    {
        currentStudentLetterGrade = "B+";
    } else if(currentStudentGrade >= 83)
    {
        currentStudentLetterGrade = "B";
    } else if(currentStudentGrade >= 80)
    {
        currentStudentLetterGrade = "B-";
    } else if(currentStudentGrade >= 77)
    {
        currentStudentLetterGrade = "C+";
    } else if(currentStudentGrade >= 73)
    {
        currentStudentLetterGrade = "C";
    } else if(currentStudentGrade >= 70)
    {
        currentStudentLetterGrade = "C-";
    } else if(currentStudentGrade >= 67)
    {
        currentStudentLetterGrade = "D+";
    } else if(currentStudentGrade >= 63)
    {
        currentStudentLetterGrade = "D";
    } else if(currentStudentGrade >= 60)
    {
        currentStudentLetterGrade = "D-";
    } else {
        currentStudentLetterGrade = "F";
    }
    
    Console.WriteLine($"{student}:\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
    iterator++;
}

// sophiaScore = (decimal)sophiaSum / currentAssignments;
// andrewScore = (decimal)andrewSum / currentAssignments;
// emmaScore = (decimal)emmaSum / currentAssignments;
// loganScore = (decimal)loganSum / currentAssignments;

// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
// Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
// Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
// Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();