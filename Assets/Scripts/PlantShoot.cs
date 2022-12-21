using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantShoot : Moving
{
    


    void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Zombie" || collision.transform.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
