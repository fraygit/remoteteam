using remoteteam.data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remoteteam.data.Model
{
    public class Room : MongoEntity
    {
        public DateTime Ended { get; set; }
        public List<PeerClient> Peers { get; set; }
    }
}
