namespace task3
{
    class Instructor(int instructor_id, string instructor_name, string instructor_specialization)
    {
        public int instructor_id = instructor_id;
        public string instructor_name = instructor_name;
        public string instructor_specialization = instructor_specialization;
        public void PrintDetails()
        {
            Console.WriteLine($"Instructor_Id: {instructor_id}");
            Console.WriteLine($"Name: {instructor_name}");
            Console.WriteLine($"Specialization: {instructor_specialization}");
        }
    }
    
}
