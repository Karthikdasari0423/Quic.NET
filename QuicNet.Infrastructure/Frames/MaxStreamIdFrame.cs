﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuicNet.Infrastructure.Frames
{
    public class MaxStreamIdFrame : Frame
    {
        public override byte Type => 0x06;

        public override byte[] Build()
        {
            throw new NotImplementedException();
        }
    }
}