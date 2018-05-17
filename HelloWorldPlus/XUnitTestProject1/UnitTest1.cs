using System.IO;
using System;
using Xunit;

namespace HelloWorldPlus
{
    
    public class UnitTest1
    {
        const string ditFornavn = "Søren";
        const string ditEfternavn = "Magnusson";
        const int dinAlder = 52;

        // for wrapping Main() in mocked environment
        StringWriter output;
        StringReader input;

        public UnitTest1()
        {
            output = new StringWriter();
            Console.SetOut(output);
            input = new StringReader("");
            Console.SetIn(input);
        }

        [Fact]
        public void Test0()
        {
            Assert.NotEqual("Søren", ditFornavn);
            Assert.NotEqual("Magnusson", ditEfternavn);
            Assert.NotEqual(52, dinAlder);
        }

        [Fact]
        public void Test5()
        {
            Program.Main(new String[] { });
            string outputs = output.ToString();

            Assert.Contains("Good Day!", outputs);
        }

        [Fact]
        public void Test6()
        {
            Program.Main(new String[] { });
            string outputs = output.ToString();

            Assert.Contains(ditFornavn, outputs);
            Assert.Contains(ditEfternavn, outputs);
            Assert.Contains(ditFornavn + " " + ditEfternavn, outputs);
        }
        [Fact]
        public void Test7()
        {
            Program.Main(new String[] { });
            string outputs = output.ToString();

            Assert.Contains("1", outputs);
            Assert.Contains("101", outputs);
            Assert.Contains("1001", outputs);
        }

        [Fact]
        public void Test8()
        {
            Program.Main(new String[] { });
            string outputs = output.ToString();

            Assert.Contains(DateTime.Now.ToString(), outputs);
        }
        [Fact]
        public void Test9()
        {
            Program.Main(new String[] { });
            string outputs = output.ToString();

            Assert.Contains("111,1080555", outputs);
        }
        [Fact]
        public void Test10()
        {
            Program.Main(new String[] { });
            string outputs = output.ToString();

            Assert.Contains("100", outputs);
            Assert.Contains("-101", outputs);
        }
        [Fact]
        public void Test11()
        {
            String inputs = String.Format(dinAlder.ToString());
            input = new StringReader(inputs);

            Console.SetIn(input);
            Program.Main(new String[] { });

            string outputs = output.ToString();

            Assert.Contains(Convert.ToString(dinAlder + 10) + " år", outputs);
        }
    }
}
