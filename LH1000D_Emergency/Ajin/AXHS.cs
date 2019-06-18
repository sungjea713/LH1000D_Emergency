/****************************************************************************
*****************************************************************************
**
** File Name
** ---------
**
** AXHS.CS
**
** COPYRIGHT (c) AJINEXTEK Co., LTD
**
*****************************************************************************
*****************************************************************************
**
** Description
** -----------
** Resource Define Header File
** 
**
*****************************************************************************
*****************************************************************************
**
** Source Change Indices
** ---------------------
** 
** (None)
**
**
*****************************************************************************
*****************************************************************************
**
** Website
** ---------------------
**
** http://www.ajinextek.com
**
*****************************************************************************
*****************************************************************************
*/

using System.Runtime.InteropServices;

// ���̽����� ����
public enum AXT_BASE_NODE:uint
{
        AXT_UNKNOWN               = 0x00,            // Unknown Baseboard
        AXT_EIP                   = 0x20,            // EtherNet/IP interface Node
        AXT_ECAT                  = 0x21,            // EtherCat interface Node
        AXT_CAN                   = 0x22,            // CAN interface Node
        AXT_DNET                  = 0x23,            // DEVICENET interface Node
        AXT_PBUS                  = 0x24             // ProfiBus interface Node
}

// ��� ����
public enum AXT_MODULE:uint
{
        AXT_NMC_2V04              = 0xB1,            // CAMC-QI, 2 Axis
        AXT_NMC_4V04              = 0xB2,            // CAMC-QI, 4 Axis
        AXT_NIO_DC16              = 0xB3,            // Digital 16 �� Configurable
        AXT_NIO_AI4               = 0xB4,            // AI 4Ch, 16 bit
        AXT_NIO_DI32              = 0xB5,            // Digital IN  32��    (reserved)
        AXT_NIO_DO32              = 0xB6,            // Digital OUT 32��    (reserved)
        AXT_NIO_DB32              = 0xB7,            // Digital IN  16�� / OUT 16��    (reserved)
        AXT_NIO_AO4               = 0xB8,            // AO 4Ch, 16 bit    (reserved)
        AXT_FN_EMPTY              = 0xFE,            // Empty module area.
        AXT_FN_UNKNOWN            = 0xFF             // Unkown module.
}

public enum AXT_FUNC_RESULT:uint
{
        AXT_RT_SUCCESS                                = 0000,
        AXT_RT_OPEN_ERROR                             = 1001,
        AXT_RT_OPEN_ALREADY                           = 1002,
        AXT_RT_NOT_OPEN                               = 1053,
        AXT_RT_NOT_SUPPORT_VERSION                    = 1054,
        AXT_RT_INVALID_NODE_NO                        = 1101,
        AXT_RT_INVALID_MODULE_POS                     = 1102,
        AXT_RT_INVALID_LEVEL                          = 1103,
        AXT_RT_FLASH_BUSY                             = 1150,
        AXT_RT_ERROR_VERSION_READ                     = 1151,
        AXT_RT_ERROR_NETWORK                          = 1152,
        AXT_RT_ERROR_HW_ACCESS                        = 1153,            
        AXT_RT_ERROR_NETWORK_CHEKSUM                  = 1154,

        AXT_RT_1ST_BELOW_MIN_VALUE                    = 1160,
        AXT_RT_1ST_ABOVE_MAX_VALUE                    = 1161,
        AXT_RT_2ND_BELOW_MIN_VALUE                    = 1170,
        AXT_RT_2ND_ABOVE_MAX_VALUE                    = 1171,
        AXT_RT_3RD_BELOW_MIN_VALUE                    = 1180,
        AXT_RT_3RD_ABOVE_MAX_VALUE                    = 1181,
        AXT_RT_4TH_BELOW_MIN_VALUE                    = 1190,
        AXT_RT_4TH_ABOVE_MAX_VALUE                    = 1191,
        AXT_RT_5TH_BELOW_MIN_VALUE                    = 1200,
        AXT_RT_5TH_ABOVE_MAX_VALUE                    = 1201,
        AXT_RT_6TH_BELOW_MIN_VALUE                    = 1210,
        AXT_RT_6TH_ABOVE_MAX_VALUE                    = 1211,
        AXT_RT_7TH_BELOW_MIN_VALUE                    = 1220,
        AXT_RT_7TH_ABOVE_MAX_VALUE                    = 1221,
        AXT_RT_8TH_BELOW_MIN_VALUE                    = 1230,
        AXT_RT_8TH_ABOVE_MAX_VALUE                    = 1231,
        AXT_RT_9TH_BELOW_MIN_VALUE                    = 1240,
        AXT_RT_9TH_ABOVE_MAX_VALUE                    = 1241,
        AXT_RT_10TH_BELOW_MIN_VALUE                   = 1250,
        AXT_RT_10TH_ABOVE_MAX_VALUE                   = 1251,

        AXT_RT_AIO_OPEN_ERROR                         = 2001,
        AXT_RT_AIO_NOT_MODULE                         = 2051,
        AXT_RT_AIO_NOT_EVENT                          = 2052,
        AXT_RT_AIO_INVALID_MODULE_NO                  = 2101,
        AXT_RT_AIO_INVALID_CHANNEL_NO                 = 2102,
        AXT_RT_AIO_INVALID_USE                        = 2106,
        AXT_RT_AIO_INVALID_TRIGGER_MODE               = 2107,

        AXT_RT_DIO_OPEN_ERROR                         = 3001,
        AXT_RT_DIO_NOT_MODULE                         = 3051,
        AXT_RT_DIO_NOT_INTERRUPT                      = 3052,
        AXT_RT_DIO_INVALID_MODULE_NO                  = 3101,
        AXT_RT_DIO_INVALID_OFFSET_NO                  = 3102,
        AXT_RT_DIO_INVALID_LEVEL                      = 3103,
        AXT_RT_DIO_INVALID_MODE                       = 3104,
        AXT_RT_DIO_INVALID_VALUE                      = 3105,
        AXT_RT_DIO_INVALID_USE                        = 3106,

