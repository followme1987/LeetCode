namespace FibonacciNumber
{
    public class FibonacciNumberCls
    {
        public int Fib(int N)
        {
            //if (N <= 1)
            //    return N;

            //return Fib(N - 1) + Fib(N - 2);

            var a = 0;
            var b = 1;

            for (var i = 0; i < N; i++)
            {
                var temp = a;
                a = b;
                b = b + temp;
            }

            return a;
        }
    }
}
