using System;
using System.Threading;

// (c) Kiolesis
// Biblioteka, kt�ra ma pom�c w zrozumieniu programowania, ucz�c si� j�zyka angielskiego.
// Ta biblioteka zosta�a stworzona przez Kiolesis'a.
namespace Engine
{
    // Klasa dla u�ytkownika i zdefiniowania w�asnych instrukcji
    class Load
    {
        public static void Console_Code()
        {

        }
        public static void Write()
        {

        }
        public static void Pause()
        {

        }
        public static void Int()
        {

        }
    }

    // Ustawienia konsoli
    class Console_Settings
    {
        // Wyj�cie z aplikacji
        public static void Exit(int a)
        {
            Environment.Exit(a);
        }

        // Oczekuje ilo�� ms przekazan� w argumencie
        public static void Wait(int a)
        {
            Thread.Sleep(a);
        }

        // Obfuskacja kodu
        public static void Obfuscation(string a, string b, string c, string d, int e)
        {
            if (a == "1")
            {
                if (c == "3")
                {
                    if (b == "2")
                    {
                        Console.WriteLine(d);
                    }
                }
            }
            if (b == "2")
            {
                if (c == "2")
                {
                    if (a == "3")
                    {
                        Thread.Sleep(e);
                    }
                }
            }
            if (c == "3")
            {
                if (e == 1000)
                {
                    if (a == "2")
                    {
                        if (b == "3")
                        {
                            Console.Clear();
                        }
                    }
                }
            }
        }

        // Chro� sw�j kod
        public static void Detect(string item)
        {
            // Wykryj przy��czonego debuggera
            if (item == "DEBUGGER")
            {
                if (System.Diagnostics.Debugger.IsAttached)
                {
                    /* Proponowane kody b��d�w:
                     * 0 - Aplikacja zamkni�ta prawid�owo.
                     * 1 - B��d w kodzie aplikacji uniemo�liwia jej dzia�anie.
                     * 2 - Nast�pi� oczekiwany wyj�tek lub b��d, kt�rego si� spodziewano.
                     * 3 - Aplikacja zosta�a nieoczekiwanie zamkni�ta przez inny proces.
                     * 4 - Za�adowane komponenty nie s� zgodne z aplikacj�.
                     * 5 - Aplikacja zosta�a uruchomiona z nieznanymi argumentami.
                     * 6 - Nieznany problem.
                     * 7 - Nieznany problem.
                     * 8 - Aplikacja zosta�a zamkni�ta z powodu wykrycia debuggera.
                     * 9 - Aplikacja zosta�a zamkni�ta z powodu wykrycia campera.
                    */
                    Console_Settings.Exit(8);
                }
            }
            // Wykryj tzw. campera
            if (item == "CAMPER")
            {

            }
        }

    }

    // Skorzystaj z mo�liwo�ci przesy�anych argument�w
    public class CommandLine
    {
        // Wy�wietl przekazane argumenty
        public static void Show(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Arg[{i}] = [{args[i]}]");
            }
        }

        // Wy�wietl ilo�� przekazanych argument�w
        public static void Show_Number(string[] args)
        {
            Console.WriteLine($"Ilo�� parametr�w = {args.Length}");
        }
    }

    // Tworzenie hase�
    public class Password
    {
        // Utworzenie loginu i has�a przez programist�
        public static void CreateAccount()
        {
            // Utworzenie loginu:
            string login = "";
            // Utworzenie has�a:
            string pass = "";

            login = login + "v19v994091012312v42351239051203v959619236012395012931a3";
            pass = pass + "v19v994091012312v42351239051203v959619236012395012931a3";
            login = login.Replace("v19v994091012312v42351239051203v959619236012395012931a3", "");
            pass = pass.Replace("v19v994091012312v42351239051203v959619236012395012931a3", "");
        }

        // Panel logowania
        public static void RegisterPanel(string a)
        {
            Login(a);
            Pass(a);

        }

        public static string Login(string a)
        {
            Console.WriteLine("Witaj w programie " + a + "!");
            Console.WriteLine("Utw�rz konto, wpisuj�c login:");
            string login = Console.ReadLine();
            return login;
        }
        public static string Pass(string a)
        {
            Console.Clear();
            Console.WriteLine("Witaj w programie " + a + "!");
            Console.WriteLine("Utw�rz konto, wpisuj�c has�o:");
            string pass = Console.ReadLine();
            return pass;
        }
        // Wpisz login
        public static string EnterLogin()
        {
            Console.WriteLine("Zaloguj si�, aby kontynuowa�.");
            Console.WriteLine("Wpisz login:");
            string login = Console.ReadLine();
            return login;
        }

        // Wpisz has�o
        public static string EnterPassword()
        {
            Console.WriteLine("Zaloguj si�, aby kontynuowa�.");
            Console.WriteLine("Wpisz has�o:");
            string pass = Console.ReadLine();
            return pass;
        }

        // Zweryfikuj podane przez u�ytkownika dane
        public static bool Verify(string a, string b, string login, string pass)
        {
            if (a == login)
            {
                if (b == pass)
                {
                    bool succeed = true;
                    return succeed;
                }
                else
                {
                    Console.WriteLine("Wprowadzone has�o jest nieprawid�owe!");
                    Console.ReadKey();
                    bool succeed = false;
                    return succeed;
                }
            }
            else
            {
                Console.WriteLine("Wprowadzony login jest nieprawid�owy!");
                Console.ReadKey();
                bool succeed = false;
                return succeed;
            }
        }

        // Wyloguj u�ytkownika
        public static bool Logout()
        {
            bool succeed = false;
            return succeed;
        }
    }

    // Podstawowa biblioteka graficzna
    class Console_Code
    {
        // Czy�ci okno konsoli
        public static void Clear()
        {
            Console.Clear();
        }
    }

    // Podstawowa biblioteka konsoli
    public class Write
    {
        // Wy�wietla napis na ekranie
        public static void Text(string a)
        {
            Console.WriteLine(a);
        }
        // Wy�wietla zmienn� typu danych tekstowych
        public static void Variable_String(string a)
        {
            Console.WriteLine(a);
        }
        // Wy�wietla zmienn� typu liczby ca�kowitej
        public static void Variable_Int(int a)
        {
            Console.WriteLine(a);
        }
    }

    // Podstawowa biblioteka interakcji z u�ytkownikiem
    class Pause
    {
        // Przywo�uje instukcj� oczekiwania
        public static void Hide()
        {
            Console.ReadKey();
        }
        // Wy�wietla napis i przywo�uje instrukcj� oczekiwania
        public static void Show()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    // Podstawowa biblioteka matematyczna
    class Int
    {
        // Dodawanie
        public static int Sum(int a, int b)
        {
            int c = a + b;
            return c;
        }
        // Odejmowanie
        public static int Difference(int a, int b)
        {
            int c = a - b;
            return c;
        }
        // Mno�enie
        public static int Multiplication(int a, int b)
        {
            int c = a * b;
            return c;
        }
        // Dzielenie
        public static int Division(int a, int b)
        {
            int c = a / b;
            return c;
        }
    }
}