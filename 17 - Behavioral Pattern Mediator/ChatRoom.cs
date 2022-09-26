using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Mediator {
    public abstract class ChatRoom {
        public abstract void Register(TeamMember teammember);
        public abstract void Send(string from, string to);

    }
}
