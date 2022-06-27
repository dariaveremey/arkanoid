using UnityEngine;

public class SingletonMonoBehavior<T>:MonoBehaviour
{
    public static T Instance { get; private set; }

    protected virtual void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = GetComponent<T>();
        DontDestroyOnLoad(gameObject);
    }
}