using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CoursePersonAPI.Model;

namespace CoursePersonAPI.Model
{ 
    public class CoursePersonDataStore
    {
        private static CoursePersonDataStore _instance;

        public static CoursePersonDataStore Instance()
        {
            if(_instance == null)
            {
                _instance = new CoursePersonDataStore();
            }
            return _instance;
        }

        //For Course
        private List<Course> _Courses; //field

        private static List<Course> SeedOfCourse()
        {
            List<Course> SeedOfCourse = new List<Course>();
            SeedOfCourse.Add(new Course
            {
                CourseID = 1,
                CourseName = "C-01",
                MaxNumber = 20,
                CourseCredit = 60
            });
            SeedOfCourse.Add(new Course
            {
                CourseID = 2,
                CourseName = "C-02",
                MaxNumber = 21,
                CourseCredit = 61
            });
            SeedOfCourse.Add(new Course
            {
                CourseID = 3,
                CourseName = "C-03",
                MaxNumber = 22,
                CourseCredit = 62
            });
            return SeedOfCourse;
        }

        //GET()
        public List<Course> GetAllCourses()
        {
            return _Courses;
        }

        //GET(id)
        public Course GetCourseByID(int InputID)
        {
            Course result = _Courses.FirstOrDefault((Course arg) => arg.CourseID == InputID);
            return result;
        }

        //POST()
        public bool AddCourse(Course newCourse)
        {
            bool resultFlag = false;
            Course result = _Courses.FirstOrDefault((Course arg) => arg.CourseID == newCourse.CourseID);
            if (result == null) //Not found
            {
                _Courses.Add(newCourse);
                resultFlag = true;
            }
            return resultFlag;
        }

        //PUT()
        public bool UpdateCourse(int InputID, Course updateCourse)
        {
            bool resultFlag = false;
            Course result = _Courses.FirstOrDefault((Course arg) => arg.CourseID == InputID);
            if (result != null)
            {
                result.CourseName = updateCourse.CourseName;
                result.MaxNumber = updateCourse.MaxNumber;
                result.CourseCredit = updateCourse.CourseCredit;
                resultFlag = true;
            }
            return resultFlag;
        }

        //Delete(id)
        public bool DeleteCourse(int InputID)
        {
            bool resultFlag = false;
            Course result = _Courses.FirstOrDefault((Course arg) => arg.CourseID == InputID);
            if(result != null)
            {
                _Courses.Remove(result);
                resultFlag = true;
            }
            return resultFlag;
        }
        //End of Course

        //For Student
        private List<Student> _Students;    //field

        private static List<Student> SeedOfStudent()
        {
            List<Student> SeedOfStudent = new List<Student>();
            SeedOfStudent.Add(new Student
            {
                StudentID = 1,
                StudentName = "S-N1",
                StudentFee = 5000,
                StudentCredit = 60
            });
            SeedOfStudent.Add(new Student
            {
                StudentID = 2,
                StudentName = "S-N2",
                StudentFee = 6000,
                StudentCredit = 70
            });
            SeedOfStudent.Add(new Student
            {
                StudentID = 3,
                StudentName = "S-N3",
                StudentFee = 7000,
                StudentCredit = 80
            });
            return SeedOfStudent;
        }

        //Get()
        public List<Student> GetAllStudents()
        {
            return _Students;
        }

        //Get(id)
        public Student GetStudentByID(int InputID)
        {
            Student result = _Students.FirstOrDefault((Student arg) => arg.StudentID == InputID);
            return result;
        }

        //POST()
        public bool addStudent(Student newStudent)
        {
            bool resultFlag = false;
            Student result = _Students.FirstOrDefault((Student arg) => arg.StudentID == newStudent.StudentID);
            if (result == null) //not found
            {
                _Students.Add(newStudent);
                resultFlag = true;
            }
            return resultFlag;
        }
        //PUT()
        public bool updateStudent(int InputID, Student updateStudent)
        {
            bool resultFlag = false;
            Student result = _Students.FirstOrDefault((Student arg) => arg.StudentID == InputID);
            if (result != null)
            {
                result.StudentName = updateStudent.StudentName;
                result.StudentFee = updateStudent.StudentFee;
                result.StudentCredit = updateStudent.StudentCredit;
                resultFlag = true;
            }
            return resultFlag;
        }
        //Delete(id)
        public bool deleteStudent(int InputID)
        {
            bool resultFlag = false;
            Student result = _Students.FirstOrDefault((Student arg) => arg.StudentID == InputID);
            if (result != null)
            {
                _Students.Remove(result);
                resultFlag = true;
            }
            return resultFlag;
        }
        //End of Student
        //For Lecturer
        private List<Lecturer> _Lectures;   //field

        private static List<Lecturer> SeedOfLecutrer()
        {
            List<Lecturer> SeedOfLecutrer = new List<Lecturer>();
            SeedOfLecutrer.Add(new Lecturer
            {
                LecturerID = 1,
                LecturerName = "L-NA",
                LecturerPayroll = "Sallary $100",
                MessageFromStudent = "This is Lecture A."
            });
            SeedOfLecutrer.Add(new Lecturer
            {
                LecturerID = 2,
                LecturerName = "L-NB",
                LecturerPayroll = "Sallary $200",
                MessageFromStudent = "This is Lecture B."
            });
            SeedOfLecutrer.Add(new Lecturer
            {
                LecturerID = 3,
                LecturerName = "L-NC",
                LecturerPayroll = "Sallary $300",
                MessageFromStudent = "This is Lecture C."
            });
            return SeedOfLecutrer;
        }

        //PUT()
        public List<Lecturer> GetAllLecturers()
        {
            return _Lectures;
        }

        //PUT(ID)
        public Lecturer GetLecturerByID(int InputID)
        {
            Lecturer result = _Lectures.FirstOrDefault((Lecturer arg) => arg.LecturerID == InputID);
            return result;
        }

        //POST()
        public bool AddLecturer(Lecturer newLecturer)
        {
            bool resultFlag = false;
            Lecturer result = _Lectures.FirstOrDefault((Lecturer arg) => arg.LecturerID == newLecturer.LecturerID);
            if (result == null) //not found
            {
                _Lectures.Add(newLecturer);
                resultFlag = true;
            }
            return resultFlag;
        }

        //PUT()
        public bool UpdateLecturer(int InputID, Lecturer updateLecturer)
        {
            bool resultFlag = false;
            Lecturer result = _Lectures.FirstOrDefault((Lecturer arg) => arg.LecturerID == InputID);
            if(result != null)
            {
                result.LecturerName = updateLecturer.LecturerName;
                result.LecturerPayroll = updateLecturer.LecturerPayroll;
                result.LecturerPayroll = updateLecturer.MessageFromStudent;
                resultFlag = true;
            }
            return resultFlag;
        }

        //Delete(ID)
        public bool DeleteLecturer(int InputID)
        {
            bool resultFlag = false;
            Lecturer result = _Lectures.FirstOrDefault((Lecturer arg) => arg.LecturerID == InputID);
            if (result != null)
            {
                _Lectures.Remove(result);
                resultFlag = true;
            }

            return resultFlag;
        }
        //End of Lecturer

        //Constructor
        private CoursePersonDataStore()
        {
            _Courses = SeedOfCourse();
            _Students = SeedOfStudent();
            _Lectures = SeedOfLecutrer();
        }

    }
}
