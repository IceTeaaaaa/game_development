﻿using Game1.Player;
using Game1.States;
using Game1.Interfaces;

namespace Game1.Commands
{
    class MarioTurnBigCommand : Interfaces.ICommand
    {
        private IPlayer player;

        //constructor
        public MarioTurnBigCommand(IPlayer player)
        {
            this.player = player;
        }
        public void Execute()
        {
            player.CurrentPowerState = new MarioBigState(player);
            player.CurrentAnimationState = new MarioRightIdleState(player);
        }

    }
}
