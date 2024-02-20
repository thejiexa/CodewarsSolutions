namespace CodewarsSolutions
{
    public class Brace
    {
        public static bool validBraces(String braces)
        {
            if (string.IsNullOrEmpty(braces))
                return false;

            var stack = new Stack<char>();
            var pairs = new Dictionary<char, char>
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };

            foreach (var item in braces)
            {
                if (pairs.ContainsKey(item))
                    stack.Push(item);
                else if (!pairs.ContainsValue(item))
                    continue;
                else if (stack.Count is 0 || pairs[stack.Pop()] != item)
                    return false;
            }

            return stack.Count is 0;
        }
    }

    [TestFixture]
    public class BraceTests
    {
        [Test]
        public void Test1() => Assert.That(Brace.validBraces("()"), Is.EqualTo(true));
        
        [Test]
        public void Test2() => Assert.That(Brace.validBraces("[(])"), Is.EqualTo(false));
    }
}