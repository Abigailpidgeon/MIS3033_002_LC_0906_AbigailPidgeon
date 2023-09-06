// MIS 3033 002
// September 6, 2023
// Abigail Pidgeon, 113515288

using a;
using fi;

Console.WriteLine("Interface");//class interface

a.Person p1;//person is like the blueprint,complex
a.Person p2 = new a.Person("Abby",new DateTime(2002,8,25),140);//constructor function and function overload 

p1 = new a.Person();// function call, constructor function 
p1.grade = 96.6;//simple
Console.WriteLine(p1.grade);//read the value 
p1.name = "Abigail Pidgeon";
p1.dob = new DateTime(2002, 8, 27);
p1.weight = 150;// in lbs
// this is on branch 1
Console.WriteLine(p1.dob.ToString("MMM dd, yyyy"));


Student stu1;//studnet,complex
stu1 = new Student();//
stu1.dob = new DateTime(2002,8,26);
stu1.id = "113515288";
stu1.grade = 97.8;
stu1.name = "Abby P";

Console.WriteLine(stu1.CoffeeMaker());
Console.WriteLine(stu1);
Console.WriteLine(stu1.ToString());

// simple int double bool char
// complex string student
int age2;//int
string str2;//string
// var
var age3 = 19;//var here is int determined by the right side 
//var ag4;
var stu3 = new Student ();// student data type 
var stu4 = new Person();// person data type 

//namespace
//folder concept
namespace fi //folder concept,
{
    public class Student: Person // none, student, complex
    {
        public string id { get;set;}
        public Student() { }

        public string ToString()
        {
            return "this is a student";
        }
        public override string CoffeeMaker()//
        {
            return "this is the coffe from the student";
        }
    }
}