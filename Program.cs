/* Vazifalarni boshqarish uchun dastur yozing.
  Foydalanuvchi vazifalarni qo'shishi, o'chirishi va
  bajarilganligini belgilashi kerak. Dastur vazifalar ro'yxatini
  va ularning holatini saqlashi kerak.
  For loop, While loop yoki Forech-dan foydalaning, va
  Array yoki List-dan foydalaning.*/

using System.ComponentModel.Design;

List<string> Vazifalar = new List<string>();
List<string> Status = new List<string>();
void Menyu()
{
	Console.Clear();
	Console.WriteLine("\t\tBo'limlar");
    Console.WriteLine("1. Vazifa qo'shish");
    Console.WriteLine("2. Vazifa o'chirish");
    Console.WriteLine("3. Vazifalar ro'yxati");
	Console.WriteLine("4. Vazifa bajarish");
    Console.Write("Buyuruqni tanlang(1, 2, 3): ");
    int n = int.Parse(Console.ReadLine());
	switch (n)
	{
		case 1: Add(); break;
		case 2: Remove(); break;
		case 3: ShowList(); break;
		case 4: GetStatus(); break;
		default:
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Notog'ri buyuruq kiritildi !");
			Console.ForegroundColor = ConsoleColor.White;
			break;

	}
	Console.ReadKey();
	Menyu();
}
void ShowList()
{
	Console.Clear();
	for (int i=0;i<Vazifalar.Count; i++)
    {
		Console.Write($"{i+1}. {Vazifalar[i]}   ");
		if (Status[i] == "Bajarilmadi")
		{
			Console.ForegroundColor = ConsoleColor.Red;
		}
		else
		{
			Console.ForegroundColor = ConsoleColor.Green;
		}
		Console.WriteLine(Status[i]);
		Console.ForegroundColor = ConsoleColor.White;
	}
	Console.ReadKey();
	Menyu();
}

void Add()
{   
	Console.Clear();
    Console.WriteLine("\t\tVazifa qo'shish");
    Console.WriteLine("Vazifani kiriting: ");
    string vazifa = Console.ReadLine();
    Vazifalar.Add(vazifa);
	string status = "Bajarilmadi";
	Status.Add(status);
	Console.ForegroundColor = ConsoleColor.Green;
	Console.WriteLine("Vazifa muaffaqiyatli qo'shildi !");
	Console.ForegroundColor = ConsoleColor.White;
	Console.WriteLine("Tap to anyway");
	Console.ReadKey();
    Menyu();
}
void Remove()
{   
	Console.Clear();
	Console.WriteLine("\t\tVazifa o'chirish");
	Console.WriteLine("Vazifa indeksini kiriting: ");
	int vazifaAt = int.Parse(Console.ReadLine()) - 1;
	Vazifalar.RemoveAt(vazifaAt);
	Status.RemoveAt(vazifaAt);
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine("Vazifa o'chirildi !");
	Console.ForegroundColor = ConsoleColor.White;
	Console.WriteLine("Tap to anyway");
	Console.ReadKey();
	Menyu();
}
void GetStatus()
{
	Console.Clear();
	Console.WriteLine("\t\tVazifa bajarish");
	Console.WriteLine("Vazifa indeksini kiriting: ");
	int vazifaAt = int.Parse(Console.ReadLine()) - 1;
	if (Status[vazifaAt] != "Bajarilgan")
	{
		Status[vazifaAt] = "Bajarilgan";
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Vazifa muaffaqiyatli bajarildi !");
	}
	else 
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Vazifa bajarilgan !!!");
    }
	Console.ForegroundColor = ConsoleColor.White;
	Console.WriteLine("Tap to anyway");
	Console.ReadKey();
	Menyu();
}
Menyu();



