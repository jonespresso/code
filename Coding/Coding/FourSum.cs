namespace Coding
{
    public sealed class FourSum
    {
        public FourSum()
        {
        }

        public IList<IList<int>> GetFourSum(int[] nums, int target)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (nums.Length < 4)
            {
                return result;
            }

            Array.Sort(nums);
            Helper(nums, target, start: 0, sum: 0, new List<int>(), result);

            return result;
        }

        private static void Helper(
            int[] nums, int target, int start, int sum, List<int> current, List<IList<int>> result)
        {
            if (current.Count == 4)
            {
                if (sum == target)
                {
                    result.Add(new List<int>(current));
                }

                return;
            }

            for (int i = start; i < nums.Length; i++)
            {
                if (i > start && nums[i] == nums[i - 1])
                {
                    continue;
                }

                current.Add(nums[i]);
                Helper(nums, target, i + 1, sum + nums[i], current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}