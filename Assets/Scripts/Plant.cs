using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : Moving
{
    public GameObject[] bullet;
    int random;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        Timer += Time.deltaTime;
        random = Random.Range(0, bullet.Length);
        if(Timer > 5)
        {
            Instantiate(bullet[random], transform.position, bullet[random].transform.rotation) ;
            Timer = 0;
        }
        
    }

}
