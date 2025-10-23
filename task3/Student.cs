namespace task3
{
    class Student(int student_id, string student_name, int student_age)
    {
        public int student_id = student_id;
        public string student_name = student_name;
        public int student_age = student_age;
        public List<Course> courses = new List<Course>();

        public void PrintDetails()
        {
            Console.WriteLine($"Student_Id: {student_id}");
            Console.WriteLine($"Student_Name: {student_name}");
            Console.WriteLine($"Age: {student_age}");
            Console.WriteLine("courses:");
            for (int i = 0; i < courses.Count(); i++)
            {
                Console.WriteLine(courses[i].course_title);  
            }

        }
        public bool Enroll(Course course)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].course_id == course.course_id)
                {
                    Console.WriteLine($"{student_name} already enrolled in {course.course_title}");
                    return false;
                }
            }

            courses.Add(course);
            Console.WriteLine($"{student_name} enrolled in {course.course_title}");
            return true;
        }
     

    }
    
}
