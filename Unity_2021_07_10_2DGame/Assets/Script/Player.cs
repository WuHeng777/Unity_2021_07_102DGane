using UnityEngine;

public class Player : MonoBehaviour
{
    #region ���
    [Header("���ʳt��"), Range(0, 1000)]
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
    #endregion
}
