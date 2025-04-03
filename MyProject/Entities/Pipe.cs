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

namespace MyProject.Entities
{
    public partial class Pipe
    {
        /// <summary>
        /// Initialization logic which is executed only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
        /// 

        private bool canMove = true;
        private float pipeSpeed = 40f;

        public float setSpeed
        {
            get { return pipeSpeed; }
            set { pipeSpeed = value; }
        }


        private void CustomInitialize()
        {
            setSpeed = 40f;
        }

        private void CustomActivity()
        {
           
            PipeMovementActivity();
        }

        private void CustomDestroy()
        {
            
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {
            
        }

        private void PipeMovementActivity()
        {
            if(!canMove)
            {
                this.Velocity.X = 0;
                return;
            }
            this.Velocity.X = -pipeSpeed;

        }

        public void StopPipeMovement()
        {
            canMove = false;
        }
    }
}
