namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool detectError = true;
            List<int> list = [];
            while (detectError)
            {
                Console.WriteLine("Menu Options:\n");
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("C - Clear the list");
                Console.WriteLine("F - Find a number in the list");
                Console.WriteLine("D - Enter a number to delete");
                Console.WriteLine("Q - Quit");
                char choice = Convert.ToChar(Console.ReadLine().ToUpper());
                switch (choice)
                { 
                    case 'P':
                        if (list.Count == 0)
                        {
                            Console.WriteLine("the list is empty");
                        }
                        else
                        {
                            Console.WriteLine("[ " + string.Join(" ",list) + " ]");
                        }
                        break;
                    case 'A':
                        
                        Console.WriteLine("Enter an integer to add to the list:");
                        int addNum = Convert.ToInt32(Console.ReadLine());
                        bool alreadyInList = false;
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == addNum)
                            {
                                Console.WriteLine($"{addNum} already in the list, not added."); //boooooooouns
                                alreadyInList = true;
                                break;
                            }
                        }
                        if (!alreadyInList)
                        {
                            list.Add(addNum);
                            Console.WriteLine($"{addNum} added");
                        }
                        break;
                    case 'M':
                        if (list.Count == 0)
                        {
                            Console.WriteLine("can't calculate the mean, there is no data");
                        }
                        else
                        {
                            int sum = 0;
                            for (int i = 0; i < list.Count; i++)
                            {
                                sum += list[i];
                            }
                            double mean = (double)sum / list.Count;
                            Console.WriteLine($"the mean = {mean}");
                        }
                        break;
                    case 'S':
                        if (list.Count == 0)
                        {
                            Console.WriteLine("can't determine the smallest number, list is empty");
                        }
                        else
                        {
                            int smallest = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {
                                if (list[i] < smallest)
                                {
                                    smallest = list[i];
                                }
                            }

                            Console.WriteLine($"the smallest is {smallest}");
                        }
                        break;
                    case 'L':
                        if (list.Count == 0)
                        {
                            Console.WriteLine("can't determine the largest number, list is empty");
                        }
                        else
                        {
                            int largest = list[0];
                            for (int i = 1; i < list.Count; i++)
                            {
                                if (list[i] > largest)
                                {
                                    largest = list[i];
                                }
                            }
                            Console.WriteLine($"the largest is {largest}");
                        }
                        break;
                    case 'C':
                        if (list.Count == 0)
                        {
                            Console.WriteLine("List is empty.");
                            break;
                        }
                        list.Clear();
                        Console.WriteLine("List cleared.");
                        break;
                    case 'F':
                        if (list.Count == 0)
                        {
                            Console.WriteLine("List is empty.");
                            break;
                        }
                        Console.WriteLine("Enter the number to find");
                        int findNum = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == findNum)
                            {
                                Console.WriteLine($"{findNum} found in the list at index {i}.");
                                break;
                            }
                            if (i == list.Count - 1)
                            {
                                Console.WriteLine($"{findNum} not found in the list.");
                            }
                        }
                        break;
                    case 'D':  //boooooouns
                        if (list.Count == 0)
                        {
                            Console.WriteLine("List is empty.");
                            break;
                        }
                        Console.WriteLine("Enter the number");
                        int deleteNum = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == deleteNum)
                            {
                                list.RemoveAt(i);
                                Console.WriteLine($"{deleteNum} deleted from the list.");
                                break;
                            }
                            if (i == list.Count - 1)
                            {
                                Console.WriteLine($"{deleteNum} not found in the list.");
                            }
                        }
                        break;
                    case 'Q':
                        Console.WriteLine("Goodbye!");
                        detectError = false;
                        break;
                    default:
                        Console.WriteLine("Unknown selection, please try again.");
                        detectError = true;
                        break;
                }
            }
        }
    }
}