/*
Authors: Jeffrey Meldrum
	Jeremiah Powell
	Angelo Arellano Gaona
	Alvaro Nunez
	Logan Clark

  Date:2/7/2023

  Description:
  Display the list or words and the hidden words.

  Attributes:
  list<word>
  reference
  hiddenWordAmount

  Behaviors:
  Dsiplay()
  randomlyHiddenWord():bool
*/
using System;
public class SPAMScripture
{
  List<SPAMWord> _scriputre = new List<SPAMWord>();
  private SPAMReference _reference;
  private int hiddenWordAmount;

  //Implement constructor to initialize attributes
  public SPAMScripture(string scriputre, SPAMReference reference)
  {
    string[] _parse = scriputre.Split(' ');
    foreach (var parse in _parse)
    {
      SPAMWord parse_word = new SPAMWord(parse);
      _scriputre.Add(parse_word);
    }
    _reference = reference;
  }

  override public String ToString()
  {
    string complete_scriputure = " ";
    foreach (var scriputre in _scriputre)
    {
      complete_scriputure += scriputre.ToString();
      complete_scriputure += " ";
    }
    return complete_scriputure;
  }
  public bool GetAreAllWordsHidden()
  {
    int Length_scripture = _scriputre.Count;
    if (Length_scripture == hiddenWordAmount)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
  public void HideRandomWord()
  {
    Random r = new Random();
    _scriputre[r.Next(0, _scriputre.Count)].changeHiddenState(true);
  }

}