public class Solution {
    public int RemoveElement(int[] nums, int val) {

        int number = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != val)
            {
                nums[number] = nums[i];
                number++;
            }
        }
        return number;
    }
}
