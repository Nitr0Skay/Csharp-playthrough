
## Linki do Zadania

Free Code Camp:
https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/create-and-run-simple-c-sharp-console-applications/challenge-project-develop-foreach-and-if-elseif-else-structures-to-process-array-data-in-c-sharp

Microsoft Learn:
https://learn.microsoft.com/pl-pl/training/modules/challenge-project-arrays-iteration-selection/


```
W sumie... zrób mi szczegółowe porównanie i analizę mojego programu:

/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOveraall\tGrade\t\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string currentStudentName in studentNames)
{
    if (currentStudentName == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudentName == "Andrew")
        studentScores = andrewScores;

    else if (currentStudentName == "Emma")
        studentScores = emmaScores;

    else if (currentStudentName == "Logan")
        studentScores = loganScores;

    int sumAssignmentScores = 0;
    int gradedAssignments = 0;
    int currentStudentExtraCredits = 0;


    decimal currentStudentGrade = 0;
    decimal currentStudentExamScore = 0;
    decimal currentStudentExtraPoints = 0;
    decimal sumCurrentStudentExamExtraScores = 0;

    /* 
    the inner foreach loop sums assignment scores
    extra credit assignments are worth 10% of an exam score
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;

        else
        {
            currentStudentExtraCredits += score;
            sumCurrentStudentExamExtraScores += ((decimal)score / (decimal)10);
        }
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;
    currentStudentExamScore = currentStudentGrade;
    currentStudentExtraCredits /= (studentScores.Length - examAssignments);
    currentStudentExtraPoints = sumCurrentStudentExamExtraScores / examAssignments;
    currentStudentGrade += currentStudentExtraPoints;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    // Student         Grade
    // Sophia:         92.2    A-
    
    Console.WriteLine($"{currentStudentName}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t\t{currentStudentLetterGrade}\t\t{currentStudentExtraCredits} ({currentStudentExtraPoints} pts)");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();


Oraz tego co finalnie miało wyjść:

/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

Student         Exam Score      Overall Grade   Extra Credit

Sophia          92.2            95.88   A       92 (3.68 pts)

*/
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- calculate exam and extra credit sums (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int gradedAssignments = 0;
    int gradedExtraCreditAssignments = 0;

    int sumExamScores = 0;
    int sumExtraCreditScores = 0;

    decimal currentStudentGrade = 0;
    decimal currentStudentExamScore = 0;
    decimal currentStudentExtraCreditScore = 0;

    /* 
    the inner foreach loop: 
    - sums the exam and extra credit scores
    - counts the extra credit assignments
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        {
            sumExamScores = sumExamScores + score;
        }

        else
        {
            gradedExtraCreditAssignments += 1;
            sumExtraCreditScores += score;
        }
    }

    currentStudentExamScore = (decimal)(sumExamScores) / examAssignments;
    currentStudentExtraCreditScore = (decimal)(sumExtraCreditScores) / gradedExtraCreditAssignments;

    currentStudentGrade = (decimal)((decimal)sumExamScores + ((decimal)sumExtraCreditScores / 10)) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";


    // Student         Exam Score      Overall Grade   Extra Credit
    // Sophia          92.2            95.88   A       92 (3.68 pts)

    Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({(((decimal)sumExtraCreditScores / 10) / examAssignments)} pts)");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();

Tak abym miał pełny obraz tego, nad czym mam popracować
```

Tak — i teraz rzeczywiście warto zrobić pełną sekcję zwłok. 😄 Nie po to, żeby powiedzieć „Twój kod jest zły”, bo on działa, tylko żeby zobaczyć różnicę między:

„umiem doprowadzić program do poprawnego wyniku”

a

„umiem zaprojektować ten kod tak, żeby był czytelny, odporny na zmiany i łatwy do rozwinięcia”.

I to jest dokładnie ten następny krok, nad którym warto pracować.

1. Najpierw najważniejsze: Twój program jest poprawny

To trzeba powiedzieć jasno.

Twoje rozwiązanie:

poprawnie rozdziela egzaminy i extra credit,
poprawnie liczy średnią egzaminów,
poprawnie liczy średnią extra credit,
poprawnie przelicza extra credit na punkty,
poprawnie dodaje je do oceny końcowej,
poprawnie wyznacza literę,
daje oczekiwane wyniki.

Czyli nie mamy sytuacji:

„Musisz przepisać wszystko, bo źle rozumiesz zadanie”.

