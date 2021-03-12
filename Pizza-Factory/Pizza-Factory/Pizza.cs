using System;

public class Pizza: Food, IFood
{
	public string Size { get; set; }
	public int NumberOfToppings { get; set; }
    public string Crust { get; set; }
    int IFood.Temperature { get; set; } // forced implented property

    // set to private to ensure forced-use of the CreateInstance method to generate new objects.
    public Pizza(string size, int numberOfToppings, string crust)
	{
		this.Size = size;
		this.NumberOfToppings = numberOfToppings;
        this.Crust = crust;
	}

	// used to interrupt constructor if encountering invalid data.
	public static Pizza CreateInstance (string size, int numberOfToppings, string crust)
    {
		if (crust == "white" || crust == "wheat")
        {
			return new Pizza(size, numberOfToppings, crust);
        } else
        {
			return null;
        }
    }

	/// <summary>
	/// Used to increment number of toppings on pizza.
	/// </summary>
	/// <param name="addedToppingsNumber"></param>
	public void AddToppings(string addedToppingsNumber)
    {
        try
        {
            int.Parse(addedToppingsNumber);
        } catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }



		//this.numberOfToppings +=  addedToppingsNumber;
    }

    // Required abstracted methods due to the interface.
    public void IsSoftOrSolid()
    {
        throw new NotImplementedException();
    }

}
