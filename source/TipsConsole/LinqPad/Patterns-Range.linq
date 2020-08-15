<Query Kind="Statements" />

var words = new string []
{
                   // index from start    index from end
    "zero",       // 0                    ^10
    "ten",        // 1                    ^9
    "twenty",     // 2                    ^8
    "thirty",     // 3                    ^7
    "forty",      // 4                    ^6
    "fifty",      // 5                    ^5
    "sixty",      // 6                    ^4
    "seventy",    // 7                    ^3
    "eighty",     // 8                    ^2
	  "ninety"      // 9                    ^1
};                // 10 (or words.Length) ^0

// get a range with the Skip, Take Linq operators

var q = from w in words
				select w;
q.Skip(2).Take(4).Dump();				

Range rangeA = new Range(start:2,end:4);

words[rangeA].Dump();



// System.Range: It represents a sub-range of the given sequence or collection.


// ".." Operator: is the range operator. 
//  It is a compact way to indicate a range of items in sequence.


Range rangeB = 4..8;

words[rangeB].Dump();