using System;

public class ErrorCheck
{
	public ErrorCheck()
	{

	}

    public static void fromString(string check, int minVal, int maxVal, out int WasChecked)//One string to check
    {
        if (check == "")//Check for blank string
        {
            WasChecked = 0;
        }
        else
        {
            fromNum(Int16.Parse(check), minVal, maxVal, out WasChecked);
        }
    }

    public static void fromNum(int toCheck, int minVal, int maxVal, out int hasChecked)
    {
        if (toCheck < minVal)//less than 100m
        {
            hasChecked = 0;
        }
        else if (toCheck > maxVal)//greater than 1000m
        {
            hasChecked = 0;
        }
        else//acceptable value
        {
            hasChecked = toCheck;//return checked value to variable
        }
    }

    public static void compareFromString(string minSpeed, string maxSpeed, int minVal, int maxVal, out int minChecked, out int maxChecked)//Checking against two values, compare
    {
        //min\maxCHECK - internal check vars, min\maxCHECKED - returned values
        int minCheck = 0;//temp Var to carry number.
        int maxCheck = 0;
        if (minSpeed == "" || maxSpeed == "")//Check for blank string
        {
            minChecked = 0;
            maxChecked = 0;
        }
        else
        {
            minCheck = Int16.Parse(minSpeed);//convert to integer
            maxCheck = Int16.Parse(maxSpeed);
            compareFromNum(minCheck, maxCheck, minVal, maxVal, out minChecked, out maxChecked);
        }
    }

    public static void compareFromNum(int minSpeed, int maxSpeed, int minVal, int maxVal, out int minCheck, out int maxCheck)//Checking against two values
    {
        if (minSpeed < minVal || maxSpeed < minVal)//less than 
        {
            minCheck = 0;
            maxCheck = 0;
        }
        else if (minSpeed > maxVal || maxSpeed > maxVal)//greater than 
        {
            minCheck = 0;
            maxCheck = 0;
        }
        else if (minSpeed > maxSpeed || maxSpeed < minSpeed)
        {
            minCheck = 0;
            maxCheck = 0;
        }
        else//acceptable value
        {
            minCheck = minSpeed;
            maxCheck = maxSpeed;//return checked value to variable
        }
    }
}
