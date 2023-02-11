/*
Authors: Jeffrey Meldrum
	Jeremiah Powell
	Angelo Arellano Gaona
	Alvaro Nunez
	Logan Clark

  Date:

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
  List<string> SPAMBookTitleArray = new List<string>();
  List<int> SPAMChapterArray = new List<int>();
  List<int> SPAMVerseArray = new List<int>();
  List<string> SPAMScriptureTextArray = new List<string>();
  
  public SPAMScriptureFileLoader()
  {
    string SPAMFileName = ("lds-scriptures.txt");
    string SPAMScriptureText = "";
    string[] SPAMScriptureLines = File.ReadAllLines (SPAMFileName);
    foreach (string SPAMScriptureLine in SPAMScriptureLines)
    {
      string[] SPAMScriptureParsed = SPAMScriptureLine.Split("|");
      SPAMBookTitleArray.Add(SPAMScriptureParsed[0]);
      SPAMChapterArray.Add(int.Parse(SPAMScriptureParsed[1]));
      SPAMVerseArray.Add(int.Parse(SPAMScriptureParsed[2]));
      SPAMScriptureTextArray.Add(SPAMScriptureParsed[3]);
    }
  }

  public string SPAMScriptureFinder(string SPAMBook, int SPAMChapter, int SPAMStartVerse, int SPAMEndVerse)
  {
    
  }
  //TODO implement method to get scriptures from file
}