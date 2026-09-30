class Solution {
    isPalindrome(s: string): boolean {
        let left = 0;
        let right = s.length - 1;

        while (left < right) {
            // Salta i caratteri non alfanumerici a sinistra
            while (left < right && !/[a-zA-Z0-9]/.test(s[left])) {
                left++;
            }

            // Salta i caratteri non alfanumerici a destra
            while (left < right && !/[a-zA-Z0-9]/.test(s[right])) {
                right--;
            }

            // Confronta ignorando maiuscole/minuscole
            if (s[left].toLowerCase() !== s[right].toLowerCase()) {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}