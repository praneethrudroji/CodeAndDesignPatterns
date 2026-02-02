namespace Programming;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<List<string>> res = NQueensClass.NQueens(n);
        foreach (List<string> row in res)
        {
            Console.WriteLine(string.Join(' ', row));
        }
    }
}
