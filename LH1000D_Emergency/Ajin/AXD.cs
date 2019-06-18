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
//========== 노드 및 모듈 정보 
    // DIO 모듈이 있는지 확인
    [DllImport("AXLNet.dll")] public static extern uint AxdInfoIsDIOModule(ref uint upStatus);
    // DIO 입출력 모듈의 개수 확인
    [DllImport("AXLNet.dll")] public static extern uint AxdInfoGetModuleCount(ref int lpModuleCount);
    // 지정한 모듈의 입력 접점 개수 확인
    [DllImport("AXLNet.dll")] public static extern uint AxdInfoGetInputCount(int lModuleNo, ref int lpCount);
    // 지정한 모듈의 출력 접점 개수 확인
    [DllImport("AXLNet.dll")] public static extern uint AxdInfoGetOutputCount(int lModuleNo, ref int lpCount);
    // 지정한 모듈 번호로 노드 ID 번호, 모듈 위치, 모듈 ID 확인
    [DllImport("AXLNet.dll")] public static extern uint AxdInfoGetModule(int lModuleNo, ref int lpNodeNum, ref int lpModulePos, ref uint upModuleID);

//========== 입출력 레벨 설정 확인 =================================================================================
//==입력 레벨 설정 확인
    // 지정한 입력 접점 모듈의 Offset 위치에서 bit 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 입력 접점에 대한 Offset 위치
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiLevelSetInportBit(int lModuleNo, int lOffset, uint uLevel);
    
    // 지정한 입력 접점 모듈의 Offset 위치에서 byte 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 입력 접점에 대한 Offset 위치
    // uLevel          : 0x00 ~ 0x0FF('1'로 설정 된 비트는 HIGH, '0'으로 설정 된 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiLevelSetInportByte(int lModuleNo, int lOffset, uint uLevel);
    
    // 지정한 입력 접점 모듈의 Offset 위치에서 word 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 입력 접점에 대한 Offset 위치
    // uLevel          : 0x00 ~ 0x0FFFF('1'로 설정 된 비트는 HIGH, '0'으로 설정 된 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiLevelSetInportWord(int lModuleNo, int lOffset, uint uLevel);
    
    // 지정한 입력 접점 모듈의 Offset 위치에서 double word 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 입력 접점에 대한 Offset 위치
    // uLevel          : 0x00 ~ 0x0FFFFFFFF('1'로 설정 된 비트는 HIGH, '0'으로 설정 된 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiLevelSetInportDword(int lModuleNo, int lOffset, uint uLevel);
    
    // 지정한 입력 접점 모듈의 Offset 위치에서 bit 단위로 데이터 레벨을 확인
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 입력 접점에 대한 Offset 위치
    // *upLevel        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiLevelGetInportBit(int lModuleNo, int lOffset, ref uint upLevel);
    
    // 지정한 입력 접점 모듈의 Offset 위치에서 byte 단위로 데이터 레벨을 확인
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 입력 접점에 대한 Offset 위치
    // *upLevel        : 0x00 ~ 0x0FF('1'로 읽힌 비트는 HIGH, '0'으로 읽힌 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiLevelGetInportByte(int lModuleNo, int lOffset, ref uint upLevel);
    
    // 지정한 입력 접점 모듈의 Offset 위치에서 word 단위로 데이터 레벨을 확인
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 입력 접점에 대한 Offset 위치
    // *upLevel        : 0x00 ~ 0x0FFFF('1'로 읽힌 비트는 HIGH, '0'으로 읽힌 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiLevelGetInportWord(int lModuleNo, int lOffset, ref uint upLevel);
    
    // 전체 입력 접점 모듈의 Offset 위치에서 bit 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lOffset         : 입력 접점에 대한 Offset 위치
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiLevelSetInport(int lOffset, uint uLevel);
    
    // 전체 입력 접점 모듈의 Offset 위치에서 bit 단위로 데이터 레벨을 확인
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 입력 접점에 대한 Offset 위치
    // *upLevel        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiLevelGetInport(int lOffset, ref uint upLevel);
    
