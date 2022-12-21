using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public int Speed = 4;
    public float Timer;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    public virtual void Update()
    {
        transform.position += new Vector3(Speed, 0, 0) * Time.deltaTime;
    }
}
