using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      yes this is really good, must be
      Author: Atika Dewi Suryani
      */


      // Let the user know that the program is starting:
Console.Write("your program is running, please wait a minute..");

Console.Write("Enter your name: ");
string name= Console.ReadLine();

Console.WriteLine($"Alright we got your name, your name is {name}, right?");

Console.WriteLine("Your response: ");

      // Give the Mad Lib a title:
string answer = Console.ReadLine();
if (answer == "yes" || answer == "ya" ){
  Console.Write("You can input your story name here : ");
  string storyName = Console.ReadLine();

  Console.WriteLine($"Well, hi {name}. My name is Jarvis, I will help you understand your story, then well here is your story title is \"{storyName}\". Begin..");

  // Console.WriteLine(title);
// Define user input and variables:
Console.Write("But, i need you to help me first we need some \"several verbs\" noun, your first verb here: ");
string verb = Console.ReadLine();
Console.Write("Verb 2: ");
string verb2 = Console.ReadLine();
Console.Write("Verb 3: ");
string verb3 = Console.ReadLine();
Console.Write("Verb 4: ");
string verb4 = Console.ReadLine();
Console.Write("Verb 5: ");
string verb5 = Console.ReadLine();

Console.WriteLine("well we can continue ya, to the noun section..");

Console.Write("Yeay, we already collect your words !, Next we need your \"10 nouns\" ya..please input the first here : "); 
string noun = Console.ReadLine();
Console.Write("Noun 2 : ");
string noun2 = Console.ReadLine(); 
Console.Write("Noun 3: ");
string noun3 = Console.ReadLine(); 
Console.Write("Noun 4: "); 
string noun4 = Console.ReadLine(); 
Console.Write("Noun 5: "); 
string noun5 = Console.ReadLine(); 
Console.Write("Noun 6: "); 
string noun6 = Console.ReadLine(); 
Console.Write("Noun 7: "); 
string noun7 = Console.ReadLine(); 
Console.Write("Noun 8: "); 
string noun8 = Console.ReadLine(); 
Console.Write("Noun 9: "); 
string noun9 = Console.ReadLine(); 
Console.Write("Noun 10: "); 
string noun10 = Console.ReadLine(); 

Console.WriteLine("then we at the last section ya, to the adj section..");

Console.Write("I need \" several adjectives\" too, please also input what is your mind, here okay : ");
string adj = Console.ReadLine(); 
Console.Write("adj 2 : ");
string adj2 = Console.ReadLine(); 
Console.Write("adj 3 : ");
string adj3 = Console.ReadLine(); 
Console.Write("adj 4: ");
string adj4 = Console.ReadLine();
Console.Write("adj 5: ");
string adj5 = Console.ReadLine();  


Console.Write("Here is your story.., ready?,\n your input here : ");
string answer2 = Console.ReadLine();
  // The template for the story:

if (answer2 == "yes" || answer2 == "ya" || answer3 = "ready") {
Console.WriteLine($"This morning {noun} woke up feeling {adj}. 'It is going to be a {adj2} day!' Outside, a bunch of {noun2}s were protesting to keep {verb} in stores. They began to {verb2} to the rhythm of the {noun3}, which made all the {noun4}s very {adj3}. Concerned, {noun5} texted {noun6}, who flew {adj4} to {verb5} and dropped {noun7} in a puddle of frozen {adj5}. {noun8} woke up in the year {noun9}, in a world where {noun10}s ruled the world.");
    } else {
Console.WriteLine("Well, you can open new tab on your browser, we didn't provide what you want, sorry 0**0");
    }
}

 else {
  Console.WriteLine("Well, you can open new tab on your browser, we didn't provide what you want, sorry 0**0");
      }
    }
  }
}
