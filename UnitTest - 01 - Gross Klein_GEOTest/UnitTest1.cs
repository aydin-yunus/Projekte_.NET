using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;
using UnitTest___01___Gross_Klein_TEST_16._03;



namespace UnitTest___01___Gross_Klein_GEOTest
{
    public class UnitTest1
    {
        [Fact]
        public void Word()
        {
            //const string expected = "abc"; // bu her kelimenin ilk harfi büyük oldugu icin burda hata verir.
            
            const string expected = "Abc"; // burda testi gecer

            Assert.Equal(expected, MyClass.Title("abc"));
            Assert.Equal(expected, MyClass.Title("ABC"));
            Assert.Equal(expected, MyClass.Title("aBC"));
            Assert.Equal(expected, MyClass.Title("Abc"));
        }
        [Fact]
        public void Sentence()
        {
            const string expected = "Abc Def Ghi";

            Assert.Equal(expected, MyClass.Title("abc def ghI"));
        }
    }
}