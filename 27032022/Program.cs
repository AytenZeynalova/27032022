using System;

namespace _27032022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qrup yaratmaq ucun qrup nomresi daxil etmelisiniz:");
            string NO=Console.ReadLine();
            //No dəyəri 2 böyük hərflə başlamalı və sonrasında 3 rəqəm olmalıdır (BP202 kimi)

            //if (NO.Length == 5 && char.IsUpper(NO[0]) && char.IsUpper(NO[1]) && char.IsDigit(NO[2]) && char.IsDigit(NO[3]) && char.IsDigit(NO[4]))
            //{
            //    Console.WriteLine(NO);

            //}
            //else

            //{
            //    Console.WriteLine("daxil edilen qrup nomresi 2 boyuk herfle baslamalidir ve davaminda 3 reqem olmalidir:");
            //    NO = Console.ReadLine();

            //}
            //    IF ELSE ILE ALINDIRA BILMEDIM FOR IF ELSE ILE YAZMAQ OLARMI? 




            while (NO.Length != 5 || !char.IsUpper(NO[0]) || !char.IsUpper(NO[1]) || !char.IsDigit(NO[2]) || !char.IsDigit(NO[3]) || !char.IsDigit(NO[4]))
            {
                Console.WriteLine("daxil edilen qrup nomresi 2 boyuk herfle baslamalidir ve davaminda 3 reqem olmalidir:");
                NO = Console.ReadLine();
            }

            //StudentLimit 0-dan kiçik və 20-dən böyük ola bilməz

            //int studentLimit = 0;
            int studentLimit;
            Console.WriteLine("limiti daxil edin:");
            studentLimit = Convert.ToInt32(Console.ReadLine());

            while(studentLimit<0 || studentLimit > 20)
            {
                Console.WriteLine("telebe limiti 0-dan kicik, 20-den boyuk olmamalidir.Limiti daxil edin:");
                studentLimit = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine("Limit:",studentLimit);

            Group group = new Group(NO, studentLimit);

            

            

            //studentLimit = Convert.ToInt32(Console.ReadLine());

            //if (studentLimit > 0 && studentLimit <= 20)
            //{
            //    Console.WriteLine("true");

            //}
            //else if(studentLimit<0 || studentLimit>20)
            //    {
            //        Console.WriteLine("limit daxil et;");
            //        Console.WriteLine(studentLimit);

            //    }

            Console.WriteLine("1. Tələbə əlavə et");
            Console.WriteLine("2.Bütün tələbələrə bax");
            Console.WriteLine("3. Tələbələr üzrə axtarış et");
            Console.WriteLine("0. Proqramı bitir");

            string selected = Console.ReadLine();
            if (selected == "1")
            {
                if(group.Students.Length+1<=studentLimit)
                {
                    Console.WriteLine("Telebe elave et:");
                    string Fullname = Console.ReadLine();
                    NO = Console.ReadLine();
                    int avgpoint = Convert.ToInt32(Console.ReadLine());
                    Student student = new Student(Fullname);
                    student.FullName = Fullname;
                    student.GroupNo = NO;
                    student.AvgPoint = avgpoint;
                    group.AddStudents(student);
                }
                else
                {
                    Console.WriteLine("limiti kecdiniz");

                }

            }
            selected = Console.ReadLine();
            if (selected == "2")
            {
                group.GetInfo();
            }





        }
    }
}
