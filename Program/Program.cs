


string[] arrayString = new string[5] { "computer science", "-)", "1234", "-2", "1567" };
string[] newArray = new string[arrayString.Length];
int maxStringLength = 3;

Console.Clear();
void CreateThreeSymbolsArray(string[] collection, string[] newCollection)
{
	int count = 0;
	for (int i = 0; i < collection.Length; i++)
	{
		if (collection[i].Length <= maxStringLength)
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

CreateThreeSymbolsArray(arrayString, newArray);
PrintArray(newArray);
