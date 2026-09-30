class Solution {


    twoSum(nums: number[], target: number): number[] {

        const dictionary = new Map<number, number>();

        for (const [index, num] of nums.entries()) {
            
            const difference = target - num;

            const resultIndex = dictionary.get(difference);

            if (resultIndex !== undefined) {
                return [index, resultIndex]
            } 
            
            dictionary.set(num, index);
        }

        return [];
    }
}
