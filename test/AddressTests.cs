using Algorand;
using NUnit.Framework;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace test
{
    [TestFixture]
    public class AddressTests
    {
        [Test]
        public void testEncodeDecodeStr()
        {
            Random r = new Random();
            for (int i = 0; i < 1000; i++)
            {
                byte[] randKey = new byte[32];
                r.NextBytes(randKey);
                Address addr = new Address(randKey);
                string addrStr = addr.EncodeAsString();
                Address reencAddr = new Address(addrStr);
                Assert.AreEqual(reencAddr, addr);
            }
        }

        [Test]
        public void testGoldenValues()
        {
            string golden = "7777777777777777777777777777777777777777777777777774MSJUVU";
            byte[] bytes = new byte[32];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte)0xff; // careful with signedness
            }
            Assert.AreEqual(new Address(bytes).ToString(), golden);
        }

        [Test]
        public void testAddressSerializable()
        {
            Address a = new Address("VKM6KSCTDHEM6KGEAMSYCNEGIPFJMHDSEMIRAQLK76CJDIRMMDHKAIRMFQ");
            MemoryStream ms = new MemoryStream();
            //�������л���ʵ��
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(ms, a);//���л�����д��ms����  
            byte[] outBytes = ms.GetBuffer();

            ms = new MemoryStream(outBytes)
            {
                Position = 0
            };
            formatter = new BinaryFormatter();
            Address o = (Address)formatter.Deserialize(ms);//���ڴ��������гɶ���
            
            Assert.AreEqual(o, a);
            Assert.AreEqual("VKM6KSCTDHEM6KGEAMSYCNEGIPFJMHDSEMIRAQLK76CJDIRMMDHKAIRMFQ", o.EncodeAsString());
        }
    }
}
