class Program
{
    static void Main()
    {
        string[] surnames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez" };

        bool allLongerThanThree = surnames.All(name => name.Length > 3);
        Console.WriteLine($"All surnames longer than 3 characters: {allLongerThanThree}");

        bool allLongerThanThreeAndLessThanTen = surnames.All(name => name.Length > 3 && name.Length < 10);
        Console.WriteLine($"All surnames longer than 3 characters and less than 10 characters: {allLongerThanThreeAndLessThanTen}");

        bool anyStartsWithW = surnames.Any(name => name.StartsWith("W"));
        Console.WriteLine($"At least one surname starts with 'W': {anyStartsWithW}");

        bool anyEndsWithY = surnames.Any(name => name.EndsWith("y"));
        Console.WriteLine($"At least one surname ends with 'y': {anyEndsWithY}");

        bool containsOrange = surnames.Contains("Orange");
        Console.WriteLine($"Contains 'Orange': {containsOrange}");

        string firstWithLengthSix = surnames.FirstOrDefault(name => name.Length == 6);
        Console.WriteLine($"First surname with length 6: {firstWithLengthSix}");

        string lastWithLengthLessThanFifteen = surnames.LastOrDefault(name => name.Length < 15);
        Console.WriteLine($"Last surname with length less than 15: {lastWithLengthLessThanFifteen}");
    }
}
