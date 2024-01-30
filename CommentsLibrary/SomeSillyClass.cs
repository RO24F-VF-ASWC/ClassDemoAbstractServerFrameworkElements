namespace CommentsLibrary
{
    /// <summary>
    /// Dette er en fjollet klasser til demo af kommentarer
    /// </summary>
    public class SomeSillyClass
    {
        /// <summary>
        /// Denne fjollede metode ganger en string med et tal 
        /// </summary>
        /// <param name="x">Tallet der skal ganges med</param>
        /// <param name="n">En tekst streng der skal være '2' eller '3'</param>
        /// <returns>multiplum af x og n, hvis n er 2 eller 3</returns>
        /// <exception cref="ArgumentNullException">N må ikke være null eller en tom streng</exception>
        /// <exception cref="ArgumentException">N skal have værdien '2' eller '3'</exception>
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