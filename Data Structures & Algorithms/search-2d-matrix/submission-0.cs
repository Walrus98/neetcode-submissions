public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {

        for (int x = 0; x < matrix.Length; x++) {
            if (BinarySearch(matrix[x], target)) {
                return true;
            }
        }

        return false;        
    }

    public bool BinarySearch(int[] array, int target) {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2;

            if (array[mid] == target) {
                return true;
            }

            if (array[mid] < target) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        
        return false;
    }
}
