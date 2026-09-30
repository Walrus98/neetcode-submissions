class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums: number[]): boolean {

        const dict: Record<number, number> = {};

        for (const num of nums) {
            dict[num] = (dict[num] ?? 0) + 1;
        }

        for (const key of Object.keys(dict)) {
            const value = dict[Number(key)];
            if (value > 1) {
                return true;
            }
        }

        return false;
    }
}
