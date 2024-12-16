using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraColorController : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Color[] colors;
    private int ColorIndex;
    [SerializeField] private float lerpValue;

    [SerializeField] private float time;
    private float CurrentTime;
   
    void Update()
    {
        ChangCameraColorSmooth();
        SetColorChangeTime();
    }

    private void ChangCameraColorSmooth(){
        mainCamera.backgroundColor = Color.Lerp(mainCamera.backgroundColor,colors[ColorIndex],lerpValue * Time.deltaTime);
    }

    private void SetColorChangeTime(){
        if(CurrentTime <= 0 ){
            IncreaseColorIndexValue();
            CheckColorIndexValue();
            CurrentTime = time;
        }else{
            CurrentTime -= Time.deltaTime;
        }     
    }
    private void IncreaseColorIndexValue(){
        ColorIndex++;  
    }

    private void CheckColorIndexValue(){
        if(ColorIndex >= colors.Length){
            ColorIndex = 0;
        }
    }
    private void OnDestroy(){
        mainCamera.backgroundColor = colors[1];
    }
}
