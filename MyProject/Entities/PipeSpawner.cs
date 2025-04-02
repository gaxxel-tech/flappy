using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using Microsoft.Xna.Framework;
using FlatRedBall.Gui;

namespace MyProject.Entities
{
    public partial class PipeSpawner
    {
        /// <summary>
        /// Initialization logic which is executed only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
        /// 
        private float pipeSpawnTimer = 0;
        private float heightRange = 100;
        private void CustomInitialize()
        {
            SpawnPipe();
        }

        private void CustomActivity()
        {
            
        }

        private void CustomDestroy()
        {
            
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {
            
        }


        private void SpawnPipe()
        {
            
            float randomHeight = FlatRedBallServices.Random.Between(-heightRange, heightRange);
            Pipe newPipe = Factories.PipeFactory.CreateNew(x: -137, y: 155);
            
            

        }
    }
}
