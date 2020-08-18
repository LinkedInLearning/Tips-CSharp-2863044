<Query Kind="Program">
  <Reference Relative="..\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// SelectMany flattens a one-many relationship
// or saying it another way , it can ungroup nested sequences
void Main()
{
	HistoryCalendar cal;
	var calendars = new List<HistoryCalendar> ();
	
	cal = new HistoryCalendar();
	cal.Decade = "Seventies";
	cal.Years = Enumerable.Range(1970, 10).ToList();
	calendars.Add(cal);
	
	cal = new HistoryCalendar();
	cal.Decade = "Eighties";
	cal.Years = Enumerable.Range(1980, 10).ToList();
	calendars.Add(cal);
	var q = from calendar in calendars
					select calendar;
					
q.Dump();
var q2 = calendars.SelectMany(m =>m.Years );
//q2.Dump();
}

// Define other methods and classes here
public class HistoryCalendar
{

	public string Decade { get; set; }
	public List<int> Years { get; set; }
}