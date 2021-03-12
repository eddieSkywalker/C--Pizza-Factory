using System;

public class Food
{
    public int calories { get; set; }
    public bool canBeEaten { get; set; }

    public Food()
	{
		int calories;
		bool canBeEaten;
	}

	public void GetNutrition()
    {
        Console.WriteLine("Running GetNutrition() method.\nThe amount of calories in this food are " + this.calories + "\nCan this food be eaten? " + this.canBeEaten + "\n");
    }
}
