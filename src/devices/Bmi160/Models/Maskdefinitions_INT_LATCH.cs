// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Iot.Device.Bmi160
{
    internal enum Maskdefinitions_INT_LATCH
    {
        /** Mask definitions for INT_LATCH register */
        BMI160_INT1_INPUT_EN_MASK = 0x10,
        BMI160_INT2_INPUT_EN_MASK = 0x20,
        BMI160_INT_LATCH_MASK = 0x0F
    }
    internal enum Maskdefinitions_INT_MOTION
    {
        /** Mask definitions for INT_MOTION register */
        BMI160_SLOPE_INT_DUR_MASK = 0x03,
        BMI160_NO_MOTION_INT_DUR_MASK = 0xFC,
        BMI160_NO_MOTION_SEL_BIT_MASK = 0x01
    }
    internal enum Maskdefinitions_INT_TAP
    {
        /** Mask definitions for INT_TAP register */
        BMI160_TAP_DUR_MASK = 0x07,
        BMI160_TAP_SHOCK_DUR_MASK = 0x40,
        BMI160_TAP_QUIET_DUR_MASK = 0x80,
        BMI160_TAP_THRES_MASK = 0x1F
    }

    internal enum Maskdefinitions_INT_FLAT
    {
        /** Mask definitions for INT_FLAT register */
        BMI160_FLAT_THRES_MASK = 0x3F,
        BMI160_FLAT_HOLD_TIME_MASK = 0x30,
        BMI160_FLAT_HYST_MASK = 0x07
    }

    internal enum Maskdefinitions_INT_LOWHIGH
    {
        /** Mask definitions for INT_LOWHIGH register */
        BMI160_LOW_G_HYST_MASK = 0x03,
        BMI160_LOW_G_LOW_MODE_MASK = 0x04,
        BMI160_HIGH_G_HYST_MASK = 0xC0
    }

    internal enum Maskdefinitions_INT_SIG_MOTION
    {
        /** Mask definitions for INT_SIG_MOTION register */
        BMI160_SIG_MOTION_SEL_MASK = 0x02,
        BMI160_SIG_MOTION_SKIP_MASK = 0x0C,
        BMI160_SIG_MOTION_PROOF_MASK = 0x30
    }

    internal enum Maskdefinitions_INT_ORIENT
    {
        /** Mask definitions for INT_ORIENT register */
        BMI160_ORIENT_MODE_MASK = 0x03,
        BMI160_ORIENT_BLOCK_MASK = 0x0C,
        BMI160_ORIENT_HYST_MASK = 0xF0,
        BMI160_ORIENT_THETA_MASK = 0x3F,
        BMI160_ORIENT_UD_ENABLE = 0x40,
        BMI160_AXES_EN_MASK = 0x80
    }

    internal enum Maskdefinitions_FIFO_CONFIG
    {
        /** Mask definitions for FIFO_CONFIG register */
        BMI160_FIFO_GYRO = 0x80,
        BMI160_FIFO_ACCEL = 0x40,
        BMI160_FIFO_AUX = 0x20,
        BMI160_FIFO_TAG_INT1 = 0x08,
        BMI160_FIFO_TAG_INT2 = 0x04,
        BMI160_FIFO_TIME = 0x02,
        BMI160_FIFO_HEADER = 0x10,
        BMI160_FIFO_CONFIG_1_MASK = 0xFE
    }

    internal enum Maskdefinitions_STEP_CONF
    {
        /** Mask definitions for STEP_CONF register */
        BMI160_STEP_COUNT_EN_BIT_MASK = 0x08,
        BMI160_STEP_DETECT_MIN_THRES_MASK = 0x18,
        BMI160_STEP_DETECT_STEPTIME_MIN_MASK = 0x07,
        BMI160_STEP_MIN_BUF_MASK = 0x07
    }
    internal enum LatchDuration
    {
        /** Latch Duration */
        BMI160_LATCH_DUR_NONE = 0x00,
        BMI160_LATCH_DUR_312_5_MICRO_SEC = 0x01,
        BMI160_LATCH_DUR_625_MICRO_SEC = 0x02,
        BMI160_LATCH_DUR_1_25_MILLI_SEC = 0x03,
        BMI160_LATCH_DUR_2_5_MILLI_SEC = 0x04,
        BMI160_LATCH_DUR_5_MILLI_SEC = 0x05,
        BMI160_LATCH_DUR_10_MILLI_SEC = 0x06,
        BMI160_LATCH_DUR_20_MILLI_SEC = 0x07,
        BMI160_LATCH_DUR_40_MILLI_SEC = 0x08,
        BMI160_LATCH_DUR_80_MILLI_SEC = 0x09,
        BMI160_LATCH_DUR_160_MILLI_SEC = 0x0A,
        BMI160_LATCH_DUR_320_MILLI_SEC = 0x0B,
        BMI160_LATCH_DUR_640_MILLI_SEC = 0x0C,
        BMI160_LATCH_DUR_1_28_SEC = 0x0D,
        BMI160_LATCH_DUR_2_56_SEC = 0x0E,
        BMI160_LATCHED = 0x0F
    }



    /** Mask definition for FIFO Header Data Tag */
#define BMI160_FIFO_TAG_INTR_MASK               UINT8_C(0xFC)

    /** Fifo byte counter mask definitions */
#define BMI160_FIFO_BYTE_COUNTER_MASK           UINT8_C(0x07)

    /** Enable/disable bit value */
#define BMI160_ENABLE                           UINT8_C(0x01)
#define BMI160_DISABLE                          UINT8_C(0x00)



    /** name API warning codes */
#define BMI160_W_GYRO_SELF_TEST_FAIL  INT8_C(1)
#define BMI160_W_ACCEl_SELF_TEST_FAIL INT8_C(2)

    /** BMI160 unique chip identifier */
#define BMI160_CHIP_ID                   UINT8_C(0xD1)

    /** Soft reset command */
#define BMI160_SOFT_RESET_CMD            UINT8_C(0xb6)
#define BMI160_SOFT_RESET_DELAY_MS       UINT8_C(15)
    /** Start FOC command */
#define BMI160_START_FOC_CMD            UINT8_C(0x03)
    /** NVM backup enabling command */
#define BMI160_NVM_BACKUP_EN    UINT8_C(0xA0)

    /* Delay in ms settings */
#define BMI160_ACCEL_DELAY_MS            UINT8_C(5)
#define BMI160_GYRO_DELAY_MS             UINT8_C(81)
#define BMI160_ONE_MS_DELAY              UINT8_C(1)
#define BMI160_AUX_COM_DELAY     UINT8_C(10)
#define BMI160_GYRO_SELF_TEST_DELAY  UINT8_C(20)
#define BMI160_ACCEL_SELF_TEST_DELAY   UINT8_C(50)


    /** Power mode settings */
    /* Accel power mode */
#define BMI160_ACCEL_NORMAL_MODE         UINT8_C(0x11)
#define BMI160_ACCEL_LOWPOWER_MODE       UINT8_C(0x12)
#define BMI160_ACCEL_SUSPEND_MODE        UINT8_C(0x10)

    /* Gyro power mode */
#define BMI160_GYRO_SUSPEND_MODE         UINT8_C(0x14)
#define BMI160_GYRO_NORMAL_MODE          UINT8_C(0x15)
#define BMI160_GYRO_FASTSTARTUP_MODE     UINT8_C(0x17)

    /* Aux power mode */
#define BMI160_AUX_SUSPEND_MODE   UINT8_C(0x18)
#define BMI160_AUX_NORMAL_MODE    UINT8_C(0x19)
#define BMI160_AUX_LOWPOWER_MODE  UINT8_C(0x1A)

    /** Range settings */
    /* Accel Range */
#define BMI160_ACCEL_RANGE_2G            UINT8_C(0x03)
#define BMI160_ACCEL_RANGE_4G            UINT8_C(0x05)
#define BMI160_ACCEL_RANGE_8G            UINT8_C(0x08)
#define BMI160_ACCEL_RANGE_16G           UINT8_C(0x0C)

    /* Gyro Range */
#define BMI160_GYRO_RANGE_2000_DPS       UINT8_C(0x00)
#define BMI160_GYRO_RANGE_1000_DPS       UINT8_C(0x01)
#define BMI160_GYRO_RANGE_500_DPS        UINT8_C(0x02)
#define BMI160_GYRO_RANGE_250_DPS        UINT8_C(0x03)
#define BMI160_GYRO_RANGE_125_DPS        UINT8_C(0x04)

    /** Bandwidth settings */
    /* Accel Bandwidth */
#define BMI160_ACCEL_BW_OSR4_AVG1        UINT8_C(0x00)
#define BMI160_ACCEL_BW_OSR2_AVG2        UINT8_C(0x01)
#define BMI160_ACCEL_BW_NORMAL_AVG4      UINT8_C(0x02)
#define BMI160_ACCEL_BW_RES_AVG8         UINT8_C(0x03)
#define BMI160_ACCEL_BW_RES_AVG16        UINT8_C(0x04)
#define BMI160_ACCEL_BW_RES_AVG32        UINT8_C(0x05)
#define BMI160_ACCEL_BW_RES_AVG64        UINT8_C(0x06)
#define BMI160_ACCEL_BW_RES_AVG128       UINT8_C(0x07)

#define BMI160_GYRO_BW_OSR4_MODE         UINT8_C(0x00)
#define BMI160_GYRO_BW_OSR2_MODE         UINT8_C(0x01)
#define BMI160_GYRO_BW_NORMAL_MODE       UINT8_C(0x02)

    /* Output Data Rate settings */
    /* Accel Output data rate */
#define BMI160_ACCEL_ODR_RESERVED        UINT8_C(0x00)
#define BMI160_ACCEL_ODR_0_78HZ          UINT8_C(0x01)
#define BMI160_ACCEL_ODR_1_56HZ          UINT8_C(0x02)
#define BMI160_ACCEL_ODR_3_12HZ          UINT8_C(0x03)
#define BMI160_ACCEL_ODR_6_25HZ          UINT8_C(0x04)
#define BMI160_ACCEL_ODR_12_5HZ          UINT8_C(0x05)
#define BMI160_ACCEL_ODR_25HZ            UINT8_C(0x06)
#define BMI160_ACCEL_ODR_50HZ            UINT8_C(0x07)
#define BMI160_ACCEL_ODR_100HZ           UINT8_C(0x08)
#define BMI160_ACCEL_ODR_200HZ           UINT8_C(0x09)
#define BMI160_ACCEL_ODR_400HZ           UINT8_C(0x0A)
#define BMI160_ACCEL_ODR_800HZ           UINT8_C(0x0B)
#define BMI160_ACCEL_ODR_1600HZ          UINT8_C(0x0C)
#define BMI160_ACCEL_ODR_RESERVED0       UINT8_C(0x0D)
#define BMI160_ACCEL_ODR_RESERVED1       UINT8_C(0x0E)
#define BMI160_ACCEL_ODR_RESERVED2       UINT8_C(0x0F)

    /* Gyro Output data rate */
#define BMI160_GYRO_ODR_RESERVED         UINT8_C(0x00)
#define BMI160_GYRO_ODR_25HZ             UINT8_C(0x06)
#define BMI160_GYRO_ODR_50HZ             UINT8_C(0x07)
#define BMI160_GYRO_ODR_100HZ            UINT8_C(0x08)
#define BMI160_GYRO_ODR_200HZ            UINT8_C(0x09)
#define BMI160_GYRO_ODR_400HZ            UINT8_C(0x0A)
#define BMI160_GYRO_ODR_800HZ            UINT8_C(0x0B)
#define BMI160_GYRO_ODR_1600HZ           UINT8_C(0x0C)
#define BMI160_GYRO_ODR_3200HZ           UINT8_C(0x0D)

    /* Auxiliary sensor Output data rate */
#define BMI160_AUX_ODR_RESERVED        UINT8_C(0x00)
#define BMI160_AUX_ODR_0_78HZ          UINT8_C(0x01)
#define BMI160_AUX_ODR_1_56HZ          UINT8_C(0x02)
#define BMI160_AUX_ODR_3_12HZ          UINT8_C(0x03)
#define BMI160_AUX_ODR_6_25HZ          UINT8_C(0x04)
#define BMI160_AUX_ODR_12_5HZ          UINT8_C(0x05)
#define BMI160_AUX_ODR_25HZ            UINT8_C(0x06)
#define BMI160_AUX_ODR_50HZ            UINT8_C(0x07)
#define BMI160_AUX_ODR_100HZ           UINT8_C(0x08)
#define BMI160_AUX_ODR_200HZ           UINT8_C(0x09)
#define BMI160_AUX_ODR_400HZ           UINT8_C(0x0A)
#define BMI160_AUX_ODR_800HZ           UINT8_C(0x0B)

    /* Maximum limits definition */
#define BMI160_ACCEL_ODR_MAX             UINT8_C(15)
#define BMI160_ACCEL_BW_MAX              UINT8_C(2)
#define BMI160_ACCEL_RANGE_MAX           UINT8_C(12)
#define BMI160_GYRO_ODR_MAX              UINT8_C(13)
#define BMI160_GYRO_BW_MAX               UINT8_C(2)
#define BMI160_GYRO_RANGE_MAX            UINT8_C(4)

    /** FIFO_CONFIG Definitions */
#define BMI160_FIFO_TIME_ENABLE          UINT8_C(0x02)
#define BMI160_FIFO_TAG_INT2_ENABLE      UINT8_C(0x04)
#define BMI160_FIFO_TAG_INT1_ENABLE      UINT8_C(0x08)
#define BMI160_FIFO_HEAD_ENABLE          UINT8_C(0x10)
#define BMI160_FIFO_M_ENABLE             UINT8_C(0x20)
#define BMI160_FIFO_A_ENABLE             UINT8_C(0x40)
#define BMI160_FIFO_M_A_ENABLE           UINT8_C(0x60)
#define BMI160_FIFO_G_ENABLE             UINT8_C(0x80)
#define BMI160_FIFO_M_G_ENABLE           UINT8_C(0xA0)
#define BMI160_FIFO_G_A_ENABLE           UINT8_C(0xC0)
#define BMI160_FIFO_M_G_A_ENABLE         UINT8_C(0xE0)


    /* Accel, gyro and aux. sensor length and also their combined
     * length definitions in FIFO */
#define BMI160_FIFO_G_LENGTH             UINT8_C(6)
#define BMI160_FIFO_A_LENGTH             UINT8_C(6)
#define BMI160_FIFO_M_LENGTH             UINT8_C(8)
#define BMI160_FIFO_GA_LENGTH            UINT8_C(12)
#define BMI160_FIFO_MA_LENGTH            UINT8_C(14)
#define BMI160_FIFO_MG_LENGTH            UINT8_C(14)
#define BMI160_FIFO_MGA_LENGTH           UINT8_C(20)


    /** FIFO Header Data definitions */
#define BMI160_FIFO_HEAD_SKIP_FRAME      UINT8_C(0x40)
#define BMI160_FIFO_HEAD_SENSOR_TIME     UINT8_C(0x44)
#define BMI160_FIFO_HEAD_INPUT_CONFIG    UINT8_C(0x48)
#define BMI160_FIFO_HEAD_OVER_READ       UINT8_C(0x80)
#define BMI160_FIFO_HEAD_A               UINT8_C(0x84)
#define BMI160_FIFO_HEAD_G               UINT8_C(0x88)
#define BMI160_FIFO_HEAD_G_A             UINT8_C(0x8C)
#define BMI160_FIFO_HEAD_M               UINT8_C(0x90)
#define BMI160_FIFO_HEAD_M_A             UINT8_C(0x94)
#define BMI160_FIFO_HEAD_M_G             UINT8_C(0x98)
#define BMI160_FIFO_HEAD_M_G_A           UINT8_C(0x9C)


    /** FIFO sensor time length definitions */
#define BMI160_SENSOR_TIME_LENGTH        UINT8_C(3)


    /** FIFO DOWN selection */
    /* Accel fifo down-sampling values*/
#define BMI160_ACCEL_FIFO_DOWN_ZERO     UINT8_C(0x00)
#define BMI160_ACCEL_FIFO_DOWN_ONE      UINT8_C(0x10)
#define BMI160_ACCEL_FIFO_DOWN_TWO      UINT8_C(0x20)
#define BMI160_ACCEL_FIFO_DOWN_THREE    UINT8_C(0x30)
#define BMI160_ACCEL_FIFO_DOWN_FOUR     UINT8_C(0x40)
#define BMI160_ACCEL_FIFO_DOWN_FIVE     UINT8_C(0x50)
#define BMI160_ACCEL_FIFO_DOWN_SIX      UINT8_C(0x60)
#define BMI160_ACCEL_FIFO_DOWN_SEVEN    UINT8_C(0x70)

    /* Gyro fifo down-smapling values*/
#define BMI160_GYRO_FIFO_DOWN_ZERO      UINT8_C(0x00)
#define BMI160_GYRO_FIFO_DOWN_ONE       UINT8_C(0x01)
#define BMI160_GYRO_FIFO_DOWN_TWO       UINT8_C(0x02)
#define BMI160_GYRO_FIFO_DOWN_THREE     UINT8_C(0x03)
#define BMI160_GYRO_FIFO_DOWN_FOUR      UINT8_C(0x04)
#define BMI160_GYRO_FIFO_DOWN_FIVE      UINT8_C(0x05)
#define BMI160_GYRO_FIFO_DOWN_SIX       UINT8_C(0x06)
#define BMI160_GYRO_FIFO_DOWN_SEVEN     UINT8_C(0x07)

    /* Accel Fifo filter enable*/
#define BMI160_ACCEL_FIFO_FILT_EN       UINT8_C(0x80)

    /* Gyro Fifo filter enable*/
#define BMI160_GYRO_FIFO_FILT_EN        UINT8_C(0x08)

    /** Definitions to check validity of FIFO frames */
#define FIFO_CONFIG_MSB_CHECK            UINT8_C(0x80)
#define FIFO_CONFIG_LSB_CHECK            UINT8_C(0x00)

    /*! BMI160 accel FOC configurations */
#define BMI160_FOC_ACCEL_DISABLED        UINT8_C(0x00)
#define BMI160_FOC_ACCEL_POSITIVE_G      UINT8_C(0x01)
#define BMI160_FOC_ACCEL_NEGATIVE_G      UINT8_C(0x02)
#define BMI160_FOC_ACCEL_0G              UINT8_C(0x03)

    /** Array Parameter DefinItions */
#define BMI160_SENSOR_TIME_LSB_BYTE      UINT8_C(0)
#define BMI160_SENSOR_TIME_XLSB_BYTE     UINT8_C(1)
#define BMI160_SENSOR_TIME_MSB_BYTE      UINT8_C(2)


    /** Interface settings */
#define BMI160_SPI_INTF                  UINT8_C(1)
#define BMI160_I2C_INTF                  UINT8_C(0)
#define BMI160_SPI_RD_MASK               UINT8_C(0x80)
#define BMI160_SPI_WR_MASK               UINT8_C(0x7F)

    /* Sensor & time select definition*/
#define BMI160_ACCEL_SEL    UINT8_C(0x01)
#define BMI160_GYRO_SEL     UINT8_C(0x02)
#define BMI160_TIME_SEL     UINT8_C(0x04)

    /* Sensor select mask*/
#define BMI160_SEN_SEL_MASK   UINT8_C(0x07)

    /* Error code mask */
#define BMI160_ERR_REG_MASK   UINT8_C(0x0F)

    /* BMI160 I2C address */
#define BMI160_I2C_ADDR                 UINT8_C(0x68)

    /* BMI160 secondary IF address */
#define BMI160_AUX_BMM150_I2C_ADDR    UINT8_C(0x10)

    /** BMI160 Length definitions */
#define BMI160_ONE                       UINT8_C(1)
#define BMI160_TWO                       UINT8_C(2)
#define BMI160_THREE                     UINT8_C(3)
#define BMI160_FOUR                      UINT8_C(4)
#define BMI160_FIVE                      UINT8_C(5)

    /** BMI160 fifo level Margin */
#define BMI160_FIFO_LEVEL_MARGIN         UINT8_C(16)

    /** BMI160 fifo flush Command */
#define BMI160_FIFO_FLUSH_VALUE          UINT8_C(0xB0)

    /** BMI160 offset values for xyz axes of accel */
#define BMI160_ACCEL_MIN_OFFSET         INT8_C(-128)
#define BMI160_ACCEL_MAX_OFFSET         INT8_C(127)

    /** BMI160 offset values for xyz axes of gyro */
#define BMI160_GYRO_MIN_OFFSET         INT16_C(-512)
#define BMI160_GYRO_MAX_OFFSET         INT16_C(511)

    /** BMI160 fifo full interrupt position and mask */
#define BMI160_FIFO_FULL_INT_POS  UINT8_C(5)
#define BMI160_FIFO_FULL_INT_MSK  UINT8_C(0x20)
#define BMI160_FIFO_WTM_INT_POS   UINT8_C(6)
#define BMI160_FIFO_WTM_INT_MSK   UINT8_C(0x40)

#define BMI160_FIFO_FULL_INT_PIN1_POS UINT8_C(5)
#define BMI160_FIFO_FULL_INT_PIN1_MSK UINT8_C(0x20)
#define BMI160_FIFO_FULL_INT_PIN2_POS UINT8_C(1)
#define BMI160_FIFO_FULL_INT_PIN2_MSK UINT8_C(0x02)

#define BMI160_FIFO_WTM_INT_PIN1_POS  UINT8_C(6)
#define BMI160_FIFO_WTM_INT_PIN1_MSK  UINT8_C(0x40)
#define BMI160_FIFO_WTM_INT_PIN2_POS  UINT8_C(2)
#define BMI160_FIFO_WTM_INT_PIN2_MSK  UINT8_C(0x04)

#define BMI160_MANUAL_MODE_EN_POS UINT8_C(7)
#define BMI160_MANUAL_MODE_EN_MSK UINT8_C(0x80)
#define BMI160_AUX_READ_BURST_POS UINT8_C(0)
#define BMI160_AUX_READ_BURST_MSK UINT8_C(0x03)

#define BMI160_GYRO_SELF_TEST_POS UINT8_C(4)
#define BMI160_GYRO_SELF_TEST_MSK UINT8_C(0x10)
#define BMI160_GYRO_SELF_TEST_STATUS_POS  UINT8_C(1)
#define BMI160_GYRO_SELF_TEST_STATUS_MSK  UINT8_C(0x02)

#define BMI160_GYRO_FOC_EN_POS  UINT8_C(6)
#define BMI160_GYRO_FOC_EN_MSK  UINT8_C(0x40)

#define BMI160_ACCEL_FOC_X_CONF_POS UINT8_C(4)
#define BMI160_ACCEL_FOC_X_CONF_MSK UINT8_C(0x30)

#define BMI160_ACCEL_FOC_Y_CONF_POS UINT8_C(2)
#define BMI160_ACCEL_FOC_Y_CONF_MSK UINT8_C(0x0C)

#define BMI160_ACCEL_FOC_Z_CONF_MSK UINT8_C(0x03)

#define BMI160_FOC_STATUS_POS UINT8_C(3)
#define BMI160_FOC_STATUS_MSK UINT8_C(0x08)

#define BMI160_GYRO_OFFSET_X_MSK  UINT8_C(0x03)

#define BMI160_GYRO_OFFSET_Y_POS  UINT8_C(2)
#define BMI160_GYRO_OFFSET_Y_MSK  UINT8_C(0x0C)

#define BMI160_GYRO_OFFSET_Z_POS  UINT8_C(4)
#define BMI160_GYRO_OFFSET_Z_MSK  UINT8_C(0x30)

#define BMI160_GYRO_OFFSET_EN_POS UINT8_C(7)
#define BMI160_GYRO_OFFSET_EN_MSK UINT8_C(0x80)

#define BMI160_ACCEL_OFFSET_EN_POS  UINT8_C(6)
#define BMI160_ACCEL_OFFSET_EN_MSK  UINT8_C(0x40)


#define BMI160_GYRO_OFFSET_POS          UINT16_C(8)
#define BMI160_GYRO_OFFSET_MSK          UINT16_C(0x0300)

#define BMI160_NVM_UPDATE_POS         UINT8_C(1)
#define BMI160_NVM_UPDATE_MSK         UINT8_C(0x02)

#define BMI160_NVM_STATUS_POS         UINT8_C(4)
#define BMI160_NVM_STATUS_MSK         UINT8_C(0x10)

}
