using System.Collections.Generic;
using System.Linq;

namespace AddBinary
{
    public class AddBinaryCls
    {
        public string AddBinary(string a, string b)
        {
            var additional = false;
            var resultStack = new Stack<char>();
            string longStr;
            Stack<char> shortStack;

            if (a.Length >= b.Length)
            {
                var li = b.ToCharArray().ToList();
                shortStack = new Stack<char>(li);
                longStr = a;
            }
            else
            {
                var li = a.ToCharArray().ToList();
                shortStack = new Stack<char>(li);
                longStr = b;
            }


            for (var i = longStr.Length - 1; i >= 0; i--)
                if (shortStack.Count > 0)
                {
                    var shortChar = shortStack.Pop();

                    if (longStr[i].Equals('1') && shortChar.Equals('1'))
                    {
                        resultStack.Push(additional ? '1' : '0');
                        additional = true;
                    }
                    else if (longStr[i].Equals('0') && shortChar.Equals('0'))
                    {
                        resultStack.Push(additional ? '1' : '0');
                        additional = false;
                    }
                    else
                    {
                        resultStack.Push(additional ? '0' : '1');
                    }
                }

                else
                {
                    if (additional)
                    {
                        if (longStr[i].Equals('0'))
                        {
                            resultStack.Push('1');
                            additional = false;
                        }
                        else
                        {
                            resultStack.Push('0');
                        }
                    }
                    else
                    {
                        resultStack.Push(longStr[i]);
                    }
                }

            if (additional)
                resultStack.Push('1');

            var resultArray = resultStack.ToArray();

            return new string(resultArray);
        }
    }
}