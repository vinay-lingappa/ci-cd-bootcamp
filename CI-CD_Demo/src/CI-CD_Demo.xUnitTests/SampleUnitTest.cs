﻿using Xunit;

namespace CI_CD_Demo.xUnitTests
{
    public class SampleUnitTest
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(3, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
