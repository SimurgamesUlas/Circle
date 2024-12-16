using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRotationController : MonoBehaviour
{
    [SerializeField] private float rotationValue;
    private float randomRotation;
    void Start()
    {
        GenerateRandomRotationValue();
        setLineRotation();   
    }

    
    private void GenerateRandomRotationValue(){
        randomRotation = Random.Range(-rotationValue,rotationValue);
    }

    private void setLineRotation(){
        transform.rotation = Quaternion.Euler(0f,0f,randomRotation);
    }
}
