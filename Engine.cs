using System;
using System.Threading;

// (c) Kiolesis
// Biblioteka, która ma pomóc w zrozumieniu programowania, ucz¹c siê jêzyka angielskiego.
// Ta biblioteka zosta³a stworzona przez Kiolesis'a.
namespace Engine
{
    // Klasa dla u¿ytkownika i zdefiniowania w³asnych instrukcji
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
        // Wyjœcie z aplikacji
        public static void Exit(int a)
        {
            Environment.Exit(a);
        }

        // Oczekuje iloœæ ms przekazan¹ w argumencie
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

        // Chroñ swój kod
        public static void Detect(string item)
        {
            // Wykryj przy³¹czonego debuggera
            if (item == "DEBUGGER")
            {
                if (System.Diagnostics.Debugger.IsAttached)
                {
                    /* Proponowane kody b³êdów:
                     * 0 - Aplikacja zamkniêta prawid³owo.
                     * 1 - B³¹d w kodzie aplikacji uniemo¿liwia jej dzia³anie.
                     * 2 - Nast¹pi³ oczekiwany wyj¹tek lub b³¹d, którego siê spodziewano.
                     * 3 - Aplikacja zosta³a nieoczekiwanie zamkniêta przez inny proces.
                     * 4 - Za³adowane komponenty nie s¹ zgodne z aplikacj¹.
                     * 5 - Aplikacja zosta³a uruchomiona z nieznanymi argumentami.
                     * 6 - Nieznany problem.
                     * 7 - Nieznany problem.
                     * 8 - Aplikacja zosta³a zamkniêta z powodu wykrycia debuggera.
                     * 9 - Aplikacja zosta³a zamkniêta z powodu wykrycia campera.
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

    // Skorzystaj z mo¿liwoœci przesy³anych argumentów
    public class CommandLine
    {
        // Wyœwietl przekazane argumenty
        public static void Show(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Arg[{i}] = [{args[i]}]");
            }
        }

        // Wyœwietl iloœæ przekazanych argumentów
        public static void Show_Number(string[] args)
        {
            Console.WriteLine($"Iloœæ parametrów = {args.Length}");
        }
    }

    // Tworzenie hase³
    public class Password
    {
        // Utworzenie loginu i has³a przez programistê
        public static void CreateAccount()
        {
            // Utworzenie loginu:
            string login = "";
            // Utworzenie has³a:
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
            Console.WriteLine("Utwórz konto, wpisuj¹c login:");
            string login = Console.ReadLine();
            return login;
        }
        public static string Pass(string a)
        {
            Console.Clear();
            Console.WriteLine("Witaj w programie " + a + "!");
            Console.WriteLine("Utwórz konto, wpisuj¹c has³o:");
            string pass = Console.ReadLine();
            return pass;
        }
        // Wpisz login
        public static string EnterLogin()
        {
            Console.WriteLine("Zaloguj siê, aby kontynuowaæ.");
            Console.WriteLine("Wpisz login:");
            string login = Console.ReadLine();
            return login;
        }

        // Wpisz has³o
        public static string EnterPassword()
        {
            Console.WriteLine("Zaloguj siê, aby kontynuowaæ.");
            Console.WriteLine("Wpisz has³o:");
            string pass = Console.ReadLine();
            return pass;
        }

        // Zweryfikuj podane przez u¿ytkownika dane
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
                    Console.WriteLine("Wprowadzone has³o jest nieprawid³owe!");
                    Console.ReadKey();
                    bool succeed = false;
                    return succeed;
                }
            }
            else
            {
                Console.WriteLine("Wprowadzony login jest nieprawid³owy!");
                Console.ReadKey();
                bool succeed = false;
                return succeed;
            }
        }

        // Wyloguj u¿ytkownika
        public static bool Logout()
        {
            bool succeed = false;
            return succeed;
        }
    }

    // Podstawowa biblioteka graficzna
    class Console_Code
    {
        // Czyœci okno konsoli
        public static void Clear()
        {
            Console.Clear();
        }
    }

    // Podstawowa biblioteka konsoli
    public class Write
    {
        // Wyœwietla napis na ekranie
        public static void Text(string a)
        {
            Console.WriteLine(a);
        }
        // Wyœwietla zmienn¹ typu danych tekstowych
        public static void Variable_String(string a)
        {
            Console.WriteLine(a);
        }
        // Wyœwietla zmienn¹ typu liczby ca³kowitej
        public static void Variable_Int(int a)
        {
            Console.WriteLine(a);
        }
    }

    // Podstawowa biblioteka interakcji z u¿ytkownikiem
    class Pause
    {
        // Przywo³uje instukcjê oczekiwania
        public static void Hide()
        {
            Console.ReadKey();
        }
        // Wyœwietla napis i przywo³uje instrukcjê oczekiwania
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
        // Mno¿enie
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