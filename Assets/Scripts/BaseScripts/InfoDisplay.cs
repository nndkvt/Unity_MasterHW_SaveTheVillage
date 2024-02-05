using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoDisplay : MonoBehaviour
{
    [SerializeField] protected Text _infoText;

    public virtual void DisplayInfo()
    {
        _infoText.text = "Info is displayed";
    }
}
