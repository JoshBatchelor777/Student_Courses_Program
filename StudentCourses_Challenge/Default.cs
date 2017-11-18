using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCourses_Challenge
{
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /* FUNCTION RULES 
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */
        private void assignment1Button_Click(object sender, EventArgs e)
        {
            // Course List, with a nested Students List per Course Member.
            // AGAIN, the syntax of nesting list members, let alone whole lists, 
            // was never covered or referenced.
            var courses = new List<Course>
            {
                new Course { CourseId = 001, Name = "Math20", Students = new List<Student>() {
                    new Student { StudentId = 001, Name = "David" },
                    new Student { StudentId = 002, Name = "Laura" }}},
                new Course { CourseId = 002, Name = "Java II", Students = new List<Student>() {
                    new Student { StudentId = 003, Name = "Reid"},
                    new Student { StudentId = 004, Name = "Gingell"}}},
                new Course { CourseId = 003, Name = "Advanced Dead Lifting Techniques", Students = new List<Student>() {
                    new Student { StudentId = 005, Name = "Dallas"},
                    new Student { StudentId = 006, Name = "Josh"}}}
            };

            // var Course becomes a new instance of the Course object, 
            // and iterates the "courses" collection (List).
            foreach (var course in courses)
            {
                resultLabel.Text += String.Format("Course: {0} - {1}\n",
                    course.CourseId, course.Name);

                // I don't know how I was supposed to know you can specify a list to an object
                // as seen below in: "course.Students". I get it, but this completely came out of nowhere.
                foreach (var student in course.Students)
                {
                    resultLabel.Text += String.Format("Student: {0} - {1}\n",
                        student.StudentId, student.Name);
                }
            }
        }


        /* FUNCTION RULES
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */
        private void assignment2Button_Click(object sender, EventArgs e)
        {
            // This is layed out so hiedeously because the syntax of building
            // these collections is Extremely confusing so far.
            var students = new Dictionary<int, Student>()
            {
                { 001, new Student() { // Dictionary
                    StudentId = 007, Name = "Mike Stoklasa", Courses = new List<Course> { // List
                            new Course { CourseId = 004, Name = "Filmography" },
                            new Course { CourseId = 005, Name = "Theatre" }
                        }
                    }
                },
                { 002, new Student() { // Dictionary
                    StudentId = 008, Name = "Jay Baumen", Courses = new List<Course> { // List
                            new Course { CourseId = 004, Name = "Debate" },
                            new Course { CourseId = 005, Name = "Cinematography" }
                        }
                    }
                },
                { 003, new Student() { // Dictionary
                    StudentId = 009, Name = "Rich Evans", Courses = new List<Course> { // List
                            new Course { CourseId = 004, Name = "Acting" },
                            new Course { CourseId = 005, Name = "Storyboarding" }
                        }
                    }
                }
            };

            foreach (var student in students)
            {
                // With an instance of a formatted print out, dictionaries are referenced
                // by the new object followed by: .Key and .Value.
                // Value must be followed by an implcit object property.
                resultLabel.Text += String.Format("Student: {0} - {1}\n",
                    student.Key, student.Value.Name);
                // "student.Value.Courses" because I'm targeting the 2nd part of the dictionary.
                foreach (var course in student.Value.Courses) 
                {
                    resultLabel.Text += String.Format("Course: {0} - {1}\n",
                    course.CourseId, course.Name);
                }
            }

        }

        /* FUNCTION RULES
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */
        private void assignment3Button_Click(object sender, EventArgs e)
        {
            // Creating a new instance of Student this way is just a shorter way of laying out a 
            // list or dictionary. I can apply the new instance, AND it's 
            // locally defined properties, to a list.
            Student student = new Student();
            student.StudentId = 008;
            student.Name = "Frooby";

            // Student Class needs a definition for "Enrollments". It needs to have a list property
            // so it can be invoked by new instances of Student, and thus stored into new list here...
            student.Enrollments = new List<Enrollment>
            {
                // Enrollment applies to a students. A new student instance is already defined in a 
                // local space, above. The list needs to include a subsequent course list.
                // The Course property of Enrollment, being a pointer to the Course Class, is
                // instantiated as a new member of the "Enrollments" list. 
                new Enrollment { Grade = 0.03, Course = new Course { CourseId = 003, Name = "Advanced Dead Lifting Techniques" }},
                new Enrollment { Grade = 98.7, Course = new Course { CourseId = 002, Name = "Java II" }} 
            };

            // Instead of starting with a foreach Statement to print to the resultLabel,
            // I can just print out the local student instance's info straight away, then 
            // iterate throught my list and print per condition.
            resultLabel.Text += String.Format("Student: {0} - {1}\n",
                student.StudentId, student.Name);
            foreach (var enrollment in student.Enrollments)
            {
                // In the format place holders, you must specifiy the new enrollment object, then 
                // target the Member (Enrollment or Course in this case), THEN a pertinate property
                // can be targetted.
                resultLabel.Text += String.Format("Course: {0} - {1}\n" + "{2}",
                    enrollment.Course.CourseId, enrollment.Course.Name, enrollment.Grade);
                if (enrollment.Grade < 55)
                    resultLabel.Text += ". . . FAILING!!\n";
                else
                    resultLabel.Text += ". . . Passing!\n";
            }
        }


        // Bonus Reset button!
        private void resetButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
        }

        // Bonus Exit button!
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
