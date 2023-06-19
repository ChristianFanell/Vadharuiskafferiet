import { TrieNode } from "./trieNode";


export interface ITrieTree {
  insert(word: string, value: string): void;
  getRoot(): TrieNode;
  startsWith(prefix: string): boolean;
  printStrings(node: TrieNode, prefix: string): void;
  searchNode(str: string): TrieNode | null;
}
