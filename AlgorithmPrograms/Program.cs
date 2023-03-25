using AlgorithmPrograms.AnagramDetection;
using AlgorithmPrograms.BinarySearch;
using AlgorithmPrograms.BubbleSort;
using AlgorithmPrograms.CustomizeMessage;
using AlgorithmPrograms.DataStructureProblems;
using AlgorithmPrograms.InsertionSort;
namespace AlgorithmPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose Option to perform\n1.Binary Search for Word \n2.Insertion Sort \n3.Bubble sort " +
                    "\n4.Anagram \n5.Prime Range NUmber \n6.Customize Message \n7.UnOrder List(Data Structure Problems) \n8.Ordered List \n9.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        BinaryWrodSearch search = new BinaryWrodSearch();
                        search.ReadFile(@"D:\BridgeLabs\AlgorithmPrograms\AlgorithmPrograms\BinarySearch\File.txt");
                        break;
                        case 2:
                        InserationSorting sorting = new InserationSorting();
                        sorting.ReadFile(@"D:\BridgeLabs\AlgorithmPrograms\AlgorithmPrograms\BinarySearch\File.txt");
                        break;
                        case 3:
                            Bubble bubble = new Bubble();
                        bubble.ReadFile(@"D:\BridgeLabs\AlgorithmPrograms\AlgorithmPrograms\BubbleSort\File.txt");
                        break;
                        case 4:
                            Anagram anagram = new Anagram();
                        anagram.CheckAnagram();
                        break;
                    case 5:
                        PrimeRangeNUmbner primeRangeNUmbner = new PrimeRangeNUmbner();
                        primeRangeNUmbner.PrimeRange();
                        break;       
                        case 6:
                        CustomizeDeatils customizeDeatils = new CustomizeDeatils();
                        customizeDeatils.Customize();
                        break;
                        case 7:
                        UnOrderList unOrderList = new UnOrderList();
                        unOrderList.ReadFile(@"D:\BridgeLabs\AlgorithmPrograms\AlgorithmPrograms\DataStructureProblems\File.txt");
                        break;
                    case 8:
                        OrderedList orderedList = new OrderedList();
                        orderedList.ReadFile(@"D:\BridgeLabs\AlgorithmPrograms\AlgorithmPrograms\DataStructureProblems\File1.txt");
                        break;
                        case 9:
                        flag = false;
                        break;
                }
            }
            
        }
    }
}