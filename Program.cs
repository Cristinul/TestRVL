using System;
using System.Collections.Generic;

namespace ProgramRVL
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Dictionar meniu
            IDictionary<int, string> meniuArticole = new Dictionary<int, string>();
            meniuArticole.Add(1, "Sageata");
            meniuArticole.Add(2, "Arc");
            meniuArticole.Add(3, "Franghie");
            meniuArticole.Add(4, "Apa");
            meniuArticole.Add(5, "Portie de mancare");
            meniuArticole.Add(6, "Sabie");
            #endregion

            int nrMaximArticole = CitesteNumarMaximArticole();
            float nrMaximGreutate = CitesteGreutateMaxima();
            float nrMaximVolum = CitesteVolumMaxima();

            Ghiozdan ghiozdan = new Ghiozdan(nrMaximArticole, nrMaximGreutate, nrMaximVolum);

            foreach (KeyValuePair<int, string> kvp in meniuArticole)
                Console.WriteLine("{0}. {1}", kvp.Key, kvp.Value);

            string inputValoare;
            Console.WriteLine("Introduceti numarul corespunzator obiectului ce doriti sa il adaugati in ghiozdan:");
            do
            {
                inputValoare = Console.ReadLine();
                AdaugaArticol(ghiozdan, inputValoare);

            } while (inputValoare != "q");

        }

        private static int CitesteNumarMaximArticole()
        {
            Console.WriteLine("Introduceti numarul maxim de articole din ghiozdan:");

            int nrMaximArticole = -1;
            string nrMaximArticoleStr;
            do
            {
                nrMaximArticoleStr = Console.ReadLine();
                bool inputValid = VerificaInputInt(nrMaximArticoleStr);
                if (inputValid)
                {
                    nrMaximArticole = Int32.Parse(nrMaximArticoleStr);
                }

            } while (nrMaximArticole == -1);

            return nrMaximArticole;
        }

        private static float CitesteGreutateMaxima()
        {
            Console.WriteLine("Introduceti greutatea maxima a ghiozdanului:");

            float greutateMaxima = -1;
            string greutateMaximaStr;
            do
            {
                greutateMaximaStr = Console.ReadLine();
                bool inputValid = VerificaInputFloat(greutateMaximaStr);
                if (inputValid)
                {
                    greutateMaxima = float.Parse(greutateMaximaStr);
                }

            } while (greutateMaxima == -1);

            return greutateMaxima;
        }

        private static float CitesteVolumMaxima()
        {
            Console.WriteLine("Introduceti volumul maxim al ghiozdanului:");

            float volumMaxim = -1;
            string volumMaximStr;
            do
            {
                volumMaximStr = Console.ReadLine();
                bool inputValid = VerificaInputFloat(volumMaximStr);
                if (inputValid)
                {
                    volumMaxim = float.Parse(volumMaximStr);
                }

            } while (volumMaxim == -1);

            return volumMaxim;
        }

        private static void AdaugaArticol(Ghiozdan ghiozdan, string inputValoare)
        {
            bool inputValid = Int32.TryParse(inputValoare, out int optiune);

            if (inputValid)
            {
                if (optiune <= 0 || optiune > 6)
                {
                    Console.WriteLine("Introduceti un numar cuprins intre 1 si 6!");
                    return;
                }

                bool rezultatExecutie = ExecutaOptiune(ghiozdan, optiune);
                if (!rezultatExecutie)
                {
                    Console.WriteLine("Articolul nu a putut fi adaugat in ghiozdan.");
                }
            }
            else
            {
                Console.WriteLine("Introduceti numarul corespunzator obiectului ce doriti sa il adaugati in ghiozdan:");
            }
        }

        private static bool VerificaInputInt(string inputValoare)
        {
            bool inputValid = Int32.TryParse(inputValoare, out int optiune);
            return inputValid && optiune > 0;
        }

        private static bool VerificaInputFloat(string inputValoare)
        {
            bool inputValid = float.TryParse(inputValoare, out float optiune);
            return inputValid && optiune > 0;
        }

        private static bool ExecutaOptiune(Ghiozdan ghiozdan, int inputValoare)
        {
            switch (inputValoare)
            {
                case 1:
                    return ghiozdan.Adauga(new Sageata());
                case 2:
                    return ghiozdan.Adauga(new Arc());
                case 3:
                    return ghiozdan.Adauga(new Franghie());
                case 4:
                    return ghiozdan.Adauga(new Apa());
                case 5:
                    return ghiozdan.Adauga(new PortieDeMancare());
                case 6:
                    return ghiozdan.Adauga(new Sabie());
                default:
                    return false;
            }
        }
    }
}
