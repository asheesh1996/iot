// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Iot.Device.Bmi160
{
    internal enum Maskdefinitions_INT_DATA
    {
        /** Mask definitions for INT_DATA register */
        BMI160_TAP_SRC_INT_MASK = 0x08,
        BMI160_LOW_HIGH_SRC_INT_MASK = 0x80,
        BMI160_MOTION_SRC_INT_MASK = 0x80
    }

}
