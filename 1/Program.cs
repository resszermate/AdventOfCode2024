namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> file = File.ReadAllLines("input.txt").ToList();

            List<int> numbers1 = new List<int>();
            List<int> numbers2 = new List<int>();

            foreach (string line in file)
            {
                List<string> splitLine = System.Text.RegularExpressions.Regex.Split(line, @"\s{2,}").ToList();
                numbers1.Add(int.Parse(splitLine[0]));
                numbers2.Add(int.Parse(splitLine[1]));
            }

            numbers1.Sort();
            numbers2.Sort();

            int totalDistance = 0;

            for (int i = 0; i < numbers1.Count; i++)
            {
                totalDistance += Math.Abs(numbers1[i] - numbers2[i]);
            }

            Console.WriteLine(totalDistance);

            int simScore = 0;

            for (int i = 0; i < numbers1.Count; i++)
            {
                int appearsTimes = numbers2.Where(x => x == numbers1[i]).Count();
                simScore += appearsTimes * numbers1[i];
            }

            Console.WriteLine(simScore);
        }
    }
}
