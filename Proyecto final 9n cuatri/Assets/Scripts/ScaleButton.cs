using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleButton : MonoBehaviour
{
    public GameObject botonClick;
    public float scaleIn = 1.1f;
    public float scaleOut = 1.0f;
    public float timeIn = 0.25f;
    public float timeOut = 0.5f;
    public float delay = 0.5f;
    public void TouchButton()
    {
        LeanTween.scale(botonClick, new Vector2(scaleIn, scaleIn), timeIn).setEase(LeanTweenType.easeOutBack);
        LeanTween.scale(botonClick, new Vector2(scaleOut, scaleOut), timeOut).setEase(LeanTweenType.easeOutBounce).setDelay(delay);

    }
}