//==출력 레벨 설정 확인
    // 지정한 출력 접점 모듈의 Offset 위치에서 bit 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 출력 접점에 대한 Offset 위치
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoLevelSetOutportBit(int lModuleNo, int lOffset, uint uLevel);
    
    // 지정한 출력 접점 모듈의 Offset 위치에서 byte 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 출력 접점에 대한 Offset 위치
    // uLevel          : 0x00 ~ 0x0FF('1'로 설정 된 비트는 HIGH, '0'으로 설정 된 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoLevelSetOutportByte(int lModuleNo, int lOffset, uint uLevel);
    
    // 지정한 출력 접점 모듈의 Offset 위치에서 word 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 출력 접점에 대한 Offset 위치
    // uLevel          : 0x00 ~ 0x0FFFF('1'로 설정 된 비트는 HIGH, '0'으로 설정 된 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoLevelSetOutportWord(int lModuleNo, int lOffset, uint uLevel);
    
    // 지정한 출력 접점 모듈의 Offset 위치에서 double word 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 출력 접점에 대한 Offset 위치
    // uLevel          : 0x00 ~ 0x0FFFFFFFF('1'로 설정 된 비트는 HIGH, '0'으로 설정 된 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoLevelSetOutportDword(int lModuleNo, int lOffset, uint uLevel);
    
    // 지정한 출력 접점 모듈의 Offset 위치에서 bit 단위로 데이터 레벨을 확인
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 출력 접점에 대한 Offset 위치
    // *upLevel        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoLevelGetOutportBit(int lModuleNo, int lOffset, ref uint upLevel);
    
    // 지정한 출력 접점 모듈의 Offset 위치에서 byte 단위로 데이터 레벨을 확인
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 출력 접점에 대한 Offset 위치
    // uLevel          : 0x00 ~ 0x0FF('1'로 읽힌 비트는 HIGH, '0'으로 읽힌 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoLevelGetOutportByte(int lModuleNo, int lOffset, ref uint upLevel);
    
    // 지정한 출력 접점 모듈의 Offset 위치에서 word 단위로 데이터 레벨을 확인
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 출력 접점에 대한 Offset 위치
    // uLevel          : 0x00 ~ 0x0FFFF('1'로 읽힌 비트는 HIGH, '0'으로 읽힌 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoLevelGetOutportWord(int lModuleNo, int lOffset, ref uint upLevel);
    
    // 전체 출력 접점 모듈의 Offset 위치에서 bit 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lOffset         : 출력 접점에 대한 Offset 위치
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoLevelSetOutport(int lOffset, uint uLevel);
    
    // 전체 출력 접점 모듈의 Offset 위치에서 bit 단위로 데이터 레벨을 확인
    //===============================================================================================//
    // lOffset         : 출력 접점에 대한 Offset 위치
    // *upLevel        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoLevelGetOutport(int lOffset, ref uint upLevel);
    
//========== 입출력 포트 쓰기 읽기 =================================================================================
//==출력 포트 쓰기
    // 전체 출력 접점 모듈의 Offset 위치에서 bit 단위로 데이터를 출력
    //===============================================================================================//
    // lOffset         : 출력 접점에 대한 Offset 위치
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoWriteOutport(int lOffset, uint uValue);
    
    // 지정한 출력 접점 모듈의 Offset 위치에서 bit 단위로 데이터를 출력
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 출력 접점에 대한 Offset 위치
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoWriteOutportBit(int lModuleNo, int lOffset, uint uValue);
    
    // 지정한 출력 접점 모듈의 Offset 위치에서 byte 단위로 데이터를 출력
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 출력 접점에 대한 Offset 위치
    // uValue          : 0x00 ~ 0x0FF('1'로 설정 된 비트는 HIGH, '0'으로 설정 된 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoWriteOutportByte(int lModuleNo, int lOffset, uint uValue);
    
    // 지정한 출력 접점 모듈의 Offset 위치에서 word 단위로 데이터를 출력
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 출력 접점에 대한 Offset 위치
    // uValue          : 0x00 ~ 0x0FFFF('1'로 설정 된 비트는 HIGH, '0'으로 설정 된 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoWriteOutportWord(int lModuleNo, int lOffset, uint uValue);
    
