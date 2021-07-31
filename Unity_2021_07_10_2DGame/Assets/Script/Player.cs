using UnityEngine;

public class Player : MonoBehaviour
{
    #region ���
    [Header("���ʳt��"), Range(0, 100)]
    public float speed = 10.5f;
    [Header("���D����"), Range(0, 3000)]
    public int jump = 100;
    [Header("��q"), Range(0, 200)]
    public float hp = 100;
    [Header("�O�_�b�a�O�W"), Tooltip("�Ψ��x�s����O�_�b�a�O�W����T.�b�a�O�W true.���b�a�O�W false")]
    public bool isGround;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;
    /// <summary>
    /// ���a������J��
    /// </summary>
    private float hValue;
    #endregion


    #region �ƥ�
    private void Start()
    {
        // GetComponent<����>()�x����k�A�i�H���w��������
        // �@�� : ���o������ 2D ���餸��
        rig = GetComponent<Rigidbody2D>();
    }
    // �@������� 60 ��
    private void Update()
    {
        GetPlayInputHorizontal();
        TurnDirection();
    }

    // �T�w��s�ƥ�
    // �@��T�w���� 50 ���A�x���ĳ���ϥΨ쪫�z API �n�b���ƥ󤺰���
    private void FixedUpdate()
    {
        Move(hValue);  
    }
    #endregion

    #region ��k

    /// <summary>
    /// ���o���a��J�����b�V�� : A �B D �B���B�k 
    /// </summary>
    private void GetPlayInputHorizontal()
    {
        // ������ = ��J.���o�b�V��(�b�V�W��)
        // �@�� : ���o���a���U�������䪺�ȡA���k�� 1�B������ -1�B�S���� 0
        hValue = Input.GetAxis("Horizontal");
        // print("���a������:" + hValue);
    }

    [Header("���O"), Range(0.1f, 10)]
    public float gravity = 1;

    /// <summary>
    /// ����
    /// </summary>
    /// <param name="horizomtal">���k�ƭ�</param>
    private void Move(float horizomtal)
    {
        // �ϰ��ܼ� : �b��k�������A���ϰ�ʡA�ȭ��󦹤�k���s��
        // ²�g : transform ������ Transform �ܧΤ���
        // posMove = �}���e�y�� + ���a��J��������
        Vector2 posMove = transform.position + new Vector3(horizomtal, -gravity, 0) * speed * Time.fixedDeltaTime;
        // ����A���ʮy��(�n�e�����y��)
        // Time.fixedDeltaTime �� 1/50 ��
        rig.MovePosition(posMove);

        print("���a���k:" + Input.GetKeyDown(KeyCode.D));

    }

    /// <summary>
    /// �����V :�@�B�z�}�⭱�V���D�A���k���� 0�A�������� 180
    /// </summary>
    private void TurnDirection()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.eulerAngles = Vector3.zero;
        }
        // �p�G���a�� A �N�N���׳]�w�� (0,180,0)
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

    }
    /// <summary>
    /// ���D
    /// </summary>
    private void Jump()
    {
        // �p�G ���a ���U �ť��� �}��N���W���D
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rig.AddForce(new Vector2(0, jump));
        }

    }
    /// <summary>
    /// ����
    /// </summary>
    private void Attack()
    { 
    
    }
    /// <summary>
    /// ����
    /// </summary>
    /// <param name="damage">�y�����ˮ`</param>
    private void Hurt(float damage)
    { 
    
    }
    /// <summary>
    /// ���`
    /// </summary>
    private void Dead()
    { 
    
    }
    /// <summary>
    /// �Y�D��
    /// </summary>
    /// <param name="propName">�Y�쪺�D��W��</param>
    private void EatProp(string propName)
    { 
    
    }

    #endregion

  


}
