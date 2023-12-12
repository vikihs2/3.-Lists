List<int> nums1 = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> nums2 = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> resultNums = new List<int>();
for (int i = 0; i < Math.Min(nums1.Count, nums2.Count); i++)
{
    resultNums.Add(nums1[i]);
    resultNums.Add(nums2[i]);
}
int startIndex = Math.Min(nums1.Count, nums2.Count);
List<int> remaining = nums1.Count > nums2.Count ? nums1.GetRange(startIndex, nums1.Count - startIndex) : nums2.GetRange(startIndex, nums2.Count - startIndex);
resultNums.AddRange(remaining);
Console.WriteLine(string.Join(" ", resultNums));