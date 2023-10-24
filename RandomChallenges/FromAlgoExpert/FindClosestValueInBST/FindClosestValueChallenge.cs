namespace RandomChallenges.FromAlgoExpert.FindClosestValueInBST;

public class FindClosestValueChallenge
{
    //Given a Binary Search Tree and a target value, find the closest value to the target
    public static int FindClosestValueInBst(BST tree, int target) 
    {
        if (tree.value == target) 
            return tree.value;
      
        var closestValue = tree.value;
        var currentTree = tree;
        while(true)
        {
            if (currentTree == null) break;
            if(currentTree.value == target) return target;
            var closestValueDiff = Math.Abs(closestValue - target);
            var currentDiff = Math.Abs(currentTree.value - target);
            closestValue = closestValueDiff > currentDiff 
                ? currentTree.value 
                : closestValue;      
            currentTree = currentTree.value < target 
                ? currentTree.right 
                : currentTree.left;        
        }

        return closestValue;
    }

    public class BST {
        public int value;
        public BST left;
        public BST right;

        public BST(int value) {
            this.value = value;
        }
    }
}