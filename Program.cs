﻿int n1;

Console.WriteLine("Введите цифру, день недели по которой хотите получить:");
n1 = Convert.ToInt32(Console.ReadLine());

if (n1==1)
{
    Console.WriteLine("Понедельник");
 }
 else 
    if (n1==2)
    {
        Console.WriteLine("Вторник");
    }
        else    
            if (n1==3)
            {
                Console.WriteLine("Среда");
            }
                else
                    if (n1==4)
                    {
                        Console.WriteLine("Четверг");
                    }
                        else 
                            if (n1==5)
                            {
                                Console.WriteLine("Пятница");
                            }
                                else 
                                    if (n1==6)
                                    {
                                        Console.WriteLine("Суббота");
                                    } 
                                    else     
                                        if (n1==7)
                                        {
                                            Console.WriteLine("Воскресенье");
                                        }
                                            else
                                            {
                                                Console.WriteLine("дурак блять!!!!!");
                                            }

