using UnityEngine;

// �{�ѹB��l
// 1. �ƾǹB��l
public class LearnOperator : MonoBehaviour
{
    public int a = 10;
    public int b = 3;
    public int c = 7;
    public int hp = 100;

    public float scoreA = 99;
    public float scoreB = 1;

    public int health = 50;
    public int key = 1;

    public int chest = 7;
    public int diamond = 0;

    private void Start()
    {
        #region �ƾǹB��l
        print(a + b);  //13
        print(a - b);  //7
        print(a * b);  //30
        print(a / b);  //3
        print(a % b);  //1

        c = c + 1;     // = ���w�Ÿ� : �k����B��A���w������
        c++;           // ²�g
        print("c �B��᪺���G:" + c);
        // ���� --
        // �ۦ�m��

        //���w�B�� - �A�Υ[����l
        //�Ҥl :�@���g�@13
        hp = hp - 13;  //87
        hp -= 13;      //74

        // �Ҥl : �ɦ� 20
        hp += 20;      //94
        #endregion
        #region ����B��l
        // > < >= <= == !=
        //�ϥΤ���B��l�����G ���O���L��
        //������T���G�� true �_�h�� false
        print("99 �j�� 1:" + (scoreA > scoreB));      //trus
        print("99 �p�� 1:" + (scoreA < scoreB));      //false
        print("99 �j�󵥩� 1" + (scoreA >= scoreB));  //trus
        print("99 �p�󵥩� 1" + (scoreA <= scoreB));  //false
        print("99 ���� 1" + (scoreA = scoreB));       //false
        print("99 ������ 1" + (scoreA != scoreB));    //trus
        #endregion
        #region �޿�B��l
        print("�޿�B��l");
        // ����ⵧ���L�Ȫ����

        print("�åB");
        // �åB &&
        // �u�n���@�ӥ��L�Ȭ� false ���G�N�� false
        print(true && true);       // true 
        print(true && false);      // false
        print(false && true);      // false
        print(false && false);     // false

        print("�Ϊ�");
        // �Ϊ� ||
        // �u�n���@�ӥ��L�Ȭ� true ���G�N�� true
        print(true || true);       // false
        print(true || false);      // true
        print(false || true);      // true
        print(false || false);     // true

        //�L������ : ��q �j�� 0 �åB �_�� �n���� 1
        print("�O�_�L��:" + (health > 0 && key == 1));
        //�L������ : �_�c �j�󵥩� 5 �Ϊ� �p�� �j�󵥩� 2
        print("�O�_�L��" + (chest >= 5 || diamond >= 2));

        // �ۤ� !
        print(!true);
        print(!false);
        #endregion
    }
}
