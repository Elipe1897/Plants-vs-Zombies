using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Moving
{
   

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        Speed = -1;
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Plant1Fire" || collision.transform.tag == "Plant2Fire" || collision.transform.tag == "Plant3Fire")
        {
            Destroy(gameObject);
            ScoreManager.instance.AddPoint(10);
        }
    }
   
}