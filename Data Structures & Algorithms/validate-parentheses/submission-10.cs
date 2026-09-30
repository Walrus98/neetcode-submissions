public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = [];

        foreach (var character in s) {
            if (character == '(' || character == '[' || character == '{') {
                stack.Push(character);
                continue;
            }

            var c = stack.Count > 0 ? stack.Pop() : default;

            if (c == null) {
                return false;
            }

            if (c == '(' && character == ')') {
                continue;
            }

            if (c == '[' && character == ']') {
                continue;
            }

            if (c == '{' && character == '}') {
                continue;
            }

            return false;
        }

        return stack.Count == 0;
    }
}
