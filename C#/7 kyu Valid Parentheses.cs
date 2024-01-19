namespace CodewarsSolutions
{
    public class ValidParenthesesKata
    {
        public static bool ValidParentheses(string str)
        {
            if (string.IsNullOrEmpty(str))
                return true;

            Dictionary<char, char> pairs = new()
            {
                { '(', ')' },
            };

            var stack = new Stack<char>();

            foreach (char item in str)
            {
                if (pairs.ContainsKey(item))
                    stack.Push(item);
                else if (!pairs.ContainsValue(item))
                    continue;
                else if (stack.Count is 0)
                    return false;
                else if (pairs[stack.Pop()] != item)
                    return false;
            }

            return stack.Count is 0;
        }
    }

    [TestFixture]
    public class ValidParenthesesSampleTests
    {
        [Test]
        public void TestValidParentheses()
        {
            DoTest(true, "()");
            DoTest(true, "((()))");
            DoTest(true, "()()()");
            DoTest(true, "(()())()");
            DoTest(true, "()(())((()))(())()");
        }

        [Test]
        public void TestInvalidParentheses()
        {
            DoTest(false, ")(");
            DoTest(false, "()()(");
            DoTest(false, "((())");
            DoTest(false, "())(()");
            DoTest(false, ")()");
            DoTest(false, ")");
        }

        [Test]
        public void TestEmptyString()
        {
            DoTest(true, "");
        }

        private void DoTest(bool expected, string str)
        {
            Assert.That(ValidParenthesesKata.ValidParentheses(str), Is.EqualTo(expected), $"Incorrect answer for str = \"{str}\"");
        }
    }
}