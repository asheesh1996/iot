// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Iot.Device.Bmi160
{
    internal enum ErrorCodeDefinitions
    {
        BMI160_OK = 0,
        BMI160_E_NULL_PTR = -1,
        BMI160_E_COM_FAIL = -2,
        BMI160_E_DEV_NOT_FOUND = -3,
        BMI160_E_OUT_OF_RANGE = -4,
        BMI160_E_INVALID_INPUT = -5,
        BMI160_E_ACCEL_ODR_BW_INVALID = -6,
        BMI160_E_GYRO_ODR_BW_INVALID = -7,
        BMI160_E_LWP_PRE_FLTR_INT_INVALID = -8,
        BMI160_E_LWP_PRE_FLTR_INVALID = -9,
        BMI160_E_AUX_NOT_FOUND = -10,
        BMI160_FOC_FAILURE = -11,
        BMI160_ERR_CHOOSE = 12
    }

    internal enum SelfTestConfigurations
    {
        /** Self test configurations */
        BMI160_ACCEL_SELF_TEST_CONFIG = 0x2C,
        BMI160_ACCEL_SELF_TEST_POSITIVE_EN = 0x0D,
        BMI160_ACCEL_SELF_TEST_NEGATIVE_EN = 0x09,
        BMI160_ACCEL_SELF_TEST_LIMIT = 8192
    }

}
