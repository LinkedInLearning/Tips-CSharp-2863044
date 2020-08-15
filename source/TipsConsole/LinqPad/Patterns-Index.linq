<Query Kind="Statements" />

// C# 8.0 introduces a functional feature called slicing. 
// In order to make it possible, two new concepts are introduced: Indexes and Ranges.

//The main purpose of introducing slicing into the language is to make working with arrays and strings easier.
// There is limited support for slicing in collections, use LINQ instead.

var words = new List<string>
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

words[0].Dump("Old Style: first item"); // use index value to get first item
words[words.Count - 1].Dump("Old Style: Last item"); // get last item

"--------------------".Dump();


// C# 8 improvement
// System.Index: It represents an index into the given sequence or collection.

var firstIndex = new System.Index(value: 0);

words[firstIndex].Dump("Use Index class: first item");

var lastIndex = new System.Index(value: 1, fromEnd:true);
words[lastIndex].Dump("Use Index class: last item");

// a new operator "^"

// ^ Operator: It is known "hat operator, or as the index from the end operator. 
// It is a compact way to indicate an index from the end of the sequence.

// Example: get 2 index item from front and end

words[2].Dump("Index= 2");
words[^2].Dump("Index= ^2");
// https://www.geeksforgeeks.org/range-and-indices-in-c-sharp-8-0/