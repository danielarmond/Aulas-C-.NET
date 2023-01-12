using System.Security.Cryptography.X509Certificates;

namespace AulaList;

class Program {
	static void Main(string[] args)
	{

		List<String> list = new List<string>();

		list.Add("Maria");
		list.Add("Alex");
		list.Add("Ana");
		list.Insert(2, "Daniel");
        list.Insert(4, "Marco");

        foreach (string x in list) {
			Console.WriteLine(x);
		}

        Console.WriteLine("__________________________");


        Console.WriteLine("List Count: "+list.Count);

		string s1 = list.Find(Test);
		string s2 = list.FindLast(Test);

		Console.WriteLine("Primeiro nome començando com A: " + s1);
        Console.WriteLine("Último nome començando com A: " + s2);

		List<string> list2 = list.FindAll(x => x.Length == 5);
		Console.WriteLine("__________________________");

		foreach (string x in list2)
		{
			Console.WriteLine(x);

		}


        static bool Test(string s) {
			return s[0] == 'A';
		}
	}
}