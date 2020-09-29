using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/// 
/// Naam: Dhr. Gillade
/// Datum: 28/09/2020
/// Project: Oefeningen hoofdstuk 14
///

namespace _5NIT_ConsApp_Oefeningenhfd14
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Voorbeeld omgevingsvariabelen
            /// 
            /// Voorbeeld omgevingsvariabelen 
            /// 
            Console.WriteLine("Voorbeeld omgevingsvariabelen\n-----------------------------");

            bool is64bit = Environment.Is64BitOperatingSystem;
            string pcname = Environment.MachineName;

            int processorCount = Environment.ProcessorCount;
            string userName = Environment.UserName;
            Int64 memory = Environment.WorkingSet;

            Console.WriteLine($"Deze computer bevat een 64-bit OS: {is64bit}");
            Console.WriteLine($"De computernaam is: {pcname}");

            Console.WriteLine($"Onze computer telt {processorCount} processoren.");
            Console.WriteLine($"De gebruiker die nu aangemeld is: {userName}");
            Console.WriteLine($"Onze computer beschikt over {memory} geheugen.");

            Console.ReadKey();
            Console.Clear();

            #endregion

            #region Oefening 14.1
            /// 
            /// Oefening 14.1 
            /// 
            Console.WriteLine("Oefening 14.1\n-------------");

            Double prijsBenzine, reisKost, afgelegdeAfstand;
            const Double verbruikAuto = 0.06;

            Console.Write("Wat is de huidige prijs voor 1L benzine?     ");
            prijsBenzine = Convert.ToDouble(Console.ReadLine());

            Console.Write("Hoeveel km reis je?     ");
            afgelegdeAfstand = Convert.ToDouble(Console.ReadLine());

            reisKost = afgelegdeAfstand * prijsBenzine * verbruikAuto;

            Console.WriteLine($"Jouw reis kost {reisKost} EURO.");

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 14.2
            /// 
            /// Oefening 14.2 
            /// 
            Console.WriteLine("Oefening 14.2\n-------------");

            const Double btwTarief = 1.21;
            Double bedragExclBTW, bedragInclBTW;

            Console.Write("Hoeveel bedraagt de prijs exclusief BTW?     ");
            bedragExclBTW = Convert.ToDouble(Console.ReadLine());

            bedragInclBTW = bedragExclBTW * btwTarief;

            Console.WriteLine($"Het bedrag inclusief BTW is: {bedragInclBTW}");

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 14.3
            /// 
            /// Oefening 14.3
            /// 
            Console.WriteLine("Oefening 14.3\n-------------");

            Int16 gewonnen, verloren, gelijk;
            Int32 punten;

            Console.Write("Hoeveel wedstrijden heb je gewonnen?     ");
            gewonnen = Convert.ToInt16(Console.ReadLine());
            Console.Write("Hoeveel wedstrijden heb je verloren?     ");
            verloren = Convert.ToInt16(Console.ReadLine());
            Console.Write("Hoeveel wedstrijden heb je gelijk gespeeld?     ");
            gelijk = Convert.ToInt16(Console.ReadLine());

            punten = gewonnen * 3 + gelijk;

            Console.WriteLine($"Jouw ploeg behaalde {punten} punten.");

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 14.4
            /// 
            /// Oefening 14.4
            /// 
            Console.WriteLine("Oefening 14.4\n-------------");

            String ingegevenWoord, omgedraaidWoord;

            Console.Write("Gelieve een woord in te vullen:     ");
            ingegevenWoord = Console.ReadLine();

            omgedraaidWoord = "";
            omgedraaidWoord += ingegevenWoord.Substring(ingegevenWoord.Length - 1, 1);
            omgedraaidWoord += "_";
            omgedraaidWoord +=  ingegevenWoord.Substring(0,1);

            Console.WriteLine($"Jouw woord telt {ingegevenWoord.Length} letters;");
            Console.WriteLine($"Jouw initialen zijn {omgedraaidWoord}");

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 14.5
            /// 
            /// Oefening 14.5
            /// 
            Console.WriteLine("Oefening 14.5");

            Console.Write("Gelieve een datum in te vullen:     ");
            DateTime ingevoerdeDatum;
            ingevoerdeDatum = Convert.ToDateTime(Console.ReadLine());

            //DateTime ingevoerdeDatum = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine($"De naam van de maand is: {ingevoerdeDatum.ToString("MMMM")}");

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 14.6
            /// 
            /// Oefening 14.6 
            /// 
            Console.WriteLine("Oefening 14.6");

            Console.Write("Gelieve een getal in te vullen tussen 1 en 20:     ");
            Int16 ingevoerdGetal = Convert.ToInt16(Console.ReadLine());

            Int32 berekendGetal = ingevoerdGetal * 2;
            Console.WriteLine(berekendGetal);
            berekendGetal += 6;
            Console.WriteLine(berekendGetal);
            berekendGetal /= 2;
            Console.WriteLine(berekendGetal);
            berekendGetal -= ingevoerdGetal;
            Console.WriteLine(berekendGetal);

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 14.7
            /// 
            /// Oefening 14.7 
            /// 
            Console.WriteLine("Oefening 14.7\n-------------");

            Double TF, TC;

            Console.Write("Gelieve de temperatuur in graden Celcius in te voeren:     ");
            TC = Convert.ToDouble(Console.ReadLine());

            TF = 1.8 * TC + 32;

            Console.WriteLine($"Temperatuur in °C: {TC} \n Temperatuur in °F: {TF}");

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 14.8
            /// 
            /// Oefening 14.8
            /// 
            Console.WriteLine("Oefening 14.8");

            bool OS64bit = Environment.Is64BitOperatingSystem;
            string pcnaam = Environment.MachineName;
            int aantalProcessors = Environment.ProcessorCount;
            string gebruikersnaam = Environment.UserName;
            Int64 geheugen = (Environment.WorkingSet/1024)/1024;
            String OSVersie = Environment.OSVersion.ToString();
            String machineNaam = Environment.MachineName;

            Console.WriteLine($"Deze computer bevat een 64-bit OS: {OS64bit}");
            Console.WriteLine($"De computernaam is: {pcnaam}");
            Console.WriteLine($"De machinenaam is: {machineNaam}");
            Console.WriteLine($"Onze computer telt {aantalProcessors} processoren.");
            Console.WriteLine($"De gebruiker die nu aangemeld is: {gebruikersnaam}");
            Console.WriteLine($"Het huidige proces gebruikt {geheugen} Mb geheugen.");
            Console.WriteLine($"Onze computer gebruikt versie {OSVersie} als OS.");

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 14.9
            /// 
            /// Oefening 14.9
            /// 
            Console.WriteLine("Oefening 14.9");

            Int64 driveInBytes = DriveInfo.GetDrives()[0].AvailableFreeSpace;
            Int64 totalSize = DriveInfo.GetDrives()[0].TotalSize;
            String driveName = DriveInfo.GetDrives()[0].Name;

            Console.WriteLine($"Naam van de schijf: {driveName}");
            Console.WriteLine($"Vrije ruimte van de schijf: {driveInBytes}");
            Console.WriteLine($"Totale grootte van de schijf: {totalSize}");


            Console.ReadKey();
            Console.Clear();
            #endregion


        }
    }
}
