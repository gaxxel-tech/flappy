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
using StateInterpolationPlugin;
using FlatRedBall.Math;
using System.Numerics;

namespace MyProject.Entities
{
    public partial class Player
    {
        /// <summary>
        /// Initialization logic which is executed only one time for this Entity (unless the Entity is pooled).
        /// This method is called when the Entity is added to managers. Entities which are instantiated but not
        /// added to managers will not have this method called.
        /// </summary>
        /// 

        private float gravity = -500f;
        private bool flying = false;
        private double keyboardJump;
        private float maxRotationLimit = 75f;
        private float rotationForce = 5f;
        private float jumpStrenght = 250f;

        private void CustomInitialize()
        {
            this.Acceleration.Y = gravity;
        }

        private void CustomActivity()
        {
            MovementActivity();
        }

        private void CustomDestroy()
        {
            
        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {
            
        }




        private void MovementActivity()
        {

            float currentRotationDegrees = MathHelper.ToDegrees(RotationZ);

            if (InputManager.Keyboard.KeyPushed(Microsoft.Xna.Framework.Input.Keys.Space))
            {
                this.Velocity.Y = jumpStrenght;
                flying = true;
            }
            else
            {
                
                if(flying)
                {
                    this.RotationZ = MathHelper.ToRadians(currentRotationDegrees + rotationForce);
                    if (currentRotationDegrees > 75 && currentRotationDegrees <= 180)
                    {
                        currentRotationDegrees = 75;
                        flying = false;
                        RotationZ = MathHelper.ToRadians(currentRotationDegrees);
                    }
                    
                }
                else
                {
                    this.RotationZ = MathHelper.ToRadians(currentRotationDegrees - rotationForce);
                    if (currentRotationDegrees > 180 && currentRotationDegrees < (360 - 75))
                    {
                        currentRotationDegrees = 360 - 75;
                        RotationZ = MathHelper.ToRadians(currentRotationDegrees);

                    }
                    
                }
                
                
            }
        }

       
    }
}
