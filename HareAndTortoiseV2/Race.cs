using System;

public class Race
{
	public Race(int distance, int tMinSpeed, int tMaxSpeed, int hMinSpeed, int hMaxSpeed, int restIncrease, int restChance)
	{
        int tLocation = 0;
        int hlocation = 0;
        int restRand = 0;


        Random random = new Random();

        //Process
        while ((tLocation <= distance) && (hlocation <= distance))
        {
            tLocation += random.Next(tMinSpeed, tMaxSpeed);//always change
            restRand = random.Next(0, 100);//generate rest chance (0 -> 100%)
            if (restRand <= (100 - restChance))
            {
                hlocation += random.Next(hMinSpeed, hMaxSpeed);
                restChance += restIncrease;
                if (restChance > 100)//Stops over 100% chance
                {
                    restChance = 100;
                }
            }
            else
            {
                restChance -= (restIncrease * 2);
                if (restChance < 1) //Stops negative chance
                {
                    restChance = 0;
                }
            }
            tbWin.Text = hlocation.ToString();
        }

        //Out
        if ((tLocation >= distance) && (hlocation >= distance))
        {
            tbWin.Text = "Its a Draw!";
        }
        else if (tLocation >= distance)
        {
            tbWin.Text = "Tortoise Wins!";
            tWins += 1;
            lblTWins.Text = tText + tWins;
        }
        else if (hlocation >= distance)
        {
            tbWin.Text = "Hare Wins!";
            hWins += 1;
            lblHWins.Text = hText + hWins;
        }
    }
}
