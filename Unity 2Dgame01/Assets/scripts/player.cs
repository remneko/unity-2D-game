
using UnityEngine;

public class player : MonoBehaviour
{
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 10.5f;
    [Header("跳躍高度"), Range(0, 3000)]
    public float jump = 100;
    [Header("是否在地板上"), Tooltip("是否在地板上")]
    public bool floor = false;
    [Header("子彈"), Tooltip("存放生成子彈預製物")]
    public GameObject bullet;
    [Header("子彈生成點"), Tooltip("子彈生成點空物件")]
    public Transform bulletbirth;
    [Header("子彈速度"), Range(0, 5000)]
    public int bulletspeed = 800;
    [Header("開槍音效"), Tooltip("開槍音效")]
    public  AudioClip soundfire;
    [Header("生命數量"), Range(0, 10)]
    public int life;
    private int score = 0;
    private AudioSource aud;
    private Rigidbody2D Rig;
    private Animator ani;
    private void Update()
    {
        Move();
    }
    /// <summary>
    /// 移動功能
    /// </summary>
    private void Move() 
    {

        float h = Input.GetAxis("Horizontal");
        //鋼體 的 加速度 = 新 2維向量()
        Rig.velocity = new Vector2(h * speed, Rig.velocity.y);
    }
    /// <summary>
    /// 跳躍功能
    /// </summary>
    private void Jump() 
    {
    
    }
    /// <summary>
    /// 射擊功能
    /// </summary>
    private void fire()
    { 
    
    }/// <summary>
     /// 死亡
     /// </summary>
     /// <param name="obj">死亡達成的物件</param>
    private void death(string obj)
    { 
    
    }

}
