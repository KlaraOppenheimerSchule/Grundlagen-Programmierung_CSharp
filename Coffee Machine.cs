using System;

public class CoffeeMachine
{
	private CoffeeBeansInKg;
	private WaterInKg;
	private Amount_Of_Coffee_Cooked_In_Kg;
	static maxWater = 2.5;
	static maxBeans = 2.5;

	public Vehicle(double CoffeeBeansInKg, double WaterInKg)
    {
		this.CoffeeBeansInKg = CoffeeBeansInKg;
		this.WaterInKg = WaterInKg;
    }
	

	public void getCoffeeBeansInKg()
    {
		return this.CoffeeBeansInKg();
    }

	public void getWaterInKg()
    {
		return this.WaterInKg;
    }

	public void getAmount_Of_Coffee_Cooked_In_Kg()
    {
		return this.Amount_Of_Coffee_Cooked_In_Kg;
	}
}
