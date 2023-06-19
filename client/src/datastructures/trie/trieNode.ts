export class TrieNode {
  value: string | undefined;
  isEnd: boolean;
  arr: TrieNode[];

  constructor() {
    this.value = undefined;
    this.isEnd = false;
    this.arr = new Array(26).fill(null);
  }
}
