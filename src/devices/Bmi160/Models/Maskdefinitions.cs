// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Iot.Device.Bmi160
{
    internal enum Maskdefinitions
    {
        BMI160_ACCEL_BW_MASK = 0x70,
        BMI160_ACCEL_ODR_MASK = 0x0F,
        BMI160_ACCEL_UNDERSAMPLING_MASK = 0x80,
        BMI160_ACCEL_RANGE_MASK = 0x0F,
        BMI160_GYRO_BW_MASK = 0x30,
        BMI160_GYRO_ODR_MASK = 0x0F,
        BMI160_GYRO_RANGE_MSK = 0x07
    }
}
