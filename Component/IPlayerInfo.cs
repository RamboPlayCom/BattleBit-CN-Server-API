﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityServerAPI.Component
{
    internal interface IPlayerInfo
    {
        public int K { get; set; }
        public int D { get; set; }

        public int rank { get; set; }

        public ulong markId { get; set; }
        public float maxHP { get; set; }
    }
}
