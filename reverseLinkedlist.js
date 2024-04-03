/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @return {ListNode}
 */
var reverseLinkedlist = function (head) {
  if (!head) {
    return head;
  }

  let cur = head;
  let prev = null;

    while (cur) {
        debugger;
    let next = cur.next;
    cur.next = prev;
    prev = cur;
    cur = next;
  }

  return prev;
};

console.log(reverseLinkedlist([1, 2, 3, 4, 5]));
