using System;

namespace Bus
{
    class Information //50 seats in a normal bus and 100 in a double decker
    {
        string BusNormal;
        int NormalPrice = 100;
        string DoubleDeckerBus;
        int DoublePrice = 200;

        string ParisRoute;
        int ParisPrice = 500;
        string BerlinRoute;
        int BerlinPrice = 200;
        string WienRoute;
        int WienPrice = 350;
        string AmsterdamRoute;
        int AmsterdamPrice = 300;

        string NormalSeat;

        string WindowSeat;
        int WindowSeatPrice = 50;

        string TableSeat;
        int TableSeatPrice = 75;
    }
    class Program
    {
        Information again = new Information();

        public string[] ListOfDestinations = { "Paris", "Berlin ", "Wien", "Amsterdam" };
        public string[] ListOfBusses = { "Double Decker", "Bus " };
        public string[] ListOfSeats = { "Normalt sæde", "Bord sæde ", "Benplads sæde" };
        public static void Main(string[] args)
        {
            Route Berlin = new Route();

            int RouteChoice = 1;
            int BusChoice = 1;
            int SeatChoice = 1;
            string CustomerName = "";
            int CustomerAge = 1;
            int GroupNumber = 1;

            Menu(RouteChoice, BusChoice, SeatChoice, CustomerName, CustomerAge, GroupNumber);
        }
        public static void Menu(int RouteChoice, int BusChoice, int SeatChoice, string CustomerName, int CustomerAge, int GroupNumber)
        {

            int i = 0;
            do
            {
                try
                {
                    Console.Clear();
                    Console.Write("Hej og velkommen til Jakobs Rejse busser!\nHvad er dit navn -> ");
                    CustomerName = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("Hej " + CustomerName + " og velkommen til Jakobs Rejse busser!\n");

                    Console.Write("Hvad er din alder? -> ");
                    CustomerAge = Convert.ToInt32(Console.ReadLine());
                    if (CustomerAge < 15)
                    {
                        Console.WriteLine("Du er for ung til at tage bussen alene. Du skal have en voksen med.");
                    }
                    else
                    {
                        Console.WriteLine("Du er gammel nok til at tage bussen alene. Du behøver ikke en voksen.");
                    }

                    Console.Clear();
                    Console.Write("Hvor mange er i der skal med bussen? -> ");
                    GroupNumber = Convert.ToInt32(Console.ReadLine());
                    if (CustomerAge < 15 && GroupNumber < 2)
                    {
                        Console.WriteLine("Jeg sagde jo at du var for ung og skulle have en voksen med!");

                    }

                    //The customer will first have to choose the route, then the bus, then the seats and first then he can see his order. I do it in this order because it makes the most sense for me.
                    Console.WriteLine("Vælg først rute[1] Eller bare luk programmet[2]");
                    Console.Write("Valg -> ");
                    int Choice = Convert.ToInt32(Console.ReadLine());

                    switch (Choice)
                    {
                        case 1:
                            Route(RouteChoice, BusChoice, SeatChoice, CustomerName, CustomerAge, GroupNumber);
                            i++;
                            break;

                        case 2:
                            Environment.Exit(0);
                            return;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (i == 0);
        }
        public static void Route(int RouteChoice, int BusChoice, int SeatChoice, string CustomerName, int CustomerAge, int GroupNumber)
        {
            Console.Clear();
            Console.Write("Hvilken by starter du i? -> \n");
            string Start = Console.ReadLine();
            Console.WriteLine("Du har 4 destinationer at vælge imellem. \nParis[1] = 500kr. per person. \nBerlin[2] = 200kr. per person \nWien[3] = 200kr. per person \nAmsterdam[4] = 300kr. per person");
            Console.Write("Hvilken destination vil du tage? -> ");
            RouteChoice = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            do
            {
                try
                {
                    Console.Clear();
                    //Now that the customer have chosen the route, he/her can choose the bus. 
                    Console.WriteLine("Nu kan du vælge bussen[1] Eller bare luk programmet[2]");
                    Console.Write("Valg -> ");
                    int Choice = Convert.ToInt32(Console.ReadLine());

                    switch (Choice)
                    {
                        case 1:
                            Bus(RouteChoice, BusChoice, SeatChoice, CustomerName, CustomerAge, GroupNumber);
                            i++;
                            break;

                        case 2:
                            Environment.Exit(0);
                            return;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (i == 0);
        }
        public static void Bus(int RouteChoice, int BusChoice, int SeatChoice, string CustomerName, int CustomerAge, int GroupNumber)
        {
            Console.Clear();
            Console.WriteLine("Du har 2 Busser at vælge imellem. \nEn normal bus[1] \nEn dobbeldecker bus[2]");
            Console.Write("Hvilken bus vil du tage? -> ");
            BusChoice = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            do
            {
                try
                {
                    Console.Clear();
                    //Now that the customer have chosen the route, he/her can choose the bus. 
                    Console.WriteLine("Nu kan du vælge sæde[1], ændrer rute[2] eller bare luk programmet[3]");
                    Console.Write("Valg -> ");
                    int Choice = Convert.ToInt32(Console.ReadLine());

                    switch (Choice)
                    {
                        case 1:
                            Seat(RouteChoice, BusChoice, SeatChoice, CustomerName, CustomerAge, GroupNumber);
                            i++;
                            break;

                        case 2:
                            Route(RouteChoice, BusChoice, SeatChoice, CustomerName, CustomerAge, GroupNumber);
                            i++;
                            break;

                        case 3:
                            Environment.Exit(0);
                            return;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (i == 0);
        }
        public static void Seat(int RouteChoice, int BusChoice, int SeatChoice, string CustomerName, int CustomerAge, int GroupNumber)
        {
            Console.Clear();
            if (BusChoice == 1)
            {
                Console.WriteLine("Du har 3 Sæder at vælge imellem. \nEn plads vi giver dig koster intet ekstra[1] \nEn bordplads koster 75kr ekstra[2]\nEn vindues plads i fronten af bussen koster 50kr ekstra[3]");
                Console.Write("Hvilket sæde vil du tage? -> ");
                SeatChoice = Convert.ToInt32(Console.ReadLine());
                Randombus(GroupNumber);
            }
            else
            {
                Console.WriteLine("Du har 3 Sæder at vælge imellem. \nEn plads vi giver dig koster intet ekstra[1] \nEn bordplads koster 75kr ekstra[2]\nEn vindues plads i fronten af bussen koster 50kr ekstra[3]");
                Console.Write("Hvilket sæde vil du tage? -> ");
                SeatChoice = Convert.ToInt32(Console.ReadLine());
                RandomDBus(GroupNumber);

            }
            

            int i = 0;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Nu kan du vælge at gå tilbage og ændre rute[1], ændrer bus[2] se din billet[3] eller bare luk programmet[4]");
                    Console.Write("Valg -> ");
                    int Choice = Convert.ToInt32(Console.ReadLine());

                    switch (Choice)
                    {
                        case 1:
                            Route(RouteChoice, BusChoice, SeatChoice, CustomerName, CustomerAge, GroupNumber);
                            i++;
                            break;

                        case 2:
                            Bus(RouteChoice, BusChoice, SeatChoice, CustomerName, CustomerAge, GroupNumber);
                            i++;
                            break;

                        case 3:
                            Ticket(RouteChoice, BusChoice, SeatChoice, CustomerName, CustomerAge, GroupNumber);
                            i++;
                            break;

                        case 4:
                            Environment.Exit(0);
                            return;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (i == 0);
        }
        public static void Ticket(int RouteChoice, int BusChoice, int SeatChoice, string CustomerName, int CustomerAge, int GroupNumber)
        {
            Console.Clear();
            Console.WriteLine("Din billet: ");
            Console.WriteLine("Navn: " + CustomerName);
            Console.WriteLine("Alder: " + CustomerAge);
            Console.WriteLine("Gruppe str: " + GroupNumber);
            Console.WriteLine("Rutevalg: " + RouteChoice);
            Console.WriteLine("BusValg: " + BusChoice);
            Console.WriteLine("Sædevalg: " + SeatChoice);

            Console.WriteLine("\nVil du betale[1], starte forfra[2] eller lukke programmet[3]?");
            int TicketChoice = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            do
            {
                try
                {
                    Console.Clear();
                    switch (TicketChoice)
                    {
                        case 1:

                            i++;
                            break;

                        case 2:
                            Program.Menu(RouteChoice, BusChoice, SeatChoice, CustomerName, CustomerAge, GroupNumber);
                            i++;
                            break;

                        case 3:
                            Environment.Exit(0);
                            return;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (i == 0);
        }
        public static void Randombus(int Groupnumber)
        {
            Random randombus = new Random();

            int randomseat = randombus.Next(1, 35);
            int finalseatBus = randomseat + Groupnumber - 1;
            Console.WriteLine("Jeres sæder starter ved " + randomseat + " og slutter ved " + finalseatBus);
            Console.ReadKey();
        }
        public static void RandomDBus(int Groupnumber)
        {
            Random randomDBus = new Random();

            int randomseat = randomDBus.Next(1, 65);
            int finalseatDBus = randomseat + Groupnumber - 1;
            Console.WriteLine("Jeres sæder starter ved " + randomseat + " og slutter ved " + finalseatDBus);
            Console.ReadKey();
        }
    }
    class Route
    {
        private string destination;
        Bus bus;
        public Route()
        {
            bus = new Bus();
            bus.CreateSeats(50);
        }
    }
    class Bus
    {
        // bustype;
        private Seat[] seats;
        private int nSeats;
        public void CreateSeats(int n)
        {
            nSeats = n;
            seats = new Seat[nSeats];
            for(int i = 0; i < nSeats; i++)
            {
                seats[i] = new Seat();
                seats[i].setNr(i + 1);
            }

        }
        
    }
    class Seat : Program
    {
        private int nr;
        private bool sold;
        private bool extraLegSpace = false;
        private bool tableSeat = false;
        private int price;
        public void setNr(int n)
        {
            nr = n;
        }
        public Seat()
        {
            sold = false;
            extraLegSpace = false;
            tableSeat = false;
            price = 100;
        }
    }
    class Ticket
    {
        
    }
}