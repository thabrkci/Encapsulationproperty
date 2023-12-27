namespace Kapsülleme_ve_Property_Kavramı;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("******Kapsülleme Ve Property******");
        Student students = new Student();
        students.Name = "Taha";
        students.Surname = "BÖREKCİ";
        students.Studentno =259;
        students.Classno = 1;
        students.classplus();
        students.Studentex();
        Student studens1 = new Student("Taha","BÖREKCİ",1,256);
        studens1.classeksi();
        studens1.classeksi();
        students.Studentex();



    }



    class Student
    {
      private string name;
      private string surname;
      private int studentno;
      private int classno;


      public string Name
      {
       get {return name;}
       set {name = value;}
      }

      public string Surname {get => surname; set => surname = value;}
      public int Studentno 
      {get => studentno; 
       set
       {
        if(value <1)
        {
            Console.WriteLine("Sınıf en az 1 olabilir");
            studentno=1;
        }
        else 
        studentno = value;

       } 
       }
      public int Classno {get => classno; set => classno = value;}


      public Student(string İsim, string soyisim, int ögrencino, int sınıf)
      {
        İsim = Name;
        soyisim = Surname;
        ögrencino = Studentno;
        sınıf = Classno;
      }

      public Student(){}


      public void Studentex()
      {
       Console.WriteLine("*****Student Ex******");
       Console.WriteLine("Student Name        :{0}", this.Name);
       Console.WriteLine("Student Surname        :{0}", this.Surname);
       Console.WriteLine("Student Studentno        :{0}", this.Studentno);
       Console.WriteLine("Student Classno        :{0}", this.Classno);
      }
      

      public void classplus()
      {
       this.Classno = this.Classno +1;

      }

      public void classeksi()
      {
       this.Studentno = this.Studentno -1;

      }



    }

  

   
    
}
