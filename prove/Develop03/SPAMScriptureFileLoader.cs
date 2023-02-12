/*
Authors: Jeffrey Meldrum
	Jeremiah Powell
	Angelo Arellano Gaona
	Alvaro Nunez
	Logan Clark

  Date: 2/11/2023

  Description:
  access a file that will load the scriptures into the scriputre class

  Attributes:
  N/A

  Behaviors:
  Loads scripture file from csv file.
*/
using System;

public class SPAMScriptureFileLoader
{
  // establishes four lists for scripture information to be loaded into
  List<string> SPAMBookTitleList = new List<string>();
  List<int> SPAMChapterList = new List<int>();
  List<int> SPAMVerseList = new List<int>();
  List<string> SPAMScriptureTextList = new List<string>();

  public SPAMScriptureFileLoader()
  {
    // splits the scripture text file into lines and saves it inot an array
    string SPAMFileName = ("lds-scriptures.txt");
    string[] SPAMScriptureLines = File.ReadAllLines(SPAMFileName);
    // goes through each line in the text file and saves the book title, verse, and text into their corresponding lists established at the beginning of the class
    foreach (string SPAMScriptureLine in SPAMScriptureLines)
    {
      string[] SPAMScriptureParsed = SPAMScriptureLine.Split("|");
      SPAMBookTitleList.Add(SPAMScriptureParsed[0].Trim());
      SPAMChapterList.Add(int.Parse(SPAMScriptureParsed[1]));
      SPAMVerseList.Add(int.Parse(SPAMScriptureParsed[2]));
      SPAMScriptureTextList.Add(SPAMScriptureParsed[3]);
    }
  }

  // Finds the desired scripture and loads it into a string
  public string SPAMScriptureFinder(string SPAMBook, int SPAMChapter, int SPAMStartVerse, int SPAMEndVerse)
  {
    List<int> SPAMUserVerseList = new List<int>();
    int SPAMVerseLoader = SPAMStartVerse;

    // gets all the verses that the user requires and loads them into a list
    while (SPAMVerseLoader != SPAMEndVerse + 1)
    {
      SPAMUserVerseList.Add(SPAMVerseLoader);
      SPAMVerseLoader++;
    }

    // code that checks the users input with every scriputre and gets the desired scripture text
    int i = 0;
    string SPAMDesiredScriptureText = "";
    foreach (string SPAMBookTitle in SPAMBookTitleList)
    {
      if (SPAMBook == SPAMBookTitleList[i] && SPAMChapter == SPAMChapterList[i])
      {
        foreach (int SPAMVerse in SPAMUserVerseList)
        {
          if (SPAMVerse == SPAMVerseList[i])
          {
            SPAMDesiredScriptureText = SPAMDesiredScriptureText + "\n" + " " + SPAMVerseList[i] + " " + SPAMScriptureTextList[i].Trim();
          }
        }
      }
      i++;
    }
    // if the user inputs something that doesn't exist
    if (SPAMDesiredScriptureText == "")
    {
      Console.WriteLine("Could not find. Check spelling, it is case sensitive.");
    }
    return SPAMDesiredScriptureText;
  }
}