using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawning : MonoBehaviour
{
    public static ZombieSpawning instance;
    public GameObject[] Zombies;
    int random;

    public float[] Ylevels = new float[5];
    int random1;

    public float Timer;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        Ylevels[0] = 4.5f;
        Ylevels[1] = 2.7f;
        Ylevels[2] = 0.9f;
        Ylevels[3] = -1f;
        Ylevels[4] = -2.9f;
        Timer = 0;
    }

    // Update is called once per frame
     void Update()
    {
        Timer += Time.deltaTime;
        random = Random.Range(0, Zombies.Length);
        random1 = Random.Range(0, Ylevels.Length);
        ScoreManager.instance.WhileLoop();
    }
    public void Spawn()
    {
     Instantiate(Zombies[random], new Vector3(8.13f, Ylevels[random1],0), Zombies[random].transform.rotation);
    }

    public void TimeCheck()
    {
        if (Timer >= 5)
        {
            Spawn();
            Timer = 0;
            print(name);
        }
    }
}
