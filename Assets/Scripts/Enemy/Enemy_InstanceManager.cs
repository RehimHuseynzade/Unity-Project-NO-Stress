using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy_InstanceManager : MonoBehaviour
{
    private List<Vector3> _vector3PosLI = new List<Vector3>()
    {
        new Vector3(0,3.3f,20),
        new Vector3(-1.2f,3.8f,20),
        new Vector3(1.13f,3.3f,20),
        new Vector3(0,0.7f,20),
        new Vector3(-1.4f,0.7f,20),
        new Vector3(1.35f,0.7f,20),
        new Vector3(0,-3.3f,20),
        new Vector3(-1.6f,-3.3f,20),
        new Vector3(1.6f,-3.3f,20),
    };
    private List<GameObject> _objects= new List<GameObject>();
    [SerializeField] private List<GameObject> _prefabs = new List<GameObject>();
    [SerializeField] private float _instanceTimer;
    private GameObject _randomPrefab;
    private int _randomIndex;
    private Vector3 _randomVector3;
    public int PrefabNumber=1;
    private void OnEnable()
    {
        InvokeRepeating(nameof(Enemy_Instance), 0f, _instanceTimer);
    }

    private void Update()
    {
        for (int i =0; i < _objects.Count; i++)
        {
            if (_objects[i].transform.position.z <= -4.5)
            {
                Destroy(_objects[i]);
                _objects.RemoveAt(i);
            }
        }
    }

    public void GameoverMethod()
    {
            foreach (GameObject obj in _objects)
            {
                Destroy(obj);
            }
            _objects.Clear();
            gameObject.SetActive(false);
    }

    private void Enemy_Instance()
    {
            _randomVector3 = _vector3PosLI[_randomIndex = Random.Range(0, 9)];
        _randomPrefab = _prefabs[Random.Range(0,PrefabNumber)];
            GameObject _object=Instantiate
                (_randomPrefab,
                _randomVector3,
                _randomPrefab.transform.rotation);
        _objects.Add(_object);
        
    } 

    private void OnDisable()
    {
        CancelInvoke(nameof(Enemy_Instance));
    }
}
