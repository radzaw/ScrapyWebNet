using ScrapyWebNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic
{
    public interface IScrapydAPI
    {
        void GetStatus(Node node);
    }
}
