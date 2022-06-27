using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        Vector3 vector1 = new Vector3(h,0,0);
        this.transform.position += vector1;

        float g = Input.GetAxis("Vertical");
        Vector3 vector2 = new Vector3(0, 0, g);
        this.transform.position += vector2;
    }

    void Awake()
    {
        
    }
}
