using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Models.API
{
    public class ApiStatusResponse
    {
        // "status": "ok"
        public string Status;
        // "running": "0"
        public string Running;
        // "pending": "0"
        public string Pending;
        // "finished": "0"
        public string Finished;
        // "node_name": "node-name"
        public string NodeName;
    }
}
