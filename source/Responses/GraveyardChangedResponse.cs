using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.Responses
{
    [Serializable]
    public class GraveyardChangedResponse : Response
    {
        public int Size { get; private set;}

        public GraveyardChangedResponse(int size)
        {
            this.Size = size;
        }

        public override void Visit(IResponseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
