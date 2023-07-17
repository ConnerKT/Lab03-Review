namespace Lab03_Review.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Challenge1_InputStringOfNumbers()
        {
        
            string input = "2 4 6";

            int result = Lab03_Review.Program.Challenge1(input);

            Assert.Equal(48, result);
        }

        [Fact]
        public void Challenge1_InputMoreThan3Numbers()
        {
         
            string input = "5 7 9 3";

     
            int result = Lab03_Review.Program.Challenge1(input);

      
            Assert.Equal(315, result);
        }

        [Fact]
        public void Challenge1_InputLessThan3Numbers()
        {
         
            string input = "1 2";

       
            
            int result = Lab03_Review.Program.Challenge1(input);

        
            Assert.Equal(0, result);
        }

        [Fact]
        public void Challenge1_InputNegativeNumbers()
        {
      
            string input = "-2 -4 -6";

            int result = Lab03_Review.Program.Challenge1(input);

      
            Assert.Equal(-48, result);
        }
        [Fact]
        public void Challenge2_InputRangeOfNumbers()
        {
       
            int[] array = { 1, 2, 3, 4, 5 };
            int input = array.Length;

  
            int result = Lab03_Review.Program.Challenge2(array, input);

            Assert.Equal(3, result);
        }

        [Fact]
        public void Challenge2_InputSingleNumber()
        {
   
            int[] array = { 7 };
            int input = array.Length;

     
            int result = Lab03_Review.Program.Challenge2(array, input);

  
            Assert.Equal(7, result);
        }

        [Fact]
        public void Challenge2_InputAllZeros()
        {

            int[] array = { 0, 0, 0 };
            int input = array.Length;

  
            int result = Lab03_Review.Program.Challenge2(array, input);

   
            Assert.Equal(0, result);
        }
        [Fact]
        public void Challenge4_InputDifferentArrays()
        {
       
            int[] array1 = { 1, 2, 2, 3, 4, 4, 4 };
            int[] array2 = { 1, 1, 2, 2, 2, 3, 3, 3, 3 };
            int[] array3 = { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };

        
            int result1 = Lab03_Review.Program.Challenge4(array1);
            int result2 = Lab03_Review.Program.Challenge4(array2);
            int result3 = Lab03_Review.Program.Challenge4(array3);
     
            Assert.Equal(4, result1);
            Assert.Equal(2, result2);
            Assert.Equal(5, result3);
        }

        [Fact]
        public void Challenge4_InputArrayWithSameNumber()
        {
            int[] array = { 3, 3, 3, 3, 3 };
            int result = Lab03_Review.Program.Challenge4(array);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Challenge4_InputArrayWithNoDuplicates()
        {
        
            int[] array = { 1, 2, 3, 4, 5 };
            int result = Lab03_Review.Program.Challenge4(array);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Challenge4_InputArrayWithMultipleEF()
        {
       
            int[] array = { 1, 2, 2, 3, 3, 4, 4 };
            int result = Lab03_Review.Program.Challenge4(array);
            
            Assert.Equal(2, result);
        }
        [Fact]
        public void Challenge5_InputArrayWithNegativeNumbers()
        {
            int[] array = { -10, -5, -20, -3, -7 };

         
            int result = Lab03_Review.Program.Challenge5(array);

            Assert.Equal(-3, result);
        }

        [Fact]
        public void Challenge5_InputArrayWithAllSameValues()
        {
            int[] array = { 7, 7, 7, 7, 7 };

            int result = Lab03_Review.Program.Challenge5(array);

          
            Assert.Equal(7, result);
        }
        [Fact]
        public void Challenge9_InputSentence()
        {
            string input = "This is a sentence about important things";
            string[] expected = { "This: 4", "is: 2", "a: 1", "sentence: 8", "about: 5", "important: 9", "things: 6" };

            string[] result = Lab03_Review.Program.Challenge9(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Challenge9_ReturnsArrayWithWordLengths()
        {
            string input = "The quick brown fox jumps over the lazy dog";
            string[] expected = { "The: 3", "quick: 5", "brown: 5", "fox: 3", "jumps: 5", "over: 4", "the: 3", "lazy: 4", "dog: 3" };

            string[] result = Lab03_Review.Program.Challenge9(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Challenge9_InputSentenceWithSymbols()
        {
            string input = "Hello, world! How are you today?";
            string[] expected = { "Hello: 5", "world: 5", "How: 3", "are: 3", "you: 3", "today: 5" };

            string[] result = Lab03_Review.Program.Challenge9(input);

            Assert.Equal(expected, result);
        }
    }
}