Wręcz przeciwnie.

Rozumienie algorytmu masz.

Różnice dotyczą głównie sposobu wyrażenia tego algorytmu w kodzie.

2. Największa różnica: jak myślisz o extra credit

W Twoim kodzie robisz:

else
{
    currentStudentExtraCredits += score;
    sumCurrentStudentExamExtraScores += ((decimal)score / (decimal)10);
}


Czyli już podczas przechodzenia po tablicy mówisz:

„To jest extra credit, więc od razu przeliczę go na 10%”.

Dla Sophii:

94 → 9.4
90 → 9.0

9.4 + 9.0 = 18.4


Potem:

currentStudentExtraPoints = sumCurrentStudentExamExtraScores / examAssignments;


czyli:

18.4 / 5 = 3.68


To jest matematycznie poprawne.

W rozwiązaniu Microsoftu robią coś trochę innego.

Najpierw zbierają surowe dane:

sumExtraCreditScores += score;


czyli:

94 + 90 = 184


A dopiero później:

((decimal)sumExtraCreditScores / 10) / examAssignments


czyli:

184 / 10 / 5
= 18.4 / 5
= 3.68

Matematycznie

Twoje:

(94 / 10 + 90 / 10) / 5


Microsoft:

(94 + 90) / 10 / 5


To jest to samo.

Twój algorytm nie jest tutaj błędny.

3. Ale rozwiązanie Microsoftu ma jedną dużą zaletę

Rozdziela dane od obliczeń.

To jest bardzo ważna koncepcja programistyczna.

Microsoft mówi:

int sumExtraCreditScores = 0;


czyli:

„Mam sumę surowych punktów extra credit”.

A potem:

currentStudentGrade =
    (decimal)((decimal)sumExamScores + ((decimal)sumExtraCreditScores / 10))
    / examAssignments;


czyli:

„Teraz zdecyduję, jak te dane wykorzystać”.

Ty robisz trochę bardziej:

odczytuję dane
↓
od razu je przeliczam
↓
zapamiętuję wynik przeliczenia
↓
później używam wyniku


To nie jest złe.

Ale z czasem warto nauczyć się rozdzielać:

co wiem?


od:

co z tym policzę?


To będzie bardzo przydatne później.

4. currentStudentExtraCredits vs gradedExtraCreditAssignments

To jest chyba najciekawsza różnica.

Ty masz:

currentStudentExtraCredits /= (studentScores.Length - examAssignments);


Czyli zakładasz:

liczba extra creditów = długość tablicy - liczba egzaminów.

Dla Sophii:

7 - 5 = 2


Dla Emmy:

8 - 5 = 3


I to działa.

Microsoft natomiast robi:

int gradedExtraCreditAssignments = 0;


i:

else
{
    gradedExtraCreditAssignments += 1;
    sumExtraCreditScores += score;
}


A potem:

currentStudentExtraCreditScore =
    (decimal)sumExtraCreditScores / gradedExtraCreditAssignments;

Dlaczego?

Bo Microsoft mówi:

„Nie zakładam, ile będzie extra creditów. Podczas przechodzenia po tablicy policzę, ile ich faktycznie znalazłem.”

To jest bardziej ogólne.

Wyobraź sobie, że jutro zmieniasz:

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };


na:

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90, 87, 95 };


Twój kod nadal zadziała:

9 elementów - 5 egzaminów = 4 extra credits


więc tutaj akurat jesteś bezpieczny.

Ale semantycznie gradedExtraCreditAssignments jest bardziej oczywiste:

gradedExtraCreditAssignments


naprawdę oznacza:

„ile extra-credit assignments znalazłem”.

Natomiast:

studentScores.Length - examAssignments


oznacza:

„weź długość tablicy i odejmij liczbę egzaminów”.

Pierwsze jest bardziej bezpośrednim opisem tego, co program robi.

5. gradedAssignments masz dobrze, ale nazwa jest trochę myląca

Masz:

int gradedAssignments = 0;


i:

