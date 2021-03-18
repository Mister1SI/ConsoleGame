using System;
using System.IO;
public class ConsoleApp {
  public static void Main() {
    bool isAlive = true;
    int score;
    if (isAlive) {
      string ReadName;
      Console.WriteLine("Welcome\n==========\nWould you like to select a new name?(y or n)");
      string newName = Console.ReadLine();
      if (newName == "y") {
        Console.WriteLine("Enter a new name:");
        string Name = Console.ReadLine();
        File.WriteAllText("data.txt", Name);
        ReadName = File.ReadAllText("data.txt");
        Console.WriteLine("Welcome " + ReadName + ", it's time to get started.");
      } else {
        ReadName = File.ReadAllText("data.txt");
        Console.WriteLine("Welcome back " + ReadName + ", it's time to begin.");
      }
      Console.WriteLine("==========\nSo you are standing in an alley, and a dark silhouette   is walking towards you. They have a bottle and they say they want to give it to you. Do you drink it?(y or n)");
      string res = Console.ReadLine();
     if (res == "y") {
        Console.WriteLine("After drinking it, you feel sick.  You get worse and worse, and crumple onto the ground.");
        score = 150;
        Console.WriteLine("You have died. Score: " + score);
        return;
      } else {
        Console.WriteLine("You made a good choice. The silhouette drinks it and dies.  Do you run away?(y or n)");
      }
    
    }
  }
}