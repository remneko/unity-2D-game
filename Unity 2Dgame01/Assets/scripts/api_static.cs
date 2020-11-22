
using UnityEngine;

public class api_static : MonoBehaviour
{
    
    private void Start()
    {
        //取得靜態屬性
        //類別名稱.靜態屬性名稱
        //數學的 拍
        print(Mathf.PI);
        //取得隨機的值
        print("隨機:" + Random.value);
        //取得靜態屬性
        //類別名稱.靜態屬性名稱
        //時間的時間大小 = 值
        Time.timeScale = 7f;
        //使用靜態方法
        int a = Mathf.Abs(-3333);
        print("絕對值後的值:" + a);
        //隨機範圍
        int b =Random.Range(0, 100);
        print("隨機範圍的值:" + b);
        int c = Camera.allCameras.Length;
        //取得 所有攝影機數量
        print("所有攝影機數量:" + c);
        //設定指標為隱藏
        Cursor.visible = false;

        //前往網站
        //Application.OpenURL("http://unity3d.com/");

        float number = Mathf.Floor(1.24566f);
        print("去小數點" + number);
            
            
    }
    private void Update()
    {
        //取得 是否輸入任意鍵
        print("是否按住任意鍵：" + Input.anyKey);

        //取得 遊戲經過時間
        //print("遊戲時間:" + Time.time);
        print("按下空白鍵:" + Input.GetKeyDown("space"));
       
    }

}