//==출력 포트 읽기    
    // 전체 출력 접점 모듈의 Offset 위치에서 bit 단위로 데이터를 읽기
    //===============================================================================================//
    // lOffset         : 출력 접점에 대한 Offset 위치
    // *upLevel        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoReadOutport(int lOffset, ref uint upValue);
    
    // 지정한 출력 접점 모듈의 Offset 위치에서 bit 단위로 데이터를 읽기
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 출력 접점에 대한 Offset 위치
    // *upLevel        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoReadOutportBit(int lModuleNo, int lOffset, ref uint upValue);
    
    // 지정한 출력 접점 모듈의 Offset 위치에서 byte 단위로 데이터를 읽기
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 출력 접점에 대한 Offset 위치
    // *upValue        : 0x00 ~ 0x0FF('1'로 읽힌 비트는 HIGH, '0'으로 읽힌 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoReadOutportByte(int lModuleNo, int lOffset, ref uint upValue);
    
    // 지정한 출력 접점 모듈의 Offset 위치에서 word 단위로 데이터를 읽기
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 출력 접점에 대한 Offset 위치
    // *upValue        : 0x00 ~ 0x0FFFF('1'로 읽힌 비트는 HIGH, '0'으로 읽힌 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoReadOutportWord(int lModuleNo, int lOffset, ref uint upValue);
    
//==입력 포트 일기    
    // 전체 입력 접점 모듈의 Offset 위치에서 bit 단위로 데이터를 읽기
    //===============================================================================================//
    // lOffset         : 입력 접점에 대한 Offset 위치
    // *upValue        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiReadInport(int lOffset, ref uint upValue);
    
    // 지정한 입력 접점 모듈의 Offset 위치에서 bit 단위로 데이터를 읽기
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 입력 접점에 대한 Offset 위치
    // *upValue        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiReadInportBit(int lModuleNo, int lOffset, ref uint upValue);
    
    // 지정한 입력 접점 모듈의 Offset 위치에서 byte 단위로 데이터를 읽기
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 입력 접점에 대한 Offset 위치
    // *upValue        : 0x00 ~ 0x0FF('1'로 읽힌 비트는 HIGH, '0'으로 읽힌 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiReadInportByte(int lModuleNo, int lOffset, ref uint upValue);
    
    // 지정한 입력 접점 모듈의 Offset 위치에서 word 단위로 데이터를 읽기
    //===============================================================================================//
    // lModuleNo       : 모듈 번호
    // lOffset         : 입력 접점에 대한 Offset 위치
    // *upValue        : 0x00 ~ 0x0FFFF('1'로 읽힌 비트는 HIGH, '0'으로 읽힌 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiReadInportWord(int lModuleNo, int lOffset, ref uint upValue);
        
