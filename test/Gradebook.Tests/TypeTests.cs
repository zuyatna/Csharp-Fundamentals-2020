using System;
using GradeBook;
using Xunit;

namespace Gradebook.Tests
{
    public delegate string WriteLogDelegate(string lowMessage);    

    public class TypeTests
    {

        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            //Given
            WriteLogDelegate log;
            log = ReturnMessage;

            //When
            var result = log("Hello!");

            //Then
            Assert.Equal("Hello!", result);
        }

        string ReturnMessage(string messgae) => messgae;

        [Fact]
        public void PassByValue()
        {
            //Given
            var x = GetInt();
        
            //When
            SetInt(ref x);
        
            //Then
            Assert.Equal(42, x);
        }

        private void SetInt(ref int z)
        {
            z = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void GetBookObjects()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

        [Fact]
        public void ReferencesObjects()
        {
            // arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
