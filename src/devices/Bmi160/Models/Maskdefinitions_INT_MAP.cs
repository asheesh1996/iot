// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Iot.Device.Bmi160
{
    internal enum Maskdefinitions_INT_MAP
    {
        /** Mask definitions for INT_MAP register */
        BMI160_INT1_LOW_G_MASK = 0x01,
        BMI160_INT1_HIGH_G_MASK = 0x02,
        BMI160_INT1_SLOPE_MASK = 0x04,
        BMI160_INT1_NO_MOTION_MASK = 0x08,
        BMI160_INT1_DOUBLE_TAP_MASK = 0x10,
        BMI160_INT1_SINGLE_TAP_MASK = 0x20,
        BMI160_INT1_FIFO_FULL_MASK = 0x20,
        BMI160_INT1_FIFO_WM_MASK = 0x40,
        BMI160_INT1_ORIENT_MASK = 0x40,
        BMI160_INT1_FLAT_MASK = 0x80,
        BMI160_INT1_DATA_READY_MASK = 0x80,
        BMI160_INT2_LOW_G_MASK = 0x01,
        BMI160_INT1_LOW_STEP_DETECT_MASK = 0x01,
        BMI160_INT2_LOW_STEP_DETECT_MASK = 0x01,
        BMI160_INT2_HIGH_G_MASK = 0x02,
        BMI160_INT2_FIFO_FULL_MASK = 0x02,
        BMI160_INT2_FIFO_WM_MASK = 0x04,
        BMI160_INT2_SLOPE_MASK = 0x04,
        BMI160_INT2_DATA_READY_MASK = 0x08,
        BMI160_INT2_NO_MOTION_MASK = 0x08,
        BMI160_INT2_DOUBLE_TAP_MASK = 0x10,
        BMI160_INT2_SINGLE_TAP_MASK = 0x20,
        BMI160_INT2_ORIENT_MASK = 0x40,
        BMI160_INT2_FLAT_MASK = 0x80
    }

}
