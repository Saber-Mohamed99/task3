namespace task3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager =new StudentManager();
            bool flage = true;
            
            while (flage) {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Instructor");
                Console.WriteLine("3. Add Course");
                Console.WriteLine("4. Enroll Student in Course");
                Console.WriteLine("5. Show All Students");
                Console.WriteLine("6. Show All Courses");
                Console.WriteLine("7. Show All Instructors");
                Console.WriteLine("8. Find the student by id or name");
                Console.WriteLine("9. Find the course by id or name");
                Console.WriteLine("10. Delet student");
                Console.WriteLine("11. Check if the student enrolled in specific course");
                Console.WriteLine("12. Return the instructor name by course name");
                Console.WriteLine("13. Exit");
               
                int cheak = int.Parse(Console.ReadLine());   
            switch (cheak) 
            {
                    case 1:
                        Console.WriteLine("Enter id student");
                        int s_id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter age student");
                        int s_age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter name student");
                        string s_name = Console.ReadLine();
                        Student st = new Student(s_id,s_name,s_age);
                        manager.AddStudent(st);
                        break;
                    case 2:
                        Console.WriteLine("Enter id instructor");
                        int i_id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter specialization instructor");
                        string specialization = Console.ReadLine();
                        Console.WriteLine("Enter name instructor");
                        string i_name = Console.ReadLine();
                        Instructor ins = new Instructor(i_id,i_name, specialization);
                        manager.AddInstructor(ins);
                        break;
                    case 3:
                        Console.WriteLine("Enter id course");
                        int c_id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter title course");
                        string c_title = Console.ReadLine();
                        Console.WriteLine("Enter id instructor");
                        int i=int.Parse(Console.ReadLine());
                        Instructor x=manager.FindInstructor(i);
                        if (x == null)
                        {
                            Console.WriteLine("The entered instructor is not found");
                        }
                        else
                        {
                            Course co = new Course(c_id, c_title, x);
                            manager.AddCourse(co);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter id course");
                        int courseId=int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter id student");
                        int studentId=int.Parse(Console.ReadLine());
                        manager.EnrollStudentInCourse(studentId, courseId);
                        break;
                    case 5:
                        manager.ShowAllStudents();
                        break;
                    case 6:
                        manager.ShowAllCourses();
                        break;
                    case 7:
                        manager.ShowAllInstructors();
                        break;
                    case 8:
                        Console.WriteLine("Enter id student");
                        int  ids = int.Parse(Console.ReadLine());
                       Student s_find =manager.FindStudent(ids);
                        if (s_find == null) 
                        {
                            Console.WriteLine("Student not found");
                        }
                        else
                        {
                            s_find.PrintDetails();
                        }
                        break;
                    case 9:
                        Console.WriteLine("Enter id course");
                        int idc = int.Parse(Console.ReadLine());
                        Course c_find = manager.FindCourse(idc);
                        if (c_find == null)
                        {
                            Console.WriteLine("Student not found");
                        }
                        else
                        {
                            c_find.PrintDetails();
                        }
                        break;
                    case 10:
                        Console.WriteLine("Enter id student");
                        int id_delet = int.Parse(Console.ReadLine());
                        bool check=manager.DeletStudent(id_delet);
                        if (check)
                        {
                            Console.WriteLine("Student is deleted");
                        }
                        else
                        {
                            Console.WriteLine("Student not found");
                        }
                        break;
                    case 11:
                        Console.WriteLine("Enter id student");
                        int idstudent=int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter id course");
                        int idcourse=int.Parse(Console.ReadLine());
                        manager.CheckEnroll(idstudent, idcourse);
                        break;
                    case 12:
                        Console.WriteLine("Enter title course");
                        string title = Console.ReadLine();
                        Console.WriteLine( manager.ReturnTnstructor(title));
                        break;
                    default:
                        flage = false;
                        break;


                }

            }
            




        }
}
    
}
