// class Node():
//     """ class node """

//     def __init__(self, char=None, end=False):
//         """ ctor """
//         self.char = char
//         self.childs = [None] * 26
//         self.end = end

//     def get(self, key):
//         """ method for test """
//         for c in self.childs:
//             if c is not None:
//                 if key == c.char:
//                     return True
//         return False
export class Node {
  end: boolean;
  childs: Node[] = [];
  char: string | undefined;

  constructor(char?: string, end = false) {
    this.end = end;
    this.char = char;
  }

  get(key: string): boolean {
    for (const child of this.childs) {
      if (child !== null || child !== undefined)
        if (key === child.char) return true;
    }

    return false;
  }
}

class Trie {
  private readonly alphabet: string = "abcdefghijklmnopqrstuvwxyzåäö";
  root: Node;

  constructor() {
    this.root = new Node();
  }

  find(char: string) {
    const charAt = this.alphabet.indexOf(char);

    return this.alphabet.charCodeAt(charAt) - this.alphabet.charCodeAt(0);
  }

  insert(key: string) {
    let node: Node = this.root;

    for (let i = 0; i < key.length; i++) {
      const char = key[i];
      const index = this.find(char);

      if (node.childs[index] !== undefined) node.childs[index] = new Node(char);
      node = node.childs[index];
    }
    node.end = true;
  }

  get(key: string) {
    let node = this.root;

    for (let i = 0; i < key.length; i++) {
      const char = key[i];
      const index = this.find(char);

      if (node.childs[index] !== undefined) return false;
      node = node.childs[index];
    }
    return true;
  }

  
}

// class Trie():
//     """ trie class"""

//     def __init__(self):
//         """ ctor """
//         self.root = Node()

//     @staticmethod
//     def find_index(char):
//         """ returns index of letter """
//         return ord(char)-ord('a')

//     def insert(self, key):
//         """ insert of word """
//         node = self.root
//         for idx, _ in enumerate(key):
//             index = self.find_index(key[idx])
//             if not node.childs[index]:
//                 node.childs[index] = Node(key[idx])
//             node = node.childs[index]
//         node.end = True

//     def get(self, key):
//         """ search for word """
//         node = self.root
//         # for idx in range(len(key)):
//         for idx, _ in enumerate(key):
//             index = self.find_index(key[idx])
//             if not node.childs[index]:
//                 return False
//             node = node.childs[index]
//         return True

//     def get_trie_list(self):
//         """ returns private function to get trie list """
//         return self._get_trie_list(self.root, '', [])

//     def _get_trie_list(self, node, chars, lista):
//         """ private recursive function """
//         if node.char:
//             chars += node.char
//         if node.end:
//             lista.append(chars)
//         # for idx in range(len(node.childs)):
//         for idx, _ in enumerate(node.childs):
//             if node.childs[idx]:
//                 self._get_trie_list(node.childs[idx], chars, lista)
//         return lista

//     def print_trie_fast(self):
//         """prints trie recursive"""
//         return self._print_trie_fast(self.root, '')

//     def _print_trie_fast(self, node, chars):
//         """ private recursive function """
//         if node.char:
//             chars += node.char
//         if node.end:
//             print(chars)
//         # for idx in range(len(node.childs)):
//         for idx, _ in enumerate(node.childs):
//             if node.childs[idx]:
//                 self._print_trie_fast(node.childs[idx], chars)

//     def find_prefix(self, search):
//         """ prefix finder """
//         string = ''
//         node = self.root
//         for x in range(len(search)):
//         # for x, _ in enumerate(node.childs):
//             index = self.find_index(search[x])
//             if not node.childs[index]:
//                 return []
//             if search[x] == node.childs[index].char:
//                 string += node.childs[index].char
//                 node = node.childs[index]
//         return self._find_prefix(node, string, [])

//     def _find_prefix(self, node, prefix, lista):
//         """ adds words to lista recursive"""
//         if node.end:
//             lista.append(prefix)
//         for x in range(len(node.childs)):
//         # for x, _ in enumerate(node.childs):
//             if node.childs[x]:
//                 c = node.childs[x].char
//                 self._find_prefix(node.childs[x], prefix+c, lista)
//         return lista
