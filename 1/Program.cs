namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = File.ReadAllLines("input.txt").ToList();

            List<int> nums1 = new List<int>();
            List<int> nums2 = new List<int>();

            foreach (string str in list)
            {
                string[] line = System.Text.RegularExpressions.Regex.Split(str, @"\s{2,}");


                nums1.Add(int.Parse(line[0]));
                nums2.Add(int.Parse(line[1]));
            }

            nums1.Sort();
            nums2.Sort();

            int totalDistance = 0;

            for (int i = 0; i < nums1.Count; i++)
            {
                totalDistance += Math.Abs(nums1[i] - nums2[i]);
            }

            Console.WriteLine(totalDistance);
        }
    }
}
