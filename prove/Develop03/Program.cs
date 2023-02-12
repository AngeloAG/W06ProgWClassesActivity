/*
Authors: Jeffrey Meldrum
	Jeremiah Powell
	Angelo Arellano Gaona
	Alvaro Nunez
	Logan Clark

  Date:2/11/2023

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
    SpamTextToConsole("Welcome to the scripture memorizer");
    SpamTextToConsole("Please enter the scripture you want to try: ");
    SpamTextToConsole("Book (Case Sensitive) i.e. 1 Nephi: ");
    string spamDesiredBook = SpamGetUserInput();
    SpamTextToConsole("Chapter (Number) i.e. 3: ");
    int spamDesiredChapter = int.Parse(SpamGetUserInput());
    SpamTextToConsole("Start verse (Number) i.e. 7: ");
    int spamDesiredStartVerse = int.Parse(SpamGetUserInput());
    SpamTextToConsole("End verse (Number) i.e. 8, if not needed type 0: ");
    int spamDesiredEndVerse = int.Parse(SpamGetUserInput());

    SPAMScriptureFileLoader spamScriptureLoader = new SPAMScriptureFileLoader();

    String spamScriptureText = spamScriptureLoader.SPAMScriptureFinder(spamDesiredBook, spamDesiredChapter, spamDesiredStartVerse, (spamDesiredEndVerse == 0) ? spamDesiredStartVerse : spamDesiredEndVerse);

    SPAMReference spamReference;

    if (spamDesiredEndVerse == 0)
    {
      spamReference = new SPAMReference(spamDesiredBook, spamDesiredChapter, spamDesiredStartVerse);
    }
    else
    {
      spamReference = new SPAMReference(spamDesiredBook, spamDesiredChapter, spamDesiredStartVerse, spamDesiredEndVerse);
    }

    SPAMScripture spamScripture = new SPAMScripture(spamScriptureText, spamReference);

    bool spamKeepPrompting = true;

    while (spamKeepPrompting)
    {
      Console.Clear();
      Console.WriteLine("Scripture memorizer!");
      SpamTextToConsole("Try to memorize this scripture.\n");
      String spamScriptureString = spamScripture.ToString();
      SpamTextToConsole(spamScriptureString);
      String spamUserInput = SpamGetUserInput();

      if (spamUserInput == "q")
      {
        spamKeepPrompting = false;
      }
      if (spamScripture.GetAreAllWordsHidden())
      {
        spamKeepPrompting = false;
      }
      else
      {
        spamScripture.HideRandomWord();
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