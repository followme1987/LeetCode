namespace RobotReturnToOrigin
{
    public class RobotReturnToOrigin
    {
        public bool JudgeCircle(string moves)
        {
            var chaArr = moves.ToCharArray();
            var x = 0;
            var y = 0;

            foreach (var ch in chaArr)
                switch (ch)
                {
                    case 'D':
                        y--;
                        break;
                    case 'R':
                        x++;
                        break;
                    case 'L':
                        x--;
                        break;
                    case 'U':
                        y++;
                        break;
                }

            return x == 0 && y == 0;
        }
    }
}