//========== 입출력 레벨 설정 확인 (지정 노드에 대한 제어)
//==입력 레벨 설정 인
    // 지정한 입력 접점 모듈의 Offset 위치에서 bit 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lModulePos      : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset         : 입력 접점에 대한 Offset 위치
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNLevelSetInportBit(int lNodeNum, int lModulePos, int lOffset, uint uLevel);

    // 지정한 입력 접점 모듈의 Offset 위치에서 byte 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lModulePos      : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset         : 입력 접점에 대한 Offset 위치
    // uValue          : 0x00 ~ 0x0FF('1'로 설정 된 비트는 HIGH, '0'으로 설정 된 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNLevelSetInportByte(int lNodeNum, int lModulePos, int lOffset, uint uLevel);

    // 지정한 입력 접점 모듈의 Offset 위치에서 word 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lModulePos      : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset         : 입력 접점에 대한 Offset 위치
    // uLevel          : 0x00 ~ 0x0FFFF('1'로 설정 된 비트는 HIGH, '0'으로 설정 된 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNLevelSetInportWord(int lNodeNum, int lModulePos, int lOffset, uint uLevel);

    // 지정한 입력 접점 모듈의 Offset 위치에서 double word 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lModulePos      : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset         : 입력 접점에 대한 Offset 위치
    // uLevel          : 0x00 ~ 0x0FFFFFFFF('1'로 설정 된 비트는 HIGH, '0'으로 설정 된 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNLevelSetInportDword(int lNodeNum, int lModulePos, int lOffset, uint uLevel);

    // 지정한 입력 접점 모듈의 Offset 위치에서 bit 단위로 데이터 레벨을 확인
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lModulePos      : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset         : 입력 접점에 대한 Offset 위치
    // *upLevel        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNLevelGetInportBit(int lNodeNum, int lModulePos, int lOffset, ref uint upLevel);

    // 지정한 입력 접점 모듈의 Offset 위치에서 byte 단위로 데이터 레벨을 확인
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lModulePos      : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset         : 입력 접점에 대한 Offset 위치
    // *upLevel        : 0x00 ~ 0x0FF('1'로 읽힌 비트는 HIGH, '0'으로 읽힌 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNLevelGetInportByte(int lNodeNum, int lModulePos, int lOffset, ref uint upLevel);

    // 지정한 입력 접점 모듈의 Offset 위치에서 word 단위로 데이터 레벨을 확인
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lModulePos      : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset         : 입력 접점에 대한 Offset 위치
    // *upLevel        : 0x00 ~ 0x0FFFF('1'로 읽힌 비트는 HIGH, '0'으로 읽힌 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNLevelGetInportWord(int lNodeNum, int lModulePos, int lOffset, ref uint upLevel);

    // 전체 입력 접점 모듈의 Offset 위치에서 bit 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lOffset         : 입력 접점에 대한 Offset 위치
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNLevelSetInport(int lNodeNum, int lOffset, uint uLevel);

    // 전체 입력 접점 모듈의 Offset 위치에서 bit 단위로 데이터 레벨을 확인
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lOffset         : 입력 접점에 대한 Offset 위치
    // *uLevel         : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNLevelGetInport(int lNodeNum, int lOffset, ref uint upLevel);

//==입력 포트 읽기
    // 전체 입력 접점 모듈의 Offset 위치에서 bit 단위로 데이터를 읽기
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lOffset         : 입력 접점에 대한 Offset 위치
    // *upValue        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNReadInport(int lNodeNum, int lOffset, ref uint upValue);

    // 지정한 입력 접점 모듈의 Offset 위치에서 bit 단위로 데이터를 읽기
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lModulePos      : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset         : 입력 접점에 대한 Offset 위치
    // *upValue        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNReadInportBit(int lNodeNum, int lModulePos, int lOffset, ref uint upValue);

    // 지정한 입력 접점 모듈의 Offset 위치에서 byte 단위로 데이터를 읽기
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lModulePos      : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset         : 입력 접점에 대한 Offset 위치
    // *upValue        : 0x00 ~ 0x0FF('1'로 읽힌 비트는 HIGH, '0'으로 읽힌 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNReadInportByte(int lNodeNum, int lModulePos, int lOffset, ref uint upValue);

    // 지정한 입력 접점 모듈의 Offset 위치에서 word 단위로 데이터를 읽기
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lModulePos      : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset         : 입력 접점에 대한 Offset 위치
    // *upValue        : 0x00 ~ 0x0FFFF('1'로 읽힌 비트는 HIGH, '0'으로 읽힌 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdiNReadInportWord(int lNodeNum, int lModulePos, int lOffset, ref uint upValue);

