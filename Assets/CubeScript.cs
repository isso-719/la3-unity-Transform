using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    float i = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, i);
        transform.Rotate(new Vector3(1, 1, 1));
        transform.localScale += new Vector3(i, i, i);
    }
}
