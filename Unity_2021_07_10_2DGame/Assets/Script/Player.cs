using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"), Range(0, 100)]
    public float speed = 10.5f;
    [Header("跳躍高度"), Range(0, 3000)]
    public int jump = 100;
    [Header("血量"), Range(0, 200)]
    public float hp = 100;
    [Header("是否在地板上"), Tooltip("用來儲存角色是否在地板上的資訊.在地板上 true.不在地板上 false")]
    public bool isGround;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;
    /// <summary>
    /// 玩家水平輸入值
    /// </summary>
    private float hValue;
    #endregion


    #region 事件
    private void Start()
    {
        // GetComponent<類型>()泛型方法，可以指定任何類型
        // 作用 : 取得此物件的 2D 剛體元件
        rig = GetComponent<Rigidbody2D>();
    }
    // 一秒約執行 60 次
    private void Update()
    {
        GetPlayInputHorizontal();
        TurnDirection();
    }

    // 固定更新事件
    // 一秒固定執行 50 次，官方建議有使用到物理 API 要在此事件內執行
    private void FixedUpdate()
    {
        Move(hValue);  
    }
    #endregion

    #region 方法

    /// <summary>
    /// 取得玩家輸入水平軸向值 : A 、 D 、左、右 
    /// </summary>
    private void GetPlayInputHorizontal()
    {
        // 水平值 = 輸入.取得軸向值(軸向名稱)
        // 作用 : 取得玩家按下水平按鍵的值，按右為 1、按左為 -1、沒按為 0
        hValue = Input.GetAxis("Horizontal");
        // print("玩家水平值:" + hValue);
    }

    [Header("重力"), Range(0.1f, 10)]
    public float gravity = 1;

    /// <summary>
    /// 移動
    /// </summary>
    /// <param name="horizomtal">左右數值</param>
    private void Move(float horizomtal)
    {
        // 區域變數 : 在方法內的欄位，有區域性，僅限於此方法內存取
        // 簡寫 : transform 此物件的 Transform 變形元件
        // posMove = 腳色當前座標 + 玩家輸入的水平值
        Vector2 posMove = transform.position + new Vector3(horizomtal, -gravity, 0) * speed * Time.fixedDeltaTime;
        // 剛體，移動座鰾(要前往的座標)
        // Time.fixedDeltaTime 指 1/50 秒
        rig.MovePosition(posMove);

        print("玩家按右:" + Input.GetKeyDown(KeyCode.D));

    }

    /// <summary>
    /// 旋轉方向 :　處理腳色面向問題，按右角度 0，按左角度 180
    /// </summary>
    private void TurnDirection()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.eulerAngles = Vector3.zero;
        }
        // 如果玩家按 A 就將角度設定為 (0,180,0)
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

    }
    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        // 如果 玩家 按下 空白鍵 腳色就往上跳躍
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rig.AddForce(new Vector2(0, jump));
        }

    }
    /// <summary>
    /// 攻擊
    /// </summary>
    private void Attack()
    { 
    
    }
    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage">造成的傷害</param>
    private void Hurt(float damage)
    { 
    
    }
    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    { 
    
    }
    /// <summary>
    /// 吃道具
    /// </summary>
    /// <param name="propName">吃到的道具名稱</param>
    private void EatProp(string propName)
    { 
    
    }

    #endregion

  


}
