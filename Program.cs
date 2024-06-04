namespace Assignment_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 10 single digit numbers: ");
            int[] nums = new int[10];

            for (int i =0; i < 10; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
         
            bool ContainsDuplicate(int[] nums)
            {
                return nums.Length != nums.Distinct().Count(); 
            }

            bool hasDuplicates = ContainsDuplicate(nums);
            Console.WriteLine($"Contains duplicates: {hasDuplicates}");
        }
    }
}
