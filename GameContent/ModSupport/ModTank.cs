﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksRebirth.Enums;
using TanksRebirth.GameContent.Systems.Coordinates;

namespace TanksRebirth.GameContent.ModSupport
{
    /// <summary>Represents a modded <see cref="GameContent.Tank"/>.</summary>
    // will probably be deleted eventually, since inheritance from AITank can exist.
    public class ModTank
    {
        public virtual string TierName => string.Empty;
        public virtual TankTeam Team => TankTeam.NoTeam;

        public AITank Tank { get; }

        internal int internal_tier;
        public int GetTier() => internal_tier;

        public void Spawn(CubeMapPosition position)
        {
        }

        public virtual bool BulletFound() => true;

        public virtual bool MineFound() => true;

        public virtual bool MinePlaced() => true;

        public virtual bool ShellFired() => true;

        public virtual bool TargetLocked() => true;
    }
}
