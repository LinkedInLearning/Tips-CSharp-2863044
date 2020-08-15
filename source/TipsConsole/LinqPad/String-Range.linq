<Query Kind="Statements" />

string letters = "abcdefghijklmnopqrstuvwxyz";

var results = letters[3..6];

results.Dump();

results = letters [5..^5];

results.Dump();

results = letters[^16..^2];

results.Dump();