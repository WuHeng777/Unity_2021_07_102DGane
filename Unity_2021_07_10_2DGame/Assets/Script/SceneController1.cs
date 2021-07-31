using UnityEngine;
using UnityEngine.SceneManagement;   // �ޥ� �����޲z API

public class SceneController1 : MonoBehaviour
{
    // Unity �L�k���W�}������j��]
    // 1. �}����������L�C�A����@���C
    // 2. ���O�P�ɮצW�٤��P�C

    // Unity ���s�p��P�}�����q
    // 1. ���}����k
    // 2. �ݭn���骫�󱾦��}��
    // 3. ���s On Click �]�w�I���ƥ󬰦�����H�έn�I�s����k

    /// <summar>
    /// ���J�C������
    /// </summar>

    public void LoadGameScene()
    {
        // ���ݨ��A���J����
        // ����I�s(��k�W�١A����ɶ�)
        // �@�� : ���ݫ��w�ɶ���A�I�s���w��k
        Invoke("DelayLoadGameScene", 2);
    }

    // ���ݤ@�q�ɦb�����k
    // Invoke ����I�s
    /// <summary>
    /// ������J����
    /// </summary>
    private void DelayLoadGameScene()
    {
        // �����޲z,���J����(�����W��) - ���J���w������
        SceneManager.LoadScene("�C������");
    }


    /// <summary>
    /// ���}�C��
    /// </summary>
    public void QuitGame()
    {
        Invoke("DelayQuitGame", 2);
    }

    /// <summary>
    /// �������}�C��
    /// </summary>
    private void DelayQuitGame()
    {
        Application.Quit();   // ���ε{��.���}() -�����C��
        print("���}�C��:");    // Quit �b�s�边�����|����
    }

}
