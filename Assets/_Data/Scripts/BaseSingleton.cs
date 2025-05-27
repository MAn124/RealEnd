using UnityEngine;


public abstract class BaseSingleton<T> : BaseMonoBehaviour where T : BaseMonoBehaviour
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("Singleton has not been create yet!");
            }
            return _instance;
        }
    }

    protected override void Awake()
    {
        base.Awake();
        this.LoadInstance();

    }
    protected virtual void LoadInstance()
    {
        if (_instance == null)
        {
            _instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else if (_instance != this)
        {
            Debug.LogWarning($"[Singleton] Instance of {typeof(T).Name} already exists!");
        }
    }
}