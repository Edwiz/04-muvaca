using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetTimer : MonoBehaviour
{
    public static ResetTimer instance;
    public int resetAfterSeconds;

    private float timer;

    private void Awake()
    {
        timer = 0f;

        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        timer = 0f;
    }

    private void Update()
    {

        if (Input.anyKeyDown)
        {
            timer = 0f;
        }
        else
        {
            timer += Time.deltaTime;
        }

        if (timer >= resetAfterSeconds)
        {
            timer = 0f;
            SceneManager.LoadScene(0);
        }

        Debug.Log(timer);
    }

}
