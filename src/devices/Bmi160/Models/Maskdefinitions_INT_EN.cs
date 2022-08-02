// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Iot.Device.Bmi160
{
    internal enum Maskdefinitions_INT_EN
    {
        /** Mask definitions for INT_EN registers */
        BMI160_ANY_MOTION_X_INT_EN_MASK = 0x01,
        BMI160_HIGH_G_X_INT_EN_MASK = 0x01,
        BMI160_NO_MOTION_X_INT_EN_MASK = 0x01,
        BMI160_ANY_MOTION_Y_INT_EN_MASK = 0x02,
        BMI160_HIGH_G_Y_INT_EN_MASK = 0x02,
        BMI160_NO_MOTION_Y_INT_EN_MASK = 0x02,
        BMI160_ANY_MOTION_Z_INT_EN_MASK = 0x04,
        BMI160_HIGH_G_Z_INT_EN_MASK = 0x04,
        BMI160_NO_MOTION_Z_INT_EN_MASK = 0x04,
        BMI160_SIG_MOTION_INT_EN_MASK = 0x07,
        BMI160_ANY_MOTION_ALL_INT_EN_MASK = 0x07,
        BMI160_STEP_DETECT_INT_EN_MASK = 0x08,
        BMI160_DOUBLE_TAP_INT_EN_MASK = 0x10,
        BMI160_SINGLE_TAP_INT_EN_MASK = 0x20,
        BMI160_FIFO_FULL_INT_EN_MASK = 0x20,
        BMI160_ORIENT_INT_EN_MASK = 0x40,
        BMI160_FIFO_WATERMARK_INT_EN_MASK = 0x40,
        BMI160_LOW_G_INT_EN_MASK = 0x08,
        BMI160_STEP_DETECT_EN_MASK = 0x08,
        BMI160_FLAT_INT_EN_MASK = 0x80,
        BMI160_DATA_RDY_INT_EN_MASK = 0x10
    }
}
