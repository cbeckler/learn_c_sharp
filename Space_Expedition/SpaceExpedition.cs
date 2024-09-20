using System;

public class SpaceExpedition
{
  public static void Main(string[] args){
    
    bool isAtomosphereBreathable = true;

    bool isGravityStable = false;

    bool resourcesSufficient = true;

    bool isHabitable = isAtomosphereBreathable&&isGravityStable;

    Console.WriteLine("Planet is habitable: "+isHabitable);

    bool suitableForExpansion = isGravityStable||resourcesSufficient;

    Console.WriteLine("Planet is suitable for expansion: "+suitableForExpansion);  

    int currentCrew = 5;

    int maxCrewCapacity = 10;

    bool canAcceptMoreCrew = currentCrew < maxCrewCapacity;

    Console.WriteLine("Can accept more crew: "+canAcceptMoreCrew);
    
  }
}