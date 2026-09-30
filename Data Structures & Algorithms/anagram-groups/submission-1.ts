class Solution {
    /** * @param {string[]} strs * @return {string[][]} */ groupAnagrams(
        strs: string[],
    ): string[][] {
        const dictionary = new Map<string, string[]>();
        for (const word of strs) {
            const count = new Array(26).fill(0);
            for (const character of word) {
                const index = character.charCodeAt(0) - "a".charCodeAt(0);
                count[index]++;
            }
            const key = count.join(",");
            const wordsArray = dictionary.get(key) ?? [];
            wordsArray.push(word);
            dictionary.set(key, wordsArray);
        }
        return Array.from(dictionary.values());
    }
}
