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

    int _carMaxIdx = 20;
    public int score = 0;
    Transform Cars;

    UI_Game gameUI;

    UI_Finish finishUI;

    override protected void Init()
    {
        base.Init();

        GameManager.Input.MouseAction -= OnMouseEvent;
        GameManager.Input.MouseAction += OnMouseEvent;

        GameManager.Input.KeyAction -= OnKeyEvenet;
        GameManager.Input.KeyAction += OnKeyEvenet;

        SceneType = Define.Scene.Stage1;

        gameUI = GameManager.UI.ShowSceneUI<UI_Game>();

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
        if (_target != null && _target.moving)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                _target.transform.Translate(Vector2.up * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow))
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
            { 7, Define.Lain.First },
            { 8, Define.Lain.None },
            { 9, Define.Lain.First },
            { 10, Define.Lain.None },
            { 11, Define.Lain.None },
            { 12, Define.Lain.Third },
            { 13, Define.Lain.None },
            { 14, Define.Lain.None },
            { 15, Define.Lain.Seceond },
            { 16, Define.Lain.None },
            { 17, Define.Lain.Third },
            { 18, Define.Lain.None },
            { 19, Define.Lain.Third },
            { 20, Define.Lain.None },
            { 21, Define.Lain.First },
            { 22, Define.Lain.None },
            { 23, Define.Lain.Seceond },
            { 24, Define.Lain.None },
            { 25, Define.Lain.None },
            { 26, Define.Lain.Third },
            { 27, Define.Lain.None },
            { 28, Define.Lain.Third },
            { 29, Define.Lain.None },
            { 30, Define.Lain.None },
            { 31, Define.Lain.Third },
            { 32, Define.Lain.None },
            { 33, Define.Lain.Seceond },
            { 34, Define.Lain.None },
            { 35, Define.Lain.None },
            { 36, Define.Lain.Seceond },
            { 37, Define.Lain.None },
            { 38, Define.Lain.None },
            { 39, Define.Lain.Third },
            { 40, Define.Lain.None },
            { 41, Define.Lain.Third },
            { 42, Define.Lain.None },
            { 43, Define.Lain.Third },
            { 44, Define.Lain.None },
            { 45, Define.Lain.None },
            { 46, Define.Lain.Seceond },
            { 47, Define.Lain.None },
            { 48, Define.Lain.Seceond },
        };
    }

    void BindInformation()
    {
        carDir = new Queue<Define.CarDir>();
        carDir.Enqueue(Define.CarDir.Left);
        carDir.Enqueue(Define.CarDir.Left);
        carDir.Enqueue(Define.CarDir.Right);
        carDir.Enqueue(Define.CarDir.Straight);
        carDir.Enqueue(Define.CarDir.Left);
        carDir.Enqueue(Define.CarDir.Straight);
        carDir.Enqueue(Define.CarDir.Straight);
        carDir.Enqueue(Define.CarDir.Left);
        carDir.Enqueue(Define.CarDir.Straight);
        carDir.Enqueue(Define.CarDir.Right);
        carDir.Enqueue(Define.CarDir.Straight);
        carDir.Enqueue(Define.CarDir.Right);
        carDir.Enqueue(Define.CarDir.Left);
        carDir.Enqueue(Define.CarDir.Left);
        carDir.Enqueue(Define.CarDir.Straight);
        carDir.Enqueue(Define.CarDir.Straight);
        carDir.Enqueue(Define.CarDir.Right);
        carDir.Enqueue(Define.CarDir.Left);
        carDir.Enqueue(Define.CarDir.Left);
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
                    SpawnCar(1);
                    break;
                case Define.Lain.Seceond:
                    SpawnCar(2);
                    break;
                case Define.Lain.Third:
                    SpawnCar(3);
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
                finishUI = GameManager.UI.ShowPopupUI<UI_Finish>();
                CheckScore();
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
            case 3:
                go.transform.position = SpawnPoint3.position;
                break;
        }

        go.GetOrAddComponent<Car>().SetDir(carDir.Dequeue());
        go.transform.parent = Cars.transform;
    }

    void CheckScore()
    {
        Debug.DrawRay(SpawnPoint1.position, Vector2.right);
        Debug.DrawRay(SpawnPoint2.position, Vector2.right);
        RaycastHit2D[] hits1 = Physics2D.RaycastAll(SpawnPoint1.position, Vector2.right, 20f);
        RaycastHit2D[] hits2 = Physics2D.RaycastAll(SpawnPoint2.position, Vector2.right, 20f);
        for (int i = 0; i < hits1.Length; i++)
        {
            if (hits1[i].collider.name == "Car(Clone)")
            {
                if (hits1[i].transform.GetComponent<Car>().carDir == Define.CarDir.Left)
                    score++;
            }
        }
        for (int i = 0; i < hits2.Length; i++)
        {
            if (hits2[i].collider.name == "Car(Clone)")
            {
                if (hits2[i].transform.GetComponent<Car>().carDir == Define.CarDir.Right)
                    score++;
            }
        }
    }
}

