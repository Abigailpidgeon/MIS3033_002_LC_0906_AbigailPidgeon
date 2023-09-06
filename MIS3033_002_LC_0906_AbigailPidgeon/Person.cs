namespace a
{
    public class Person//: Object 
    {
        public double grade { get; set; } // C# syntax//you need to know 
        public string name {  get; set; }// called member variable/field
        public DateTime dob { get; set; }
        public double weight { get; set; }
        public virtual string CoffeeMaker()//virtual,replacable 
        {
            return "This is the coffee from person";
        }



        public Person() { }//empty constructor function

        // local variable 
        public Person(string name, DateTime dob, double weight)
        {
            Console.WriteLine("name");//local has priotity 
            this.name = name;//this means self 
            this.dob = dob;
            this.weight = weight;
        }
        // two functions have the same name but different parameters. called a function overload 
    }
}
