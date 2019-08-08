using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace BackToBasic
{
   public class myCustomSerialize
    {
        [Serializable]
        public class myObject : ISerializable
        {
            public int n1;
            public int n2;
            public string str;

            public myObject()
            {

            }

            protected myObject(SerializationInfo info, StreamingContext context)
            {
                n1 = info.GetInt32("i");
                n2 = info.GetInt32("j");
                str = info.GetString("k");
            }

            public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("i", n1);
                info.AddValue("j", n2);
                info.AddValue("K", str);
            }
        }


        [Serializable]
        public class ObjectTwo : myObject
        {
            public int num;
            public ObjectTwo() : base()
            {
           } 

            protected ObjectTwo(SerializationInfo si, StreamingContext context) : base(si, context)
            {
                num = si.GetInt32("num");
            }

            public override void GetObjectData(SerializationInfo si, StreamingContext context)
            {
                base.GetObjectData(si, context);
                si.AddValue("num", num);
            }
        }
    }
}