        AXT_RT_MOTION_OPEN_ERROR                      = 4001,
        AXT_RT_MOTION_NOT_MODULE                      = 4051,
        AXT_RT_MOTION_NOT_INTERRUPT                   = 4052,
        AXT_RT_MOTION_NOT_INITIAL_AXIS_NO             = 4053,
        AXT_RT_MOTION_NOT_IN_CONT_INTERPOL            = 4054,
        AXT_RT_MOTION_NOT_PARA_READ                   = 4055,
        AXT_RT_MOTION_INVALID_AXIS_NO                 = 4101,
        AXT_RT_MOTION_INVALID_METHOD                  = 4102,
        AXT_RT_MOTION_INVALID_USE                     = 4103,
        AXT_RT_MOTION_INVALID_LEVEL                   = 4104,
        AXT_RT_MOTION_INVALID_BIT_NO                  = 4105,
        AXT_RT_MOTION_INVALID_STOP_MODE               = 4106,
        AXT_RT_MOTION_INVALID_TRIGGER_MODE            = 4107,
        AXT_RT_MOTION_INVALID_TRIGGER_LEVEL           = 4108,
        AXT_RT_MOTION_INVALID_SELECTION               = 4109,
        AXT_RT_MOTION_INVALID_TIME                    = 4110,
        AXT_RT_MOTION_INVALID_FILE_LOAD               = 4111,
        AXT_RT_MOTION_INVALID_FILE_SAVE               = 4112,
        AXT_RT_MOTION_INVALID_VELOCITY                = 4113,
        AXT_RT_MOTION_INVALID_ACCELTIME               = 4114,
        AXT_RT_MOTION_INVALID_PULSE_VALUE             = 4115,
        AXT_RT_MOTION_INVALID_NODE_NUMBER             = 4116,
        AXT_RT_MOTION_INVALID_TARGET                  = 4117,
        AXT_RT_MOTION_ERROR_IN_NONMOTION              = 4151,
        AXT_RT_MOTION_ERROR_IN_MOTION                 = 4152,
        AXT_RT_MOTION_ERROR                           = 4153,
       
        AXT_RT_MOTION_ERROR_GANTRY_ENABLE             = 4154,
        AXT_RT_MOTION_ERROR_GANTRY_AXIS               = 4155,
        AXT_RT_MOTION_ERROR_MASTER_SERVOON            = 4156,
        AXT_RT_MOTION_ERROR_SLAVE_SERVOON             = 4157,
        AXT_RT_MOTION_INVALID_POSITION                = 4158,

        AXT_RT_ERROR_NOT_SAME_MODULE                  = 4159,
        AXT_RT_ERROR_NOT_SAME_PRODUCT                 = 4161,
        AXT_RT_NOT_CAPTURED                           = 4162,
        AXT_RT_ERROR_NOT_SAME_IC                      = 4163,
        AXT_RT_ERROR_NOT_GEARMODE                     = 4164,
        AXT_ERROR_CONTI_INVALID_AXIS_NO               = 4165,
        AXT_ERROR_CONTI_INVALID_MAP_NO                = 4166,
        AXT_ERROR_CONTI_EMPTY_MAP_NO                  = 4167,
        AXT_RT_MOTION_ERROR_CACULATION                = 4168,
        AXT_RT_ERROR_NOT_SAME_NODE                    = 4169,

        AXT_ERROR_HELICAL_INVALID_AXIS_NO             = 4170,
        AXT_ERROR_HELICAL_INVALID_MAP_NO              = 4171,
        AXT_ERROR_HELICAL_EMPTY_MAP_NO                = 4172,

        AXT_ERROR_SPLINE_INVALID_AXIS_NO              = 4180,
        AXT_ERROR_SPLINE_INVALID_MAP_NO               = 4181,
        AXT_ERROR_SPLINE_EMPTY_MAP_NO                 = 4182,
        AXT_ERROR_SPLINE_NUM_ERROR                    = 4183,
        AXT_RT_MOTION_INTERPOL_VALUE                  = 4184,
        AXT_RT_ERROR_NOT_CONTIBEGIN                   = 4185,
        AXT_RT_ERROR_NOT_CONTIEND                     = 4186,

        AXT_RT_MOTION_HOME_SEARCHING                  = 4201,
        AXT_RT_MOTION_HOME_ERROR_SEARCHING            = 4202,
        AXT_RT_MOTION_HOME_ERROR_START                = 4203,
        AXT_RT_MOTION_HOME_ERROR_GANTRY               = 4204,
        AXT_RT_MOTION_POSITION_OUTOFBOUND             = 4251,
        AXT_RT_MOTION_PROFILE_INVALID                 = 4252,
        AXT_RT_MOTION_VELOCITY_OUTOFBOUND             = 4253,
        AXT_RT_MOTION_MOVE_UNIT_IS_ZERO               = 4254,
        AXT_RT_MOTION_SETTING_ERROR                   = 4255,
        AXT_RT_MOTION_IN_CONT_INTERPOL                = 4256,
        AXT_RT_MOTION_DISABLE_TRIGGER                 = 4257,
        AXT_RT_MOTION_INVALID_CONT_INDEX              = 4258,
        AXT_RT_MOTION_CONT_QUEUE_FULL                 = 4259,

