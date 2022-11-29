namespace Abstraction3
{
    internal class Program
    {
        static bool Reverse(string msg)
        {
            bool word = false;
            // Remove all empty spaces
            string spaceless = msg.Replace(" ", "");
            // Turn entire sentence to lowercase
            string lowercase = spaceless.ToLower();
            // Convert sentence to a array
            char[] reversed = lowercase.ToCharArray();
            // Goes through the array from the front
            for(int x = 0; x < reversed.Length; x++)
            {
                // Goes through the array from the back
                for(int y = reversed.Length - 1; y >= 0; y--)
                {
                    // Compare letter by letter
                    if (reversed[x] == reversed[y])
                    {
                        word = true;

                    }
                    else
                    {
                        word = false;
                    }
                }
                
                
            }
            return word;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("Race car"));
        }
    }
}