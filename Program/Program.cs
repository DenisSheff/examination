

string[] arrayString = new string[5] { "hello", "2", "world", ":-)", "computer science" };
string[] newArrayString = new string[arrayString.Length];
int maxSizeString = 3;

Console.Clear();
void CreateMaxThreeSymbolsArray(string[] collection, string[] newCollection)
{
	int count = 0;
	for (int i = 0; i < collection.Length; i++)
	{
		if (collection[i].Length <= maxSizeString)
		{
			newCollection[count] = collection[i];
			count++;
		}
	}
}
void PrintArray(string[] block)
{
	for (int i = 0; i < block.Length; i++)
	{
		Console.Write($"{block[i]} ");
	}
	Console.WriteLine();
}

CreateMaxThreeSymbolsArray(arrayString, newArrayString);
PrintArray(newArrayString);