        AXT_RT_INIT_DOSE_NOT_EXIST_LAN_CARD           = 4301,
        AXT_RT_INIT_DOES_NOT_RESPONSE_SLAVE           = 4302,
        AXT_RT_INIT_INVALID_HOST_IP_ADDRESS           = 4303,
        AXT_RT_INIT_INVALID_HOST_COUNT                = 4304,
        AXT_RT_INIT_EIPSTART_FAIL                     = 4305,
        AXT_RT_INIT_ALREADY_INITIALIZED               = 4306,
        AXT_RT_INIT_INVALID_NET_TYPE                  = 4307,
        AXT_RT_INIT_PRODUCTID                         = 4308,
        AXT_RT_INIT_NOT_ENOUGH_MEMORY                 = 4309,
        AXT_RT_INIT_DOES_NOT_RESPONSE_SLAVE_AT_RING   = 4310,
        AXT_RT_INIT_NETWORK_ERROR                     = 4311,
        AXT_RT_INIT_BACKGROUND_NOT_STARTED            = 4312,
        AXT_RT_INIT_BACKGROUND_START_FAIL             = 4313
}

public enum AXT_BOOLEAN:uint
{
    FALSE,
    TRUE
}

public enum AXT_EVENT:uint
{
    WM_USER                      = 0x0400
    //WM_AXL_INTERRUPT           = (WM_USER + 1001)
    //WM_AXL_NETSTAT             = (WM_USER + 1002)
}

public enum AXT_LOG_LEVEL:uint
{
    LEVEL_NONE,
    LEVEL_ERROR,
    LEVEL_RUNSTOP,
    LEVEL_FUNCTION
}

public enum AXT_EXISTENCE:uint
{
    STATUS_NOTEXIST,
    STATUS_EXIST
}

public enum AXT_USE:uint
{
    DISABLE,
    ENABLE
}

public enum AXT_AIO_TRIGGER_MODE:uint
{
    DISABLE_MODE               = 0,
    NORMAL_MODE                = 1,
    TIMER_MODE, 
    EXTERNAL_MODE
}

public enum AXT_AIO_FULL_MODE:uint
{
    NEW_DATA_KEEP,
    CURR_DATA_KEEP
}

public enum AXT_AIO_EVENT_MASK:uint 
{
    DATA_EMPTY                  = 0x01,
    DATA_MANY                   = 0x02,
    DATA_SMAL                   = 0x04,
    DATA_FULL                   = 0x08
}

public enum AXT_AIO_INTERRUPT_MASK:uint 
{
    ADC_DONE                    = 0x00,
    SCAN_END                    = 0x01,
    FIFO_HALF_FULL              = 0x02,
    NO_SIGNAL                   = 0x03
}

public enum AIO_EVENT_MODE:uint 
{
    AIO_EVENT_DATA_RESET         = 0x00, 
    AIO_EVENT_DATA_UPPER, 
    AIO_EVENT_DATA_LOWER, 
    AIO_EVENT_DATA_FULL, 
    AIO_EVENT_DATA_EMPTY         = 0x03
}
    
public enum AXT_DIO_EDGE:uint
{
    DOWN_EDGE,
    UP_EDGE
}

public enum AXT_DIO_STATE:uint
{
    OFF_STATE,
    ON_STATE
}

public enum AXT_MOTION_STOPMODE:uint
{
    EMERGENCY_STOP,
    SLOWDOWN_STOP
}

public enum AXT_MOTION_EDGE:uint
{
    SIGNAL_UP_EDGE,
    SIGNAL_DOWN_EDGE
}

public enum AXT_MOTION_SELECTION:uint
{
    COMMAND,
    ACTUAL
}

public enum AXT_MOTION_TRIGGER_MODE:uint
{
    PERIOD_MODE,
    ABS_POS_MODE
}

public enum AXT_MOTION_LEVEL_MODE:uint
{
    LOW,
    HIGH,
    UNUSED,
    USED
}

public enum AXT_MOTION_ABSREL_MODE:uint
{
    POS_ABS_MODE,
    POS_REL_MODE
}

public enum AXT_MOTION_PROFILE_MODE:uint
{
    SYM_TRAPEZOIDE_MODE,
    ASYM_TRAPEZOIDE_MODE,
    QUASI_S_CURVE_MODE,
    SYM_S_CURVE_MODE,
    ASYM_S_CURVE_MODE
}

public enum AXT_MOTION_SIGNAL_LEVEL:uint
{
    INACTIVE,
    ACTIVE
}

public enum AXT_MOTION_HOME_RESULT:uint
{
    HOME_SUCCESS                      = 0x01,
    HOME_SEARCHING                    = 0x02,
    HOME_ERR_GNT_RANGE                = 0x10,
    HOME_ERR_USER_BREAK               = 0x11,
    HOME_ERR_VELOCITY                 = 0x12,
    HOME_ERR_AMP_FAULT                = 0x13,
    HOME_ERR_NEG_LIMIT                = 0x14,
    HOME_ERR_POS_LIMIT                = 0x15,
    HOME_ERR_NOT_DETECT               = 0x16,
    HOME_ERR_UNKNOWN                  = 0xFF
}

public enum AXT_MOTION_UNIV_INPUT:uint
{
    UIO_INP0,
    UIO_INP1,
    UIO_INP2,
    UIO_INP3,
    UIO_INP4,
    UIO_INP5
}

public enum AXT_MOTION_UNIV_OUTPUT:uint
{
    UIO_OUT0,
    UIO_OUT1,
    UIO_OUT2,
    UIO_OUT3,
    UIO_OUT4,
    UIO_OUT5
}

public enum AXT_MOTION_DETECT_DOWN_START_POINT:uint
{
    AutoDetect,
    RestPulse
}

