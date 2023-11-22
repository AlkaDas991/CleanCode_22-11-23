1. review1.cs
int d; // elapsed time in days
int elapsedTimeInDays;

2. review2.cs
var dataFromDb = db.GetFromService().ToList(); // Get List of employees 

var allEmpFromDb = db.GetEmpDataFromService().ToList();

3.review3.cs
int iCounter;
string strFullName;
DateTime dModifiedDate;

//Modified One
int counter;
string fullName;
DateTime modifiedDate;

4.review4.cs
public bool IsShopOpen(string pDay, int pAmount)//Avoid hungarian notation
{
    // some logic
}

5.review5.cs
const int DAYS_IN_WEEK = 7;
const int daysInMonth = 30;

var songs = new List<string> { 'Back In Black', 'Stairway to Heaven', 'Hey Jude' };
var Artists = new List<string> { 'ACDC', 'Led Zeppelin', 'The Beatles' };

bool EraseDatabase() {}
bool Restore_database() {}

class animal {}
class Alpaca {}

//Modied Content
const int daysInWeek = 7;
const int daysInMonth = 30;

var songs = new List<string> { 'Back In Black', 'Stairway to Heaven', 'Hey Jude' };
var artits = new List<string> { 'ACDC', 'Led Zeppelin', 'The Beatles' };

bool EraseDatabase() {}
bool RestoreDatabase() {}

class animal {}
class Alpaca {}

6.review6.cs
public class Employee
{
    public Datetime sWorkDate { get; set; } // get set Start Working Date --> name can be startWorkDate
    public Datetime modTime { get; set; } // get set Modification Time
}

7.review7.cs
var employeephone;

public double CalculateSalary(int workingdays, int workinghours) // it should be camelcase
{
    // some logic
}
