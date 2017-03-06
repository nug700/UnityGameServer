﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityGameServer.Networking;

namespace UnityGameServer {
    public interface IUser {
        void UserSet(AsyncServer.SocketUser socket);
        void Disconnected();
    }
}
