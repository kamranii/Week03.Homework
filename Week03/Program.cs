using System;

namespace Week03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            ////First person
            //Console.Write("1. ");
            //string name = Console.ReadLine();
            //Person_Task1 people = new Person_Task1(name);
            ////Second person
            //Console.Write("2. ");
            //string name2 = Console.ReadLine();
            //Person_Task1 people2 = new Person_Task1(name2);
            ////Third person
            //Console.Write("3. ");
            //string name3 = Console.ReadLine();
            //Person_Task1 people3 = new Person_Task1(name3);
            ////Output the result
            //Console.WriteLine($"Hello! My name is {people.ToString()}");
            //Console.WriteLine($"Hello! My name is {people2.ToString()}");
            //Console.WriteLine($"Hello! My name is {people3.ToString()}");

            //Resources
            //https://www.c-sharpcorner.com/blogs/override-tostring-method-in-c-sharp
            #endregion
            #region Task2
            //int total_people = 3;
            //Person_Task2[] person_Types = new Person_Task2[total_people];
            ////Get names
            //for (int i = 0; i < total_people; i++)
            //{
            //    Console.Write($"{i + 1}. ");
            //    string input_name = Console.ReadLine();
            //    person_Types[i] = new Person_Task2(input_name);
            //}
            //for (int i = 0; i < total_people; i++)
            //{
            //    Console.WriteLine(person_Types[i].ToString());
            //}


            //Resources:
            //https://www.geeksforgeeks.org/destructors-in-c-sharp/
            #endregion
            #region Task3
            ////New "Person"
            //Person_Task3 new_person = new Person_Task3();
            ////Greet
            //Console.WriteLine(new_person.Greet());
            ////New "Student"
            //Student_Task3 new_student = new Student_Task3();
            ////Greet
            //Console.WriteLine(new_student.Greet());
            ////Ask for the age
            //Console.Write("How old is the student: ");
            ////Store his age
            //string age_input = Console.ReadLine();
            ////Set the student's age
            //new_student.SetAge(int.Parse(age_input));
            ////Display his age
            //new_student.ShowAge();
            ////Start studying
            //new_student.Study();
            ////Create a teacher
            //Professor_Task3 new_professor = new Professor_Task3();
            ////Greet
            //Console.WriteLine(new_professor.Greet());
            ////Ask for the teacher's age
            //Console.Write("How old is the teacher: ");
            //string prof_age_input = Console.ReadLine();
            ////Set his age
            //new_professor.SetAge(int.Parse(prof_age_input));
            ////Start explaining
            //new_professor.Explain();
            #endregion
            #region Task4
            ////A default "PhotoBook"
            //PhotoBook defaultPhotoBook = new PhotoBook();
            ////Display number of pages
            //Console.WriteLine(defaultPhotoBook.GetNumberPages());
            ////A new "Photobook" with custom number of pages
            //PhotoBook firstPhotoBook = new PhotoBook(24);
            ////Display the number of pages
            //Console.WriteLine(firstPhotoBook.GetNumberPages());
            ////A new "BigPhotoBook"
            //BigPhotoBook largePhotoBook = new BigPhotoBook();
            ////Display number of pages
            //Console.WriteLine(largePhotoBook.GetNumberPages());
            #endregion
            #region Task5
            ////Get professor's name
            //Console.Write("1. ");
            //string professor_name = Console.ReadLine();
            ////Create the professor
            //Professor_Task5 theprofessor = new Professor_Task5(professor_name);
            ////Get first student's name
            //Console.Write("2. ");
            //string name1 = Console.ReadLine();
            ////Create first student
            //Student_Task5 student1 = new Student_Task5(name1);
            ////Get second student's name
            //Console.Write("3. ");
            //string name2 = Console.ReadLine();
            ////Create second student
            //Student_Task5 student2 = new Student_Task5(name2);
            ////Call the methods
            //theprofessor.Explain();
            //student1.Study();
            //student2.Study();

            //Resources:
            //https://stackoverflow.com/questions/12051/calling-the-base-constructor-in-c-sharp
            #endregion
            #region OptionalTask1
            ////Ask for the array length
            //Console.Write("Provide length of the array: ");
            //int array_length = int.Parse(Console.ReadLine());
            ////Constraints of Array length
            //if (array_length < 2 || array_length > 100)
            //{
            //    Console.WriteLine("Invalid array length!!!");
            //    return;
            //}
            ////Get the divisor
            //Console.Write("Input a divisor: ");
            //int divisor = int.Parse(Console.ReadLine());
            ////Constraints of the divisor
            //if (divisor < 1 || divisor > 100)
            //{
            //    Console.WriteLine("Invalid input!!! Divisor must be: 0 < divisor < 101");
            //    return;
            //}
            ////Create an array of integers
            //int[] arrayOfIntegers = new int[array_length];
            ////Ask for the array elements
            //for (int i = 0; i < array_length; i++)
            //{
            //    //Ask for each element
            //    Console.Write($"Enter the {i + 1}th element of the Array: ");
            //    arrayOfIntegers[i] = int.Parse(Console.ReadLine());
            //    if (arrayOfIntegers[i] < 1 || arrayOfIntegers[i] > 100)
            //    {
            //        Console.WriteLine("Invalid input!!! Element must be: 0 < element < 101");
            //        return;
            //    }
            //}
            ////Print out the input
            //Console.WriteLine($"{divisibleSumPairs(array_length, arrayOfIntegers, divisor)} number of pairs meet the criteria");
            ////Function to find the number of pairs whose sum is divisible by the divisor
            //int divisibleSumPairs(int array_length, int[] arrayOfIntegers, int divisor)
            //{
            //    int number_of_pairs = 0;
            //    //Loop through each element
            //    for (int i = 0; i < array_length; i++)
            //    {
            //        //Loop through all the flowwing elements to divide by the divisor
            //        for (int j = i + 1; j < array_length; j++)
            //        {
            //            if ((arrayOfIntegers[i] + arrayOfIntegers[j]) % divisor == 0)
            //            {
            //                number_of_pairs++;
            //            }
            //        }
            //    }
            //    return number_of_pairs;
            //}
            #endregion
            #region OptionalTask2
            ////Array of kangaroos
            //Kangaroo[] kangaroos = new Kangaroo[2];
            ////Ask for the input numbers
            //Console.Write($"Starting position of the first kangaroo: ");
            //int start_position1 = int.Parse(Console.ReadLine());
            //Console.Write($"Velocity of the first kangaroo: ");
            //int start_velocity1 = int.Parse(Console.ReadLine());
            //kangaroos[0] = new Kangaroo(start_position1, start_velocity1);
            //Console.Write($"Starting position of the second kangaroo: ");
            //int start_position2 = int.Parse(Console.ReadLine());
            //Console.Write($"Velocity of the first kangaroo: ");
            //int start_velocity2 = int.Parse(Console.ReadLine());
            //kangaroos[1] = new Kangaroo(start_position2, start_velocity2);
            ////Print the result
            //Console.WriteLine($"{Circus()}");
            ////Function to check the posiibility
            //string Circus()
            //{
            //    bool possible = false;
            //    //Check if it is possible to meet
            //    if (kangaroos[0].location < kangaroos[1].location && kangaroos[0].velocity < kangaroos[1].velocity)
            //    {
            //        possible = false;
            //    }
            //    else if (kangaroos[0].location > kangaroos[1].location && kangaroos[0].velocity > kangaroos[1].velocity)
            //    {
            //        possible = false;
            //    }
            //    //Loop to find the position of the first kangaroo after each step
            //    for (int i = 1; i < (10000 - kangaroos[0].location) / kangaroos[0].velocity; i++)
            //    {
            //        if (kangaroos[0].SetPosition(i) == kangaroos[1].SetPosition(i))
            //        {
            //            possible = true;
            //            break;
            //        }

            //    }
            //    if (possible)
            //    {
            //        return "YES";
            //    }
            //    else
            //    {
            //        return "NO";
            //    }
            //}
            #endregion
            #region OptionalTask3
            ////Ask for number of socks
            //Console.Write("How many socks are there: ");
            //int number_of_socks = Convert.ToInt16(Console.ReadLine());
            ////Check for the constraint
            //if (number_of_socks > 100)
            //{
            //    Console.WriteLine("Input must be <100");
            //    return;
            //}
            ////An array to store the color
            //int[] colors = new int[number_of_socks];
            ////Get the integers representing colors
            //for (int i = 0; i < number_of_socks; i++)
            //{
            //    Console.Write($"Input integer {i + 1} representing a color: ");
            //    int element = Convert.ToInt16(Console.ReadLine());
            //    //Checking for the constraint
            //    if (element < 101 && element > 0)
            //    {
            //        colors[i] = element;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Input must be 0 < n < 101");
            //        return;
            //    }
            //}
            ////Get the result
            //Console.WriteLine($"Number of pairs is: {SockMerchant(number_of_socks, colors)}");
            ////Find number of pairs
            //int SockMerchant(int length, int[] colorArray)
            //{
            //    //Bool array to check if the element is already existing in a pair
            //    bool[] locked = new bool[length];
            //    int number_of_pairs = 0;
            //    //Loop to find the pairs
            //    for (int i = 0; i < length; i++)
            //    {
            //        //Check if the element exists in any pair
            //        if (locked[i] == false)
            //        {
            //            //Loop through the rest of the array to find the match
            //            for (int j = i + 1; j < length; j++)
            //            {
            //                if (colorArray[i] == colorArray[j] && locked[j] == false)
            //                {
            //                    number_of_pairs++;
            //                    locked[i] = true;
            //                    locked[j] = true;
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //    return number_of_pairs;
            //}
            #endregion
            
        }
        //class Person_Task1
        //{
        //    string Name;
        //    public Person_Task1(string name)
        //    {
        //        Name = name;
        //    }
        //    public override string ToString()
        //    {
        //        return this.Name;
        //    }
        //}
        //class Person_Task2
        //{
        //    string Name;

        //    internal Person_Task2(string name)
        //    {
        //        Name = name;
        //    }
        //    public override string ToString()
        //    {
        //        return "Hello! My name is " + this.Name;
        //    }
        //    ~Person_Task2()
        //    {
        //        Name = String.Empty;
        //    }
        //}
        //class Person_Task3
        //{
        //    protected int Age;
        //    public string Greet()
        //    {
        //        return "Hello!";
        //    }
        //    public void SetAge(int age)
        //    {
        //        Age = age;
        //    }
        //}
        //class Student_Task3 : Person_Task3
        //{
        //    public void Study()
        //    {
        //        Console.WriteLine("I'm studying ");
        //    }
        //    public void ShowAge()
        //    {
        //        Console.WriteLine($"My age is: {base.Age} years old");
        //    }
        //}
        //class Professor_Task3 : Person_Task3
        //{
        //    public void Explain()
        //    {
        //        Console.WriteLine("I'm explaining ");
        //    }
        //}
        //class PhotoBook
        //{
        //    protected int numPages;
        //    public int GetNumberPages()
        //    {
        //        return numPages;
        //    }
        //    public PhotoBook()
        //    {
        //        numPages = 16;
        //    }
        //    public PhotoBook(int pages)
        //    {
        //        numPages = pages;
        //    }
        //}
        //class BigPhotoBook : PhotoBook
        //{
        //    public BigPhotoBook()
        //    {
        //        this.numPages = 64;
        //    }
        //}
        //class Person_Task5
        //{
        //    protected string Name;
        //    public Person_Task5(string name)
        //    {
        //        Name = name;
        //    }
        //    public override string ToString()
        //    {
        //        return this.Name;
        //    }
        //}
        //class Student_Task5 : Person_Task5
        //{
        //    public Student_Task5(string name) : base(name)
        //    {
        //        Name = name;
        //    }
        //    public void Study()
        //    {
        //        Console.WriteLine("I'm studying ");
        //    }
        //}
        //class Professor_Task5 : Person_Task5
        //{
        //    public Professor_Task5(string name) : base(name)
        //    {
        //        Name = name;
        //    }
        //    public void Explain()
        //    {
        //        Console.WriteLine("I'm explaining ");
        //    }
        //}
        //class Kangaroo
        //{
        //    public int location;
        //    public int velocity;
        //    public Kangaroo(int loc_inp, int vel_inp)
        //    {
        //        location = loc_inp;
        //        velocity = vel_inp;
        //    }
        //    public int SetPosition(int step)
        //    {
        //        return this.location + (step * this.velocity);
        //    }
        //}
    }
    
}
