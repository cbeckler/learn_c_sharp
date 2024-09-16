using System;

public class GalacticTravelAgency { 
  public static void Main(string[] args) {
    // Project to play around with variable creation and conversion

    string passengerName = "Zara";
    int passengerAge = 28;
    string ticketType = "First Class";
    string preferredPlanet = "Mars";

    Console.Write(passengerName+"\n");
    Console.Write(passengerAge+"\n");
    Console.Write(ticketType+"\n");
    Console.Write(preferredPlanet+"\n");

    passengerAge = passengerAge + 1;

    Console.Write(passengerAge+"\n");

    // explicit conversion
    double passengerAgeDouble = (double) passengerAge;

    Console.Write(passengerAgeDouble+"\n");

    // implicit conversion
    double passengerAgeDouble2 = passengerAge;

    Console.Write(passengerAgeDouble2+"\n");

    string passengerAgeString = Convert.ToString(passengerAge);

    Console.Write(passengerAgeString);
    
  }
}