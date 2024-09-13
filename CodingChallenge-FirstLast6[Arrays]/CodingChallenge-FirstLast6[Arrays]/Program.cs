namespace CodingChallenge_FirstLast6_Arrays_
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("First Last 6");

            int[] nbrs = [13, 6, 1, 2, 3 ];
            bool idxs = FirstLast6(nbrs);

            Console.WriteLine(idxs);

            
        }

       
        public static bool FirstLast6(int[] nums)
        {            
            if (nums[0] == 6 || nums[nums.Length - 1] == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
