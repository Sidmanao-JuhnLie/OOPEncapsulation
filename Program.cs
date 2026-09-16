using System;

class program
{
    static void Main(string[] args)
    {
        CarRental rental = new CarRental();


        Console.Write("Enter Customer Name: ");
        rental.customerName = Console.ReadLine();

        Console.Write("Enter Daily Rate: ");
        rental.dailyRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rental Days: ");
        rental.rentalDays = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Kilometers Traveled: ");
        rental.kilometersTraveled = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine();
        Console.WriteLine("----- CAR RENTAL SUMMARY -----");
        Console.WriteLine("Customer Name       : " + rental.customerName);
        Console.WriteLine("Daily Rate          : " + rental.dailyRate + ".00");
        Console.WriteLine("Rental Days         : " + rental.rentalDays);
        Console.WriteLine("Kilometers Traveled : " + rental.kilometersTraveled);
        Console.WriteLine();
        Console.WriteLine("Rental Charge       : " + rental.RentalCharge + ".00");
        Console.WriteLine("Mileage Charge      : " + rental.MileageCharge + ".00");
        Console.WriteLine("Insurance Fee       : " + rental.InsuranceFee + ".00");
        Console.WriteLine("Discount Amount     : " + rental.DiscountAmount.ToString("0.00"));
        Console.WriteLine("Total Rental Cost   : " + rental.TotalRentalCost + ".00");
        Console.WriteLine("-----------------------------------");
    }
}
class CarRental
{
    private String CustomerName;
    private double DailyRate;
    private int RentalDays;
    private double KilometersTraveled;

    public String customerName
    {
        get 
        { 
            return CustomerName;
        }
        set 
        { 
            CustomerName = value;
        }
    } 
    public double dailyRate
    {
        get 
        { 
            return DailyRate;
        }
        set 
        { 
            if(value > 0)
            {
                DailyRate = value;
            }
            else
            {
                Console.WriteLine("Daily rate must be greater than 0.");
            }
        }
    }
    public int rentalDays
    {
        get { 
            return RentalDays;
        }
        set 
        { 
            if(value >= 1 && value <= 30)
            {
                RentalDays = value;
            }
            else
            {
                Console.WriteLine("Rental Days must be between 1 and 30. Value not stored.");
            }
    
        }
    }
    public double kilometersTraveled
    {
        get { 
            return KilometersTraveled;
        }
        set { 
            if(value >= 0 && value <= 3000)
            {
                KilometersTraveled = value;
            }
            else
            {
                Console.WriteLine("Kilometers traveled must be between 0 and 3000.");
            }
        }
    }

    public double RentalCharge
    {
        get
        {
            return DailyRate * RentalDays;
        }
    }

    public double MileageCharge
    {
        get
        {
            if(KilometersTraveled > 300)
            {
                double ExtraKilometers = KilometersTraveled - 300;
                return ExtraKilometers * 8;
            }
            else
            {
                return 0;
            }
        }
    }

    public double InsuranceFee
    {
        get
        {
            return RentalDays * 150;
        }
    }

    public double DiscountAmount
    {
        get
        {
            if(RentalCharge >= 5)
            {
                return RentalCharge * 0.07;
            }
            else
            {
                return 0;
            }    
        }
    }

    public double TotalRentalCost
    {
        get
        {
            return RentalCharge + MileageCharge + InsuranceFee - DiscountAmount;
        }    
    }
}
