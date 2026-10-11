/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        Node current = head;

        Dictionary<Node, Node> dictionary = [];

        while (current != null) {
            var newNode = new Node(current.val);
            dictionary[current] = newNode;
            current = current.next;
        }

        current = head;

        Node headCopy = null;
        Node precCopy = null;
        Node prec = null;

        while (current != null) {
            var node = dictionary[current];

            if (prec == null) {
                headCopy = node;
            } else {
                precCopy.next = node;
            }

            node.random = current.random == null
                ? null
                : dictionary[current.random];

            precCopy = node;
            prec = current;
            current = current.next;
        }

        return headCopy;
    }
}