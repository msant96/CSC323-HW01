using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
    public GameObject myObject;
    public Vector3 spawnvec;
    public double Timer;
    public float spawnnumber;

    void Awake()
    {
        Timer = Time.time + .1;
    }

    void Update()
    {
        spawnvec = new Vector3(Random.Range(40f, 60f), 40, Random.Range(40f, 60f));
        if (Timer < Time.time)
        {
            Instantiate(myObject, spawnvec, Quaternion.Euler(0f,0f,0f));
            Timer = Time.time + .1;
        }
    }
}

