namespace task3
{
    class Course(int course_id, string course_title, Instructor instructor)
    {
        public int course_id = course_id;
        public string course_title = course_title;
        public Instructor instructor = instructor;
        public void PrintDetails()
        {
            Console.WriteLine($"Course_Id: {course_id}");
            Console.WriteLine($"Title: {course_title}");
            Console.WriteLine($"Instructor: {instructor.instructor_name}");
        }
       
    }
    
}
