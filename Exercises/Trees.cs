using Exercises.Models;

namespace Exercises
{
    class Trees
    {
        public static int sum(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            return sum(node.left) + node.value + sum(node.right);
        }
    }
}
