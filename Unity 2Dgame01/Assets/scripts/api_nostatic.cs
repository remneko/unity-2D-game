
using UnityEngine;

public class api_nostatic : MonoBehaviour
{
    public GameObject objA;
    public GameObject objB;
    public Transform TraA;
    public Transform TraB;

    public void Start()
    {
        //取得 非靜態 屬性
        //遊戲物件 A 的標籤
        print(objA.tag);
        print(objB.layer);
        print(TraA.localScale);
    }
    public void Update()
    {
        //
        //物件 的方法(參數)
        //
        TraB.Rotate(0, 0, 1);
    }
}
