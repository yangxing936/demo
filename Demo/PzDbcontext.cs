using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Demo
{
    public class PzDbcontext : IEncoder
    {
        public int Decode(byte[] data, int off, int length, Stream outStream)
        {
            return 0;
        }
        public int DecodeString(string data, Stream outStream)
        {
            return 0;
        }
        public int Encode(byte[] data, int off, int length, Stream outStream)
        {
            return 0;
        }
    }
}
