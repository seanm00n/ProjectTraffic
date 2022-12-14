using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2 : BaseScene
{
    [SerializeField]
    Transform SpawnPoint1;
    [SerializeField]
    Transform SpawnPoint2;
    [SerializeField]
    Transform SpawnPoint3;

    Dictionary<int, Define.Lain> spawnPoint;
    Queue<Define.CarDir> carDir;

    Car _target = null;

    int _carMaxIdx = 8;

    Transform Cars;

    override protected void Init()
    {
        base.Init();

        GameManager.Input.MouseAction -= OnMouseEvent;
        GameManager.Input.MouseAction += OnMouseEvent;

        GameManager.Input.KeyAction -= OnKeyEvenet;
        GameManager.Input.KeyAction += OnKeyEvenet;

        SceneType = Define.Scene.Stage2;

        GameManager.UI.ShowSceneUI<UI_Game>();

        BindSpawnPoint();
        BindInformation();

        Cars = GameObject.Find("@Cars").transform;

        StartCoroutine(Spawn());
    }

    // 마우스
    void OnMouseEvent(Define.clickEvent evt)
    {
        Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);

        if (hit.collider == null)
        {
            _target = null;
        }
        else
        {
            _target = hit.collider.gameObject.GetOrAddComponent<Car>();
        }
    }

    // 키보드
    void OnKeyEvenet()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // 위
            if (_target != null && _target.moving)
            {
                _target.transform.Translate(Vector2.up * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // 아래
            if (_target != null && _target.moving)
            {
                _target.transform.Translate(Vector2.down * Time.deltaTime);
            }

        }
    }


    void BindSpawnPoint()
    {
        spawnPoint = new Dictionary<int, Define.Lain>()
        {
            { 1, Define.Lain.Seceond },
            { 2, Define.Lain.None },
            { 3, Define.Lain.None },
            { 4, Define.Lain.None },
            { 5, Define.Lain.Third },
            { 6, Define.Lain.None },
            { 7, Define.Lain.None },
            { 8, Define.Lain.None },
            { 9, Define.Lain.None },
            { 10, Define.Lain.None },
            { 11, Define.Lain.None },
            { 12, Define.Lain.None },
            { 13, Define.Lain.None },
            { 14, Define.Lain.None },
            { 15, Define.Lain.None },
            { 16, Define.Lain.None },
            { 17, Define.Lain.None },
            { 18, Define.Lain.None },
            { 19, Define.Lain.None },
            { 20, Define.Lain.None },
            { 21, Define.Lain.None },
            { 22, Define.Lain.None },
            { 23, Define.Lain.None },
            { 24, Define.Lain.Seceond },
            { 25, Define.Lain.None },
            { 26, Define.Lain.None },
            { 27, Define.Lain.First },
            { 28, Define.Lain.Seceond },
            { 29, Define.Lain.None },
            { 30, Define.Lain.None },
            { 31, Define.Lain.None },
            { 32, Define.Lain.None },
            { 33, Define.Lain.None },
            { 34, Define.Lain.None },
            { 35, Define.Lain.None },
            { 36, Define.Lain.None },
            { 37, Define.Lain.None },
            { 38, Define.Lain.None },
            { 39, Define.Lain.None },
            { 40, Define.Lain.None },
            { 41, Define.Lain.None },
            { 42, Define.Lain.None },
            { 43, Define.Lain.None },
        };
    }

    void BindInformation()
    {
        carDir = new Queue<Define.CarDir>();
        carDir.Enqueue(Define.CarDir.Straight);
        carDir.Enqueue(Define.CarDir.Left);
        carDir.Enqueue(Define.CarDir.Straight);
        carDir.Enqueue(Define.CarDir.Right);
        carDir.Enqueue(Define.CarDir.Left);
        carDir.Enqueue(Define.CarDir.Left);
        carDir.Enqueue(Define.CarDir.Straight);
        carDir.Enqueue(Define.CarDir.Right);
    }

    IEnumerator Spawn()
    {
        for (int i = 1; i <= spawnPoint.Count; i++)
        {
            switch (spawnPoint[i])
            {
                case Define.Lain.None:
                    break;
                case Define.Lain.First:
                    {
                        SpawnCar(1);
                    }
                    break;
                case Define.Lain.Seceond:
                    {
                        SpawnCar(2);
                    }
                    break;
            }

            if (Cars.childCount == _carMaxIdx)
            {
                StartCoroutine(FinishCheck());
                StopCoroutine(Spawn());
            }
            yield return new WaitForSeconds(1.5f);
        }
    }

    IEnumerator FinishCheck()
    {
        while (true)
        {
            bool GameFinish = false;
            for (int j = 0; j < Cars.childCount; ++j)
            {
                Car car = Cars.GetChild(j).GetComponent<Car>();
                GameFinish = car.moving;
            }

            if (!GameFinish)
            {
                GameManager.UI.ShowPopupUI<UI_Finish>();
                StopAllCoroutines();
            }

            yield return new WaitForSeconds(.5f);
        }
    }

    void SpawnCar(int _lain)
    {
        GameObject go = GameManager.Resource.Instantiate("Object/Car");

        switch (_lain)
        {
            case 1:
                go.transform.position = SpawnPoint1.position;
                break;
            case 2:
                go.transform.position = SpawnPoint2.position;
                break;
        }

        go.GetOrAddComponent<Car>().SetDir(carDir.Dequeue());
        go.transform.parent = Cars.transform;
    }
}

