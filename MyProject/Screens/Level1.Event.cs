using System;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Specialized;
using FlatRedBall.Audio;
using FlatRedBall.Screens;
using MyProject.Entities;
using MyProject.Screens;
using FlatRedBall.Math;
namespace MyProject.Screens
{
    public partial class Level1
    {

        



        void OnPlayerVsGroundCollided (Entities.Player player, Entities.Ground ground) 
        {

            player.StopPlayerMovement();
        }

        void OnPlayerVsPipeCollided (Entities.Player player, Entities.Pipe pipe) 
        {
            pipe.StopPipeMovement();
            player.StopPlayerMovement();
            
        }
        void OnplayerVsPointGapCollided (Entities.Player player, Entities.PointPipeGap pointPipeGap) 
        {
            FlatRedBall.Debugging.Debugger.Write("+1 punto");
        }
        
    }
}
