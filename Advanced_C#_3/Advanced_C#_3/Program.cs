using System.Runtime.InteropServices;

namespace Advanced
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public static List<Person> GetPeople()
        {
            List<Person> people = new List<Person>
            {
                new Person { FirstName = "Magnus",    LastName = "Hedlund" },
                new Person { FirstName = "Terry",     LastName = "Adams" },
                new Person { FirstName = "Charlotte", LastName = "Weiss" },
                new Person { FirstName = "Arlene",    LastName = "Huff" },
                new Person { FirstName = "Rui",       LastName = "Raposo" }
            };
            return people;
        }
    }
    class Pet
    {
        public string Name { get; set; }
        public Person Owner { get; set; }
        public static List<Pet> GetPets()
        {
            List<Person> owners = Person.GetPeople();
            List<Pet> pets = new List<Pet>
            {
                new Pet { Name = "Barley",    Owner = owners.First(p => p.FirstName == "Terry") },
                new Pet { Name = "Boots",     Owner = owners.First(p => p.FirstName == "Terry") },
                new Pet { Name = "Whiskers",  Owner = owners.First(p => p.FirstName == "Charlotte") },
                new Pet { Name = "Blue Moon", Owner = owners.First(p => p.FirstName == "Rui") },
                new Pet { Name = "Daisy",     Owner = owners.First(p => p.FirstName == "Magnus") }
            };
            return pets;
        }
    }

    public class studentAge
    {
        public string name { get; set; }
        public int age { get; set; }
        public static List<studentAge> GetStudentsSimple()
        {
            List<studentAge> students = new List<studentAge>
        {
        new studentAge {name = "kwongeonwoo", age = 95},
        new studentAge {name = "hyunseo", age = 15},
        new studentAge {name = "jiyoo", age = 12},
        new studentAge {name = "sundayBagle", age = 10},
        new studentAge {name = "cute", age = 20},
        new studentAge {name = "leesang", age = 30},
        new studentAge {name = "DDak", age = 26}
        };
            return students;
        }
    }
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public List<int> Scores;
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
        {
        new Student {First = "kwon",Last = "o", ID = 11,Scores = new List<int>{97,98,11,12}},
        new Student {First = "o",Last = "f", ID = 12,Scores = new List<int>{33,1,11,12}},
        new Student {First = "k",Last = "d", ID = 13,Scores = new List<int>{100,8,11,12}}
        };
            return students;
        }
    }
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("------------------------------------");
            List<Student> students = Student.GetStudents();
            PassNonpass(students);
            Console.WriteLine("------------------------------------");
            List<studentAge> simpleStudents = studentAge.GetStudentsSimple();
            AgeArrangeTopDown(simpleStudents);
            Console.WriteLine("------------------------------------");
            GroupPrint(simpleStudents);

            Console.WriteLine("------------------------------------");
            List<Person> people = Person.GetPeople();
            List<Pet> pets = Pet.GetPets();
            JoinPrint(people, pets);
        }

        private static void PassNonpass(List<Student> students)
        {
            var booleanGroup =
                from student in students
                group student by student.Scores.Average() >= 80;
            foreach (var studentGroup in booleanGroup)
            {
                Console.WriteLine(studentGroup.Key == true ? "High averages" : "Low averages");
                foreach (var student in studentGroup)
                {
                    Console.WriteLine("{0},{1}{2}", student.Last, student.First, student.Scores.Average());
                }
            }
        }
        private static void AgeArrangeTopDown(List<studentAge> simplestudents)
        {
            var youngList = from oldYoung in simplestudents
                            orderby oldYoung.age ascending
                            select oldYoung;
            foreach(var student in youngList)
            {
                Console.WriteLine("{0}, {1}", student.age, student.name);
            }
        }
        private static void GroupPrint(List<studentAge> simplestudents)
        {
            var over25Query = from over25 in simplestudents
                          group over25 by over25.age > 25;
            foreach(var oldboy in over25Query)
            {
                Console.WriteLine(oldboy.Key == true ? "over25" : "lower25");
                foreach(var student in oldboy)
                {
                    Console.WriteLine( "{0}, {1}", student.name, student.age);
                }
            }
        }
        private static void JoinPrint(List<Person> people,List<Pet> pets)
        {
            var query = from person in people
                        join pet in pets on person.FirstName equals pet.Owner.FirstName
                        select new { OwnerName = person.FirstName, PetName = pet.Name };
            /*
            from person in people
                → people 리스트에서 person을 하나씩 꺼낸다.
            join pet in pets on person.FirstName equals pet.Owner.FirstName
                → pets 리스트에서 pet을 하나씩 꺼내서,
            person.FirstName(사람 이름) 과 pet.Owner.FirstName(pet 소유자 이름) 이 문자열로 같은 경우에만 짝을 맺는다.
            select new { OwnerName = ..., PetName = ... }
                → 매칭된 쌍에서 소유자 이름과 pet 이름만 뽑아 익명 객체로 만든다.
             */


            foreach (var ownerAndPet in query)
            {
                Console.WriteLine("\"{0}\" is owned by {1}", ownerAndPet.PetName, ownerAndPet.OwnerName);
            }

        }
    }
}