using Calabonga.DemoClasses;
using System;
using Xunit;

namespace XUnit.Tests
{
    public class DemoClassesTests
    {
        [Fact]
        public void ItShould_under_testing()
        {
            //Arrange
            Person person = new Person();

            //Act

            //Assert
            Assert.NotNull(person);
        }

        [Fact]
        public void ItShould_throw_exception_when_person_is_null()
        {
            //Arrange
            Person person = null;

            //Act

            //Assertt
            Assert.Throws<NullReferenceException>(() => person.Name);
        }
    }
}
