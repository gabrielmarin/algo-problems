namespace RandomChallenges.FromAlgoExpert.NodeDepths;

public class NodeDepthsChallenge
{
    //given a binary tree return the sum of the depths for each node
    //ex: 
    //          1     
    //         / \    
    //      2      3  
    //     / \    / \ 
    //   4     5 6   7
    //  / \         
    // 8   9        
    //output: 16
    public static int NodeDepths(BinaryTree root) {
    
        return NodeDepthsHandler(root.Left, root.Right, 0);
    }

    private static int NodeDepthsHandler(BinaryTree leftNode, BinaryTree rightNode, int currentDepth)
    {
        var depthSum = currentDepth;
        if(leftNode != null)
            depthSum += NodeDepthsHandler(leftNode.Left, leftNode.Right, currentDepth+1);
        
        if(rightNode != null)
            depthSum += NodeDepthsHandler(rightNode.Left, rightNode.Right, currentDepth+1);

        return depthSum;     
    }  

    public class BinaryTree {
        public int Value;
        public BinaryTree Left;
        public BinaryTree Right;

        public BinaryTree(int value) {
            this.Value = value;
        }
    }
    
}