
using System.Diagnostics.Eventing.Reader;

public class Calculator
{
    public int Add(string numbers)
    {
        // MINE:
        //numbers = numbers.Replace('\n', ',');

        //if (numbers == "")
        //{
        //    return 0;
        //}
        //else if (numbers.Contains(","))
        //{
        //    string[] result = numbers.Split(',');
        //    int total = 0;
        //    for (int i = 0;i < result.Length; i++)
        //    {
        //        total += int.Parse(result[i]);
        //    }
        //    return total;
        //}        
        //else
        //{
        //    return int.Parse(numbers);
        //}    

        // INSTRUCTOR:
        if (numbers == "")
        {
            return 0;
        }

        return numbers
            .Split(',', '\n') // ["1", "2", "3"]
            .Select(int.Parse) // [1, 2, 3]
            .Sum();
    }
}
