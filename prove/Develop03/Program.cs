/*
Authors: Jeffrey Meldrum
	Jeremiah Powell
	Angelo Arellano Gaona
	Alvaro Nunez
	Logan Clark

  Date:

  Description:
  Responsibilities:
  This is the primary program file 
  that calls and runs other classes. 

  Attributes:
  Scriptures

  Behaviors:
  display Sctriptures
  quits program. 
*/

using System;

class Program
{
  static void Main(string[] args)
  {
    SPAMReference spamReference = new SPAMReference("1 Nephi", 3, 7);
    SPAMScripture spamScripture = new SPAMScripture("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.", spamReference);

    bool keep_prompting = true;

    while (keep_prompting)
    {
      Console.Clear();
      Console.WriteLine("Scripture memorizer!");
      SpamTextToConsole("Try to memorize this scripture.\n");
      String spamScriptureString = spamScripture.ToString();
      SpamTextToConsole(spamScriptureString);
      String spamUserInput = SpamGetUserInput();

      spamScripture.HideRandomWord();

      if (spamUserInput == "q")
      {
        keep_prompting = false;
      }
      if (spamScripture.GetAreAllWordsHidden())
      {
        keep_prompting = false;
      }
    }
    Console.Clear();
    SpamTextToConsole("Thank you for using this program.");
  }

  static string SpamGetUserInput()
  {
    String spamUserInput = Console.ReadLine();
    return spamUserInput;
  }

  static void SpamTextToConsole(String spamText)
  {
    Console.WriteLine(spamText);
  }

  static void SpamCloseProgram()
  {
    System.Environment.Exit(0);
  }
}