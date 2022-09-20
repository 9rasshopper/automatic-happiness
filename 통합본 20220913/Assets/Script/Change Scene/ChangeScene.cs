using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{   

    public void LoadGame()
    {
       switch(SceneManager.GetActiveScene().buildIndex)
       {
        case 0:
            SceneManager.LoadScene("메인화면");
            break;
        case 1:
            SceneManager.LoadScene("스테이지1");
            break;
       }
    }
    
    
}