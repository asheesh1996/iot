// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Iot.Device.Bmi160
{
    internal enum Maskdefinitions_INT_OUT_CTRL
    {
        /** Mask definitions for INT_OUT_CTRL register */
        BMI160_INT1_EDGE_CTRL_MASK = 0x01,
        BMI160_INT1_OUTPUT_MODE_MASK = 0x04,
        BMI160_INT1_OUTPUT_TYPE_MASK = 0x02,
        BMI160_INT1_OUTPUT_EN_MASK = 0x08,
        BMI160_INT2_EDGE_CTRL_MASK = 0x10,
        BMI160_INT2_OUTPUT_MODE_MASK = 0x40,
        BMI160_INT2_OUTPUT_TYPE_MASK = 0x20,
        BMI160_INT2_OUTPUT_EN_MASK = 0x80
    }
}
