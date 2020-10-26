using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private HashSet<Student> students;

        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            this.students = new HashSet<Student>();
        }

        public int Capacity { get; set; }
        public int Count => this.students.Count;

        public string RegisterStudent(Student student)
        {
            if (this.Count < this.Capacity)
            {
                this.students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }

            return $"No seats in the classroom";

        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student removedStudent = this.students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

            if (removedStudent!=null)
            {
                students.Remove(removedStudent);
                return $"Dismissed student {firstName} {lastName}";
            }

            return $"Student not found";
        }

        public string GetSubjectInfo(string subject)
        {
            StringBuilder sb = new StringBuilder();
            var selectedStudents = students.Where(s => s.Subject == subject);

            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine($"Students:");
            if (selectedStudents.Count()>0)
            {
                foreach (var student in selectedStudents)
                {
                    sb.AppendLine($"{student.FirstName} {student.LastName}");
                   
                }

                return sb.ToString().TrimEnd();
            }

            return $"No students enrolled for the subject";


        }

        public int GetStudentsCount()
        {
            return this.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            Student student = this.students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
            
            return student;
        }
    }
}
