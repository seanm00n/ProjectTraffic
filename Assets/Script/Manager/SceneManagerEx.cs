using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerEx
{
    // define되어있는 씬만 로드할 수 있게 함
    public void LoadScene(Define.Scene scene)
    {
        SceneManager.LoadScene(GetSceneName(scene));
    }

    public string GetSceneName(Define.Scene scene)
    {
        return System.Enum.GetName(typeof(Define.Scene), scene);
    }
}