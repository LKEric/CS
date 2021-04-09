using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class People
    {
        private string name;

        public People()
        {
        }

        public string Name { get => name; set => name = value; }
    }
    class Student:People
    {
        private int SID;
        private string Khoa;
        private float DiemTB;

        public int SID1 { get => SID; set => SID = value; }
   
        public string Khoa1 { get => Khoa; set => Khoa = value; }
        public float DiemTB1 { get => DiemTB; set => DiemTB = value; }

        public Student(int sID, string tenSV, string khoa, float diemTB)
        {
            SID = sID;
            Name = tenSV;
            Khoa = khoa;
            DiemTB = diemTB;
        }
        public Student()
        {
            SID = 1;
            Name = "Dat";
            Khoa = "SE";
            DiemTB = 7;

        }
        public Student(Student std)
        {
            SID = std.SID;
            Name = std.Name;
            Khoa = std.Khoa;
            DiemTB = std.DiemTB;
        }
        public void Show()
        {
            Console.WriteLine($"MSSV:{this.SID}");
            Console.WriteLine($"Ten SV:{this.Name}");
            Console.WriteLine($"Khoa:{this.Khoa}");
            Console.WriteLine($"Diem TB:{this.DiemTB}");
        }
        public void Nhap(int n,List<Student> DSSV )
        {
           
            
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            for (int i = 0; i < n; i++)
            {
                Student s = new Student();
                Console.Write("Nhap MaSV {0}:", i + 1);
                s.SID1 = int.Parse(Console.ReadLine());
                Console.Write("Ho ten SV:");
                s.Name = Console.ReadLine();
                Console.Write("Nhap khoa:");
                s.Khoa1 = Console.ReadLine();
                Console.Write("Nhap Diem TB:");
                s.DiemTB1 = float.Parse(Console.ReadLine());
                DSSV.Add(s);
            }
        }

    }
    class Tester
    {
        static void Main(string[] args)
        {
            List<Student> DSSV=new List<Student>();
            int n;
            Console.Write("Nhap so luong SV:");
            n = int.Parse(Console.ReadLine());
            
            Student st = new Student();
            st.Nhap(n, DSSV);
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            for(int i= 0;i < n; i++)
            {
                DSSV[i].Show();

            }
                
            Console.ReadLine();
        }
    
    }
}
