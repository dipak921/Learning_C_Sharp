using System;
using System.Collections.Generic;

namespace GenericMiniProject
{
    class Student123
    {
        public int Id;
        public string Name;
        public int Age;
        public string Mobile;
    }

    class Mini_Project_using_generic_collection
    {
        static List<Student123> students = new List<Student123>();
        static Dictionary<int, string> courses = new Dictionary<int, string>();
        static HashSet<string> enrollments = new HashSet<string>();
        static Queue<int> admissionQueue = new Queue<int>();
        static Stack<string> undoStack = new Stack<string>();

        // MODULE 1 – STUDENT
        static void AddStudent()
        {
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());

            foreach (var s in students)
            {
                if (s.Id == id)
                {
                    Console.WriteLine("Student ID already exists!");
                    return;
                }
            }

            Student123 st = new Student123();
            st.Id = id;
            Console.Write("Enter Name: ");
            st.Name = Console.ReadLine();
            Console.Write("Enter Age: ");
            st.Age = int.Parse(Console.ReadLine());
            Console.Write("Enter Mobile: ");
            st.Mobile = Console.ReadLine();

            students.Add(st);
            Console.WriteLine("Student Added Successfully");
        }

        static void ViewStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found");
                return;
            }

            foreach (var s in students)
            {
                Console.WriteLine($"{s.Id} | {s.Name} | {s.Age} | {s.Mobile}");
            }
        }

        static void SearchStudent()
        {
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());

            foreach (var s in students)
            {
                if (s.Id == id)
                {
                    Console.WriteLine($"{s.Id} | {s.Name} | {s.Age} | {s.Mobile}");
                    return;
                }
            }
            Console.WriteLine("Student Not Found");
        }

        static void DeleteStudent()
        {
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == id)
                {
                    undoStack.Push("STUDENT:" + students[i].Id);
                    students.RemoveAt(i);
                    Console.WriteLine("Student Deleted");
                    return;
                }
            }
            Console.WriteLine("Student Not Found");
        }

        // MODULE 2 – COURSE
        static void AddCourse()
        {
            Console.Write("Enter Course Code: ");
            int code = int.Parse(Console.ReadLine());

            if (courses.ContainsKey(code))
            {
                Console.WriteLine("Course already exists");
                return;
            }

            Console.Write("Enter Course Name: ");
            string name = Console.ReadLine();
            courses.Add(code, name);
            Console.WriteLine("Course Added");
        }

        static void ViewCourses()
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("No courses available");
                return;
            }

            foreach (var c in courses)
            {
                Console.WriteLine($"{c.Key} - {c.Value}");
            }
        }

        // MODULE 3 – ENROLLMENT
        static void EnrollStudent()
        {
            Console.Write("Enter Student ID: ");
            int sid = int.Parse(Console.ReadLine());
            Console.Write("Enter Course Code: ");
            int cid = int.Parse(Console.ReadLine());

            if (!courses.ContainsKey(cid))
            {
                Console.WriteLine("Invalid Course");
                return;
            }

            bool studentExists = false;
            foreach (var s in students)
            {
                if (s.Id == sid)
                {
                    studentExists = true;
                    break;
                }
            }

            if (!studentExists)
            {
                Console.WriteLine("Invalid Student");
                return;
            }

            string key = sid + "-" + cid;
            if (!enrollments.Add(key))
            {
                Console.WriteLine("Duplicate Enrollment Not Allowed");
            }
            else
            {
                undoStack.Push("ENROLL:" + key);
                Console.WriteLine("Enrollment Successful");
            }
        }

        static void ViewEnrollments()
        {
            if (enrollments.Count == 0)
            {
                Console.WriteLine("No enrollments");
                return;
            }

            foreach (var e in enrollments)
            {
                Console.WriteLine(e);
            }
        }

        // MODULE 4 – QUEUE
        static void AddToQueue()
        {
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());
            admissionQueue.Enqueue(id);
            Console.WriteLine("Student Added to Queue");
        }

        static void ProcessAdmission()
        {
            if (admissionQueue.Count == 0)
            {
                Console.WriteLine("Queue Empty");
                return;
            }

            int id = admissionQueue.Dequeue();
            Console.WriteLine("Processing Student ID: " + id);
        }

        // MODULE 5 – UNDO
        static void UndoOperation()
        {
            if (undoStack.Count == 0)
            {
                Console.WriteLine("Nothing to Undo");
                return;
            }

            string action = undoStack.Pop();
            Console.WriteLine("Undo Operation: " + action);
        }

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n====== STUDENT MANAGEMENT SYSTEM ======");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Add Course");
                Console.WriteLine("6. View Courses");
                Console.WriteLine("7. Enroll Student in Course");
                Console.WriteLine("8. View Enrollments");
                Console.WriteLine("9. Add Student to Admission Queue");
                Console.WriteLine("10. Process Admission");
                Console.WriteLine("11. Undo Last Operation");
                Console.WriteLine("12. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent(); 
                        break;
                    case 2:
                        ViewStudents(); 
                        break;
                    case 3:
                        SearchStudent();
                        break;
                    case 4:
                        DeleteStudent();
                        break;
                    case 5: 
                        AddCourse();
                        break;
                    case 6:
                        ViewCourses(); 
                        break;
                    case 7:
                        EnrollStudent();
                        break;
                    case 8:
                        ViewEnrollments();
                        break;
                    case 9:
                        AddToQueue();
                        break;
                    case 10:
                        ProcessAdmission();
                        break;
                    case 11:
                        UndoOperation();
                        break;
                    case 12: 
                        Console.WriteLine("Exiting Program...");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice"); 
                        break;
                }
            } while (choice != 12);
        }
    }
}