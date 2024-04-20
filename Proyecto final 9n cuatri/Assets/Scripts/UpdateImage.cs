using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateImage : MonoBehaviour
{
    public Image[] imageProfile;
    public Image imageButton;
  public void UpdateProfilePicture()
    {
        imageProfile[1].sprite = imageButton.sprite;
        imageProfile[0].sprite = imageButton.sprite;
    }
}
