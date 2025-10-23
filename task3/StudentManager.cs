namespace task3
{
    class StudentManager
    {
        public List<Student> students;
        public List<Course> courses;
        public List<Instructor> instructors;

        public StudentManager()
        {
            students = new List<Student>();
            courses = new List<Course>();
            instructors = new List<Instructor>();
        }
        public void AddStudent(Student student)
        {
            if (students.Count() == 0)
            {
                students.Add(student);
                Console.WriteLine("Student added successfully");
            }
            else { 
                for (int i = 0; i < students.Count(); i++)
                {
                    if (students[i].student_id == student.student_id)
                        Console.WriteLine("Invaild , The student has already been added");
                    else
                    {
                        students.Add(student);
                        Console.WriteLine("Student added successfully");

                    }
                }
            }

        }
        public void AddInstructor(Instructor instructor)
        {
            if(instructors.Count() == 0)
            {
                instructors.Add(instructor);
                Console.WriteLine("Instructor added successfully");
            }
            else
            {
                for (int i = 0; i < instructors.Count(); i++)
                {
                    if (instructors[i].instructor_id == instructor.instructor_id)
                        Console.WriteLine("Invaild , The instructor has already been added");
                    else
                    {
                        instructors.Add(instructor);
                        Console.WriteLine("Instructor added successfully");

                    }
                }
            }

                
        }
        public void AddCourse(Course course)
        {
            if(courses.Count() == 0)
            {
                courses.Add(course);
                Console.WriteLine("Course added successfully");
            }
            else
            {
                for (int i = 0; i < courses.Count(); i++)
                {
                    if (courses[i].course_id == course.course_id)
                        Console.WriteLine("Invaild , The course has already been added");
                    else
                    {
                        courses.Add(course);
                        Console.WriteLine("Course added successfully");

                    }
                }
            }
                
        }
        public Student FindStudent(int id)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].student_id == id)
                    return students[i];

            }
            return null;
        }

        public Course FindCourse(int id)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].course_id == id)
                    return courses[i];
            }
            return null;
        }

        public Instructor FindInstructor(int id)
        {
            for (int i = 0; i < instructors.Count; i++)
            {
                if (instructors[i].instructor_id == id)
                    return instructors[i];
            }
            return null;
        }

        public void EnrollStudentInCourse(int studentId, int courseId)
        {
            Student student = FindStudent(studentId);
            Course course = FindCourse(courseId);

            if (student == null)
            {
                Console.WriteLine("Student not found!");
                return;
            }
            if (course == null)
            {
                Console.WriteLine("Course not found!");
                return;
            }

            student.Enroll(course);
        }

        public void ShowAllStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }

            for (int i = 0; i < students.Count; i++)
            {
                students[i].PrintDetails();
             
            }
        }

        public void ShowAllCourses()
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("No courses available.");
                return;
            }

            for (int i = 0; i < courses.Count; i++)
            {
                courses[i].PrintDetails();
               
            }
        }

        public void ShowAllInstructors()
        {
            if (instructors.Count == 0)
            {
                Console.WriteLine("No instructors available.");
                return;
            }

            for (int i = 0; i < instructors.Count; i++)
            {
                instructors[i].PrintDetails();
               
            }
        }
        public bool DeletStudent(int studentId)
        {
            Student check = FindStudent(studentId);
            if (check != null)
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].student_id == check.student_id)
                        students.RemoveAt(i);
                     return true;

                }
                
            }
            return false;



        }
        public void CheckEnroll(int studentId, int courseId)
        {
            Student student = FindStudent(studentId);
            Course course = FindCourse(courseId);

            if (student == null)
            {
                Console.WriteLine("Student not found!");
                return;
            }
            if (course == null)
            {
                Console.WriteLine("Course not found!");
                return;
            }
            for (int i = 0; i < student.courses.Count; i++)
            {
                if (student.courses[i] == course)
                {
                    Console.WriteLine($"{student.student_name} is enrolled in {course.course_title}");

                    return;
                }
            }
            Console.WriteLine($"{student.student_name} is NOT enrolled in {course.course_title}");
        }
        public string ReturnTnstructor(string title)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].course_title == title)
                    return ($"Instructor name { courses[i].instructor.instructor_name}");
            }
            return  "Course not found";
        }
    }
    
}
