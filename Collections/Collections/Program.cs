// See https://aka.ms/new-console-template for more information

using Collections;

Console.WriteLine("Hello, World!");

// Создание двумерного массива
People[,] peoplesArray = new People[3, 3];

// Создание словаря
Dictionary<string, int> addresses = new Dictionary<string, int>();

// Добавление элементов в массив и соответствующие ключи в словарь
addresses.Add("address1", 2);
peoplesArray[0, 0] = new People("s",0);

addresses.Add("address2", 1);
peoplesArray[1, 2] = new People("d",1);

// Получение элемента массива по ключу из словаря
int index;
if (addresses.TryGetValue("address1", out index))
{
    People person = peoplesArray[index, 0];
    
}

foreach (var VARIABLE in peoplesArray)
{
    Console.WriteLine(VARIABLE);
}

