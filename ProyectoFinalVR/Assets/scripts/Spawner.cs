using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject zombie;

    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(7,15);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            Instantiate(zombie, gameObject.transform);
            timer = Random.Range(7, 15);
        }
    }
}