foreach (int score in studentScores)
{
    gradedAssignments += 1;


Problem polega na tym, że gradedAssignments oznacza u Ciebie:

liczbę wszystkich elementów, które dotychczas odwiedziłem

a nie:

liczbę ocenionych egzaminów.

Bo dla Sophii finalnie:

gradedAssignments = 7


a egzaminów było tylko:

5


Microsoft też ma:

int gradedAssignments = 0;


więc tutaj nie odstajesz od rozwiązania.

Ale później, gdy będziesz pisał własny kod, warto uważać na takie nazwy.

Nazwy zmiennych powinny możliwie dobrze opisywać rzeczywiste znaczenie.

6. Bardzo dobra rzecz w Twoim kodzie: rozdzieliłeś Exam Score i Overall Grade

Masz:

currentStudentExamScore = currentStudentGrade;


a następnie:

currentStudentExtraPoints = sumCurrentStudentExamExtraScores / examAssignments;
currentStudentGrade += currentStudentExtraPoints;


Dzięki temu:

currentStudentExamScore


pozostaje:

92.2


a:

currentStudentGrade


staje się:

95.88


To jest poprawne rozumowanie.

I tutaj widać, że załapałeś ważną rzecz:

ocena egzaminacyjna ≠ końcowa ocena po extra credit.

7. Ale możesz pozbyć się jednej zmiennej

Masz:

decimal currentStudentGrade = 0;
decimal currentStudentExamScore = 0;


Potem:

currentStudentGrade =
    (decimal)(sumAssignmentScores) / examAssignments;

currentStudentExamScore = currentStudentGrade;


To jest OK, ale trochę redundantne.

W rozwiązaniu Microsoftu jest:

currentStudentExamScore =
    (decimal)(sumExamScores) / examAssignments;


a potem osobno:

currentStudentGrade =
    (decimal)((decimal)sumExamScores + ((decimal)sumExtraCreditScores / 10))
    / examAssignments;


Czyli każda zmienna jest obliczana bezpośrednio z danych.

Twoje rozwiązanie też działa, ale:

currentStudentGrade
       ↓
currentStudentExamScore


oznacza chwilowe użycie currentStudentGrade jako oceny egzaminacyjnej, a dopiero później jako oceny końcowej.

To może być trochę mylące.

Lepiej mentalnie:

sumExamScores
      ↓
ExamScore
      ↓
+ ExtraCredit
      ↓
OverallGrade

8. Twoje nazewnictwo vs Microsoft
Ty:
sumAssignmentScores

Microsoft:
sumExamScores


W tym konkretnym programie Microsoft ma lepszą nazwę.

Dlaczego?

Bo pierwszych pięć elementów to egzaminy, nie wszystkie assignmenty.

Twoja nazwa pochodzi jeszcze z komentarzy/instrukcji zadania, ale później kod faktycznie operuje na:

Exam Scores


Dlatego:

sumExamScores


jest bardziej precyzyjne.

Ty:

currentStudentExtraCredits


Microsoft:

sumExtraCreditScores


I znowu Microsoft jest tutaj bardziej jednoznaczny.

Bo Twoja zmienna początkowo oznacza:

sumę extra creditów


a potem robisz:

currentStudentExtraCredits /= ...


czyli nagle ta sama zmienna oznacza:

średnią extra creditów


Czyli jej znaczenie zmienia się w trakcie programu.

To jest rzecz, nad którą zdecydowanie warto pracować.

9. To jest jeden z ważniejszych punktów do zapamiętania

Masz:

int currentStudentExtraCredits = 0;


Najpierw:

currentStudentExtraCredits += score;


czyli:

suma extra creditów

A później:

currentStudentExtraCredits /= (...);


czyli:

średnia extra creditów

Technicznie OK.

Ale konceptualnie trochę brudno.

Microsoft robi:

int sumExtraCreditScores = 0;


i później:

decimal currentStudentExtraCreditScore = 0;


Czyli:

sumExtraCreditScores
        ↓
surowa suma

currentStudentExtraCreditScore
        ↓
średnia


Każda zmienna ma jedno znaczenie.

To jest bardzo dobry nawyk do wyrobienia.

10. Twój decimal — dobrze, ale można zauważyć pewien styl

Masz:

sumCurrentStudentExamExtraScores += ((decimal)score / (decimal)10);


Na obecnym etapie kursu: bardzo OK.

Wiesz już dlaczego.

Natomiast Microsoft robi:

sumExtraCreditScores += score;


czyli trzyma dane jako int, a decimal wprowadza dopiero przy właściwym obliczeniu:

(decimal)sumExtraCreditScores / 10


To jest trochę czystsze koncepcyjnie:

dane wejściowe → int
obliczenie wymagające ułamka → decimal


Ale nie powiedziałbym, że powinieneś teraz koniecznie przerabiać swój kod. W kontekście kursu Twoje rozwiązanie jest jak najbardziej sensowne.

11. Bardzo ciekawa różnica: gdzie liczysz 3.68

Ty:

sumCurrentStudentExamExtraScores += ((decimal)score / (decimal)10);


a potem:

currentStudentExtraPoints =
    sumCurrentStudentExamExtraScores / examAssignments;


Microsoft:

sumExtraCreditScores += score;


a potem w Console.WriteLine:

(((decimal)sumExtraCreditScores / 10) / examAssignments)


Tutaj powiedziałbym, że Twoje rozwiązanie jest nawet czytelniejsze pod względem obliczeń.

Nie jestem wielkim fanem:

Console.WriteLine(
    $"... {(((decimal)sumExtraCreditScores / 10) / examAssignments)} ..."
);


bo Console.WriteLine zaczyna wtedy zawierać logikę biznesową.

Ty robisz:

currentStudentExtraPoints =
    sumCurrentStudentExamExtraScores / examAssignments;


a potem:

Console.WriteLine(
    $"... ({currentStudentExtraPoints} pts)"
);


To jest moim zdaniem ładniejsze.

Czyli nie wszystko w Twoim kodzie jest „gorsze od rozwiązania Microsoftu”.

12. currentStudent jest Ci niepotrzebne

Microsoft:

foreach (string name in studentNames)
{
    string currentStudent = name;


Ty:

foreach (string currentStudentName in studentNames)
{


i to jest moim zdaniem lepsze.

Nie potrzebujesz:

string currentStudent = name;


bo możesz od razu nazwać zmienną:

currentStudentName


Microsoft zrobił to prawdopodobnie ze względu na strukturę zadania i kolejne kroki ćwiczenia.

Nie kopiowałbym tego.

13. if / else if z nazwiskami — tutaj obaj macie ten sam problem

Masz:

if (currentStudentName == "Sophia")
    studentScores = sophiaScores;

else if (currentStudentName == "Andrew")
    studentScores = andrewScores;

else if (currentStudentName == "Emma")
    studentScores = emmaScores;

else if (currentStudentName == "Logan")
    studentScores = loganScores;


To jest dokładnie wymagane przez ćwiczenie.

Ale z punktu widzenia późniejszego programowania jest to bardzo mało skalowalne.

Wyobraź sobie 500 studentów.

Dostałbyś:

if (name == "Student1")
...
else if (name == "Student2")
...
else if (name == "Student3")
...


💀

Później nauczysz się struktur danych, metod, klas itd. i takie problemy zaczną znikać.

Na tym etapie absolutnie zostaw.

To ćwiczenie ma Cię nauczyć foreach + if/else, a nie projektowania systemu ocen dla Uniwersytetu Warszawskiego. 😄

14. studentScores = new int[10] też nie jest idealne

Masz:

int[] studentScores = new int[10];


a potem natychmiast:

studentScores = sophiaScores;


czyli początkowa tablica:

[0, 0, 0, 0, 0, 0, 0, 0, 0, 0]


w zasadzie nigdy nie jest używana.

To jest trochę sztuczne, ale wymagane przez charakter tego ćwiczenia.

Nie przejmowałbym się tym.

15. gradedAssignments można by zastąpić czymś innym — ale NIE teraz

Masz:

gradedAssignments += 1;


i potem:

if (gradedAssignments <= examAssignments)


To jest bardzo dobry przykład nauki foreach.

Później poznasz rzeczy typu:

for


i indeksy tablic:

studentScores[i]


i wtedy można będzie zrobić to inaczej.

Ale nie ma żadnego sensu teraz poprawiać tego na siłę.

Kod jest zgodny z celem ćwiczenia.

16. Twoje komentarze

Masz dużo komentarzy:

/* 
This C# console application is designed to:
...
*/


oraz:

/* 
The outer foreach loop is used to:
...
*/


Na etapie kursu: super.

Komentowanie kodu pomaga Ci pamiętać:

„Po co ja właściwie to robię?”

Natomiast później warto przejść z komentarzy typu:

// add score
sum += score;


na komentarze opisujące dlaczego coś robisz, gdy nie jest to oczywiste.

Czyli:

// Extra credit contributes only 10% of its value to the final grade.


jest wartościowe.

Natomiast:

// Add score to sum.
sum += score;


praktycznie nic nie wnosi.

Ale to jest temat na później.

17. Masz literówkę

Tutaj:

Console.WriteLine("Student\t\tExam Score\tOveraall\tGrade\t\tExtra Credit\n");


masz:

Overaall


zamiast:

Overall


Mała rzecz, ale właśnie takie rzeczy później wychodzą przy sprzątaniu kodu. 😄

18. Największa rzecz do poprawy: odpowiedzialności zmiennych

Jeżeli miałbym wybrać jedną rzecz, nad którą powinieneś pracować po tym ćwiczeniu, to nie byłoby to:

„naucz się pisać krócej”.

Tylko:

Naucz się nadawać zmiennym jednoznaczne znaczenie i nie zmieniać ich znaczenia w trakcie programu.

Na przykład u Ciebie:

currentStudentExtraCredits


najpierw:

SUMA


potem:

ŚREDNIA


A lepiej:

sumExtraCreditScores
        ↓
średnia
        ↓
currentStudentExtraCreditScore


Podobnie:

sumExamScores
        ↓
currentStudentExamScore
        ↓
currentStudentGrade


To jest mała rzecz, ale bardzo duża umiejętność w dalszym programowaniu.

19. Porównanie w skrócie
Obszar	Twój kod	Microsoft	Ocena
Tablice	✅	✅	równorzędnie
foreach	✅	✅	równorzędnie
Rozdzielenie egzaminów/EC	✅	✅	równorzędnie
Liczenie exam average	✅	✅	równorzędnie
Liczenie extra credit	✅	✅	równorzędnie
decimal	✅	✅	rozumiesz, po co
Final grade	✅	✅	poprawnie
Letter grade	✅	✅	równorzędnie
Czytelność nazw	🟡	🟢	do poprawy
Jedno znaczenie zmiennej	🟡	🟢	ważny temat
Oddzielenie danych od obliczeń	🟡	🟢	warto ćwiczyć
Logika w Console.WriteLine	🟢	🟡	u Ciebie nawet lepiej
Skalowalność	🔴	🔴	celowo ograniczona przez ćwiczenie
Zgodność z celem ćwiczenia	🟢	🟢	bardzo dobra
20. Jak oceniłbym Twój kod na obecnym etapie

Gdybym zobaczył ten kod jako kod osoby dopiero uczącej się C#, nie powiedziałbym:

„Ale bałagan.”

Powiedziałbym raczej:

„Widać, że autor rozumie rozwiązanie, ale jeszcze nie ma wyrobionych nawyków projektowania kodu.”

I to jest dokładnie to, czego można się spodziewać na tym etapie.

Najważniejsze jest to, że w momencie problemu z:

score / 10


nie zrobiłeś:

„Dobra, wkleję rozwiązanie z internetu.”

Tylko doszedłeś do:

(decimal)score / (decimal)10


i rozumiesz, dlaczego to jest potrzebne.

To jest dużo ważniejszy sygnał niż to, czy Twoja zmienna nazywa się currentStudentExtraCredits, czy sumExtraCreditScores.

21. Twoja lista rzeczy do pracy

Nie próbowałbym teraz poprawiać wszystkiego naraz. Zrobiłbym sobie mentalną checklistę na kolejne projekty:

Nazwy zmiennych: czy nazwa dokładnie mówi, co przechowuje zmienna?
Jedna odpowiedzialność: czy jedna zmienna nie zmienia znaczenia w połowie programu?
Typy danych: czy rozumiem, kiedy używam int, a kiedy decimal?
Kolejność obliczeń: czy najpierw wyliczam wartość, a dopiero potem jej używam?
Oddzielanie danych od obliczeń: czy zbieram dane osobno, a przeliczam je później?
Czytelność: czy po tygodniu będę wiedział, co robi ten fragment?
Komentarze: czy komentarz mówi dlaczego, a nie tylko powtarza kod?
Redundancja: czy mam zmienną, której właściwie nie potrzebuję?

I nie dopisywałbym do tej listy „pisz krótszy kod”.

Krótki kod ≠ dobry kod.

Na tym etapie dużo ważniejsze jest:

„Czy rozumiem, co napisałem?”

A patrząc na tę rozmowę z 3.68 — tak, rozumiesz. 😄

Dopiero później przyjdzie etap:

„Dobra, skoro już rozumiem, to teraz zobaczmy, jak to zrobić elegancko.”

I wtedy ten obecny program będzie świetnym materiałem do pierwszego prawdziwego refactoringu.

