import { ITrieTree } from "./ITrieTree";
import { TrieNode } from "./trieNode";

export class TrieTree implements ITrieTree {
  private root: TrieNode;

  constructor() {
    this.root = new TrieNode();
  }

  insert(word: string, value: string) {
    let node = this.root;
    for (let i = 0; i < word.length; i++) {
      const index = parseInt(word[i], 36) - 10;

      if (node.arr[index] === null) {
        const temp = new TrieNode();
        node.arr[index] = temp; 
        node = temp;
      } else {
        node = node.arr[index];
      }
    }
    node.isEnd = true;
    node.value = value;
  }

  getRoot() {
    return this.root;
  }

  startsWith(prefix: string) {
    const node = this.searchNode(prefix);
    if (node == null) {
      return false;
    } else {
      this.printStrings(node, "");
      return true;
    }
  }

  printStrings(node : TrieNode, prefix : string) {
    if (node.isEnd) console.log(prefix);
    for (let i = 0; i < node.arr.length; i++) {
      if (node.arr[i] !== null) {
        const character = String.fromCharCode("a".charCodeAt(0) + i);
        this.printStrings(node.arr[i], prefix + "" + character);
      }
    }
  }

  searchNode(str: string) {
    let node = this.root;
    for (let i = 0; i < str.length; i++) {
      const index = parseInt(str[i], 36) - 10;
      if (node.arr[index] !== null) {

        node = node.arr[index];
      } else {
        return null;
      }
    }

    if (node === this.root) return null;

    return node;
  }
}
