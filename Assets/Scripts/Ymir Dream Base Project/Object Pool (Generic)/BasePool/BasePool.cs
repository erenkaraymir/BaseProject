using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class BasePool<T> : SingletonDestroyMono<BasePool<T>> where T : MonoBehaviour
{
    private Stack<T> _pool;

    [SerializeField] private T _spawnPrefab;

    [SerializeField] private int _poolSize;

    [SerializeField] private bool _IsBaseParent;

    [SerializeField] private Transform _baseParentTransform;


    private void Start()
    {
        Initiliaze(_poolSize);
    }

    //Create Pool
    protected void Initiliaze(int poolSize)
    {
        Debug.Log("Total pool size : " + _poolSize);

        _pool = new Stack<T>();

        for (int i = 0; i < poolSize; i++)
        {
            AddObjectToPool(CreateNewObject());
        }
    }

    //Add Object On Stack
    public virtual void AddObjectToPool(T obj)
    {
        _pool.Push(obj);
        obj.gameObject.SetActive(false);
    }

    //For Setup & empty pool
    protected virtual T CreateNewObject()
    {
        T prefabClone = Instantiate(_spawnPrefab, Vector3.zero, _spawnPrefab.transform.rotation, transform);
        return prefabClone;
    }


    //Check if Pool Count 0
    //if 0 Add new object on pool
    //if not get object on stack and set active state

    protected virtual T GetObjectFromPool()
    {
        if (_pool.Count == 0)
        {
            AddObjectToPool(CreateNewObject());
        }

        T obj = _pool.Pop();
        obj.gameObject.SetActive(true);

        return obj;
    }


}
