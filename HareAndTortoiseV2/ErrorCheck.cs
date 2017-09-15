using System;

public class ErrorCheck
{
	public ErrorCheck()
	{

	}

    public int Item(string toCheck, int minVal, int maxVal)//One Item to check
    {
        int check = 0;//temp Var to carry number.
        if (toCheck == "")//Check for blank string
        {
            return 0;
        }
        else
        {
            check = Int16.Parse(toCheck);//convert to integer
            if (check < minVal)//less than 100m
            {
                return 0;
            }
            else if (check > maxVal)//greater than 1000m
            {
                return 0;
            }
            else//acceptable value
            {
                return check;//return checked value to variable
            }
        }
    }

    public void Compare(string minSpeed, string maxSpeed, int minVal, int maxVal, out int minChecked, out int maxChecked)//Checking against two values, compare
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
            if (minCheck < minVal || maxCheck < minVal)//less than 
            {
                minChecked = 0;
                maxChecked = 0;
            }
            else if (minCheck > maxVal || maxCheck > maxVal)//greater than 
            {
                minChecked = 0;
                maxChecked = 0;
            }
            else if (minCheck > maxCheck || maxCheck < minCheck)
            {
                minChecked = 0;
                maxChecked = 0;
            }
            else//acceptable value
            {
                minChecked = minCheck;
                maxChecked = maxCheck;//return checked value to variable
            }
        }
    }
}
