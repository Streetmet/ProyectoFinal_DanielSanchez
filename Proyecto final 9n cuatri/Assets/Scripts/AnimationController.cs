using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public GameObject tutorialPaneles;
    public GameObject panelTutorial;
    public GameObject profileImages;
    public GameObject buttonApplyImage;
    public GameObject[] botonesInicio;
    public GameObject ranking;
    public GameObject store;
    public GameObject game;
    public GameObject profilePic;
    public GameObject panelProfile;
    public GameObject username;
    public GameObject trans;
    public GameObject titulo;

    int posicion = 0;
    float delay = 0;
    void Start()
    {

        for (int i = 0; i < botonesInicio.Length; i++)
        {
            delay += 0.2f;
            LeanTween.moveX(botonesInicio[i].GetComponent<RectTransform>(), -263f, 1f).setEase(LeanTweenType.easeInOutBack).setDelay(delay);
            Debug.Log(i);
        }

        LeanTween.moveY(profilePic.GetComponent<RectTransform>(), 139.35f, 1.0f).setEase(LeanTweenType.easeInOutBack).setDelay(0.1f);

        LeanTween.moveY(username.GetComponent<RectTransform>(), 176f, 1.4f).setEase(LeanTweenType.easeInOutBack).setDelay(0.1f);

        LeanTween.moveY(titulo.GetComponent<RectTransform>(), -110.5f, 1.2f).setEase(LeanTweenType.easeInOutBack).setDelay(0.1f);

    }



    public void TutorialNext()
    {
        if (posicion == 0)
        {
            LeanTween.moveX(tutorialPaneles.GetComponent<RectTransform>(), -3, 0.7f).setEase(LeanTweenType.easeOutQuint).setDelay(0.1f);
            posicion++;
        }
        else if(posicion == 1)
        {
            LeanTween.moveX(tutorialPaneles.GetComponent<RectTransform>(), -755, 0.7f).setEase(LeanTweenType.easeOutQuint).setDelay(0.1f);
            posicion++;
        }
        else if(posicion >= 2)  
                {
            LeanTween.moveX(tutorialPaneles.GetComponent<RectTransform>(), 748.5f, 1.0f).setEase(LeanTweenType.easeInOutBack).setDelay(0.1f);
            posicion = 0;
            
        }

    }



    public void ExitTutorial()
    {
        LeanTween.moveY(tutorialPaneles.GetComponent<RectTransform>(), 500, 1.0f).setEase(LeanTweenType.easeInOutBack).setDelay(0.1f);
        LeanTween.moveY(panelTutorial.GetComponent<RectTransform>(), 500, 1.0f).setEase(LeanTweenType.easeInOutBack).setDelay(0.6f);
    }

    public void EnterTutorial()
    {
        LeanTween.moveY(tutorialPaneles.GetComponent<RectTransform>(), 0, 1.0f).setEase(LeanTweenType.easeInOutBack).setDelay(0.6f);
        LeanTween.moveY(panelTutorial.GetComponent<RectTransform>(), 0, 1.0f).setEase(LeanTweenType.easeInOutBack).setDelay(0.1f);
    }
   

    public void EnterProfileImages()
    {
        LeanTween.moveX(profileImages.GetComponent<RectTransform>(),-147.5f, 0.6f).setEase(LeanTweenType.easeInOutCirc).setDelay(0.1f);
    }
    public void ExitProfileImages()
    {
        LeanTween.moveX(profileImages.GetComponent<RectTransform>(), -800f, 1f).setEase(LeanTweenType.easeOutExpo).setDelay(0.1f);
    }

    public void EnterButtonApplyImage()
    {
        LeanTween.moveY(buttonApplyImage.GetComponent<RectTransform>(), -158f, 0.5f).setEase(LeanTweenType.easeOutExpo).setDelay(0.1f);
    }
    public void ExitButtonApplyImage()
    {
        LeanTween.moveY(buttonApplyImage.GetComponent<RectTransform>(), -321f, 0.5f).setEase(LeanTweenType.easeInOutCirc).setDelay(0.2f);
    }

    public void ExitRanking()
    {
        LeanTween.moveX(ranking.GetComponent<RectTransform>(), 870f, 1f).setEase(LeanTweenType.easeOutQuart).setDelay(0.1f);
    }
    public void EnterRanking()
    {
        LeanTween.moveX(ranking.GetComponent<RectTransform>(), 0f, 0.7f).setEase(LeanTweenType.easeOutQuart).setDelay(0.1f);
    }


    public void ExitPanelProfile()
    {
        LeanTween.moveX(panelProfile.GetComponent<RectTransform>(), 1640f, 1.2f).setEase(LeanTweenType.easeInOutBack).setDelay(0.1f);
    }
    public void EnterPanelProfile()
    {
        LeanTween.moveX(panelProfile.GetComponent<RectTransform>(), 0f, 0.6f).setEase(LeanTweenType.easeOutCirc).setDelay(0.1f);
    }

    public void ExitStore()
    {
        LeanTween.moveY(store.GetComponent<RectTransform>(), -550f, 1f).setEase(LeanTweenType.easeOutQuint).setDelay(0.1f);
    }

    public void EnterStore()
    {
        LeanTween.moveY(store.GetComponent<RectTransform>(), 0f, 1f).setEase(LeanTweenType.easeOutBounce).setDelay(0.1f);
    }


    public void ExitGame()
    {
        LeanTween.moveY(game.GetComponent<RectTransform>(), 550f, 1f).setEase(LeanTweenType.easeInOutBack).setDelay(0.1f);
    }

    public void EnterGame()
    {
        LeanTween.moveY(game.GetComponent<RectTransform>(), 0f, 1f).setEase(LeanTweenType.easeInOutBack).setDelay(0.1f);
    }

    public void Transition()
    {
        LeanTween.moveX(trans.GetComponent<RectTransform>(), -0, 1.1f).setEase(LeanTweenType.easeInOutExpo).setDelay(0.1f);
    }

}
