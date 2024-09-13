namespace CodingChallenge_RotateLeft
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Rotate Left\n");

            int[] nbr = [ 1, 2, 3 ];
            int[] idxs = RotateLeft3(nbr);
            Console.WriteLine(PrintIt(idxs));

        }

        public static string PrintIt(int[] nbrs)
        {
            string retStr = "";
            foreach (int nbr in nbrs)
            {
                retStr += nbr + " ";
            }
            return retStr;
        }

        public static int[] RotateLeft3(int[] nums)
        {
            int[] idx = new int[3];
            if (nums.Length != 3)
            {
                Console.WriteLine("Array must have length of 3");
            }
            else
            {
            idx[0] = nums[1];
            idx[1] = nums[2];
            idx[2] = nums[0];
            }
            return idx;
        }


    }
}
