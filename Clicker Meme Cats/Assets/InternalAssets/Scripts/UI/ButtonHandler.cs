using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public void OpenAndCloseUIPanel(GameObject panel)
    {
        panel.SetActive(!panel.activeInHierarchy);
    }
}
