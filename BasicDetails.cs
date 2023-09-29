using System;
using System.Text.RegularExpressions;

public class BasicDetails
{
    public static void Main()
    {
        
        string name = "ananya";
        string phoneNumber = "91 9234567213";
        string address = "hyderabad";

        
        string namePattern = @"^[A-Za-z\s]+$"; 
        string phonePattern = @"^91\s\d{10}$"; 
        string addressPattern = @"^[A-Za-z\s]+$"; 

        
        if (Regex.IsMatch(name, namePattern))
        {
            Console.WriteLine("Name: " + name);
        }
        else
        {
            Console.WriteLine("Invalid name");
        }

        
        if (Regex.IsMatch(phoneNumber, phonePattern))
        {
            Console.WriteLine("Phone Number: " + phoneNumber);
        }
        else
        {
            Console.WriteLine("Invalid phone number");
        }

        
        if (Regex.IsMatch(address, addressPattern))
        {
            Console.WriteLine("Address: " + address);
        }
        else
        {
            Console.WriteLine("Invalid address");
        }
    }
}
