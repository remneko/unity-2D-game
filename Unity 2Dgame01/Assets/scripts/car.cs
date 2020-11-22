
using UnityEngine;

public class car : MonoBehaviour
    {
    #region 練習欄位
    //單行註解:紀錄、筆記、說明、開發者名稱..
    //資料 =C# 欄位 (Field)
    //語法:
    //類型 名稱(指定 值);
    //4大基本類型:整數int、浮點數float、字串string、布林值bool 小數點後面必須加 f or F
    //私人(預設)private-不顯示在屬性面板上
    //公開      -顯示在屬性面板上

    public float HP = 1000;
    [Header("汽車CC數"), Tooltip("CC")]
    [Range(200,2000)]
    public int cc = 1000;
    [Header("汽車重量"), Range(1000, 2000)]
    public float weight = 1500;
    public string brand = "BMW";
    [Tooltip("勾選代表有天窗，無則沒有")]
    public bool havewindow = true;

    public Color red = Color.red;
    public Color white = Color.white;
    public Color mycolor = new Color(0, 0, 0);//新顏色

    //2~4維
    public Vector2 pos0 = Vector2.zero;
    public Vector2 pos1 = Vector2.one;
    public Vector2 pos2 = new Vector2(7,9);
    public Vector3 pos3 = Vector3.zero;
    public Vector4 pos4 = Vector4.zero;

    // 遊戲物件與元件 無須指定值
    public GameObject obj;
    public Transform trs;
    public SpriteRenderer spr;
    #endregion

    // 事件
    private void Start()
    {
        //輸出訊息(訊息) - 顯示在 Console面板上
        print("hallo World!");
        //呼叫方法
        Drive(1);
        shoot();
        shoot(3,500);
        shoot(7,900);
        shoot(5,100);

    }
       //事件
    private void Update()
    {
        print("我好帥");
        Drive(0.01f);
    }
    //方法:
    //定義程式區塊的語法
    //語法:
    //修飾詞 傳回類型 名稱 () {程式區塊}
    //參數類型 參數名稱
    //※有預設值的參數要放在最右邊
    //方法需要被呼叫才會進行
    private void Drive(float speed)
    {
        print("開車中...");
        transform.Translate(speed, 0, 0);
    }

    /// <summary>
    /// 發射子彈的功能
    /// </summary>
    /// <param name="count">發射弓箭</param>
    /// <param name="speed">弓箭速度</param>
    private void shoot(int count=1, int speed=300)
    {
        print("發射弓箭:" + count);
        print("弓箭速度:" + speed);

    }


}