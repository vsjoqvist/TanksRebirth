﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksRebirth.GameContent.GameMechanics
{
    public class AiBehavior
    {
        public string Label;

        public long Value;

        public bool IsModOf(long remainder)
        {
            if (remainder == 0)
                return false;
            return Value % remainder == 0;
        }
    }
    public static class AiBehaviorExtensions
    {
        public static AiBehavior FromName(this AiBehavior[] arr, string name)
        {
            return arr.First(behavior => behavior.Label == name);
        }
    }
}