public enum AXT_MOTION_PULSE_OUTPUT:uint
{
    OneHighLowHigh,                      // 1�޽� ���, PULSE(Active High), ������(DIR=Low)  / ������(DIR=High)
    OneHighHighLow,                      // 1�޽� ���, PULSE(Active High), ������(DIR=High) / ������(DIR=Low)
    OneLowLowHigh,                       // 1�޽� ���, PULSE(Active Low),  ������(DIR=Low)  / ������(DIR=High)
    OneLowHighLow,                       // 1�޽� ���, PULSE(Active Low),  ������(DIR=High) / ������(DIR=Low)
    TwoCcwCwHigh,                        // 2�޽� ���, PULSE(CCW:������),  DIR(CW:������),  Active High     
    TwoCcwCwLow,                         // 2�޽� ���, PULSE(CCW:������),  DIR(CW:������),  Active Low     
    TwoCwCcwHigh,                        // 2�޽� ���, PULSE(CW:������),   DIR(CCW:������), Active High
    TwoCwCcwLow,                         // 2�޽� ���, PULSE(CW:������),   DIR(CCW:������), Active Low
    TwoPhase                             // 2��(90' ������),  PULSE lead DIR(CW: ������), PULSE lag DIR(CCW:������)
}

public enum AXT_MOTION_EXTERNAL_COUNTER_INPUT:uint
{
    ObverseUpDownMode,                   // ������ Up/Down
    ObverseSqr1Mode,                     // ������ 1ü��
    ObverseSqr2Mode,                     // ������ 2ü��
    ObverseSqr4Mode,                     // ������ 4ü��
    ReverseUpDownMode,                   // ������ Up/Down
    ReverseSqr1Mode,                     // ������ 1ü��
    ReverseSqr2Mode,                     // ������ 2ü��
    ReverseSqr4Mode                      // ������ 4ü��
}

public enum AXT_MOTION_ACC_UNIT:uint
{
    UNIT_SEC2              = 0x0,    // unit/sec2
    SEC                    = 0x1     // sec
}

public enum AXT_MOTION_MOVE_DIR:uint
{
    DIR_CCW                = 0x0,    // �ݽð����
    DIR_CW                 = 0x1     // �ð����
}

public enum AXT_MOTION_RADIUS_DISTANCE:uint
{
    SHORT_DISTANCE          = 0x0,    // ª�� �Ÿ��� ��ȣ �̵� 
    LONG_DISTANCE           = 0x1     // �� �Ÿ��� ��ȣ �̵� 
}

public enum AXT_MOTION_INTERPOLATION_AXIS:uint
{
    INTERPOLATION_AXIS2     = 0x0,         // 2���� �������� ����� ��
    INTERPOLATION_AXIS3     = 0x1,         // 3���� �������� ����� ��
    INTERPOLATION_AXIS4     = 0x2          // 4���� �������� ����� ��
}

public enum AXT_MOTION_CONTISTART_NODE:uint
{
    CONTI_NODE_VELOCITY               = 0x0,    // �ӵ� ���� ���� ���
    CONTI_NODE_MANUAL                 = 0x1,    // ��� ������ ���� ���
    CONTI_NODE_AUTO                   = 0x2     // �ڵ� ������ ���� ���
}

public enum AXT_MOTION_HOME_DETECT_SIGNAL:uint
{
    PosEndLimit                       = 0x0,    // +Elm(End limit) +���� ����Ʈ ���� ��ȣ
    NegEndLimit                       = 0x1,    // -Elm(End limit) -���� ����Ʈ ���� ��ȣ
    PosSloLimit                       = 0x2,    // +Slm(Slow Down limit) ��ȣ - ������� ����
    NegSloLimit                       = 0x3,    // -Slm(Slow Down limit) ��ȣ - ������� ����
    HomeSensor                        = 0x4,    // IN0(ORG)  ���� ���� ��ȣ
    EncodZPhase                       = 0x5,    // IN1(Z��)  Encoder Z�� ��ȣ
    UniInput02                        = 0x6,    // IN2(����) ���� �Է� 2�� ��ȣ
    UniInput03                        = 0x7,    // IN3(����) ���� �Է� 3�� ��ȣ
}

public enum AXT_MOTION_MPG_INPUT_METHOD:uint
{
    MPG_DIFF_ONE_PHASE                = 0x0,    // MPG �Է� ��� One Phase
    MPG_DIFF_TWO_PHASE_1X             = 0x1,    // MPG �Է� ��� TwoPhase1
    MPG_DIFF_TWO_PHASE_2X             = 0x2,    // MPG �Է� ��� TwoPhase2
    MPG_DIFF_TWO_PHASE_4X             = 0x3,    // MPG �Է� ��� TwoPhase4
    MPG_LEVEL_ONE_PHASE               = 0x4,    // MPG �Է� ��� Level One Phase
    MPG_LEVEL_TWO_PHASE_1X            = 0x5,    // MPG �Է� ��� Level Two Phase1
    MPG_LEVEL_TWO_PHASE_2X            = 0x6,    // MPG �Է� ��� Level Two Phase2
    MPG_LEVEL_TWO_PHASE_4X            = 0x7,    // MPG �Է� ��� Level Two Phase4
}

public enum AXT_MOTION_HOME_CRC_SELECT:uint
{
    CRC_SELECT1                       = 0x0,    // ��ġŬ���� ������, �ܿ��޽� Ŭ���� ��� ����
    CRC_SELECT2                       = 0x1,    // ��ġŬ���� �����, �ܿ��޽� Ŭ���� ��� ����
    CRC_SELECT3                       = 0x2,    // ��ġŬ���� ������, �ܿ��޽� Ŭ���� �����
    CRC_SELECT4                       = 0x3     // ��ġŬ���� �����, �ܿ��޽� Ŭ���� �����
}

public enum AXT_MOTION_QIDETECT_DESTINATION_SIGNAL:uint
{
    Signal_PosEndLimit                = 0x0,    // +Elm(End limit) +���� ����Ʈ ���� ��ȣ
    Signal_NegEndLimit                = 0x1,    // -Elm(End limit) -���� ����Ʈ ���� ��ȣ
    Signal_PosSloLimit                = 0x2,    // +Slm(Slow Down limit) ��ȣ - ������� ����
    Signal_NegSloLimit                = 0x3,    // -Slm(Slow Down limit) ��ȣ - ������� ����
    Signal_HomeSensor                 = 0x4,    // IN0(ORG)  ���� ���� ��ȣ
    Signal_EncodZPhase                = 0x5,    // IN1(Z��)  Encoder Z�� ��ȣ
    Signal_UniInput02                 = 0x6,    // IN2(����) ���� �Է� 2�� ��ȣ
    Signal_UniInput03                 = 0x7     // IN3(����) ���� �Է� 3�� ��ȣ
}

