﻿namespace TimeControl.KeyBindings
{
    public enum TimeControlKeyAction
    {
        GUIToggle = 1,
        Realtime = 2,
        PauseToggle = 3,
        TimeStep = 4,
        
        HyperToggle = 5,
        HyperActivate = 6,
        HyperDeactivate = 7,
        HyperRateSetRate = 8,
        HyperRateSpeedUp = 9,
        HyperRateSlowDown = 10,
        HyperPhysicsAccuracySet = 11,
        HyperPhysicsAccuracyUp = 12,
        HyperPhysicsAccuracyDown = 13,

        SlowMoToggle = 14,
        SlowMoActivate = 15,
        SlowMoDeactivate = 16,
        SlowMoSetRate = 17,
        SlowMoSpeedUp = 18,
        SlowMoSlowDown = 19,
        
        WarpToNextKACAlarm = 20,
        WarpForNOrbits = 21,

        WarpToVesselOrbitLocation = 22,
        WarpForNTimeIncrements = 23,

        HyperRateChangeToLowerRate = 24,
        HyperRateChangeToHigherRate = 25,

        HyperAndSloMoSlowDownTime = 26,
        HyperAndSloMoSpeedUpTime = 27
    }
}
/*
All code in this file Copyright(c) 2016 Nate West

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
