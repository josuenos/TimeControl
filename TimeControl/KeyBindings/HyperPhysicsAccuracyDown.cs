﻿using System;

namespace TimeControl.KeyBindings
{
    public class HyperPhysicsAccuracyDown : TimeControlKeyBindingValue
    {
        private float v = 0.5f;

        private void UpdateDescription()
        {
            Description = String.Format( "Hyper-Warp Accuracy -{0}", v );
        }

        public HyperPhysicsAccuracyDown()
        {
            TimeControlKeyActionName = TimeControlKeyAction.HyperPhysicsAccuracyDown;
            SetDescription = "Hyper-Warp Decrease Accuracy By: ";
            FireWhileHoldingKeyDown = true;
            UpdateDescription();
        }

        public override float VMax
        {
            get => 3f;
        }

        public override float VMin
        {
            get => 0.05f;
        }

        public override float V
        {
            get => v;
            set
            {
                if (value >= VMax)
                {
                    v = VMax;
                }
                else if (value <= VMin)
                {
                    v = VMin;
                }
                else
                {
                    v = (float)Math.Round( value, 2 );
                }

                UpdateDescription();
            }
        }

        public override void Press()
        {
            if (HyperWarpController.IsReady)
            {
                HyperWarpController.Instance.DecreasePhysicsAccuracy( v );
            }
        }
    }
}
/*
All code in this file Copyright(c) 2016 Nate West
Rewritten from scratch, but based on code Copyright(c) 2014 Xaiier using the same license as below

The MIT License (MIT)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