//==출력 레벨 설정 확인
    // 지정한 출력 접점 모듈의 Offset 위치에서 bit 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lModulePos      : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset         : 출력 접점에 대한 Offset 위치
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNLevelSetOutportBit(int lNodeNum, int lModulePos, int lOffset, uint uLevel);

    // 지정한 출력 접점 모듈의 Offset 위치에서 byte 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lModulePos      : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset         : 출력 접점에 대한 Offset 위치
    // uLevel          : 0x00 ~ 0x0FF('1'로 설정 된 비트는 HIGH, '0'으로 설정 된 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNLevelSetOutportByte(int lNodeNum, int lModulePos, int lOffset, uint uLevel);

    // 지정한 출력 접점 모듈의 Offset 위치에서 word 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lModulePos      : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset         : 출력 접점에 대한 Offset 위치
    // uLevel          : 0x00 ~ 0x0FFFF('1'로 설정 된 비트는 HIGH, '0'으로 설정 된 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNLevelSetOutportWord(int lNodeNum, int lModulePos, int lOffset, uint uLevel);

    // 지정한 출력 접점 모듈의 Offset 위치에서 double word 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lModulePos      : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset         : 출력 접점에 대한 Offset 위치
    // uLevel          : 0x00 ~ 0x0FFFFFFFF('1'로 설정 된 비트는 HIGH, '0'으로 설정 된 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNLevelSetOutportDword(int lNodeNum, int lModulePos, int lOffset, uint uLevel);

    // 지정한 출력 접점 모듈의 Offset 위치에서 bit 단위로 데이터 레벨을 확인
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lModulePos      : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset         : 출력 접점에 대한 Offset 위치
    // *upLevel        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNLevelGetOutportBit(int lNodeNum, int lModulePos, int lOffset, ref uint upLevel);

    // 지정한 출력 접점 모듈의 Offset 위치에서 byte 단위로 데이터 레벨을 확인
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lModulePos      : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset         : 출력 접점에 대한 Offset 위치
    // *upLevel        : 0x00 ~ 0x0FF('1'로 읽힌 비트는 HIGH, '0'으로 읽힌 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNLevelGetOutportByte(int lNodeNum, int lModulePos, int lOffset, ref uint upLevel);

    // 지정한 출력 접점 모듈의 Offset 위치에서 word 단위로 데이터 레벨을 확인
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lModulePos      : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset         : 출력 접점에 대한 Offset 위치
    // *upLevel        : 0x00 ~ 0x0FFFF('1'로 읽힌 비트는 HIGH, '0'으로 읽힌 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNLevelGetOutportWord(int lNodeNum, int lModulePos, int lOffset, ref uint upLevel);

    // 전체 출력 접점 모듈의 Offset 위치에서 bit 단위로 데이터 레벨을 설정
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lOffset         : 출력 접점에 대한 Offset 위치
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNLevelSetOutport(int lNodeNum, int lOffset, uint uLevel);

    // 전체 출력 접점 모듈의 Offset 위치에서 bit 단위로 데이터 레벨을 확인
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lOffset         : 출력 접점에 대한 Offset 위치
    // *upLevel        : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNLevelGetOutport(int lNodeNum, int lOffset, ref uint upLevel);

//========== 입출력 포트 쓰기 읽기 
//==출력 포트 쓰기
    // 전체 출력 접점 모듈의 Offset 위치에서 bit 단위로 데이터를 출력
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lOffset         : 출력 접점에 대한 Offset 위치
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNWriteOutport(int lNodeNum, int lOffset, uint uValue);

    // 지정한 출력 접점 모듈의 Offset 위치에서 bit 단위로 데이터를 출력
    //===============================================================================================//
    // lNodeNum        : 노드 번호
    // lModulePos      : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset         : 출력 접점에 대한 Offset 위치
    // uLevel          : LOW(0)
    //                 : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNWriteOutportBit(int lNodeNum, int lModulePos, int lOffset, uint uValue);

    // 지정한 출력 접점 모듈의 Offset 위치에서 byte 단위로 데이터를 출력
    //===============================================================================================//
    // lNodeNum         : 노드 번호
    // lModulePos       : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset          : 출력 접점에 대한 Offset 위치
    // uValue           : 0x00 ~ 0x0FF('1'로 설정 된 비트는 HIGH, '0'으로 설정 된 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNWriteOutportByte(int lNodeNum, int lModulePos, int lOffset, uint uValue);

    // 지정한 출력 접점 모듈의 Offset 위치에서 word 단위로 데이터를 출력
    //===============================================================================================//
    // lNodeNum         : 노드 번호
    // lModulePos       : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset          : 출력 접점에 대한 Offset 위치
    // uValue           : 0x00 ~ 0x0FFFF('1'로 설정 된 비트는 HIGH, '0'으로 설정 된 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNWriteOutportWord(int lNodeNum, int lModulePos, int lOffset, uint uValue);

    // 지정한 출력 접점 모듈의 Offset 위치에서 double word 단위로 데이터를 출력
    //===============================================================================================//
    // lNodeNum         : 노드 번호
    // lModulePos       : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset          : 출력 접점에 대한 Offset 위치
    // uValue           : 0x00 ~ 0x0FFFFFFFF('1'로 설정 된 비트는 HIGH, '0'으로 설정 된 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNWriteOutportDword(int lNodeNum, int lModulePos, int lOffset, uint uValue);