public enum AXT_MOTION_QIMECHANICAL_SIGNAL:uint
{
    QIMECHANICAL_PELM_LEVEL           = 0x00001,       // Bit 0, +Limit ������ ��ȣ ���� ����
    QIMECHANICAL_NELM_LEVEL           = 0x00002,       // Bit 1, -Limit ������ ��ȣ ���� ����
    QIMECHANICAL_PSLM_LEVEL           = 0x00004,       // Bit 2, +limit �������� ���� ����.
    QIMECHANICAL_NSLM_LEVEL           = 0x00008,       // Bit 3, -limit �������� ���� ����
    QIMECHANICAL_ALARM_LEVEL          = 0x00010,       // Bit 4, Alarm ��ȣ ���� ����
    QIMECHANICAL_INP_LEVEL            = 0x00020,       // Bit 5, Inposition ��ȣ ���� ����
    QIMECHANICAL_ESTOP_LEVEL          = 0x00040,       // Bit 6, ��� ���� ��ȣ(ESTOP) ���� ����.
    QIMECHANICAL_ORG_LEVEL            = 0x00080,       // Bit 7, ���� ��ȣ ���� ����
    QIMECHANICAL_ZPHASE_LEVEL         = 0x00100,       // Bit 8, Z �� �Է� ��ȣ ���� ����
    QIMECHANICAL_ECUP_LEVEL           = 0x00200,       // Bit 9, ECUP �͹̳� ��ȣ ����.
    QIMECHANICAL_ECDN_LEVEL           = 0x00400,       // Bit 10, ECDN �͹̳� ��ȣ ����.
    QIMECHANICAL_EXPP_LEVEL           = 0x00800,       // Bit 11, EXPP �͹̳� ��ȣ ����
    QIMECHANICAL_EXMP_LEVEL           = 0x01000,       // Bit 12, EXMP �͹̳� ��ȣ ����
    QIMECHANICAL_SQSTR1_LEVEL         = 0x02000,       // Bit 13, SQSTR1 �͹̳� ��ȣ ����
    QIMECHANICAL_SQSTR2_LEVEL         = 0x04000,       // Bit 14, SQSTR2 �͹̳� ��ȣ ����
    QIMECHANICAL_SQSTP1_LEVEL         = 0x08000,       // Bit 15, SQSTP1 �͹̳� ��ȣ ����
    QIMECHANICAL_SQSTP2_LEVEL         = 0x10000,       // Bit 16, SQSTP2 �͹̳� ��ȣ ����
    QIMECHANICAL_MODE_LEVEL           = 0x20000        // Bit 17, MODE �͹̳� ��ȣ ����.
}

public enum AXT_MOTION_QIEND_STATUS:uint
{
    QIEND_STATUS_0                    = 0x00000001,    // Bit 0, ������ ����Ʈ ��ȣ(PELM)�� ���� ����
    QIEND_STATUS_1                    = 0x00000002,    // Bit 1, ������ ����Ʈ ��ȣ(NELM)�� ���� ����
    QIEND_STATUS_2                    = 0x00000004,    // Bit 2, ������ �ΰ� ����Ʈ ��ȣ(PSLM)�� ���� ���� ����
    QIEND_STATUS_3                    = 0x00000008,    // Bit 3, ������ �ΰ� ����Ʈ ��ȣ(NSLM)�� ���� ���� ����
    QIEND_STATUS_4                    = 0x00000010,    // Bit 4, ������ ����Ʈ ����Ʈ ������ ��ɿ� ���� ���� ����
    QIEND_STATUS_5                    = 0x00000020,    // Bit 5, ������ ����Ʈ ����Ʈ ������ ��ɿ� ���� ���� ����
    QIEND_STATUS_6                    = 0x00000040,    // Bit 6, ������ ����Ʈ ����Ʈ �������� ��ɿ� ���� ���� ����
    QIEND_STATUS_7                    = 0x00000080,    // Bit 7, ������ ����Ʈ ����Ʈ �������� ��ɿ� ���� ���� ����
    QIEND_STATUS_8                    = 0x00000100,    // Bit 8, ���� �˶� ��ɿ� ���� ���� ����.
    QIEND_STATUS_9                    = 0x00000200,    // Bit 9, ��� ���� ��ȣ �Է¿� ���� ���� ����.
    QIEND_STATUS_10                   = 0x00000400,    // Bit 10, �� ���� ��ɿ� ���� ���� ����.
    QIEND_STATUS_11                   = 0x00000800,    // Bit 11, ���� ���� ��ɿ� ���� ���� ����.
    QIEND_STATUS_12                   = 0x00001000,    // Bit 12, ���� ������ ��ɿ� ���� ���� ����
    QIEND_STATUS_13                   = 0x00002000,    // Bit 13, ���� ���� ��� #1(SQSTP1)�� ���� ���� ����.
    QIEND_STATUS_14                   = 0x00004000,    // Bit 14, ���� ���� ��� #2(SQSTP2)�� ���� ���� ����.
    QIEND_STATUS_15                   = 0x00008000,    // Bit 15, ���ڴ� �Է�(ECUP,ECDN) ���� �߻�
    QIEND_STATUS_16                   = 0x00010000,    // Bit 16, MPG �Է�(EXPP,EXMP) ���� �߻�
    QIEND_STATUS_17                   = 0x00020000,    // Bit 17, ���� �˻� ���� ����.
    QIEND_STATUS_18                   = 0x00040000,    // Bit 18, ��ȣ �˻� ���� ����.
    QIEND_STATUS_19                   = 0x00080000,    // Bit 19, ���� ������ �̻����� ���� ����.
    QIEND_STATUS_20                   = 0x00100000,    // Bit 20, ������ ���� �����߻�.
    QIEND_STATUS_21                   = 0x00200000,    // Bit 21, MPG ��� ��� �޽� ���� �����÷ο� �߻�
    QIEND_STATUS_22                   = 0x00400000,    // Bit 22, DON'CARE
    QIEND_STATUS_23                   = 0x00800000,    // Bit 23, DON'CARE
    QIEND_STATUS_24                   = 0x01000000,    // Bit 24, DON'CARE
    QIEND_STATUS_25                   = 0x02000000,    // Bit 25, DON'CARE
    QIEND_STATUS_26                   = 0x04000000,    // Bit 26, DON'CARE
    QIEND_STATUS_27                   = 0x08000000,    // Bit 27, DON'CARE
    QIEND_STATUS_28                   = 0x10000000,    // Bit 28, ����/������ ���� ����̺� ����
    QIEND_STATUS_29                   = 0x20000000,    // Bit 29, �ܿ� �޽� ���� ��ȣ ��� ��.
    QIEND_STATUS_30                   = 0x40000000,    // Bit 30, ������ ���� ���� ���� ����
    QIEND_STATUS_31                   = 0x80000000     // Bit 31, ���� ����̺� ����Ÿ ���� ����.
}

