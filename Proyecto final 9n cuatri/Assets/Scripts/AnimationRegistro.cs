using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationRegistro : MonoBehaviour
{
    public GameObject panelRegistro;
    public GameObject panelDev;
    public GameObject trans;



    public void Start()
    {
        LeanTween.moveX(trans.GetComponent<RectTransform>(), -1000f, 1.5f).setEase(LeanTweenType.easeInOutExpo).setDelay(0.5f);
    }


    public void EnterPanelRegistro()
    {
        LeanTween.moveX(panelRegistro.GetComponent<RectTransform>(), 0f, 0.7f).setEase(LeanTweenType.easeOutBack).setDelay(0.1f);
    }

    public void ExitPanelRegistro()
    {
        LeanTween.moveX(panelRegistro.GetComponent<RectTransform>(), 1100f, 0.8f).setEase(LeanTweenType.easeInOutBack).setDelay(0.1f);
    }

    public void EnterPanelDev()
    {
        LeanTween.moveY(panelDev.GetComponent<RectTransform>(), 0f, 0.8f).setEase(LeanTweenType.easeOutExpo).setDelay(0.1f);
    }

    public void ExitPanelDev()
    {
        LeanTween.moveY(panelDev.GetComponent<RectTransform>(), 600f, 0.8f).setEase(LeanTweenType.easeInOutBack).setDelay(0.1f);
    }

}