//==출력 포트 읽기
    // 전체 출력 접점 모듈의 Offset 위치에서 bit 단위로 데이터를 읽기
    //===============================================================================================//
    // lNodeNum         : 노드 번호
    // lOffset          : 입력 접점에 대한 Offset 위치
    // *upValue         : LOW(0)
    //                  : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNReadOutport(int lNodeNum, int lOffset, ref uint upValue);

    // 지정한 출력 접점 모듈의 Offset 위치에서 bit 단위로 데이터를 읽기
    //===============================================================================================//
    // lNodeNum         : 노드 번호
    // lModulePos       : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset          : 입력 접점에 대한 Offset 위치
    // *upValue         : LOW(0)
    //                  : HIGH(1)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNReadOutportBit(int lNodeNum, int lModulePos, int lOffset, ref uint upValue);

    // 지정한 출력 접점 모듈의 Offset 위치에서 byte 단위로 데이터를 읽기
    //===============================================================================================//
    // lNodeNum         : 노드 번호
    // lModulePos       : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset          : 입력 접점에 대한 Offset 위치
    // *upValue         : 0x00 ~ 0x0FF('1'로 읽힌 비트는 HIGH, '0'으로 읽힌 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNReadOutportByte(int lNodeNum, int lModulePos, int lOffset, ref uint upValue);

    // 지정한 출력 접점 모듈의 Offset 위치에서 word 단위로 데이터를 읽기
    //===============================================================================================//
    // lNodeNum         : 노드 번호
    // lModulePos       : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset          : 입력 접점에 대한 Offset 위치
    // *upValue         : 0x00 ~ 0x0FFFF('1'로 읽힌 비트는 HIGH, '0'으로 읽힌 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNReadOutportWord(int lNodeNum, int lModulePos, int lOffset, ref uint upValue);

    // 지정한 출력 접점 모듈의 Offset 위치에서 double word 단위로 데이터를 읽기
    //===============================================================================================//
    // lNodeNum         : 노드 번호
    // lModulePos       : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset          : 입력 접점에 대한 Offset 위치
    // *upValue         : 0x00 ~ 0x0FFFFFFFF('1'로 읽힌 비트는 HIGH, '0'으로 읽힌 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNReadOutportDword(int lNodeNum, int lModulePos, int lOffset, ref uint upValue);
    
    // 지정한 출력 접점 모듈이 연결된 노드의 통신이 끊어 졌을때 현재 출력 접점 상태에 대한 예외처리 방법 설정.
    //===============================================================================================//
    // lModuleNo      : 모듈 번호
    // dwNetErrorAct  : 접점의 상태(0 - 1)
    //                  '0' - 현재 접점 상태 유지
    //                  '1' - AxdoSetNetWorkErrorByteValue 함수에 의하여 Setting된 값으로 동작
    //===============================================================================================//
     [DllImport("AXLNet.dll")] public static extern uint AxdoNetWorkErrorSetAction(int lModuleNo, uint dwNetErrorAct);

    // 지정한 출력 접점 모듈이 연결된 노드의 통신이 끊어 졌을때 현재 출력 접점 상태에 대한 예외처리 방법 확인.
    //===============================================================================================//
    // lModuleNo      : 모듈 번호
    // *dwNetErrorAct : 접점의 상태(0 - 1)
    //                  '0' - 현재 접점 상태 유지
    //                  '1' - AxdoSetNetWorkErrorByteValue 함수에 의하여 Setting된 값으로 동작하도록 설정
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNetWorkErrorGetAction(int lModuleNo, ref uint dwpNetErrorAct);
 
    // 지정한 출력 접점 모듈이 연결된 노드의 통신이 끊어 졌을때 현재 출력 접점 상태에 대한 예외처리 상태.
    //===============================================================================================//
    // lModuleNo      : 모듈 번호
    // lOffset        : 출력 접점에 대한 Offset 위치
    // uValue         : 0x00 ~ 0xFF('1'네트웍 에러시 출력 High, '0'네트웍 에러시 출력 Low) 
    //===============================================================================================//
	[DllImport("AXLNet.dll")] public static extern uint AxdoNetWorkErrorSetByteValue(int lModuleNo, int lOffset, uint uValue);

	// 지정한 출력 접점 모듈이 연결된 노드의 통신이 끊어 졌을때 현재 출력 접점 상태에 대한 예외처리 상태 확인.
    //===============================================================================================//
    // lModuleNo      : 모듈 번호
    // lOffset        : 출력 접점에 대한 Offset 위치
    // *upValue       : 0x00 ~ 0xFF('1'네트웍 에러시 출력 High, '0'네트웍 에러시 출력 Low) 
    //===============================================================================================//
	[DllImport("AXLNet.dll")] public static extern uint AxdoNetWorkErrorGetByteValue(int lModuleNo, int lOffset, ref uint upValue);
