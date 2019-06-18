/****************************************************************************
*****************************************************************************
**
** File Name
** ---------
**
** AXD.CS
**
** COPYRIGHT (c) AJINEXTEK Co., LTD
**
*****************************************************************************
*****************************************************************************
**
** Description
** -----------
** Ajinextek Digital Library Header File
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

using System;
using System.Runtime.InteropServices;

public class CAXD
{
//========== ��� �� ��� ���� 
    // DIO ����� �ִ��� Ȯ��
    [DllImport("AXLNet.dll")] public static extern uint AxdInfoIsDIOModule(ref uint upStatus);
    // DIO ����� ����� ���� Ȯ��
    [DllImport("AXLNet.dll")] public static extern uint AxdInfoGetModuleCount(ref int lpModuleCount);
    // ������ ����� �Է� ���� ���� Ȯ��
    [DllImport("AXLNet.dll")] public static extern uint AxdInfoGetInputCount(int lModuleNo, ref int lpCount);
    // ������ ����� ��� ���� ���� Ȯ��
    [DllImport("AXLNet.dll")] public static extern uint AxdInfoGetOutputCount(int lModuleNo, ref int lpCount);
    // ������ ��� ��ȣ�� ��� ID ��ȣ, ��� ��ġ, ��� ID Ȯ��
    [DllImport("AXLNet.dll")] public static extern uint AxdInfoGetModule(int lModuleNo, ref int lpNodeNum, ref int lpModulePos, ref uint upModuleID);

//========== ����� ���� ���� Ȯ�� =================================================================================
//==�Է� ���� ���� Ȯ��
    // ������ �Է� ���� ����� Offset ��ġ���� bit ������ ������ ������ ����
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiLevelSetInportBit(int lModuleNo, int lOffset, uint uLevel);
    
    // ������ �Է� ���� ����� Offset ��ġ���� byte ������ ������ ������ ����
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // uLevel          : 0x00 ~ 0x0FF('1'�� ���� �� ��Ʈ�� HIGH, '0'���� ���� �� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiLevelSetInportByte(int lModuleNo, int lOffset, uint uLevel);
    
    // ������ �Է� ���� ����� Offset ��ġ���� word ������ ������ ������ ����
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // uLevel          : 0x00 ~ 0x0FFFF('1'�� ���� �� ��Ʈ�� HIGH, '0'���� ���� �� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiLevelSetInportWord(int lModuleNo, int lOffset, uint uLevel);
    
    // ������ �Է� ���� ����� Offset ��ġ���� double word ������ ������ ������ ����
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // uLevel          : 0x00 ~ 0x0FFFFFFFF('1'�� ���� �� ��Ʈ�� HIGH, '0'���� ���� �� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiLevelSetInportDword(int lModuleNo, int lOffset, uint uLevel);
    
    // ������ �Է� ���� ����� Offset ��ġ���� bit ������ ������ ������ Ȯ��
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // *upLevel        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiLevelGetInportBit(int lModuleNo, int lOffset, ref uint upLevel);
    
    // ������ �Է� ���� ����� Offset ��ġ���� byte ������ ������ ������ Ȯ��
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // *upLevel        : 0x00 ~ 0x0FF('1'�� ���� ��Ʈ�� HIGH, '0'���� ���� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiLevelGetInportByte(int lModuleNo, int lOffset, ref uint upLevel);
    
    // ������ �Է� ���� ����� Offset ��ġ���� word ������ ������ ������ Ȯ��
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // *upLevel        : 0x00 ~ 0x0FFFF('1'�� ���� ��Ʈ�� HIGH, '0'���� ���� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiLevelGetInportWord(int lModuleNo, int lOffset, ref uint upLevel);
    
    // ��ü �Է� ���� ����� Offset ��ġ���� bit ������ ������ ������ ����
    //===============================================================================================//
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiLevelSetInport(int lOffset, uint uLevel);
    
    // ��ü �Է� ���� ����� Offset ��ġ���� bit ������ ������ ������ Ȯ��
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // *upLevel        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiLevelGetInport(int lOffset, ref uint upLevel);
    
//==��� ���� ���� Ȯ��
    // ������ ��� ���� ����� Offset ��ġ���� bit ������ ������ ������ ����
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : ��� ������ ���� Offset ��ġ
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoLevelSetOutportBit(int lModuleNo, int lOffset, uint uLevel);
    
    // ������ ��� ���� ����� Offset ��ġ���� byte ������ ������ ������ ����
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : ��� ������ ���� Offset ��ġ
    // uLevel          : 0x00 ~ 0x0FF('1'�� ���� �� ��Ʈ�� HIGH, '0'���� ���� �� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoLevelSetOutportByte(int lModuleNo, int lOffset, uint uLevel);
    
    // ������ ��� ���� ����� Offset ��ġ���� word ������ ������ ������ ����
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : ��� ������ ���� Offset ��ġ
    // uLevel          : 0x00 ~ 0x0FFFF('1'�� ���� �� ��Ʈ�� HIGH, '0'���� ���� �� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoLevelSetOutportWord(int lModuleNo, int lOffset, uint uLevel);
    
    // ������ ��� ���� ����� Offset ��ġ���� double word ������ ������ ������ ����
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : ��� ������ ���� Offset ��ġ
    // uLevel          : 0x00 ~ 0x0FFFFFFFF('1'�� ���� �� ��Ʈ�� HIGH, '0'���� ���� �� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoLevelSetOutportDword(int lModuleNo, int lOffset, uint uLevel);
    
    // ������ ��� ���� ����� Offset ��ġ���� bit ������ ������ ������ Ȯ��
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : ��� ������ ���� Offset ��ġ
    // *upLevel        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoLevelGetOutportBit(int lModuleNo, int lOffset, ref uint upLevel);
    
    // ������ ��� ���� ����� Offset ��ġ���� byte ������ ������ ������ Ȯ��
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : ��� ������ ���� Offset ��ġ
    // uLevel          : 0x00 ~ 0x0FF('1'�� ���� ��Ʈ�� HIGH, '0'���� ���� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoLevelGetOutportByte(int lModuleNo, int lOffset, ref uint upLevel);
    
    // ������ ��� ���� ����� Offset ��ġ���� word ������ ������ ������ Ȯ��
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : ��� ������ ���� Offset ��ġ
    // uLevel          : 0x00 ~ 0x0FFFF('1'�� ���� ��Ʈ�� HIGH, '0'���� ���� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoLevelGetOutportWord(int lModuleNo, int lOffset, ref uint upLevel);
    
    // ��ü ��� ���� ����� Offset ��ġ���� bit ������ ������ ������ ����
    //===============================================================================================//
    // lOffset         : ��� ������ ���� Offset ��ġ
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoLevelSetOutport(int lOffset, uint uLevel);
    
    // ��ü ��� ���� ����� Offset ��ġ���� bit ������ ������ ������ Ȯ��
    //===============================================================================================//
    // lOffset         : ��� ������ ���� Offset ��ġ
    // *upLevel        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoLevelGetOutport(int lOffset, ref uint upLevel);
    
//========== ����� ��Ʈ ���� �б� =================================================================================
//==��� ��Ʈ ����
    // ��ü ��� ���� ����� Offset ��ġ���� bit ������ �����͸� ���
    //===============================================================================================//
    // lOffset         : ��� ������ ���� Offset ��ġ
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoWriteOutport(int lOffset, uint uValue);
    
    // ������ ��� ���� ����� Offset ��ġ���� bit ������ �����͸� ���
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : ��� ������ ���� Offset ��ġ
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoWriteOutportBit(int lModuleNo, int lOffset, uint uValue);
    
    // ������ ��� ���� ����� Offset ��ġ���� byte ������ �����͸� ���
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : ��� ������ ���� Offset ��ġ
    // uValue          : 0x00 ~ 0x0FF('1'�� ���� �� ��Ʈ�� HIGH, '0'���� ���� �� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoWriteOutportByte(int lModuleNo, int lOffset, uint uValue);
    
    // ������ ��� ���� ����� Offset ��ġ���� word ������ �����͸� ���
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : ��� ������ ���� Offset ��ġ
    // uValue          : 0x00 ~ 0x0FFFF('1'�� ���� �� ��Ʈ�� HIGH, '0'���� ���� �� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoWriteOutportWord(int lModuleNo, int lOffset, uint uValue);
    
//==��� ��Ʈ �б�    
    // ��ü ��� ���� ����� Offset ��ġ���� bit ������ �����͸� �б�
    //===============================================================================================//
    // lOffset         : ��� ������ ���� Offset ��ġ
    // *upLevel        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoReadOutport(int lOffset, ref uint upValue);
    
    // ������ ��� ���� ����� Offset ��ġ���� bit ������ �����͸� �б�
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : ��� ������ ���� Offset ��ġ
    // *upLevel        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoReadOutportBit(int lModuleNo, int lOffset, ref uint upValue);
    
    // ������ ��� ���� ����� Offset ��ġ���� byte ������ �����͸� �б�
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : ��� ������ ���� Offset ��ġ
    // *upValue        : 0x00 ~ 0x0FF('1'�� ���� ��Ʈ�� HIGH, '0'���� ���� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoReadOutportByte(int lModuleNo, int lOffset, ref uint upValue);
    
    // ������ ��� ���� ����� Offset ��ġ���� word ������ �����͸� �б�
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : ��� ������ ���� Offset ��ġ
    // *upValue        : 0x00 ~ 0x0FFFF('1'�� ���� ��Ʈ�� HIGH, '0'���� ���� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoReadOutportWord(int lModuleNo, int lOffset, ref uint upValue);
    
//==�Է� ��Ʈ �ϱ�    
    // ��ü �Է� ���� ����� Offset ��ġ���� bit ������ �����͸� �б�
    //===============================================================================================//
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // *upValue        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiReadInport(int lOffset, ref uint upValue);
    
    // ������ �Է� ���� ����� Offset ��ġ���� bit ������ �����͸� �б�
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // *upValue        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiReadInportBit(int lModuleNo, int lOffset, ref uint upValue);
    
    // ������ �Է� ���� ����� Offset ��ġ���� byte ������ �����͸� �б�
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // *upValue        : 0x00 ~ 0x0FF('1'�� ���� ��Ʈ�� HIGH, '0'���� ���� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiReadInportByte(int lModuleNo, int lOffset, ref uint upValue);
    
    // ������ �Է� ���� ����� Offset ��ġ���� word ������ �����͸� �б�
    //===============================================================================================//
    // lModuleNo       : ��� ��ȣ
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // *upValue        : 0x00 ~ 0x0FFFF('1'�� ���� ��Ʈ�� HIGH, '0'���� ���� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiReadInportWord(int lModuleNo, int lOffset, ref uint upValue);
        
//========== ����� ���� ���� Ȯ�� (���� ��忡 ���� ����)
//==�Է� ���� ���� ��
    // ������ �Է� ���� ����� Offset ��ġ���� bit ������ ������ ������ ����
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lModulePos      : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNLevelSetInportBit(int lNodeNum, int lModulePos, int lOffset, uint uLevel);

    // ������ �Է� ���� ����� Offset ��ġ���� byte ������ ������ ������ ����
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lModulePos      : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // uValue          : 0x00 ~ 0x0FF('1'�� ���� �� ��Ʈ�� HIGH, '0'���� ���� �� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNLevelSetInportByte(int lNodeNum, int lModulePos, int lOffset, uint uLevel);

    // ������ �Է� ���� ����� Offset ��ġ���� word ������ ������ ������ ����
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lModulePos      : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // uLevel          : 0x00 ~ 0x0FFFF('1'�� ���� �� ��Ʈ�� HIGH, '0'���� ���� �� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNLevelSetInportWord(int lNodeNum, int lModulePos, int lOffset, uint uLevel);

    // ������ �Է� ���� ����� Offset ��ġ���� double word ������ ������ ������ ����
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lModulePos      : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // uLevel          : 0x00 ~ 0x0FFFFFFFF('1'�� ���� �� ��Ʈ�� HIGH, '0'���� ���� �� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNLevelSetInportDword(int lNodeNum, int lModulePos, int lOffset, uint uLevel);

    // ������ �Է� ���� ����� Offset ��ġ���� bit ������ ������ ������ Ȯ��
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lModulePos      : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // *upLevel        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNLevelGetInportBit(int lNodeNum, int lModulePos, int lOffset, ref uint upLevel);

    // ������ �Է� ���� ����� Offset ��ġ���� byte ������ ������ ������ Ȯ��
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lModulePos      : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // *upLevel        : 0x00 ~ 0x0FF('1'�� ���� ��Ʈ�� HIGH, '0'���� ���� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNLevelGetInportByte(int lNodeNum, int lModulePos, int lOffset, ref uint upLevel);

    // ������ �Է� ���� ����� Offset ��ġ���� word ������ ������ ������ Ȯ��
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lModulePos      : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // *upLevel        : 0x00 ~ 0x0FFFF('1'�� ���� ��Ʈ�� HIGH, '0'���� ���� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNLevelGetInportWord(int lNodeNum, int lModulePos, int lOffset, ref uint upLevel);

    // ��ü �Է� ���� ����� Offset ��ġ���� bit ������ ������ ������ ����
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNLevelSetInport(int lNodeNum, int lOffset, uint uLevel);

    // ��ü �Է� ���� ����� Offset ��ġ���� bit ������ ������ ������ Ȯ��
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // *uLevel         : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNLevelGetInport(int lNodeNum, int lOffset, ref uint upLevel);

//==�Է� ��Ʈ �б�
    // ��ü �Է� ���� ����� Offset ��ġ���� bit ������ �����͸� �б�
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // *upValue        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNReadInport(int lNodeNum, int lOffset, ref uint upValue);

    // ������ �Է� ���� ����� Offset ��ġ���� bit ������ �����͸� �б�
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lModulePos      : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // *upValue        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNReadInportBit(int lNodeNum, int lModulePos, int lOffset, ref uint upValue);

    // ������ �Է� ���� ����� Offset ��ġ���� byte ������ �����͸� �б�
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lModulePos      : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // *upValue        : 0x00 ~ 0x0FF('1'�� ���� ��Ʈ�� HIGH, '0'���� ���� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNReadInportByte(int lNodeNum, int lModulePos, int lOffset, ref uint upValue);

    // ������ �Է� ���� ����� Offset ��ġ���� word ������ �����͸� �б�
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lModulePos      : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset         : �Է� ������ ���� Offset ��ġ
    // *upValue        : 0x00 ~ 0x0FFFF('1'�� ���� ��Ʈ�� HIGH, '0'���� ���� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNReadInportWord(int lNodeNum, int lModulePos, int lOffset, ref uint upValue);

//==��� ���� ���� Ȯ��
    // ������ ��� ���� ����� Offset ��ġ���� bit ������ ������ ������ ����
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lModulePos      : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset         : ��� ������ ���� Offset ��ġ
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNLevelSetOutportBit(int lNodeNum, int lModulePos, int lOffset, uint uLevel);

    // ������ ��� ���� ����� Offset ��ġ���� byte ������ ������ ������ ����
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lModulePos      : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset         : ��� ������ ���� Offset ��ġ
    // uLevel          : 0x00 ~ 0x0FF('1'�� ���� �� ��Ʈ�� HIGH, '0'���� ���� �� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNLevelSetOutportByte(int lNodeNum, int lModulePos, int lOffset, uint uLevel);

    // ������ ��� ���� ����� Offset ��ġ���� word ������ ������ ������ ����
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lModulePos      : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset         : ��� ������ ���� Offset ��ġ
    // uLevel          : 0x00 ~ 0x0FFFF('1'�� ���� �� ��Ʈ�� HIGH, '0'���� ���� �� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNLevelSetOutportWord(int lNodeNum, int lModulePos, int lOffset, uint uLevel);

    // ������ ��� ���� ����� Offset ��ġ���� double word ������ ������ ������ ����
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lModulePos      : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset         : ��� ������ ���� Offset ��ġ
    // uLevel          : 0x00 ~ 0x0FFFFFFFF('1'�� ���� �� ��Ʈ�� HIGH, '0'���� ���� �� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNLevelSetOutportDword(int lNodeNum, int lModulePos, int lOffset, uint uLevel);

    // ������ ��� ���� ����� Offset ��ġ���� bit ������ ������ ������ Ȯ��
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lModulePos      : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset         : ��� ������ ���� Offset ��ġ
    // *upLevel        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNLevelGetOutportBit(int lNodeNum, int lModulePos, int lOffset, ref uint upLevel);

    // ������ ��� ���� ����� Offset ��ġ���� byte ������ ������ ������ Ȯ��
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lModulePos      : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset         : ��� ������ ���� Offset ��ġ
    // *upLevel        : 0x00 ~ 0x0FF('1'�� ���� ��Ʈ�� HIGH, '0'���� ���� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNLevelGetOutportByte(int lNodeNum, int lModulePos, int lOffset, ref uint upLevel);

    // ������ ��� ���� ����� Offset ��ġ���� word ������ ������ ������ Ȯ��
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lModulePos      : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset         : ��� ������ ���� Offset ��ġ
    // *upLevel        : 0x00 ~ 0x0FFFF('1'�� ���� ��Ʈ�� HIGH, '0'���� ���� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNLevelGetOutportWord(int lNodeNum, int lModulePos, int lOffset, ref uint upLevel);

    // ��ü ��� ���� ����� Offset ��ġ���� bit ������ ������ ������ ����
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lOffset         : ��� ������ ���� Offset ��ġ
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNLevelSetOutport(int lNodeNum, int lOffset, uint uLevel);

    // ��ü ��� ���� ����� Offset ��ġ���� bit ������ ������ ������ Ȯ��
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lOffset         : ��� ������ ���� Offset ��ġ
    // *upLevel        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNLevelGetOutport(int lNodeNum, int lOffset, ref uint upLevel);

//========== ����� ��Ʈ ���� �б� 
//==��� ��Ʈ ����
    // ��ü ��� ���� ����� Offset ��ġ���� bit ������ �����͸� ���
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lOffset         : ��� ������ ���� Offset ��ġ
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNWriteOutport(int lNodeNum, int lOffset, uint uValue);

    // ������ ��� ���� ����� Offset ��ġ���� bit ������ �����͸� ���
    //===============================================================================================//
    // lNodeNum        : ��� ��ȣ
    // lModulePos      : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset         : ��� ������ ���� Offset ��ġ
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNWriteOutportBit(int lNodeNum, int lModulePos, int lOffset, uint uValue);

    // ������ ��� ���� ����� Offset ��ġ���� byte ������ �����͸� ���
    //===============================================================================================//
    // lNodeNum         : ��� ��ȣ
    // lModulePos       : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset          : ��� ������ ���� Offset ��ġ
    // uValue           : 0x00 ~ 0x0FF('1'�� ���� �� ��Ʈ�� HIGH, '0'���� ���� �� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNWriteOutportByte(int lNodeNum, int lModulePos, int lOffset, uint uValue);

    // ������ ��� ���� ����� Offset ��ġ���� word ������ �����͸� ���
    //===============================================================================================//
    // lNodeNum         : ��� ��ȣ
    // lModulePos       : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset          : ��� ������ ���� Offset ��ġ
    // uValue           : 0x00 ~ 0x0FFFF('1'�� ���� �� ��Ʈ�� HIGH, '0'���� ���� �� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNWriteOutportWord(int lNodeNum, int lModulePos, int lOffset, uint uValue);

    // ������ ��� ���� ����� Offset ��ġ���� double word ������ �����͸� ���
    //===============================================================================================//
    // lNodeNum         : ��� ��ȣ
    // lModulePos       : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset          : ��� ������ ���� Offset ��ġ
    // uValue           : 0x00 ~ 0x0FFFFFFFF('1'�� ���� �� ��Ʈ�� HIGH, '0'���� ���� �� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNWriteOutportDword(int lNodeNum, int lModulePos, int lOffset, uint uValue);

//==��� ��Ʈ �б�
    // ��ü ��� ���� ����� Offset ��ġ���� bit ������ �����͸� �б�
    //===============================================================================================//
    // lNodeNum         : ��� ��ȣ
    // lOffset          : �Է� ������ ���� Offset ��ġ
    // *upValue         : LOW(0)
    //                  : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNReadOutport(int lNodeNum, int lOffset, ref uint upValue);

    // ������ ��� ���� ����� Offset ��ġ���� bit ������ �����͸� �б�
    //===============================================================================================//
    // lNodeNum         : ��� ��ȣ
    // lModulePos       : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset          : �Է� ������ ���� Offset ��ġ
    // *upValue         : LOW(0)
    //                  : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNReadOutportBit(int lNodeNum, int lModulePos, int lOffset, ref uint upValue);

    // ������ ��� ���� ����� Offset ��ġ���� byte ������ �����͸� �б�
    //===============================================================================================//
    // lNodeNum         : ��� ��ȣ
    // lModulePos       : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset          : �Է� ������ ���� Offset ��ġ
    // *upValue         : 0x00 ~ 0x0FF('1'�� ���� ��Ʈ�� HIGH, '0'���� ���� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNReadOutportByte(int lNodeNum, int lModulePos, int lOffset, ref uint upValue);

    // ������ ��� ���� ����� Offset ��ġ���� word ������ �����͸� �б�
    //===============================================================================================//
    // lNodeNum         : ��� ��ȣ
    // lModulePos       : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset          : �Է� ������ ���� Offset ��ġ
    // *upValue         : 0x00 ~ 0x0FFFF('1'�� ���� ��Ʈ�� HIGH, '0'���� ���� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNReadOutportWord(int lNodeNum, int lModulePos, int lOffset, ref uint upValue);

    // ������ ��� ���� ����� Offset ��ġ���� double word ������ �����͸� �б�
    //===============================================================================================//
    // lNodeNum         : ��� ��ȣ
    // lModulePos       : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset          : �Է� ������ ���� Offset ��ġ
    // *upValue         : 0x00 ~ 0x0FFFFFFFF('1'�� ���� ��Ʈ�� HIGH, '0'���� ���� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNReadOutportDword(int lNodeNum, int lModulePos, int lOffset, ref uint upValue);
    
    // ������ ��� ���� ����� ����� ����� ����� ���� ������ ���� ��� ���� ���¿� ���� ����ó�� ��� ����.
    //===============================================================================================//
    // lModuleNo      : ��� ��ȣ
    // dwNetErrorAct  : ������ ����(0 - 1)
    //                  '0' - ���� ���� ���� ����
    //                  '1' - AxdoSetNetWorkErrorByteValue �Լ��� ���Ͽ� Setting�� ������ ����
    //===============================================================================================//
     [DllImport("AXLNet.dll")] public static extern uint AxdoNetWorkErrorSetAction(int lModuleNo, uint dwNetErrorAct);

    // ������ ��� ���� ����� ����� ����� ����� ���� ������ ���� ��� ���� ���¿� ���� ����ó�� ��� Ȯ��.
    //===============================================================================================//
    // lModuleNo      : ��� ��ȣ
    // *dwNetErrorAct : ������ ����(0 - 1)
    //                  '0' - ���� ���� ���� ����
    //                  '1' - AxdoSetNetWorkErrorByteValue �Լ��� ���Ͽ� Setting�� ������ �����ϵ��� ����
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNetWorkErrorGetAction(int lModuleNo, ref uint dwpNetErrorAct);
 
    // ������ ��� ���� ����� ����� ����� ����� ���� ������ ���� ��� ���� ���¿� ���� ����ó�� ����.
    //===============================================================================================//
    // lModuleNo      : ��� ��ȣ
    // lOffset        : ��� ������ ���� Offset ��ġ
    // uValue         : 0x00 ~ 0xFF('1'��Ʈ�� ������ ��� High, '0'��Ʈ�� ������ ��� Low) 
    //===============================================================================================//
	[DllImport("AXLNet.dll")] public static extern uint AxdoNetWorkErrorSetByteValue(int lModuleNo, int lOffset, uint uValue);

	// ������ ��� ���� ����� ����� ����� ����� ���� ������ ���� ��� ���� ���¿� ���� ����ó�� ���� Ȯ��.
    //===============================================================================================//
    // lModuleNo      : ��� ��ȣ
    // lOffset        : ��� ������ ���� Offset ��ġ
    // *upValue       : 0x00 ~ 0xFF('1'��Ʈ�� ������ ��� High, '0'��Ʈ�� ������ ��� Low) 
    //===============================================================================================//
	[DllImport("AXLNet.dll")] public static extern uint AxdoNetWorkErrorGetByteValue(int lModuleNo, int lOffset, ref uint upValue);
//==TCP, UDP Protocol ����
    // Digital Output ���� TCP/IP�� ��� �� ������ UDP/IP�� ��� �� ������ ����.
    //===============================================================================================//
    // lModuleNo      : ��� ��ȣ
    // dwSelNet       : ��� ��� ����(0 - 1)
    //                  '0' - UDP/IP
    //                  '1' - TCP/IP
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNetWorkSetSelNet(int lNodeNum, uint dwSelNet);
    // Digital Output ���� TCP/IP�� ��� �� ������ UDP�� ��� �� ������ ���� Ȯ��.
    //===============================================================================================//
    // lModuleNo      : ��� ��ȣ
    // *upSelNet       : 0 ~ 1 ('0' UDP/IP, '1' TCP/IP)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNetWorkGetSelNet(int lNodeNum, ref uint upSelNet);
    // ������ ��� ���� ����� Offset ��ġ���� Byte ������ ���� ���� ����ڰ� ���ϴ� ���� AND ���� ������ ���    
    //===============================================================================================//
    // lNodeNum       : ��� ��ȣ
    // lModulePos     : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset        : ��� ������ ���� Offset ��ġ
    // uValue         : 0x00 ~ 0xFF('1'�� ���� �� ��Ʈ�� HIGH, '0'���� ���� �� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoWriteOutportReadAndByte(int lNodeNum, int lModulePos, int lOffset, uint uValue);
    // ������ ��� ���� ����� Offset ��ġ���� Byte ������ ���� ���� ����ڰ� ���ϴ� ���� OR ���� ������ ���    
    //===============================================================================================//
    // lModuleNo      : ��� ��ȣ
    // lNodeNum       : ��� ��ȣ
    // lModulePos     : ��� ��ġ(����ڰ� ���͸� ����ġ�� ���� ���� ��ġ)
    // lOffset        : ��� ������ ���� Offset ��ġ
    // uValue         : 0x00 ~ 0xFF('1'�� ���� �� ��Ʈ�� HIGH, '0'���� ���� �� ��Ʈ�� LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoWriteOutportReadOrByte(int lNodeNum, int lModulePos, int lOffset, uint uValue);
}
