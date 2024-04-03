class Node {
  constructor(value) {
    this.value = value;
    this.next = null;
  }
}
class LinkedList {
  constructor(value) {
    this.head = {
      value: value,
      next: null,
    };
    this.tail = this.head;
    this.length = 1;
  }

  append(value) {
    const newNode = new Node(value);

    /**
     * On the first instance, head and tail are pointing to the same object in memory: head
     * So updating this.tail.next with the new node updates the next of head to the new node.
     * Then finally assign the reference to the new node to tail.
     * At this point, tail does not point to the head node anymore, but to the newly added node.
     *
     */
    this.tail.next = newNode;
    this.tail = newNode;
    this.length++;
    return this;
  }

  prepend(value) {
    const newNode = new Node(value);
    newNode.next = this.head;
    this.head = newNode;
    this.length++;
    return this;
  }

  insert(index, value) {
    const newNode = new Node(value);
    if (index >= this.length) {
      return this.append(value);
    }
    let i = 0;
    let currentNode = this.head;
    while (i < index - 1 && currentNode !== null) {
      currentNode = currentNode.next;
      i++;
    }
    //At this point, current node will contain the node before the index, which will have the node at index as its next node
    let nextNode = currentNode.next;
    currentNode.next = newNode;
    newNode.next = nextNode;
    this.length++;
    return this;
  }
}

//10-->5-->16

const myLinkedList = new LinkedList(10);

myLinkedList.append(5);
// myLinkedList.append(16);
// myLinkedList.prepend(1);
console.log(myLinkedList);
// myLinkedList.insert(1, 90);
myLinkedList.insert(10, 400);

console.log(myLinkedList);
