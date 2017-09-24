using HareAndTortoiseV2;
using System;

public class Race
{
    public Race()
    {

    }
	public static void Go(int distance, int[] minSpeeds, int[] maxSpeeds, int[]endurance, out int win)//arrays are located through Globals.*
	{
        int noOfRacers = minSpeeds.Length;
        int movement = 0;
        bool winner = false;
        Random random = new Random();
        int[] location = new int[noOfRacers];

        //Process
        while (winner == false)
        {
            for (int i = 0; i < noOfRacers; i++)
            {
                if (endurance[i] != 0)
                {
                    movement = random.Next(minSpeeds[i], maxSpeeds[i]);
                    location[i] += movement
                    endurance[i] -= movement;
                }
                else
                {
                    endurance[i] += (minSpeeds[i]*3);
                }
                if (location[i] == distance)
                {
                    winner = true;
                    win = i;
                }
            }
        }
    }
}
