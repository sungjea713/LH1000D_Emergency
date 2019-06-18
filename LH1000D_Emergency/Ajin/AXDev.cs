/****************************************************************************
*****************************************************************************
** AXDev.CS
**
** COPYRIGHT (c) AJINEXTEK Co., LTD
**
*****************************************************************************
*****************************************************************************
**
** Description
** -----------
** Ajinextek Motion Library Header File
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


public class CAXDEV
{

    // ���̺귯�� �ʱ�ȭ
    [DllImport("AXLNet.dll")] public static extern uint AxlOpenTimer();
    // Board Number�� �̿��Ͽ� Board Address ã��
    [DllImport("AXLNet.dll")] public static extern uint AxlGetBoardAddress(int lBoardNo, ref uint upBoardAddress);
    // Board Number�� �̿��Ͽ� Board ID ã��
    [DllImport("AXLNet.dll")] public static extern uint AxlGetBoardID(int lBoardNo, ref uint upBoardID);
    // Board Number�� �̿��Ͽ� Board Version ã��
    [DllImport("AXLNet.dll")] public static extern uint AxlGetBoardVersion(int lBoardNo, ref uint upBoardVersion);
    // Board Number�� Module Position�� �̿��Ͽ� Module ID ã��
    [DllImport("AXLNet.dll")] public static extern uint AxlGetModuleID(int lBoardNo, int lModulePos, ref uint upModuleID);
    // Board Number�� Module Position�� �̿��Ͽ� Module Version ã��
    [DllImport("AXLNet.dll")] public static extern uint AxlGetModuleVersion(int lBoardNo, int lModulePos, ref uint upModuleVersion);
    // Board Number�� Module Position�� �̿��Ͽ� AIO Module Number ã��
    [DllImport("AXLNet.dll")] public static extern uint AxaInfoGetModuleNo(int lBoardNo, int lModulePos, ref int lpModuleNo);
    // Board Number�� Module Position�� �̿��Ͽ� DIO Module Number ã��
    [DllImport("AXLNet.dll")] public static extern uint AxdInfoGetModuleNo(int lBoardNo, int lModulePos, ref int lpModuleNo);
    
    // ������ ����� EzSpy�� �α� ��� ���� ����
    [DllImport("AXLNet.dll")] public static extern uint AxdLogSetModule(int lModuleNo, uint uUse);
    // ������ ����� EzSpy�� �α� ��� ���� Ȯ��
    [DllImport("AXLNet.dll")] public static extern uint AxdLogGetModule(int lModuleNo, ref uint upUse);


    // ���� �࿡ QICOMMAND Setting
    //[DllImport("AXLNet.dll")] public static extern uint AxmSetCommandQi(int lAxisNo, QICOMMAND sCommand);
    // ���� �࿡ 8bit QICOMMAND Setting
    //[DllImport("AXLNet.dll")] public static extern uint AxmSetCommandData08Qi(int lAxisNo, QICOMMAND sCommand, uint uData);
    // ���� �࿡ 8bit QICOMMAND ��������
    //[DllImport("AXLNet.dll")] public static extern uint AxmGetCommandData08Qi(int lAxisNo, QICOMMAND sCommand, ref uint upData);
    // ���� �࿡ 16bit QICOMMAND Setting
    //[DllImport("AXLNet.dll")] public static extern uint AxmSetCommandData16Qi(int lAxisNo, QICOMMAND sCommand, uint uData);
    // ���� �࿡ 16bit QICOMMAND ��������
    //[DllImport("AXLNet.dll")] public static extern uint AxmGetCommandData16Qi(int lAxisNo, QICOMMAND sCommand, ref uint upData);
    // ���� �࿡ 24bit QICOMMAND Setting
    //[DllImport("AXLNet.dll")] public static extern uint AxmSetCommandData24Qi(int lAxisNo, QICOMMAND sCommand, uint uData);
    // ���� �࿡ 24bit QICOMMAND ��������
    //[DllImport("AXLNet.dll")] public static extern uint AxmGetCommandData24Qi(int lAxisNo, QICOMMAND sCommand, ref uint upData);
    // ���� �࿡ 32bit QICOMMAND Setting
    //[DllImport("AXLNet.dll")] public static extern uint AxmSetCommandData32Qi(int lAxisNo, QICOMMAND sCommand, uint uData);
    // ���� �࿡ 32bit QICOMMAND ��������
    //[DllImport("AXLNet.dll")] public static extern uint AxmGetCommandData32Qi(int lAxisNo, QICOMMAND sCommand, ref uint upData);

    // ���� �࿡ Port Data �������� - IP
    //[DllImport("AXLNet.dll")] public static extern uint AxmGetPortData(int lAxisNo,  WORD wOffset, ref uint upData);
    // ���� �࿡ Port Data Setting - IP
    //[DllImport("AXLNet.dll")] public static extern uint AxmSetPortData(int lAxisNo, WORD wOffset, uint dwData);

    // ���� �࿡ Port Data �������� - QI
    //[DllImport("AXLNet.dll")] public static extern uint AxmGetPortDataQi(int lAxisNo, WORD byOffset, ref uint wpData);
    // ���� �࿡ Port Data Setting - QI
    //[DllImport("AXLNet.dll")] public static extern uint AxmSetPortDataQi(int lAxisNo, WORD byOffset, WORD wData);
        
    // ���� �࿡ ��ũ��Ʈ�� �����Ѵ�. - QI
    //[DllImport("AXLNet.dll")] public static extern uint AxmSetScriptCaptionQi(int lAxisNo, int sc, uint event, uint cmd, uint data);
    // ���� �࿡ ��ũ��Ʈ�� ��ȯ�Ѵ�. - QI
    //[DllImport("AXLNet.dll")] public static extern uint AxmGetScriptCaptionQi(int lAxisNo, int sc, ref uint event, ref uint cmd, ref uint data);
    
    [DllImport("AXLNet.dll")] public static extern uint AxdoDoSaveToFlash(int lModuleNo);
    [DllImport("AXLNet.dll")] public static extern uint AxdoDoLoadToFlash(int lModuleNo);

    
    //======= �︮�� �̵�  ===========================================================================
    // ������ ��ǥ�迡 ������, �������� �߽����� �����Ͽ� �︮�� ���� �����ϴ� �Լ��̴�.
    // AxmContiBeginNode, AxmContiEndNode�� ���̻��� ������ ��ǥ�迡 ������, �������� �߽����� �����Ͽ� �︮�� ���Ӻ��� �����ϴ� �Լ��̴�. 
    // ��ȣ ���� ���� ������ ���� ���� Queue�� �����ϴ� �Լ��̴�. AxmContiStart�Լ��� ����ؼ� �����Ѵ�. (���Ӻ��� �Լ��� ���� �̿��Ѵ�)
    // dCenterPos = �߽��� X,Y  , dEndPos = ������ X,Y .
    
    // uCWDir   DIR_CCW(0): �ݽð����, DIR_CW(1) �ð����
    [DllImport("AXLNet.dll")] public static extern uint AxmHelixCenterMove(int lCoord, double dCenterXPos, double dCenterYPos, double dEndXPos, double dEndYPos, double dZPos, double dVel, double dAccel, double dDecel, uint uCWDir);
    
    // ������ ��ǥ�迡 ������, �������� �������� �����Ͽ� �︮�� ���� �����ϴ� �Լ��̴�. 
    // AxmContiBeginNode, AxmContiEndNode�� ���̻��� ������ ��ǥ�迡 �߰���, �������� �����Ͽ� �︮�ÿ��� ���� �����ϴ� �Լ��̴�. 
    // ��ȣ ���� ���� ������ ���� ���� Queue�� �����ϴ� �Լ��̴�. AxmContiStart�Լ��� ����ؼ� �����Ѵ�. (���Ӻ��� �Լ��� ���� �̿��Ѵ�.)
    // dMidPos = �߰��� X,Y  , dEndPos = ������ X,Y 
    [DllImport("AXLNet.dll")] public static extern uint AxmHelixPointMove(int lCoord, double dMidXPos, double dMidYPos, double dEndXPos, double dEndYPos, double dZPos, double dVel, double dAccel, double dDecel);
    
    // ������ ��ǥ�迡 ������, �������� �������� �����Ͽ� �︮�� ���� �����ϴ� �Լ��̴�.
    // AxmContiBeginNode, AxmContiEndNode�� ���̻��� ������ ��ǥ�迡 ������, �������� �������� �����Ͽ� �︮�ÿ��� ���� �����ϴ� �Լ��̴�. 
    // ��ȣ ���� ���� ������ ���� ���� Queue�� �����ϴ� �Լ��̴�. AxmContiStart�Լ��� ����ؼ� �����Ѵ�. (���Ӻ��� �Լ��� ���� �̿��Ѵ�.)
    // dRadius = ������, dEndPos = ������ X,Y  , uShortDistance = ������(0), ū��(1)
    
    // uCWDir   DIR_CCW(0): �ݽð����, DIR_CW(1) �ð����
    [DllImport("AXLNet.dll")] public static extern uint AxmHelixRadiusMove(int lCoord, double dRadius, double dEndXPos, double dEndYPos, double dZPos, double dVel, double dAccel, double dDecel, uint uCWDir, uint uShortDistance);
    
    // ������ ��ǥ�迡 ������, ȸ�������� �������� �����Ͽ� �︮�� ���� �����ϴ� �Լ��̴�
    // AxmContiBeginNode, AxmContiEndNode�� ���̻��� ������ ��ǥ�迡 ������, ȸ�������� �������� �����Ͽ� �︮�ÿ��� ���� �����ϴ� �Լ��̴�. 
    // ��ȣ ���� ���� ������ ���� ���� Queue�� �����ϴ� �Լ��̴�. AxmContiStart�Լ��� ����ؼ� �����Ѵ�. (���Ӻ��� �Լ��� ���� �̿��Ѵ�.)
    // dCenterPos = �߽��� X,Y  , dAngle = ����.
    // uCWDir   DIR_CCW(0): �ݽð����, DIR_CW(1) �ð����
    [DllImport("AXLNet.dll")] public static extern uint AxmHelixAngleMove(int lCoord, double dCenterXPos, double dCenterYPos, double dAngle, double dZPos, double dVel, double dAccel, double dDecel, uint uCWDir);
    
    //======== ���ö��� �̵� =========================================================================== 
    
    // AxmContiBeginNode, AxmContiEndNode�� ���̻�����. 
    // ���ö��� ���� ���� �����ϴ� �Լ��̴�. ��ȣ ���� ���� ������ ���� ���� Queue�� �����ϴ� �Լ��̴�.
    // AxmContiStart�Լ��� ����ؼ� �����Ѵ�. (���Ӻ��� �Լ��� ���� �̿��Ѵ�.)    
    // lPosSize : �ּ� 3�� �̻�.
    // 2������ ���� dPoZ���� 0���� �־��ָ� ��.
    // 3������ ���� ������� 3���� dPosZ ���� �־��ش�.
    [DllImport("AXLNet.dll")] public static extern uint AxmSplineWrite(int lCoord, int lPosSize, ref double dpPosX, ref double dpPosY, double dVel, double dAccel, double dDecel, double dPosZ, int lPointFactor);

    //====���� �Լ� ============================================================================================================================================;
    // ������ ��ǥ�迡 ���Ӻ��� �� ������ �����Ѵ�.
    // (����� ��ȣ�� 0 ���� ����))
    // ������: ������Ҷ��� �ݵ�� ���� ���ȣ�� ���� ���ں��� ū���ڸ� �ִ´�.
    //         ������ ���� �Լ��� ����Ͽ��� �� �������ȣ�� ���� ���ȣ�� ���� �� ���� lpAxesNo�� ���� ���ؽ��� �Է��Ͽ��� �Ѵ�.
    //         ������ ���� �Լ��� ����Ͽ��� �� �������ȣ�� �ش��ϴ� ���� ���ȣ�� �ٸ� ���̶�� �Ѵ�.
    //         ���� ���� �ٸ� Coordinate�� �ߺ� �������� ���ƾ� �Ѵ�.
    [DllImport("AXLNet.dll")] public static extern uint AxmContiSetAxisMap(int lCoord, int lSize, ref int lpAxesNo);
    //������ ��ǥ�迡 ���Ӻ��� �� ������ ��ȯ�Ѵ�.
    [DllImport("AXLNet.dll")] public static extern uint AxmContiGetAxisMap(int lCoord, ref int lpSize, ref int lpAxesNo);
    
    // ������ ��ǥ�迡 ���Ӻ��� �� ����/��� ��带 �����Ѵ�.
    // (������ : �ݵ�� ����� �ϰ� ��밡��)
    // ���� ���� �̵� �Ÿ� ��� ��带 �����Ѵ�.
    // uAbsRelMode : POS_ABS_MODE '0' - ���� ��ǥ��
    //              POS_REL_MODE '1' - ��� ��ǥ��
    
    [DllImport("AXLNet.dll")] public static extern uint AxmContiSetAbsRelMode(int lCoord, uint uAbsRelMode);
    // ������ ��ǥ�迡 ���Ӻ��� �� ����/��� ��带 ��ȯ�Ѵ�.
    [DllImport("AXLNet.dll")] public static extern uint AxmContiGetAbsRelMode(int lCoord, ref uint upAbsRelMode);
    
    // ������ ��ǥ�迡 ���� ������ ���� ���� Queue�� ��� �ִ��� Ȯ���ϴ� �Լ��̴�.
    [DllImport("AXLNet.dll")] public static extern uint AxmContiReadFree(int lCoord, ref uint upQueueFree);
    // ������ ��ǥ�迡 ���� ������ ���� ���� Queue�� ����Ǿ� �ִ� ���� ���� ������ Ȯ���ϴ� �Լ��̴�.
    [DllImport("AXLNet.dll")] public static extern uint AxmContiReadIndex(int lCoord, ref int lpQueueIndex);
    // ������ ��ǥ�迡 ���� ���� ������ ���� ����� ���� Queue�� ��� �����ϴ� �Լ��̴�.
    [DllImport("AXLNet.dll")] public static extern uint AxmContiWriteClear(int lCoord);
    
    // ������ ��ǥ�迡 ���Ӻ������� ������ �۾����� ����� �����Ѵ�. ���Լ��� ȣ������,
    // AxmContiEndNode�Լ��� ȣ��Ǳ� ������ ����Ǵ� ��� ����۾��� ���� ����� �����ϴ� ���� �ƴ϶� ���Ӻ��� ������� ��� �Ǵ� ���̸�,
    // AxmContiStart �Լ��� ȣ��� �� ��μ� ��ϵȸ���� ������ ����ȴ�.
    [DllImport("AXLNet.dll")] public static extern uint AxmContiBeginNode(int lCoord);
    // ������ ��ǥ�迡�� ���Ӻ����� ������ �۾����� ����� �����Ѵ�.
    [DllImport("AXLNet.dll")] public static extern uint AxmContiEndNode(int lCoord);
    
    // ���� ���� ���� �Ѵ�.
    // dwProfileset(0 : ���� ���� ���, 1 : �������� ���� ���, 2 : �ڵ� �������� ����, 3 : �ӵ����� ��� ���) 
    [DllImport("AXLNet.dll")] public static extern uint AxmContiStart(int lCoord, uint dwProfileset, int lAngle); 
    // ������ ��ǥ�迡 ���� ���� ���� ������ Ȯ���ϴ� �Լ��̴�.
    [DllImport("AXLNet.dll")] public static extern uint AxmContiIsMotion(int lCoord, ref uint upInMotion);
    // ������ ��ǥ�迡 ���� ���� ���� �� ���� �������� ���� ���� �ε��� ��ȣ�� Ȯ���ϴ� �Լ��̴�.
    [DllImport("AXLNet.dll")] public static extern uint AxmContiGetNodeNum(int lCoord, ref int lpNodeNum);
    // ������ ��ǥ�迡 ������ ���� ���� ���� �� �ε��� ������ Ȯ���ϴ� �Լ��̴�.
    [DllImport("AXLNet.dll")] public static extern uint AxmContiGetTotalNodeNum(int lCoord, ref int lpNodeNum);

    // ���̺귯�� �ʱ�ȭ(�� ī�带 2���� ����� Ring ���� ��Ʈ�� ����, Lancard�� 2�� �̻� �����Ǿ�� �Ѵ�.)
    [DllImport("AXLNet.dll")] public static extern uint AxlRingOpen();
    
    // ������ �Ÿ���ŭ �Ǵ� ��ġ���� �̵��Ѵ�.
    // ���� ���� ���� ��ǥ/�����ǥ�� ������ ��ġ���� 2�ܰ��� �ӵ������� ������ �Ѵ�.
    // 1) ������ ���� ���� �ӵ����� ���� 2) ���� ���� �ӵ����� �ڵ� ������ 3) ���� ���� �ӵ����� ���� ������ ����.
    // �ӵ� ���������� AxmMotSetProfileMode �Լ����� �����Ѵ�. 
    // �޽��� ��µǴ� �������� �Լ��� �����.
    [DllImport("AXLNet.dll")] public static extern uint AxmMoveStartPos2(int lAxisNo, double dPos, double dAccelEndVel, double dDecelStrVel, double dAccel, double dDecel);

    // ������ �Ÿ���ŭ �Ǵ� ��ġ���� �̵��Ѵ�.
    // ���� ���� ���� ��ǥ/�����ǥ�� ������ ��ġ���� 2�ܰ��� �ӵ������� ������ �Ѵ�.
    // 1) ������ ���� ���� �ӵ����� ���� 2) ���� ���� �ӵ����� �ڵ� ������ 3) ���� ���� �ӵ����� ���� ������ ����.
    // �ӵ� ���������� AxmMotSetProfileMode �Լ����� �����Ѵ�. 
    // �޽� ����� ����Ǵ� �������� �Լ��� �����
    [DllImport("AXLNet.dll")] public static extern uint AxmMovePos2(int lAxisNo, double dPos, double dAccelEndVel, double dDecelStrVel, double dAccel, double dDecel);
    
    // ���� �࿡ ������ Ư�� �̺�Ʈ �߻��� �̸� ������ ������ �����ϵ��� �Ѵ�.
    // ���� �࿡ ���� �̺�Ʈ�� ������ ��ɾ�, ����� ����Ÿ���� �����Ѵ�.
    [DllImport("AXLNet.dll")] public static extern uint AxmEventSetOperation(int lAxisNo, uint uEvent, uint uCmd, uint uData);
    
    // ���� �࿡ ���� �̺�Ʈ�� ������ ��ɾ�, ����� ����Ÿ���� Ȯ���Ѵ�.
    [DllImport("AXLNet.dll")] public static extern uint AxmEventGetOperation(int lAxisNo,  ref uint upEvent, ref uint upCmd, ref uint upData);

    // ���� �࿡ �̺�Ʈ ���� ��ɾ� �������� ĸ�ĵ� ���� Ȯ�� �Ѵ�.
    [DllImport("AXLNet.dll")] public static extern uint AxmEventGetCapture(int lAxisNo, ref uint upCapData);

    // ���� �࿡ �̺�Ʈ ���� ��ɾ� ���� ��� ��� ���θ� ���� �Ѵ�.
    // uUse       : DISABLE(0), ENABLE(1)
    [DllImport("AXLNet.dll")] public static extern uint AxmEventSetUse(int lAxisNo, uint uUse);

    // ���� �࿡ �̺�Ʈ ���� ��ɾ� ���� ��� ��� ���θ� Ȯ�� �Ѵ�.
    [DllImport("AXLNet.dll")] public static extern uint AxmEventGetUse(int lAxisNo, ref uint upUse);
        
}

