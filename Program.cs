using System;

using System.Collections.Generic;

using System.Linq;

using System.Security.Cryptography;

using System.Text;

using System.Threading.Tasks;



namespace kk_oraimunka

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Random r = new Random();

            Console.WriteLine("Adja meg a matrix oszlopainak számát: ");

            int oszlop = int.Parse(Console.ReadLine());



            Console.WriteLine();



            Console.WriteLine("Adja meg a matrix sorainak a számát: ");

            int sor = int.Parse(Console.ReadLine());
            double avg = 0;
            bool van_e_benne = false;


            List<int> paros = new List<int>();
            List<int> paratlan = new List<int>();
            List<int> osszesszam = new List<int>();

            int[,] matrix2 = new int[sor, oszlop];
            int[,] matrix = new int[sor, oszlop];



            Console.WriteLine();



            Console.WriteLine("A létrehozott mátrix: ");



            Console.WriteLine();



            for (int i = 0; i < sor; i++)

            {

                for (int j = 0; j < oszlop; j++)

                {

                    matrix[i, j] = r.Next(1, 21);

                    matrix2[i, j] = matrix[i, j];



                    Console.Write(matrix[i, j] + " ");

                    avg += matrix[i, j];

                    if (matrix[i, j] == 12)

                        van_e_benne = true;

                    osszesszam.Add(matrix[i, j]);

                    if (matrix[i, j] % 2 == 0)

                        paros.Add(matrix[i, j]);

                    else

                        paratlan.Add(matrix[i, j]);

                }



                Console.WriteLine();

            }

            Console.WriteLine();

            Console.WriteLine("***************");

            Console.WriteLine();

            int megadottszam = 1;

            while (megadottszam != 0)

            {


                Console.WriteLine("1. A mátrix minimum eleme");
                Console.WriteLine("2. A mátrix maximum eleme");
                Console.WriteLine("3. A mátrix átlaga");
                Console.WriteLine("4. Található-e 12 a mátrixban");
                Console.WriteLine("5. A mátrix sorai rendezve növekvő sorrendbe");
                Console.WriteLine("6. A mátrix sorai rendezve csökkenő sorrendbe");
                Console.WriteLine("7. A mátrix páros és páratlan számok");
                Console.WriteLine("0. Kilépés");

                Console.WriteLine();



                Console.Write("Kérem válasszon egy menüpontot: ");
                megadottszam = int.Parse(Console.ReadLine());
                Console.WriteLine();



                switch (megadottszam)

                {

                    case 1:

                        int min = matrix.Cast<int>().Min();
                        Console.WriteLine("Legkisebb szám: " + min);
                        Console.WriteLine("***************");
                        Console.WriteLine();

                        break;



                    case 2:

                        int max = matrix.Cast<int>().Max();
                        Console.WriteLine("Legnagyobb szám: " + max);
                        Console.WriteLine("***************");
                        Console.WriteLine();

                        break;



                    case 3:

                        avg = avg / (sor + oszlop);
                        Console.WriteLine("Átlaga: " + avg);
                        Console.WriteLine("***************");
                        Console.WriteLine();
                        break;

                    case 4:

                        if (van_e_benne)

                        {

                            Console.WriteLine("Van benne 12");
                            Console.WriteLine("***************");
                            Console.WriteLine();

                        }

                        else

                        {

                            Console.WriteLine("Nincs benne 12");
                            Console.WriteLine("***************");
                            Console.WriteLine();

                        }
                        break;

                    case 5:

                        for (int i = 0; i < sor; i++)

                        {

                            for (int j = oszlop - 1; j > 0; j--)

                            {

                                for (int k = 0; k < j; k++)

                                {

                                    if (matrix[i, k] > matrix[i, k + 1])

                                    {

                                        int temp = matrix[i, k];

                                        matrix[i, k] = matrix[i, k + 1];

                                        matrix[i, k + 1] = temp;

                                    }

                                }

                            }

                            Console.WriteLine();

                        }

                        Console.WriteLine("Eredeti: ");

                        for (int i = 0; i < sor; i++)

                        {

                            for (int j = 0; j < oszlop; j++)

                            {

                                Console.Write("{0,3}", matrix2[i, j]);

                            }

                            Console.WriteLine();

                        }

                        Console.WriteLine("***************");

                        Console.WriteLine("Növekvő sorrend: ");

                        for (int i = 0; i < sor; i++)

                        {

                            for (int j = 0; j < oszlop; j++)

                            {

                                Console.Write("{0,3}", matrix[i, j]);

                            }

                            Console.WriteLine();

                        }

                        Console.WriteLine("***************");

                        Console.WriteLine();

                        break;

                    case 6:

                        for (int i = 0; i < sor; i++)

                        {

                            for (int j = oszlop - 1; j > 0; j--)

                            {

                                for (int k = 0; k < j; k++)

                                {

                                    if (matrix[i, k] < matrix[i, k + 1])

                                    {

                                        int temp = matrix[i, k];

                                        matrix[i, k] = matrix[i, k + 1];

                                        matrix[i, k + 1] = temp;

                                    }

                                }

                            }

                            Console.WriteLine();

                        }

                        Console.WriteLine("Eredeti: ");

                        for (int i = 0; i < sor; i++)

                        {

                            for (int j = 0; j < oszlop; j++)

                            {

                                Console.Write("{0,3}", matrix2[i, j]);

                            }

                            Console.WriteLine();

                        }

                        Console.WriteLine("***************");

                        Console.WriteLine("Csökkenő sorrend: ");

                        for (int i = 0; i < sor; i++)

                        {

                            for (int j = 0; j < oszlop; j++)

                            {

                                Console.Write("{0,3}", matrix[i, j]);

                            }

                            Console.WriteLine();

                        }

                        Console.WriteLine("***************");

                        Console.WriteLine();

                        break;


                    case 7:

                        Console.Write("Az összes szám: ");

                        foreach (int number in osszesszam)
                        {
                            Console.Write($"{number}, ");
                        }

                        Console.WriteLine();
                        Console.Write("Páros számok: ");

                        if (paros.Count == 0)
                        {
                            Console.Write("Nincs páros szám.");
                        }

                        else
                        {
                            foreach (int number in paros)
                            {
                                Console.Write($"{number} ");
                            }
                        }

                        Console.WriteLine();
                        Console.Write("Páratlan számok: ");

                        if (paratlan.Count == 0)
                        {
                            Console.Write("Nincs páratlan szám.");
                        }

                        else
                        {
                            foreach (int number in paratlan)

                            {

                                Console.Write($"{number}, ");

                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("***************");
                        Console.WriteLine();
                        break;


                    case 0:
                        break;

                    default:

                        Console.WriteLine("Hibás menüpont!");
                        Console.WriteLine("***************");
                        Console.WriteLine();

                        break;

                }

            }

        }

    }

}