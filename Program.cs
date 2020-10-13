using System;

namespace Задача_из_экзамена
{
    class Student
    {
        public string name;
        public double score;
        public double scorePhilosofy;
        public double scoreProgrammy;
        public double scoreInformation;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] StudentName = new Student[5];
            for (int i = 0; i < StudentName.Length; i++)
            {
                StudentName[i] = new Student();
            }
            StudentName[0].name = "Ilyasov Timur";
            StudentName[0].scorePhilosofy = 5;
            StudentName[0].scoreProgrammy = 4;
            StudentName[0].scoreInformation = 4;
            StudentName[0].score = Math.Round(((StudentName[0].scorePhilosofy + StudentName[0].scoreProgrammy + StudentName[0].scoreInformation) / 3), 2);
            StudentName[1].name = "Ilyasov Leysan";
            StudentName[1].scorePhilosofy = 4;
            StudentName[1].scoreProgrammy = 4;
            StudentName[1].scoreInformation = 4;
            StudentName[1].score = Math.Round(((StudentName[1].scorePhilosofy + StudentName[1].scoreProgrammy + StudentName[1].scoreInformation) / 3), 2);
            StudentName[2].name = "Zifarov Adel";
            StudentName[2].scorePhilosofy = 5;
            StudentName[2].scoreProgrammy = 5;
            StudentName[2].scoreInformation = 4;
            StudentName[2].score = Math.Round(((StudentName[2].scorePhilosofy + StudentName[2].scoreProgrammy + StudentName[2].scoreInformation) / 3), 2);
            StudentName[3].name = "Garaev Ilyas";
            StudentName[3].scorePhilosofy = 5;
            StudentName[3].scoreProgrammy = 5;
            StudentName[3].scoreInformation = 5;
            StudentName[3].score = Math.Round(((StudentName[3].scorePhilosofy + StudentName[3].scoreProgrammy + StudentName[3].scoreInformation) / 3), 2);
            StudentName[4].name = "Galyautdinov Islam";
            StudentName[4].scorePhilosofy = 5;
            StudentName[4].scoreProgrammy = 5;
            StudentName[4].scoreInformation = 5;
            StudentName[4].score = Math.Round(((StudentName[4].scorePhilosofy + StudentName[4].scoreProgrammy + StudentName[4].scoreInformation) / 3), 2);
            Console.Write("Enter the minimal score: ");
            double minScore = double.Parse(Console.ReadLine());
            int a = 0;
            for (int i = 0; i < StudentName.Length; i++)
            {
                if (minScore <= StudentName[i].score)
                {
                    a++;
                    Console.WriteLine($"Name and Last name: {StudentName[i].name} Average score: {StudentName[i].score} ");
                }
            }
            if (a == 0)
            {
                Console.WriteLine("There are no students with such a score!");
            }
        }
    }
}