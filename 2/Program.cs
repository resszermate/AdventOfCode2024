namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1();
            Part2();
        }

        static void Part1()
        {
            string[] data = File.ReadAllLines("input.txt");
            int safeReports = 0;
            foreach (string line in data)
            {
                int[] values = line.Split(' ').Select(int.Parse).ToArray();

                if (values[0] > values[1])
                {
                    int counter = 0;
                    while (counter < values.Length - 1 && values[counter] > values[counter + 1] && values[counter] - values[counter + 1] >= 1 && values[counter] - values[counter + 1] <= 3)
                    {
                        counter++;
                    }
                    if (counter >= values.Length - 1)
                    {
                        safeReports++;
                    }
                }
                else
                {
                    int counter = 0;
                    while (counter < values.Length - 1 && values[counter] < values[counter + 1] && values[counter + 1] - values[counter] >= 1 && values[counter + 1] - values[counter] <= 3)
                    {
                        counter++;
                    }
                    if (counter >= values.Length - 1)
                    {
                        safeReports++;
                    }

                }


            }
            //Console.WriteLine(safeReports);

        }

        static void Part2()
        {

            string[] data = File.ReadAllLines("input.txt");
            int safeReports = 0;
            foreach (string line in data)
            {
                int[] values = line.Split(' ').Select(int.Parse).ToArray();

                if (values[0] > values[1])
                {
                    int counter = 0;
                    while (counter < values.Length - 1 && values[counter] > values[counter + 1] && values[counter] - values[counter + 1] >= 1 && values[counter] - values[counter + 1] <= 3)
                    {
                        counter++;
                    }
                    if (counter >= values.Length - 1)
                    {
                        safeReports++;
                    }
                    else
                    {
                        // Try removing each element once and see if removing it makes the report safe
                        for (int i = 0; i < values.Length; i++)
                        {
                            List<int> valuesDampened = values.ToList();
                            valuesDampened.RemoveAt(i);
                            int counterDampened = 0;
                            if (valuesDampened[0] > valuesDampened[1])
                            {
                                while (counterDampened < valuesDampened.Count - 1 && valuesDampened[counterDampened] > valuesDampened[counterDampened + 1] && valuesDampened[counterDampened] - valuesDampened[counterDampened + 1] >= 1 && valuesDampened[counterDampened] - valuesDampened[counterDampened + 1] <= 3)
                                {
                                    counterDampened++;
                                }
                                if (counterDampened >= valuesDampened.Count - 1)
                                {
                                    safeReports++;
                                    break;
                                }
                            }
                            else
                            {
                                while (counterDampened < valuesDampened.Count - 1 && valuesDampened[counterDampened] < valuesDampened[counterDampened + 1] && valuesDampened[counterDampened + 1] - valuesDampened[counterDampened] >= 1 && valuesDampened[counterDampened + 1] - valuesDampened[counterDampened] <= 3)
                                {
                                    counterDampened++;
                                }
                                if (counterDampened >= valuesDampened.Count - 1)
                                {
                                    safeReports++;
                                    break;
                                }
                            }
                            


                        }
                    }
                }
                else
                {
                    int counter = 0;
                    while (counter < values.Length - 1 && values[counter] < values[counter + 1] && values[counter + 1] - values[counter] >= 1 && values[counter + 1] - values[counter] <= 3)
                    {
                        counter++;
                    }
                    if (counter >= values.Length - 1)
                    {
                        safeReports++;
                    }
                    else
                    {
                        // Try removing each element once and see if removing it makes the report safe
                        for (int i = 0; i < values.Length; i++)
                        {
                            List<int> valuesDampened = values.ToList();
                            valuesDampened.RemoveAt(i);
                            int counterDampened = 0;
                            if (valuesDampened[0] > valuesDampened[1])
                            {
                                while (counterDampened < valuesDampened.Count - 1 && valuesDampened[counterDampened] > valuesDampened[counterDampened + 1] && valuesDampened[counterDampened] - valuesDampened[counterDampened + 1] >= 1 && valuesDampened[counterDampened] - valuesDampened[counterDampened + 1] <= 3)
                                {
                                    counterDampened++;
                                }
                                if (counterDampened >= valuesDampened.Count - 1)
                                {
                                    safeReports++;
                                    break;
                                }
                            }
                            else
                            {
                                while (counterDampened < valuesDampened.Count - 1 && valuesDampened[counterDampened] < valuesDampened[counterDampened + 1] && valuesDampened[counterDampened + 1] - valuesDampened[counterDampened] >= 1 && valuesDampened[counterDampened + 1] - valuesDampened[counterDampened] <= 3)
                                {
                                    counterDampened++;
                                }
                                if (counterDampened >= valuesDampened.Count - 1)
                                {
                                    safeReports++;
                                    break;
                                }
                            }
                        }

                        }

                    }
            }
            Console.WriteLine(safeReports);
        }
  
    }
}
