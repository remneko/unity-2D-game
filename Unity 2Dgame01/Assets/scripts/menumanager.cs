
using UnityEngine;
using UnityEngine.SceneManagement; //引用 場景管理 API

public class menumanager : MonoBehaviour
{
    //開始遊戲
    public void StartGame()
    {
        // 場景管理 的 載入場景("場景名稱")
        SceneManager.LoadScene("關卡1");
    }

    //離開遊戲
    public void QuitGame()
    {
        //應用程式
        Application.Quit();
    }
}