public enum AXT_MOTION_QIDRIVE_STATUS:uint
{
    QIDRIVE_STATUS_0                  = 0x0000001,     // Bit 0, BUSY(����̺� ���� ��)
    QIDRIVE_STATUS_1                  = 0x0000002,     // Bit 1, DOWN(���� ��)
    QIDRIVE_STATUS_2                  = 0x0000004,     // Bit 2, CONST(��� ��)
    QIDRIVE_STATUS_3                  = 0x0000008,     // Bit 3, UP(���� ��)
    QIDRIVE_STATUS_4                  = 0x0000010,     // Bit 4, ���� ����̺� ���� ��
    QIDRIVE_STATUS_5                  = 0x0000020,     // Bit 5, ���� �Ÿ� ����̺� ���� ��
    QIDRIVE_STATUS_6                  = 0x0000040,     // Bit 6, MPG ����̺� ���� ��
    QIDRIVE_STATUS_7                  = 0x0000080,     // Bit 7, �����˻� ����̺� ������
//���ǻ��� : (���� ���̺귯�� ���� ������ HOME�Լ��� ������� ���۵ȴ�.)
    QIDRIVE_STATUS_8                  = 0x0000100,     // Bit 8, ��ȣ �˻� ����̺� ���� ��
//���ǻ��� : (���� ���̺귯�� ���� ������ HOME�Լ��� ���� ���۵ȴ�. Ȩ�Լ��� ��ȣ��ġ�Լ��� ����������Ͽ� ������ �Ǿ����� Ȩ �˻��� BIT: 1 �ȴ�.)
    QIDRIVE_STATUS_9                  = 0x0000200,     // Bit 9, ���� ����̺� ���� ��
    QIDRIVE_STATUS_10                 = 0x0000400,     // Bit 10, Slave ����̺� ������
    QIDRIVE_STATUS_11                 = 0x0000800,     // Bit 11, ���� ���� ����̺� ����(���� ����̺꿡���� ǥ�� ���� �ٸ�)
    QIDRIVE_STATUS_12                 = 0x0001000,     // Bit 12, �޽� ����� ������ġ �Ϸ� ��ȣ �����.
    QIDRIVE_STATUS_13                 = 0x0002000,     // Bit 13, ���� ���� ����̺� ������.
    QIDRIVE_STATUS_14                 = 0x0004000,     // Bit 14, ��ȣ ���� ����̺� ������.
    QIDRIVE_STATUS_15                 = 0x0008000,     // Bit 15, �޽� ��� ��.
    QIDRIVE_STATUS_16                 = 0x0010000,     // Bit 16, ���� ���� ������ ����(ó��)(0-7)
    QIDRIVE_STATUS_17                 = 0x0020000,     // Bit 17, ���� ���� ������ ����(�߰�)(0-7)
    QIDRIVE_STATUS_18                 = 0x0040000,     // Bit 18, ���� ���� ������ ����(��)(0-7)
    QIDRIVE_STATUS_19                 = 0x0100000,     // Bit 19, ���� ���� Queue ��� ����.
    QIDRIVE_STATUS_20                 = 0x0200000,     // Bit 20, ���� ���� Queue ���� �H
    QIDRIVE_STATUS_21                 = 0x0400000,     // Bit 21, ���� ���� ����̺��� �ӵ� ���(ó��)
    QIDRIVE_STATUS_22                 = 0x0800000,     // Bit 22, ���� ���� ����̺��� �ӵ� ���(��)
    QIDRIVE_STATUS_23                 = 0x1000000,     // Bit 23, MPG ���� #1 Full
    QIDRIVE_STATUS_24                 = 0x2000000,     // Bit 24, MPG ���� #2 Full
    QIDRIVE_STATUS_25                 = 0x4000000,     // Bit 25, MPG ���� #3 Full
    QIDRIVE_STATUS_26                 = 0x8000000      // Bit 26, MPG ���� ������ OverFlow
}

