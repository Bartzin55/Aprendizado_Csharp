using System;

public static class StopWatch
{
    public static List<int> Stopwatch(List<int> tempo)
    {
        int segundo = tempo[2]; 
        int minuto = tempo[1];
        int hora = tempo[0];

        segundo += 1;

        if (segundo > 59)
        {
            minuto += 1;
            segundo = 0;
        }

        if (minuto > 59)
        {
            hora += 1;
            minuto = 0;
        }

        tempo[0] = hora;
        tempo[1] = minuto;
        tempo[2] = segundo;

        return tempo;
    }
}