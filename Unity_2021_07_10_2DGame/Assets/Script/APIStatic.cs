using UnityEngine;
/// <summary>
/// �{�� API �H�βĤ@�إΪk : �R�A static
/// </summary>
public class APIStatic : MonoBehaviour
{
    // API ���A������j��
    // 1. �R�A : ������r   static
    // 2. �D�R�A : �L����r static

    //�� ��(�� ��) :�@Propreties �i�H�z�Ѭ����P�����
    //�� �k : Methods

    public float number = 9.99f;
    public Vector3 a = new Vector3(1, 1, 1);
    public Vector3 b = new Vector3(22, 22, 22);

    private void Start()
    {
        #region �{���R�A�ݩʻP��k
        // �R�A�ݩ�   
        // 1. ���o
        // �y�k :�@���O.�R�A�ݩ�
        print("�H����:" + Random.value);   // 0 - 1
        print("�L��:" + Mathf.Infinity);

        // 2. �]�w
        // �y�k :�@���O.�R�A�ݩ� ���w �� ;
        Cursor.visible = false;
        // Random.value = 7.7F;   �߿W�ݩʤ���]�w Read Only
        Screen.fullScreen = true;

        // �R�A��k
        // 3. �I�s �R�A��k
        // �y�k : ���O.�R�A��k(�����޼�);
        float r = Random.Range(7.5f, 9.8f);
        print("�H���d�� 7.5 ~ 9.8:" + r);
        #endregion

        #region �m���R�A�ݩʻP��k
        // 1. ���o�R�A�ݩ�
        print("�Ҧ���v���ƶq:" + Camera.allCamerasCount);
        print("2D ���O:" + Physics2D.gravity);
        print("��P�v:" + Mathf.PI);
        // 2. �]�w�R�A�ݩ�
        Physics2D.gravity = new Vector2(0, -20);
        print("2D���O:" + Physics2D.gravity);
        Time.timeScale = 0.5f;     // �C�ʧ@�A�ְʧ@ 2�A�Ȱ� 0
        print("�ɶ��j�p:" + Time.timeScale);

        // 3. �I�s�R�A��k
        number = Mathf.Floor(number);
        print("9.99 �h�p���I:" + number);

        float d = Vector3.Distance(a, b);
        print("A�PB���Z��:" + d);

        Application.OpenURL("https://unity.com/");
    
    #endregion
    }
    public float hp = 70;

    private void Update()
    {
        hp = Mathf.Clamp(hp, 0, 100);     //�ƾ�.����(��,�̤p��,�̤j��) - �N��J���ȧ��b�̤p�̤j�d��
        print("��q:" + hp);

        #region �m���R�A�ݩʻP��k
        print("�O�_���U���N��:" + Input.anyKey);
        // print("�C���L�F�h�[:" + Time.time)

        // 3. �I�s�R�A��k
        bool space = Input.GetKeyDown("space");
        print("�O�_���U�ť���:" + space);
        #endregion
    }

}
