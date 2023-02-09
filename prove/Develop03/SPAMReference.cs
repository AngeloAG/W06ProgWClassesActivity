/*
Authors: Jeffrey Meldrum
	Jeremiah Powell
	Angelo Arellano Gaona
	Alvaro Nunez
	Logan Clark

  Date:

  Description:
  Holds information about the book
  chapter and verse dependent on it a beginning or end verse.

  Attributes:
  Book
  Chapter
  Startverse
  Endverse

  Behaviors:
  Display()
*/
using System;
public class SPAMReference
{
  //TODO implement attributes to hold book, chapter, verse, and endVerse
  private string _SPAMBook;
  private int _SPAMChapter;
  private int _SPAMStartVerse;
  private int _SPAMEndVerse = 0;


  //TODO implement constructors, one that does not include endVerse and other
  // that does
  public SPAMReference(string SPAMBook, int SPAMChapter, int SPAMVerse)
  {
    _SPAMBook = SPAMBook;
    _SPAMChapter = SPAMChapter;
    _SPAMStartVerse = SPAMVerse;
  }

  public SPAMReference(string SPAMBook, int SPAMChapter, int SPAMVerse, int SPAMEndVerse)
  {
    _SPAMBook = SPAMBook;
    _SPAMChapter = SPAMChapter;
    _SPAMStartVerse = SPAMVerse;
    _SPAMEndVerse = SPAMEndVerse;
  }

  override public string ToString()
  {

    if (_SPAMEndVerse == 0){
      return string.Format("{0} {1}:{2}", _SPAMBook, _SPAMChapter, _SPAMStartVerse);
    }
    else{
      return string.Format("{0} {1}:{2}-{3}", _SPAMBook, _SPAMChapter, _SPAMStartVerse, _SPAMEndVerse);
    }
  }

  //TODO implement method to turn attributes into string
}