package tries3;

class TrieNode {

    Trie root;

    public TrieNode() {
        root = new Trie();
    }

    public class Trie {

        Trie[] children;
        boolean eow;

        public Trie() {
            this.children = new Trie[26];
            for (int i = 0; i < children.length; i++) {
                children[i] = null;
            }
            this.eow = false;
        }

    }
// Time complexity O(n) where n is the length of the word
// Space complexity o(n*m) where m is the array size of each alphabet
    public void insert(String word) {
        Trie currentNode = root;
        for (int i = 0; i < word.length(); i++) {
            int index = word.charAt(i) - 'a';
            if (currentNode.children[index] == null) {
                currentNode.children[index] = new Trie();
            }
           if (i == word.length() - 1) {
                currentNode.children[index].eow = true;
            }
            currentNode = currentNode.children[index];
        }
         

    }
// Time complexity O(n) where n is the length of the word
// Space complexity o(1)
    public boolean search(String word) {
        Trie currentNode = root;
        for (int i = 0; i < word.length(); i++) {
            int index = word.charAt(i) - 'a';
            if (currentNode.children[index] == null) {
                return false;
            }
            if (i == word.length() - 1 && currentNode.children[index].eow == false) {
                return false;
            }
            currentNode = currentNode.children[index];

        }
        return true;
    }
// Time complexity O(n) where n is the length of the word
// Space complexity o(1)
    public boolean startsWith(String prefix) {
        Trie currentNode = root;
        for (int i = 0; i < prefix.length(); i++) {
            int index = prefix.charAt(i) - 'a';
            if (currentNode.children[index] == null) {
                return false;
            }
          
            currentNode = currentNode.children[index];

        }
        return true;
    }

}

public class ImplementTrie {

    public static void main(String[] args) {
        TrieNode obj = new TrieNode();
        obj.insert("apple");
        System.out.println(obj.search("apple") );
        System.out.println( obj.search("app"));
         System.out.println( obj.startsWith("app"));
        
        obj.insert("app");
        System.out.println( obj.search("app") );
       

    }

}
