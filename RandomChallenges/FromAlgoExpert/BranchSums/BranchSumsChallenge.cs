namespace RandomChallenges.FromAlgoExpert.BranchSums;

public class BranchSumsChallenge
{

    //given a binary tree, calculate the sum of the values for each branch from leftmost to the rightmost and return it in as a List ordered 
    //ex: 
    //          1     
    //         / \    
    //      2      3  
    //     / \    / \ 
    //   4     5 6   7
    //  / \   /       
    // 8   9 10       
    //output: [15,16,18,10,11]
    public static List<int> BranchSums(BinaryTree root) 
    {
        var output = new List<int>();
        BranchSumsHelper(root.Left, root.Right, root.Value, output);     
        return output;
    }

    private static void BranchSumsHelper(BinaryTree leftNode, BinaryTree rightNode, int currentSum, List<int> output)  
    {      
        if(leftNode != null)       
            BranchSumsHelper(leftNode.Left, leftNode.Right, currentSum + leftNode.Value, output);            

        if(rightNode != null)                 
            BranchSumsHelper(rightNode.Left, rightNode.Right, currentSum + rightNode.Value, output);      

        if(leftNode == null && rightNode == null)
            output.Add(currentSum);
    } 
    public class BinaryTree {
        public int Value;
        public BinaryTree Left;
        public BinaryTree Right;

        public BinaryTree(int value) {
           Value = value;
           Left = null;
           Right = null;
        }
    }
}