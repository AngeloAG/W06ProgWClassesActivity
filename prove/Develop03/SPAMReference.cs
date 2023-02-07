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

public class SPAMReference
{
  //TODO implement attributes to hold book, chapter, verse, and endVerse
  private string _SPAMBook;
  private int _SPAMChapter;
  private int _SPAMStartVerse;
  private int _SPAMEndVerse;


  //TODO implement constructors, one that does not include endVerse and other
  // that does
  public SPAMReference(string SPAMBook, int SPAMChapter, int SPAMVerse)
  {
    _SPAMBook = SPAMBook;
    _SPAMChapter = SPAMChapter;
    _SPAMStartVerse = SPAMVerse;
  }

  public SPAMReference(string SPAMBook, int SPAMChapter, int SPAMVerse, int SPAMEndVerse){
    _SPAMBook = SPAMBook;
    _SPAMChapter = SPAMChapter;
    _SPAMStartVerse = SPAMVerse;
    _SPAMEndVerse = SPAMEndVerse;   
  }

  public string ToString(){
    return string.Format("{0} {1}:{2}-{3}", _SPAMBook, _SPAMChapter, _SPAMStartVerse, _SPAMStartVerse);
  }

  //TODO implement method to turn attributes into string
}