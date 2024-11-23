namespace TASK
{
    public class Program
    {
      
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter your email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            Console.WriteLine("Enter your fullname:");
            string fullname = Console.ReadLine();

            User user = new User(email, password, fullname);


            Console.WriteLine("\nUser created successfully!");
            user.ShowInfo();

            
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Show info");
                Console.WriteLine("2. Create new group");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    user.ShowInfo();
                }
                else if (choice == "2")
                {
                   
                    Console.WriteLine("Enter group number (2 uppercase letters + 3 digits):");
                    string groupNo = Console.ReadLine();

                   
                    Group group = null;
                    if (user.PasswordChecker(groupNo) && new Group(groupNo, 10).CheckGroupNo(groupNo))
                    {
                        group = new Group(groupNo, 10);
                        Console.WriteLine("Group created successfully!");

                       
                        while (true)
                        {
                            Console.WriteLine("\nGroup Menu:");
                            Console.WriteLine("1. Show all students");
                            Console.WriteLine("2. Get student by id");
                            Console.WriteLine("3. Add student");
                            Console.WriteLine("0. Quit");

                            string groupChoice = Console.ReadLine();

                            if (groupChoice == "1")
                            {
                                foreach (var student in group.GetAllStudents())
                                {
                                    student.StudentInfo();
                                }
                            }
                            else if (groupChoice == "2")
                            {
                               
                                Console.WriteLine("Enter student ID:");
                                int id = int.Parse(Console.ReadLine());
                                var student = group.GetStudent(id);
                                if (student != null)
                                    student.StudentInfo();
                                else
                                    Console.WriteLine("Student not found.");
                            }
                            else if (groupChoice == "3")
                            {
                               
                                Console.WriteLine("Enter student fullname:");
                                string studentName = Console.ReadLine();
                                Console.WriteLine("Enter student points:");
                                int points = int.Parse(Console.ReadLine());

                                var student = new Student(studentName, points);
                                if (group.AddStudent(student))
                                    Console.WriteLine("Student added successfully!");
                                else
                                    Console.WriteLine("Unable to add student, group limit reached.");
                            }
                            else if (groupChoice == "0")
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }


}

