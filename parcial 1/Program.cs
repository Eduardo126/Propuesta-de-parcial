using System;
using System.Collections;

namespace parcial_1
{
    class Program
    {
        static void Main()
        {
            bool repit = true;
            do
            {
                int numberStudents;
                string firstname, lastname;
                double grade1, grade2, grade3;
                ArrayList list = new ArrayList();

                Console.Write("Ingrese el numero de estudiantes: ");
                numberStudents = int.Parse(Console.ReadLine());
                Console.WriteLine();

                for (int i = 0; i < numberStudents; i++)
                {
                    Console.Write("Nombres: ");
                    firstname = Console.ReadLine();
                    Console.Write("Apellidos:");
                    lastname = Console.ReadLine();
                    Console.Write("Primer nota: ");
                    grade1 = double.Parse(Console.ReadLine());
                    Console.Write("Segunda nota: ");
                    grade2 = double.Parse(Console.ReadLine());
                    Console.Write("Terca nota: ");
                    grade3 = double.Parse(Console.ReadLine());


                    list.Add(new Students()
                    {
                        firstname = firstname,
                        lastname = lastname,
                        grade1 = grade1,
                        grade2 = grade2,
                        grade3 = grade3,
                    });
                    Console.WriteLine(" =================================== ");
                    Console.WriteLine("");
                }

                foreach (Students st in list)
                {
                    Console.WriteLine("* " + st.ReturnInfo());
                    double prom = st.ReturnGrades();
                    Console.WriteLine("Su promedio de notas es: {0}", prom);
                    Console.WriteLine((prom >= 6.0)? " Aprobado" : " Reprobado" );
                }
                Console.WriteLine();

                bool question;
                do
                {
                    Console.Write("Si desea finalizar el programa escriba 'S', de los contrario escriba 'N' ");
                    string response = Console.ReadLine();
                    switch (response)
                    {
                        case "S":
                        case "s":
                            repit = false;
                            question = false;
                            break;
                        case "N":
                        case "n":
                            repit = false;
                            question = false;
                            break;
                        default:
                            Console.WriteLine("Opcion incorrecta");
                            question = true;
                            break;

                    }
                } while (question);

            } while (repit);
            Console.WriteLine("Programar finalizada");
        }
        public class Students
        {
            private string _firstname;
            private string _lastname;
            private double _grade1;
            private double _grade2;
            private double _grade3;

            public string firstname
            {
                get => _firstname;
                set => _firstname = value;
            }
            public string lastname
            {
                get => _lastname;
                set => _lastname = value;
            }
            public double grade1
            {
                get => _grade1;
                set => _grade1 = value;
            }
            public double grade2
            {
                get => _grade2;
                set => _grade2 = value;
            }
            public double grade3
            {
                get => _grade3;
                set => _grade3 = value;
            }

            public string ReturnInfo() => _firstname + " " + _lastname;

            public double ReturnGrades() => (_grade1 * .3) + (_grade1 * .3) + (_grade3 * .4);
        }
    }
}
