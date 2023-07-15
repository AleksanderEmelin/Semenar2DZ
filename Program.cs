

  



    int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }



     void Task10()
     {
        // Напишите программу, которая принимает на вход трехзначное число и на выходе 
        //показывает вторую цифру этого числа

        int number = Input("Введите число:  ");
        if (number >= 100 && number < 1000)
        {
            Console.WriteLine($"Вторая цифра числа: {number / 10 % 10}");
        }
         
        else Console.WriteLine("Число не трехзначное");

     }  


    void Task13()
    {
            // Напишите программу, которая с помощью деления выводит третью цифру 
            //заданного числа или сообщает, что этой цифры нет
        int number = Input("Введите число:  ");
        if (number > 99)
            {
                while (number > 999)
                {
                    number /=10;
                }
                Console.WriteLine($"Третья цифра числа: {number  % 10}");
            }
        else
            {
            Console.WriteLine("Третьей цифры нет");
            }
    }



        void Task15()
        {
            // Напишите программу, которая принимает на вход цифру, обозначающая
            // день недели и проверяет является ли этот деньвыходным
            int day = Input("Введите номер дня недели:  ");

            if (day >= 1 && day<= 5)
            {
                Console.WriteLine("Будни");
            }
            else if (day == 6 || day == 7)
            {
                Console.WriteLine("Выходной");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }


        }
       

        









    



     

