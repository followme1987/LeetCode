namespace FibonacciNumber
{
    public class FibonacciNumberCls
    {
        public int Fib(int N)
        {
            if (N <= 1)
            {
                return N;
            }
            var result = new int[N + 1];
            result[1] = 1;
            result[0] = 0;
            for (int i = 2; i <= N; i++)
            {
                result[i] = result[i - 1] + result[i - 2];
            }
            return result[N];
            // //if (N <= 1)
            // //    return N;

            // //return Fib(N - 1) + Fib(N - 2);

            // var a = 0;
            // var b = 1;

            // for (var i = 0; i < N; i++)
            // {
            //     var temp = a;
            //     a = b;
            //     b = b + temp;
            // }

            // return a;
        }
    }
}
