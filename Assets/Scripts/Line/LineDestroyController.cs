using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDestroyController : MonoBehaviour
{
    [SerializeField] private float endxValue;
 
    void Update()
    {
        CheckLinex();
    }
    private void CheckLinex(){
        if(transform.position.x <= endxValue){
            Destroy(gameObject);
        }
    }
}
