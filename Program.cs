using System;

namespace Encapsulationproperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Encapsulation and Property******");

            // Creating an instance of the Student class using the default constructor
            Student student1 = new Student();
            student1.Name = "Taha";
            student1.Surname = "BÖREKCİ";
            student1.StudentNo = 259;
            student1.ClassNo = 1;

            // Incrementing the class number using the classplus method
            student1.ClassPlus();

            // Displaying the information of the student using the Studentex method
            student1.StudentEx();

            // Creating another instance of the Student class using the parameterized constructor
            Student student2 = new Student("Taha", "BÖREKCİ", 1, 256);

            // Decrementing the student number using the classeksi method
            student2.ClassEksi();
            student2.ClassEksi();

            // Displaying the information of the second student
            student2.StudentEx();
        }
    }

    // Student class definition
    class Student
    {
        // Private fields for encapsulation
        private string name;
        private string surname;
        private int studentNo;
        private int classNo;
        private int schoolNo;

        // Public properties with encapsulation
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get => surname;
            set => surname = value;
        }

        public int StudentNo
        {
            get => studentNo;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Class number cannot be less than 1");
                    studentNo = 1;
                }
                else
                {
                    studentNo = value;
                }
            }
        }

        public int ClassNo { get => classNo; set => classNo = value; }

        // Parameterized constructor for initializing object with provided values
        public Student(string name, string surname, int studentNo, int classNo)
        {
            Name = name;
            Surname = surname;
            StudentNo = studentNo;
            ClassNo = classNo;
        }

        // Default constructor needed for the Studentex method not to produce errors
        public Student() { }

        // Method to display student information
        public void StudentEx()
        {
            Console.WriteLine("*****Student Information******");
            Console.WriteLine("Student Name        : {0}", this.Name);
            Console.WriteLine("Student Surname     : {0}", this.Surname);
            Console.WriteLine("Student StudentNo   : {0}", this.StudentNo);
            Console.WriteLine("Student ClassNo     : {0}", this.ClassNo);
        }

        // Method to increment the class number
        public void ClassPlus()
        {
            this.ClassNo = this.ClassNo + 1;
        }

        // Method to decrement the student number
        public void ClassEksi()
        {
            this.StudentNo = this.StudentNo - 1;
        }
    }
}
