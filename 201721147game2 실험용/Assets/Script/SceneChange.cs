using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void SceneChangeBtn()
    {
        SceneManager.LoadScene("stage1");
    }
}
