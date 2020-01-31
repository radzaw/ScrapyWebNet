using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Models
{
    [Table("nodes")]
    public class Node
    {
        public enum NodeStatus { OK, Unknown, ConnectionError };

        [Key]
        [Column("node_id")]
        public string NodeId { get; set; }

        [Column("node_url")]
        public string NodeUrl { get; set; }

        public bool Active;

        public NodeStatus Status = NodeStatus.Unknown;

        public int Running = 0;

        public int Pending = 0;

        public int Finished = 0;

        public string NodeName = String.Empty;

        public Node()
        {

        }
    }
}
