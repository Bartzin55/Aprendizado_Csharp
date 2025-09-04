

bool validador = true;
bool validadorinterno;
bool validadorinterno_2;
while (validador)
{
    DateTime tempo = DateTime.Now;
    Console.Clear();
    Console.WriteLine(tempo.ToString("dd/MM/yyyy, HH'h':mm'm'"));
    Console.WriteLine("\n1 - Relógio;\n2 - Cronômetro;\n3 - Temporizador;\nESC - Sair.");
    Thread.Sleep(500);
    Console.Clear();
    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo tecla = Console.ReadKey(intercept: true);
        switch (tecla.Key)
        {
            case ConsoleKey.Escape:
                Console.WriteLine("Saindo...");
                validador = false;
                break;

            case ConsoleKey.D1:
                validadorinterno = true;
                while (validadorinterno)
                {
                    tempo = DateTime.Now;
                    Console.WriteLine(tempo.ToString("dd/MM/yyyy, HH:mm:ss"));
                    Console.Write("Pressione ESC para voltar...");
                    if (Console.KeyAvailable)
                    {
                        tecla = Console.ReadKey(intercept: true);
                        if (tecla.Key == ConsoleKey.Escape)
                        {
                            validadorinterno = false;
                        }
                    }
                    Thread.Sleep(500);
                    Console.Clear();
                }
                break;


            case ConsoleKey.D2: //cronometro
                validadorinterno = true;
                while (validadorinterno)
                {
                    Console.WriteLine("00:00:00\n\nBARRA DE ESPAÇO - Iniciar;\nESC - Sair.");
                    if (Console.KeyAvailable)
                    {
                        tecla = Console.ReadKey(intercept: true);
                        switch (tecla.Key)
                        {
                            case ConsoleKey.Escape:
                                validadorinterno = false;
                                break;

                            case ConsoleKey.Spacebar:
                                validadorinterno_2 = true;
                                List<int> tempocronometrado = new List<int> { 0, 0, 0 };
                                while (validadorinterno_2)
                                {
                                    Console.Clear();
                                    string strtempo = $"{tempocronometrado[0].ToString("D2")}:{tempocronometrado[1].ToString("D2")}:{tempocronometrado[2].ToString("D2")}";
                                    Console.WriteLine($"{strtempo}\n\nPressione BARRA DE ESPAÇO para parar...");
                                    tempocronometrado = StopWatch.Stopwatch(tempocronometrado);
                                    Thread.Sleep(1000);
                                    if (Console.KeyAvailable)
                                    {
                                        tecla = Console.ReadKey(intercept: true);
                                        if (tecla.Key == ConsoleKey.Spacebar)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"O tempo foi de {strtempo}\n\n-----------------------\n");
                                            Console.WriteLine("Pressione qualquer tecla para voltar...");
                                            Console.ReadKey();
                                            validadorinterno_2 = false;
                                        }
                                    }
                                }
                                break;
                        }
                    }
                    Thread.Sleep(500);
                    Console.Clear();
                }
                break;


            case ConsoleKey.D3:
                Console.WriteLine("Temporizador");
                break;
        }
    }
}
