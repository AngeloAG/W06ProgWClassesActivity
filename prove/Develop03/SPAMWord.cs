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

public class SPAMWord
{
  private String _wordText;
  private bool _isHidden;
  
  //TODO implement attributes to hold the text of the word and 
  // the flag to know if it's hidden or not


  //TODO implement constructor to initialize object
  public SPAMWord(string Word)
  {
    _wordText = Word;
    _isHidden = false;

  }

  public String ToString()
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
  //TODO implement method to return the words as string or underscores if 
  // it is hidden

  //TODO implement method to change the hidden state of this word
}