public enum AXT_MOTION_QIINTERRUPT_BANK1:uint
{
    QIINTBANK1_DISABLE                = 0x00000000,    // INTERRUT DISABLED.
    QIINTBANK1_0                      = 0x00000001,    // Bit 0,  ���ͷ�Ʈ �߻� ��� ������ ���� �����.
    QIINTBANK1_1                      = 0x00000002,    // Bit 1,  ���� �����
    QIINTBANK1_2                      = 0x00000004,    // Bit 2,  ���� ���۽�.
    QIINTBANK1_3                      = 0x00000008,    // Bit 3,  ī���� #1 < �񱳱� #1 �̺�Ʈ �߻�
    QIINTBANK1_4                      = 0x00000010,    // Bit 4,  ī���� #1 = �񱳱� #1 �̺�Ʈ �߻�
    QIINTBANK1_5                      = 0x00000020,    // Bit 5,  ī���� #1 > �񱳱� #1 �̺�Ʈ �߻�
    QIINTBANK1_6                      = 0x00000040,    // Bit 6,  ī���� #2 < �񱳱� #2 �̺�Ʈ �߻�
    QIINTBANK1_7                      = 0x00000080,    // Bit 7,  ī���� #2 = �񱳱� #2 �̺�Ʈ �߻�
    QIINTBANK1_8                      = 0x00000100,    // Bit 8,  ī���� #2 > �񱳱� #2 �̺�Ʈ �߻�
    QIINTBANK1_9                      = 0x00000200,    // Bit 9,  ī���� #3 < �񱳱� #3 �̺�Ʈ �߻�
    QIINTBANK1_10                     = 0x00000400,    // Bit 10, ī���� #3 = �񱳱� #3 �̺�Ʈ �߻�
    QIINTBANK1_11                     = 0x00000800,    // Bit 11, ī���� #3 > �񱳱� #3 �̺�Ʈ �߻�
    QIINTBANK1_12                     = 0x00001000,    // Bit 12, ī���� #4 < �񱳱� #4 �̺�Ʈ �߻�
    QIINTBANK1_13                     = 0x00002000,    // Bit 13, ī���� #4 = �񱳱� #4 �̺�Ʈ �߻�
    QIINTBANK1_14                     = 0x00004000,    // Bit 14, ī���� #4 < �񱳱� #4 �̺�Ʈ �߻�
    QIINTBANK1_15                     = 0x00008000,    // Bit 15, ī���� #5 < �񱳱� #5 �̺�Ʈ �߻�
    QIINTBANK1_16                     = 0x00010000,    // Bit 16, ī���� #5 = �񱳱� #5 �̺�Ʈ �߻�
    QIINTBANK1_17                     = 0x00020000,    // Bit 17, ī���� #5 > �񱳱� #5 �̺�Ʈ �߻�
    QIINTBANK1_18                     = 0x00040000,    // Bit 18, Ÿ�̸� #1 �̺�Ʈ �߻�.
    QIINTBANK1_19                     = 0x00080000,    // Bit 19, Ÿ�̸� #2 �̺�Ʈ �߻�.
    QIINTBANK1_20                     = 0x00100000,    // Bit 20, ���� ���� ���� Queue �����.
    QIINTBANK1_21                     = 0x00200000,    // Bit 21, ���� ���� ���� Queue ����H
    QIINTBANK1_22                     = 0x00400000,    // Bit 22, Ʈ���� �߻��Ÿ� �ֱ�/������ġ Queue �����.
    QIINTBANK1_23                     = 0x00800000,    // Bit 23, Ʈ���� �߻��Ÿ� �ֱ�/������ġ Queue ����H
    QIINTBANK1_24                     = 0x01000000,    // Bit 24, Ʈ���� ��ȣ �߻� �̺�Ʈ
    QIINTBANK1_25                     = 0x02000000,    // Bit 25, ��ũ��Ʈ #1 ��ɾ� ���� ���� Queue �����.
    QIINTBANK1_26                     = 0x04000000,    // Bit 26, ��ũ��Ʈ #2 ��ɾ� ���� ���� Queue �����.
    QIINTBANK1_27                     = 0x08000000,    // Bit 27, ��ũ��Ʈ #3 ��ɾ� ���� ���� �������� ����Ǿ� �ʱ�ȭ ��.
    QIINTBANK1_28                     = 0x10000000,    // Bit 28, ��ũ��Ʈ #4 ��ɾ� ���� ���� �������� ����Ǿ� �ʱ�ȭ ��.
    QIINTBANK1_29                     = 0x20000000,    // Bit 29, ���� �˶���ȣ �ΰ���.
    QIINTBANK1_30                     = 0x40000000,    // Bit 30, |CNT1| - |CNT2| >= |CNT4| �̺�Ʈ �߻�.
    QIINTBANK1_31                     = 0x80000000     // Bit 31, ���ͷ�Ʈ �߻� ��ɾ�|INTGEN| ����.
}

