using HareAndTortoiseV2;
using System;

public class Race
{
    public Race()
    {

    }
	public static void Go(int distance, int MinSpeed)//arrays are located through Globals.*
	{
        int noOfRacers = Globals.speed.Length;

        bool winner = false;


        Random random = new Random();

        //create local arrays
        int[] location;
        int[] speedMax;
        int[] stamina;

        speedMax = new int[noOfRacers];
        location = new int[noOfRacers];
        stamina = new int[noOfRacers];

        //add to local arrays 
        //IS THERE ANY POINT TO THIS? TEST WHEN COMPLETE
        for (int i = 0; i < noOfRacers; i++)
        {
            speedMax[i] = Globals.speed[i];
        }
        for (int i = 0; i < noOfRacers; i++)
        {
            stamina[i] = Globals.endurance[i];
        }

        //Process
        while (winner == false)
        {
            for (int i = 0; i < noOfRacers; i++)
            {
                if (stamina[i] != 0)
                {
                    location[i] += random.Next(MinSpeed, speedMax[i]);
                    stamina[i]--;
                }
                else
                {
                    stamina[i] += Globals.endurance[i];
                }
                if (location[i] == distance)
                {
                    winner = true;
                    Globals.wins[i]++;
                }
            }
        }
    }
}
