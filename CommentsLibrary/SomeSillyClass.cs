namespace CommentsLibrary
{
    public class SomeSillyClass
    {
        public int SillyMethod(int x, String n)
        {
            if (string.IsNullOrWhiteSpace(n)) throw new ArgumentNullException("n must have a value but was null or empty");
            if (!(n == "2" || n == "3")) throw new ArgumentException("Only '2' or '3' is supported but was " + n);

            switch (n)
            {
                case "2": return x * 2;
                case "3": return x * 3;
            }

            return -1;
        }

    }
}