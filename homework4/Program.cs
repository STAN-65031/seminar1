//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

int number1 = Convert.ToInt32(Console.ReadLine());
int mas = number1 % 2;

if(mas == 0){
while (mas < number1){
    mas = mas +2;
    Console.Write("{0} , ", mas);
    }
}

if(mas != 0){
    mas = 0;
    while (mas < number1 - 1){
        mas = mas +2;
        Console.Write("{0} , ", mas);
    }
}