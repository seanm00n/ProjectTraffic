using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneTemplate;
using UnityEngine;

public class GAPI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = Resources.Load<GameObject>("path");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}