//==TCP, UDP Protocol 선택
    // Digital Output 값을 TCP/IP로 통신 할 것인지 UDP/IP로 통신 할 것인지 선택.
    //===============================================================================================//
    // lModuleNo      : 모듈 번호
    // dwSelNet       : 통신 방식 선택(0 - 1)
    //                  '0' - UDP/IP
    //                  '1' - TCP/IP
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNetWorkSetSelNet(int lNodeNum, uint dwSelNet);
    // Digital Output 값을 TCP/IP로 통신 할 것인지 UDP로 통신 할 것인지 선택 확인.
    //===============================================================================================//
    // lModuleNo      : 모듈 번호
    // *upSelNet       : 0 ~ 1 ('0' UDP/IP, '1' TCP/IP)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoNetWorkGetSelNet(int lNodeNum, ref uint upSelNet);
    // 지정한 출력 접점 모듈의 Offset 위치에서 Byte 단위로 현재 값에 사용자가 원하는 값을 AND 시켜 데이터 출력    
    //===============================================================================================//
    // lNodeNum       : 노드 번호
    // lModulePos     : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset        : 출력 접점에 대한 Offset 위치
    // uValue         : 0x00 ~ 0xFF('1'로 설정 된 비트는 HIGH, '0'으로 설정 된 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoWriteOutportReadAndByte(int lNodeNum, int lModulePos, int lOffset, uint uValue);
    // 지정한 출력 접점 모듈의 Offset 위치에서 Byte 단위로 현재 값에 사용자가 원하는 값을 OR 시켜 데이터 출력    
    //===============================================================================================//
    // lModuleNo      : 모듈 번호
    // lNodeNum       : 노드 번호
    // lModulePos     : 모듈 위치(사용자가 로터리 스위치로 정한 절대 위치)
    // lOffset        : 출력 접점에 대한 Offset 위치
    // uValue         : 0x00 ~ 0xFF('1'로 설정 된 비트는 HIGH, '0'으로 설정 된 비트는 LOW)
    //===============================================================================================//
    [DllImport("AXLNet.dll")] public static extern uint AxdoWriteOutportReadOrByte(int lNodeNum, int lModulePos, int lOffset, uint uValue);
}
