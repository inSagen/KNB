// See https://aka.ms/new-console-template for more information


    Console.WriteLine("Привет, это игра камень, ножницы, бумага!\nИгра ведётся против компьютера, побждает тот, кто выигрывает 3 раза.");
    Console.WriteLine("Для выбора знака использвуются следубщие цифры:\n1 - КАМЕНЬ\n2 - НОЖНИЦЫ\n3 - Бумага");
    var rnd = new Random();
    int playerScore = 0;
    int compScore = 0;

    while (playerScore <= 2 && compScore <= 2)
    {
        var compChoose = rnd.Next(1, 4);
        Console.WriteLine("\nПожалуйста, выберите свой знак: ");
        int playerChoose = Convert.ToInt32(Console.ReadLine());

        if (playerChoose < 1 || playerChoose > 3)
        {
            Console.WriteLine("Неверный ввод!");
            continue;
        }
        
        switch (playerChoose)
        {
            case 1:
                Console.WriteLine("Выбор игрока - КАМЕНЬ");
                break;
            case 2:
                Console.WriteLine("Выбор игрока - НОЖНИЦЫ");
                break;
            case 3:
                Console.WriteLine("Выбор игрока - БУМАГА");
                break;
        }
        
        switch (compChoose)
        {
            case 1:
                Console.WriteLine("Выбор компьютера - КАМЕНЬ");
                break;
            case 2:
                Console.WriteLine("Выбор компьютера - НОЖНИЦЫ");
                break;
            case 3:
                Console.WriteLine("Выбор компьютера - БУМАГА");
                break;
        }
        
        if ((compChoose == 1 && playerChoose == 2) || (compChoose == 2 && playerChoose == 3) || (compChoose == 3 && playerChoose == 1))
        {
            Console.WriteLine("Выигрывает компьютер!\n");
            compScore++;
        }
        else if ((compChoose == 2 && playerChoose == 1) || (compChoose == 3 && playerChoose == 2) ||
                 (compChoose == 1 && playerChoose == 3))
        {
            Console.WriteLine("Выигрывает игрок!\n");
            playerScore++;
        }
        else
        {
            Console.WriteLine("Ничья!\n");
        }     

        Console.WriteLine($"Текущий счёт:\nИгрок - {playerScore}\nКомпютер - {compScore}");
        if (playerScore == 3)
        {
            Console.WriteLine("Игрок побеждает 3-ий раз и выигрывает игру!");
        }
        else if(compScore == 3)
        {
            Console.WriteLine("Компьютер побеждает 3-ий раз и выигрывает игру!"); 
        }
    }