public enum AXT_MOTION_QIINTERRUPT_BANK2:uint
{
    QIINTBANK2_DISABLE                = 0x00000000,    // INTERRUT DISABLED.
    QIINTBANK2_0                      = 0x00000001,    // Bit 0,  ��ũ��Ʈ #1 �б� ��� ��� Queue �� ����H.
    QIINTBANK2_1                      = 0x00000002,    // Bit 1,  ��ũ��Ʈ #2 �б� ��� ��� Queue �� ����H.
    QIINTBANK2_2                      = 0x00000004,    // Bit 2,  ��ũ��Ʈ #3 �б� ��� ��� �������Ͱ� ���ο� �����ͷ� ���ŵ�.
    QIINTBANK2_3                      = 0x00000008,    // Bit 3,  ��ũ��Ʈ #4 �б� ��� ��� �������Ͱ� ���ο� �����ͷ� ���ŵ�.
    QIINTBANK2_4                      = 0x00000010,    // Bit 4,  ��ũ��Ʈ #1 �� ���� ��ɾ� �� ���� �� ���ͷ�Ʈ �߻����� ������ ��ɾ� �����.
    QIINTBANK2_5                      = 0x00000020,    // Bit 5,  ��ũ��Ʈ #2 �� ���� ��ɾ� �� ���� �� ���ͷ�Ʈ �߻����� ������ ��ɾ� �����.
    QIINTBANK2_6                      = 0x00000040,    // Bit 6,  ��ũ��Ʈ #3 �� ���� ��ɾ� ���� �� ���ͷ�Ʈ �߻����� ������ ��ɾ� �����.
    QIINTBANK2_7                      = 0x00000080,    // Bit 7,  ��ũ��Ʈ #4 �� ���� ��ɾ� ���� �� ���ͷ�Ʈ �߻����� ������ ��ɾ� �����.
    QIINTBANK2_8                      = 0x00000100,    // Bit 8,  ���� ����
    QIINTBANK2_9                      = 0x00000200,    // Bit 9,  ���� ��ġ ���� �Ϸ�(Inposition)����� ����� ����,���� ���� �߻�.
    QIINTBANK2_10                     = 0x00000400,    // Bit 10, �̺�Ʈ ī���ͷ� ���� �� ����� �̺�Ʈ ���� #1 ���� �߻�.
    QIINTBANK2_11                     = 0x00000800,    // Bit 11, �̺�Ʈ ī���ͷ� ���� �� ����� �̺�Ʈ ���� #2 ���� �߻�.
    QIINTBANK2_12                     = 0x00001000,    // Bit 12, SQSTR1 ��ȣ �ΰ� ��.
    QIINTBANK2_13                     = 0x00002000,    // Bit 13, SQSTR2 ��ȣ �ΰ� ��.
    QIINTBANK2_14                     = 0x00004000,    // Bit 14, UIO0 �͹̳� ��ȣ�� '1'�� ����.
    QIINTBANK2_15                     = 0x00008000,    // Bit 15, UIO1 �͹̳� ��ȣ�� '1'�� ����.
    QIINTBANK2_16                     = 0x00010000,    // Bit 16, UIO2 �͹̳� ��ȣ�� '1'�� ����.
    QIINTBANK2_17                     = 0x00020000,    // Bit 17, UIO3 �͹̳� ��ȣ�� '1'�� ����.
    QIINTBANK2_18                     = 0x00040000,    // Bit 18, UIO4 �͹̳� ��ȣ�� '1'�� ����.
    QIINTBANK2_19                     = 0x00080000,    // Bit 19, UIO5 �͹̳� ��ȣ�� '1'�� ����.
    QIINTBANK2_20                     = 0x00100000,    // Bit 20, UIO6 �͹̳� ��ȣ�� '1'�� ����.
    QIINTBANK2_21                     = 0x00200000,    // Bit 21, UIO7 �͹̳� ��ȣ�� '1'�� ����.
    QIINTBANK2_22                     = 0x00400000,    // Bit 22, UIO8 �͹̳� ��ȣ�� '1'�� ����.
    QIINTBANK2_23                     = 0x00800000,    // Bit 23, UIO9 �͹̳� ��ȣ�� '1'�� ����.
    QIINTBANK2_24                     = 0x01000000,    // Bit 24, UIO10 �͹̳� ��ȣ�� '1'�� ����.
    QIINTBANK2_25                     = 0x02000000,    // Bit 25, UIO11 �͹̳� ��ȣ�� '1'�� ����.
    QIINTBANK2_26                     = 0x04000000,    // Bit 26, ���� ���� ����(LMT, ESTOP, STOP, ESTOP, CMD, ALARM) �߻�.
    QIINTBANK2_27                     = 0x08000000,    // Bit 27, ���� �� ������ ���� ���� �߻�.
    QIINTBANK2_28                     = 0x10000000,    // Bit 28, Don't Care
    QIINTBANK2_29                     = 0x20000000,    // Bit 29, ����Ʈ ��ȣ(PELM, NELM)��ȣ�� �Է� ��.
    QIINTBANK2_30                     = 0x40000000,    // Bit 30, �ΰ� ����Ʈ ��ȣ(PSLM, NSLM)��ȣ�� �Է� ��.
    QIINTBANK2_31                     = 0x80000000     // Bit 31, ��� ���� ��ȣ(ESTOP)��ȣ�� �Էµ�.
}

public class CAXHS
{
    public delegate void AXT_EVENT_PROC(int nActiveNo, uint uFlag);
    public delegate void AXT_INTERRUPT_PROC(int nActiveNo, uint uFlag);
    public delegate void AXT_NETMON_PROC(int nActiveNo, uint uFlag);

    public readonly static int MAX_NODE_COUNT            = 250;
    public readonly static int MAX_AXIS_PER_NODE         = 20;

    public readonly static uint WM_USER                  = 0x0400;
    public readonly static uint WM_AXL_INTERRUPT         = (WM_USER + 1001);

    public static int  AXIS_EVN(int nAxisNo) 
    {
        nAxisNo = (nAxisNo - (nAxisNo % 2));        // ���� �̷�� ���� ¦������ ã��

        return nAxisNo;
    }

    public static int  AXIS_ODD(int nAxisNo) 
    {
        nAxisNo = (nAxisNo + ((nAxisNo + 1) % 2));   // ���� �̷�� ���� Ȧ������ ã��

        return nAxisNo;

    }

    public static int  AXIS_QUR(int nAxisNo) 
    {
        nAxisNo = (nAxisNo % 4);                     // ���� �̷�� ���� Ȧ������ ã��

        return nAxisNo;
    }

    public static int  AXIS_N04(int nAxisNo, int nPos) 
    {
        nAxisNo = (((nAxisNo / 4) * 4) + nPos);       // �� Ĩ�� �� ��ġ�� ����(0~3)

        return nAxisNo;
    }

    public static int  AXIS_N01(int nAxisNo) 
    {
        nAxisNo = ((nAxisNo % 4) >> 2);               // 0, 1���� 0���� 2, 3���� 1�� ����

        return nAxisNo;
    }

    public static int  AXIS_N02(int nAxisNo) 
    {
        nAxisNo = ((nAxisNo % 4)  % 2);               // 0, 2���� 0���� 1, 3���� 1�� ����

        return nAxisNo;
    }

    public static int    m_SendAxis            =0;    // ���� ���ȣ
}
