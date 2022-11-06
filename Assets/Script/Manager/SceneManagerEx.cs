using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerEx
{
    // define�Ǿ��ִ� ���� �ε��� �� �ְ� ��
    public void LoadScene(Define.Scene scene)
    {
        SceneManager.LoadScene(GetSceneName(scene));
    }

    public void ReLoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public string GetSceneName(Define.Scene scene)
    {
        return System.Enum.GetName(typeof(Define.Scene), scene);
    }
}