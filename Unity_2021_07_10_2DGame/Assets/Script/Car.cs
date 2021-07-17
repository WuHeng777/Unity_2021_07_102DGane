using UnityEngine;     //�ޥ�Unity ���� ���Ѫ� API:½:[] (Unity Engine:½[Unity����] �R�W�Ŷ�)

//���O
//�y�k : �׹��� ���O����r �}���W��

public class Car : MonoBehaviour
{
    #region ����
    //������:�K�[����.½Ķ.��������...�|�Q�{������
    //Heng 2021.07.17(��) �}�o�T���}��

    /* �h�����
     * �h�����
     * �h�����
     * �h�����
     */
    #endregion

    #region �{�����P�`�Υ|�j����
    // ��� : �x�s²���� [field]
    // �y�k :
    // �׹��� ������� ���W�� ���w�Ÿ� �w�]�� ����
    // ���w�Ÿ� =
    // �׹���:
    // 1. �p�H [private] �w�] - �����
    // 2. ���} [public]       - ���
    // �K�[�w�]�� �B�I�� [�᭱�O�o�[�Wf]

    // Unity ���`�Ϊ��|�j����
    // ���   [int]    �� : 1, 99, 0, -123... [���t��Ƴ��]�t�]�A�s]
    // �B�I�� [float]  �� : 2.3, 3.1415, -1.123 [���p���I]
    // �r��   [string] ��: BMW, ���h, ��ܤ��e@#...
    // ���L�� [bool]   ��: true[�u��], false[����] : ��.�S�� �i�H.���i�H

    // �w�q��� : ���������ܥ|�j���� [�����R�W��K���� �H�K���z] [ ; �N�����Ÿ�]
    // �`�N : �J�����L�C�ݷ�U����
    // Unity �H�ݩʭ��O [Inspector] ���O�W���Ȭ��D
    public float weight = 3.5f;
    public int cc = 2000;
    public string brand = "���h";
    public bool windowSky = true;

    //�i�H�ϥΤ���.����ĳ - �s�X���D�P�ഫ�į���D
    public int ���L�ƶq = 4;

    //����ݩ� : ���U���K�[�B�~�\��
    //�y�k : [�ݩʦW��(�ݩʭ�)]
    
    //���D : [Header(�r��)] �i�ϥΤ���.����ĳ - �s�X���D�P�ഫ�į���D
    [Header("���L�ƶq")]
    public int wheelCount;
    
    //���� : [Tooltip(�r��)] �i�ϥΤ������
    [Tooltip("�o����쪺�@�άO�]�w�T��������...")]
    public float height = 1.5f;
    
    //�d�� : [Range(�̤p�ƭ�,�̤j�ƭ�)]
    [Range(2, 10)]
    public int boorCount;

    //���~�d�� : ���A�Ω� float �P int �H�~������
    [Range(2, 10)]
    public bool canOpenMusic;
    #endregion

    #region ��L����
    // �C�� Color
    public Color color1;                                        // �����w���¦�z��
    public Color red = Color.red;                               // �ϥιw�]�C��
    public Color yellow = Color.yellow;                         
    public Color colorCustom1 = new Color(0.5f, 0.5f, 0);       // �ۭq�C�� : (R,G,B)
    public Color colorCustom2 = new Color(0.5f, 0, 0.5f, 0.5f); // �ۭq�C�� : (R,G,B,A)
    public Color colorCustom3 = new Color(1, 0, 0.3f, 0.8f);

    // �y�� 2 . 4 �� Vector2 - 4
    // �O�s�ƭȸ�T.�B�I��
    public Vector2 v2;
    public Vector2 v2Zero = Vector2.zero;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2UP = Vector2.up;
    public Vector2 v2Right = Vector2.right;
    public Vector2 v2Custom = new Vector2(-99.5f, 100.5f);

    public Vector3 v3;
    public Vector4 v4;

    // ��������
    public KeyCode kc;
    public KeyCode forward = KeyCode.D;
    public KeyCode attack = KeyCode.Mouse0; // ���� 0, �k�� 1, �u�� 2

    //�C������P����
    public GameObject goCamera; // �C������]�t�����W���H�αM�פ����w�s��
    // ����ȭ���s���ݩʭ��O�������󪺪���
    public Transform traCar;
    public SpriteRenderer sprPicture;
    #endregion

    #region �ƥ�
    // �}�l�ƥ� : ����C���ɰ���@�� , �B�z��l�� (�_�l��q.����...����)
    private void Start()
    {
        // (½Ķ : �C�L) ��X(�����������); ��Unity = print 
        print("���o.�U�w:p");    
    }

    // ��s�ƥ� : �j���@�� 60 �� . 60FPS . �B�z���󲾰ʩΪ̺�ť���a��J
    private void Update()
    {
        print("�ڦb Update ��@3@");

        // �m�ߨ��o��� Get
        print(brand);
        // �m�߳]�w��� Set
        windowSky = true;
        cc = 5000;
        weight = 9.9f;
    }
    #endregion

}
