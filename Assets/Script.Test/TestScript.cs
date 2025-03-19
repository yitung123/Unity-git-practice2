

using NUnit.Framework;
using NUnit.Framework.Internal;

public class TestScript
{
    [Test(Description = "測試兩個數字相加")]
    [TestCase(2,2,4)]
    [TestCase(-1,3,2)]
    [TestCase(-1,-3,-4)]
    public void Add_Two_Number(int a, int b, int expected)
    {
      //建立變數
      TimeScript timeConverter = new TimeScript();
      //呼叫我們寫的方法
      int result = timeConverter.Add(a,b);
      //驗證結果
      Assert.AreEqual(expected, actual:result);
    }
    
}
