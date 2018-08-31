using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnowflakeApp;
using System.Collections.Generic;

namespace UnitTestSnowflakeApp
{
    [TestClass]
    public class SnowflakeUnitTest1
    {
        /// <summary>
        /// ��̬�����й��ɵ�ID Snowflake�㷨��Twitter�Ĺ���ʦΪʵ�ֵ��������ظ���IDʵ�ֵ�
        /// </summary>
        [TestMethod]
        public void SnowflakeTestMethod1()
        {
            var ids = new List<long>();
            for (int i = 0; i < 1000000; i++)//����ͬʱ100W����ID
            {
                ids.Add(Snowflake.Instance().GetId());
            }
            for (int i = 0; i < ids.Count - 1; i++)
            {
                Assert.IsTrue(ids[i] < ids[i + 1]);
            }
        }
    }
}
