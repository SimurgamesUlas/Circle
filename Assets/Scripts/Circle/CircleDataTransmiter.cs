using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDataTransmiter : MonoBehaviour
{
    [SerializeField] private CircleInputController  circleInputController;
    [SerializeField] private CircleScoreController circleScoreController;
    
    public bool  getIsTocuh(){
        return circleInputController.isTouch;

    }

    public void IncreaseScoreValue(){
        circleScoreController.IncreaseScoreValue();
    }
}
