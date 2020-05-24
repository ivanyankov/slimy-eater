using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPanel : MonoBehaviour
{
    public GameObject GameObject;
    public InputField InputField;
    public Text WarningText;
    public string UsernameErrorMessage;
    private bool ValidUsername = false;

    public void HideStartPanel()
    {
        ValidateUsername();

        if (this.ValidUsername == true) {
            GameObject.SetActive(false);
        }
    }

    public void ValidateUsername()
    {
        if (InputField.text == "") {
            WarningText.text = UsernameErrorMessage;
            WarningText.gameObject.SetActive(true);
        } else {
            WarningText.gameObject.SetActive(false);
            this.ValidUsername = true;
        }
    }
}
