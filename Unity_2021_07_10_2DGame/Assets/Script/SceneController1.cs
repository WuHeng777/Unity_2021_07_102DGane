using UnityEngine;
using UnityEngine.SceneManagement;   // �ޥ� �����޲z API

public class SceneController1 : MonoBehaviour
{
    // Unity ���s�p��P�}�����q
    // 1. ���}����k
    // 2. �ݭn���骫�󱾦��}��

    /// <summar>
    /// ���J�C������
    /// </summar>

    public void LoadGameScene()
    {
        // �����޲z,���J����(�����W��) - ���J���w������
        SceneManager.LoadScene("�C������");
    }

    /// <summary>
    /// ���}�C��
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();   // ���ε{��.���}() -�����C��
        print("���}�C��:");    // Quit �b�s�边�����|����
    }



}
