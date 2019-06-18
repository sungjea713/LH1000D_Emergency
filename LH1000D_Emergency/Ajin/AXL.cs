/****************************************************************************
*****************************************************************************
**
** File Name
** ---------
**
** AXL.CS
**
** COPYRIGHT (c) AJINEXTEK Co., LTD
**
*****************************************************************************
*****************************************************************************
**
** Description
** -----------
** Ajinextek Library Header File
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

public class CAXL
{
//========== �Է� ���� ���� ���� ����. =======================================================================
// lNodeNum   : CPU ����� ID ���� ���͸� ����ġ�� ���� �ǹ� �մϴ�.(0x00 �̻�,  0xF9 ����)
//==============================================================================================================

//========== ���̺귯�� �ʱ�ȭ =================================================================================

    // ���̺귯�� �ʱ�ȭ
    [DllImport("AXLNet.dll")] public static extern uint AxlOpen();
    // ��忡 ������ ��� �ʱ�ȭ  
    // ����ڰ� ���ϴ� �Ķ��Ÿ�� Flash�� ����Ǹ� �����ʱ�ȭ���� �װ����� �ʱ�ȭ �ǰ� ������� Axm�� �Ķ��Ÿ Default������ �ʱ�ȭ�ȴ�.
    [DllImport("AXLNet.dll")] public static extern uint AxlInit(int lNodeNum);
    // ���̺귯�� ����� ����
    [DllImport("AXLNet.dll")] public static extern int AxlClose();
    // ���̺귯���� �ʱ�ȭ �Ǿ� �ִ� �� Ȯ��
    [DllImport("AXLNet.dll")] public static extern int AxlIsOpened();

//========== ���̺귯�� �� ���̽� ���� ���� =================================================================================

    // ��ϵ� ��� ���� Ȯ��
    [DllImport("AXLNet.dll")] public static extern uint AxlGetNodeCount(ref int lpNodeCount);
    // ��� ����(��� ID, ��� ����) Ȯ��
    // lNodeNum : ����ȣ.
    // dwpModuleId : ��� ID �ݵ�� 17���迭�� �����ؾߵ�.
    [DllImport("AXLNet.dll")] public static extern uint AxlGetNodeInfo(int lNodeNum, ref uint dwpModuleId);
    // ��ϵ� ��� ������ �����Ѵ�.
    // upNodeCount : ��尹��
    // upArrayNodeID : �迭 ��� ID �ݵ�� 250���迭�� �����ؾߵ�.
    [DllImport("AXLNet.dll")] public static extern uint AxlGetNetInfo(ref uint upNodeCount,  ref uint upArrayNodeID);
    // ���̺귯�� ���� Ȯ��
    [DllImport("AXLNet.dll")] public static extern uint AxlGetLibVersion(byte[] szVersion);

//========== �α� ���� =================================================================================================

    // EzSpy�� ����� �޽��� ���� ����
    // uLevel : 0 - 3 ����
    // LEVEL_NONE(0)    : ��� �޽����� ������� �ʴ´�.
    // LEVEL_ERROR(1)   : ������ �߻��� �޽����� ����Ѵ�.
    // LEVEL_RUNSTOP(2) : ��ǿ��� Run / Stop ���� �޽����� ����Ѵ�.
    // LEVEL_FUNCTION(3): ��� �޽����� ����Ѵ�.    
    [DllImport("AXLNet.dll")] public static extern uint AxlSetLogLevel(uint uLevel);
    // EzSpy�� ����� �޽��� ���� Ȯ��
    [DllImport("AXLNet.dll")] public static extern uint AxlGetLogLevel(ref uint upLevel);

//========= ��Ʈ��ũ ���� ���� ����� �˸�  �Լ� =============================================================================
   
    // �ش� ����� ���� ��Ʈ��ũ ���¸� Ȯ�� �Ѵ�.
    // dwpFlag : '0' - connected ����
    //           '1' - disconnected ����
    [DllImport("AXLNet.dll")] public static extern uint AxlNetStatusRead(int lNodeNum, ref uint dwpFlag);
    // �ش� ����� Frimware ������ Ȯ���Ѵ�.
    [DllImport("AXLNet.dll")] public static extern uint AxlGetNodeFirmVersion(int lNodeNum, ref char szVersion);

    // �ش� ��忡 �ִ� ������ �Ķ���͸� �����Ѵ�.
    [DllImport("AXLNet.dll")] public static extern uint AxlSaveParamToFlash(int lNodeNum);
    // �ش� ��忡 �ִ� ������ �������� �ε��Ѵ�.
    [DllImport("AXLNet.dll")] public static extern uint AxlLoadParamFromFlash(int lNodeNum);
    // �ش� ��忡 �ִ� ������ �������� ���� ������ �ʱ�ȭ �Ѵ�.
    // Axm�� �Ķ��Ÿ Default������ �ʱ�ȭ�ȴ�.    
    [DllImport("AXLNet.dll")] public static extern uint AxlResetParamFlash(int lNodeNum);
    
   // Background process check function
	// dwpProcessState --> 255(Background process not execute)
	// dwpProcessState --> 0(Background process idle)
	// dwpProcessState --> 2(Background process run)
   [DllImport("AXLNet.dll")] public static extern uint AxlProcessStateCheck(ref uint dwpProcessState);  
}
