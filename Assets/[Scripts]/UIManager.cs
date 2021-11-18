using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("On Screen Controls")]
    public GameObject onScreenControls;
    [Header("Button Control Event")]
    public static bool jumpButtonDown;
    // Start is called before the first frame update
    void Start()
    {
        CheckPlatform();
    }

    private void CheckPlatform()
    {
        switch(Application.platform)
        {
            case RuntimePlatform.Android:
            case RuntimePlatform.IPhonePlayer:
            case RuntimePlatform.WindowsEditor:
                onScreenControls.SetActive(true);
                break;
            default:
                onScreenControls.SetActive(false);
                break;
        }
    }

    public void OnJumpButtonDown()
    {
        jumpButtonDown = true;
    }

    public void OnJumpButtonUp()
    {
        jumpButtonDown = false;
    }
}
