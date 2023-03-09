using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    private float chestMaxPosY = 3f;
    private float chestMinPosY = 2f;
    private bool floatDown = false;
    //private float chestMove = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= chestMinPosY){
            floatDown = false;
        }
        else if (transform.position.y >= chestMaxPosY){
            floatDown = true;
        }

        if(floatDown){
            transform.position -= Vector3.up * Time.deltaTime;
        }
        else{
            transform.position += Vector3.up * Time.deltaTime;
        }
    }
}
