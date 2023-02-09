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
using system;

public class SPAMScriptureFileLoader
{

  public SPAMScriptureFileLoader()
  {

  }

  public string SPAMScriptureFinder(string SPAMBook, int SPAMchapter, int SPAMStartVerse, int SPAMEndVerse)
  {
    string SPAMFileName = ("lds-scriptures.txt");
    string SPAMScriptureText = "";
    string[] SPAMScripturesList = File.ReadAllLines (SPAMFileName);
    foreach (string SPAMLine in SPAMScripturesList)
    {
      string[] SPAMScripture = SPAMLine.Split("\n")
    }

  }
  //TODO implement method to get scriptures from file
}