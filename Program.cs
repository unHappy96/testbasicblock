/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами. */
string Input(string text){
    System.Console.Write(text);
    return Console.ReadLine();
}

int ReadInt(string text){
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(string[] arrayForPrint) {
	System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

//----------------------------------------------------

int N = ReadInt("Введите количество элементов массива ");    //Вводим длину первого массива N

string[] arrayA = new string[N];

for (int i = 0; i < N; i++){
    arrayA[i] = Input($"Введите {i+1} значение ");           //Вводим значения для первого массива A
}

PrintArray(arrayA);

int count = 0;

for (int i = 0; i < N; i++){
    if (arrayA[i].Length <= 3){
        count++;                                        //Находим длину второго массива
    }
}

string[] arrayB = new string[count];                    //Создаем второй массив B

for (int i = N-1; i >= 0; i--){
    if (arrayA[i].Length <= 3){
        arrayB[count=count-1] = arrayA[i];              //Заполняем второй массив B элементами из первого массива A, которые меньше или равны 3
    }
}

PrintArray(arrayB);