namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();


        Console.Write("Enter total number of enrolled courses: ");
        int enrolledCourse = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter price of book: ");
        double getPrice= Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine("Name: " + name + "\nTotal Enrolled Course: " + enrolledCourse + "\nPrice of Book: " +getPrice * enrolledCourse);


    }
}