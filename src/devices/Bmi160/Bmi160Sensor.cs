// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Buffers.Binary;
using System.Device.I2c;
using System.Device.Model;
using System.Numerics;
using System.Threading;

namespace Iot.Device.Bmi160
{
    /// <summary>
    /// BMI160 - inertial measurement unit (IMU)
    /// </summary>
    [Interface("BMI160 - inertial measurement unit (IMU)")]
    public partial class Bmi160Sensor : IDisposable
    {
        /// <summary>
        /// The default I2C Address, page 91 of the main documentation
        /// https://ae-bst.resource.bosch.com/media/_tech/media/datasheets/BST-BNO055-DS000.pdf
        /// </summary>
        public const byte DefaultI2cAddress = 0x69;

        private I2cDevice _i2cDevice;

        /// <summary>
        /// Initializes a new instance of the <see cref="Bmi160Sensor"/> class.
        /// </summary>
        /// <param name="i2cDevice">The I2C Device</param>
        public Bmi160Sensor(I2cDevice i2cDevice)
        {
            _i2cDevice = i2cDevice;
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _i2cDevice?.Dispose();
            _i2cDevice = null!;
        }
    }
}
