//void SayHello()=> Console.WriteLine("Hello");
//void SayHello()
//{
//    Console.WriteLine("Hello");
//}
//SayHello();

//Console.WriteLine("Введите ваше имя");
//string name= Console.ReadLine();
//Console.WriteLine("Введите ваш язык(русский/немецкий/английский");
//string l= Console.ReadLine().ToLower();
//void SayHelloRu() => Console.WriteLine($"Привет {name}");
//void SayHelloEn() => Console.WriteLine($"Hello {name}");
//void SayHelloDe() => Console.WriteLine($"Guten Tag {name}");
//switch (l)
//{
//    case "русский":
//        SayHelloRu();
//        break;
//    case "немецкий":
//        SayHelloDe();
//        break;
//    case "английский":
//        SayHelloEn();
//        break;
//    default: Console.WriteLine("языка нет");
//        break;
//}

//void Game()
//{
//    string myGame = "Sims";
//    Console.WriteLine(myGame);
//}
//Game();

//void Print(string message)
//{
//    Console.WriteLine(message);
//}
//Print("hello");

//void summ(int x, int y)
//{
//    int res = x + y;
//    Console.WriteLine(res);
//}
//summ(12, 12);
//int x=int.Parse(Console.ReadLine());
//int y=int.Parse(Console.ReadLine());
//summ(x, y);

//void PrintPerson(string personname="None", int age=18, string vuz = "None")
//{
//    Console.WriteLine(personname + " " + age + " " + vuz);
//}
//PrintPerson("Тимофей", 20,"Волгу");
//PrintPerson(vuz:"ВолГУ", age: 20,personname: "Тимофей");
//PrintPerson();

//string GetMessage()
//{
//    return "hello";
//}
//int getnumber()
//{ 
//    return 1;
//}

//int getnumbers() => 4;

//var result=GetMessage();
//Console.WriteLine(result);
//Console.WriteLine(GetMessage());

//int Sum(int a, int b) => a + b;
//var sum = Sum(10, 20);
//Console.WriteLine(sum);
//Console.WriteLine(Sum(34,35));

//Console.WriteLine("Ваш возраст ");
//int number=Convert.ToInt32(Console.ReadLine());
//void Check(int number)
//{
//    if (number < 0)
//    {
//        Console.WriteLine("Отрицательное");
//        return;
//    }
//    Console.WriteLine("Положительное");
//}
//Check(number);

//Random random = new Random();
//int number = random.Next(1,100);
//Console.WriteLine(number);

//void Show() => Console.WriteLine("Здравствуйте ");
//void Showg() => Console.WriteLine("Хорошего дня ");
//string weather()
//{
//    string[] a = ["Солнечно", "Снежно", "Дождливо", "Пасмурно"];
//    Random random = new();
//    int index=random.Next(a.Length);
//    return a[index];
//}
//Show();
//Console.WriteLine(weather());
//Showg();

int factorial(int n)
{
    if(n==1) return 1;
    return n * factorial(n - 1);
}
Console.WriteLine(factorial(5));

