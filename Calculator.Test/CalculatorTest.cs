using System;
using System.Collections;
using Xunit;
using System.Text;
using WebApplication1.BL;
using System.Collections.Generic;
using Xunit.Abstractions;
using Calculator.Test;
using Moq;

namespace Calculator.Test
{
    public class CalculatorFixture : IDisposable
    {
        public WebApplication1.BL.Calculator calc = new WebApplication1.BL.Calculator();
        public WebApplication1.BL.Customer customer = new Customer();

        public void Dispose()
        {
            //clean up your code
        }
    }
    public class CalculatorTests : IClassFixture<CalculatorFixture>
    {
        private readonly CalculatorFixture _calculatorFixture;
        

        public CalculatorTests(CalculatorFixture calculatorFixture)
        {
            _calculatorFixture = calculatorFixture;
          
        }
        [Fact]
        public void TestAdd()
        {
            //ClearingAccountTests          
           // Assert.True(true);
            Assert.Equal(2, 2);

        }

        [Fact]
        public void Add_Test_Retrun_Int()
        {           
            var result = _calculatorFixture.calc.Add(2, 2);
            Assert.Equal(4, result);
        }

        [Fact]
        public void Test_Double()
        {            
            var result = _calculatorFixture.calc.AddDouble(1.2, 3.5);
            Assert.Equal(4.7, result);
        }

        [Fact]
        public void MakeFullNameTest()
        {
            var names = new Names();
            var result = names.MakeFullName("Tamil", "selvi");
            //Assert.Equal("Tamil selvi", result, ignoreCase: true);
            //Assert.Contains("tamil", result, StringComparison.InvariantCultureIgnoreCase);
          //  Assert.Null(result);
          //  Assert.False(string.IsNullOrEmpty(result));
          //  Assert.NotNull(result);            
        }
        [Fact]
        public void FiboDoesNotIncludeZero()
        {
            
            Assert.All(_calculatorFixture.calc.FiboNumbers, n => Assert.NotEqual(0,n)); // the number should not contain zero
          //  Assert.Contains(13, _calculatorFixture.calc.FiboNumbers);
           // Assert.DoesNotContain(4, _calculatorFixture.calc.FiboNumbers);

        }
         
        [Fact]
        [Trait("Category","Fibo")]
        public void CheckCollection()
        {
            var expectedCollection = new List<int>() { 1, 1, 2, 3, 5, 8,13 };
            // Assert.Equal(expectedCollection, calc.FiboNumbers); //verifying both collections are same or not
            Assert.DoesNotContain(0, _calculatorFixture.calc.FiboNumbers);
        
        }

        [Fact]
        public void CheckLegForDiscount()
        {
            Assert.InRange(_calculatorFixture.calc.age, 25, 40);
        }

        [Fact]
        public void GetOrdersByNameNotNull()
        {
            Assert.Throws<ArgumentException>(()=> 
            _calculatorFixture.customer.GetOrdersByName(null)); //passing null to get the exception
        }

        [Fact]
        public void Mock_GetCustomerData_ReturnSalaries()
        {
            var curobj = _calculatorFixture.customer.GetOrdersByName("100");
            var curobj1 =new Mock<Customer>();
            

        }

        [Fact]
        public void GetOrdersByNameNull()
        {
            //var ex = Assert.Throws<ArgumentException>(() => _calculatorFixture.customer.GetOrdersByName(null));
           // Assert.Equal("Hello", ex.Message); //checking the exception message;
        }

        [Fact]
        public void LoyalCustomerForOrdersG100()
        {
            var cs = WebApplication1.BL.CustomerFactory.CreateCustomerInstance(102);
            var loyalCustomer = Assert.IsType<LoyalCustomer>(cs);
            Assert.Equal(10, loyalCustomer.Discount);
        }

        [Fact]
        public void IsOdd_returnsTrue()
        {
            Assert.True(_calculatorFixture.calc.IsOdd(5));
        }

        [Fact]
        public void IsOdd_returnsFalse()
        {
            Assert.False(_calculatorFixture.calc.IsOdd(6));
        }
        [Theory] // means our test will execute multiple times, going to pass diferent data
        [InlineData(5,true)]
        [InlineData(6,false)]
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
           Assert.Equal(expected,_calculatorFixture.calc.IsOdd(value));           
        }


        [Theory] // means our test will execute multiple times, going to pass diferent data
        [MemberData(nameof(TestDataShare.IsOddOrEvenData), MemberType = typeof(TestDataShare))]
        public void IsOdd_TestOddAndEven_datashare(int value, bool expected)
        {
            Assert.Equal(expected, _calculatorFixture.calc.IsOdd(value));
        }

        [Fact]
        public void DateTime_Null_Check()
        {
            Mock<DateTimeHelper> obj = new Mock<DateTimeHelper>();
            obj.Setup(x => x.GetDateTimeNow()).Returns(DateTime.Now);

            DateTimeHelper res = new DateTimeHelper();
        }

        public interface IDateProv
        {
            DateTime GetDateTimeNow();
        }
        public class DateTimeHelper : IDateProv
        {
            public DateTime GetDateTimeNow()
            {
                return DateTime.Now;
            }
        }


    }

    public class TestCollectionOrder : ITestCollectionOrderer
    {
        public IEnumerable<ITestCollection> OrderTestCollections(IEnumerable<ITestCollection> testCollections)
        {
            throw new NotImplementedException();
        }
    }
}
