using System;
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
