package tries3;

class WordDictionary {

    TrieNode root;

    public WordDictionary() {
        this.root = new TrieNode();
    }

    public class TrieNode {

        TrieNode[] children;
        boolean eow;

        public TrieNode() {
            this.children = new TrieNode[26];
            for (int i = 0; i < children.length; i++) {
                children[i] = null;
            }
            eow = false;
        }

    }
// time complexity O(n) where n is the length of the word
    // space complexity O(m*n) where m is the array size
    public void addWord(String word) {
        TrieNode currentNode = root;
        for (int i = 0; i < word.length(); i++) {
            int index = word.charAt(i) - 'a';

            if (currentNode.children[index] == null) {
                currentNode.children[index] = new TrieNode();
            }
            if (i == word.length() - 1) {
                currentNode.children[index].eow = true;
            }
            currentNode = currentNode.children[index];

        }
    }
// time complexity O(n^2) where n is the length of the word
    // space complexity O(1) 
    public boolean search(String word) {
        return searchHelper(word, root, 0);
    }

    private boolean searchHelper(String word, TrieNode root, int index) {
        TrieNode currentNode = root;
        for (int i = index; i < word.length(); i++) {
            int c = word.charAt(i) - 'a';
            if (word.charAt(i) == '.') {
                for (TrieNode temp : currentNode.children) {
                    if (temp != null && searchHelper(word, temp, i + 1)) {
                        return true;
                    }
                }
                return false;
            }
            if (currentNode.children[c] == null) {
                return false;
            }

           
            currentNode = currentNode.children[c];

        }
        return currentNode.eow;
    }
}

public class DesignAddandSearchWordsDataStructure {

    public static void main(String[] args) {
        WordDictionary obj = new WordDictionary();
        obj.addWord("bad");
        obj.addWord("dad");
        obj.addWord("mad");
        System.out.println(obj.search("pad"));
        System.out.println(obj.search("bad"));
        System.out.println(obj.search(".ad"));
        System.out.println(obj.search("b.."));

    }

}
