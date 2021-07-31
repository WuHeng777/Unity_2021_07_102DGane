using UnityEngine;

public class APINoStatic : MonoBehaviour
{
    // API 文件、分文兩大類
    // 1. 靜  態 : 有關鍵字 static
    // 2. 非靜態 : 無關鍵字 static

    // 使用非靜態屬性 1. 先定義此非靜態屬性的類別欄位
    // 使用非靜態屬性 3. 欄位必須放入要取的資訊的物件。不能為空值。
    public Transform traA;
    public Camera cam;
    public Transform traB;

    public Camera camA;
    public SpriteRenderer srA;
    public Transform traC;
    public Rigidbody2D rig;

    private void Start()
    {
        #region 認識非靜態屬性

        // 1. 取得非靜態屬性

        //print("取得座標:" + Transform); 錯誤需要有物件參考

        // 使用非靜態屬性 2.
        // 語法 : 欄位，非靜態屬性
        print("取得立方體座標:" + traA.position);
        print("取得攝影機的背景:" + cam.backgroundColor);

        // 2. 設定非靜態屬性
        // 語法 :　欄位，非靜態屬性　指定　值　；
        cam.backgroundColor = new Color(0.8f, 0.5f, 0.6f);

        // 3. 呼叫非靜態方法
        // 語法 : 欄位，非靜態方法(對應的引數);
        traB.Translate(1, 0, 0);
        #endregion

        #region 練習非靜態屬性
        // 1. 取得非靜態屬性
        print("攝影機深度:" + camA.depth);
        print("圖片1的顏色:" + srA.color);

        // 2. 設定非靜態屬性
        camA.backgroundColor = Random.ColorHSV();
        srA.flipY = true;
        #endregion
    }
    private void Update()
    {
            traC.Rotate(0, 0, 1);
            rig.AddForce(new Vector2(0, 10));
    }


}

