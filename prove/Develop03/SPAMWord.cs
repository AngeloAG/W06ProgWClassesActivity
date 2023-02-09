/*
Authors: Jeffrey Meldrum
	Jeremiah Powell
	Angelo Arellano Gaona
	Alvaro Nunez
	Logan Clark

  Date:2/7/2023

  Description:
  Holds the words themselves and hides the words for the meorization.

  Attributes:
  text
  isHidden = boolean

  Behaviors:
  Display()
  hidden
*/
using System;
public class SPAMWord
{
  private String _wordText;
  private bool _isHidden;

  public SPAMWord(string Word)
  {
    _wordText = Word;
    _isHidden = false;

  }

  override public String ToString()
  {
    if (_isHidden == true)
    {
      return "___";
    }

    else
    {
      return _wordText;
    }

  }

  public void changeHiddenState(bool isHidden)
  {
    _isHidden = isHidden;

  }

  public bool IsHidden()
  {
    return _isHidden;

  }
}