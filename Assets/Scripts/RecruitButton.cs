using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecruitButton : MonoBehaviour
{
    [SerializeField] private float _inactivityTime;

    private Button _button;
    private Image _buttonImg;
    private float _inactiveStartTime;

    private void Start()
    {
        _buttonImg = GetComponent<Image>();
        _button = GetComponent<Button>();
    }

    private void Update()
    {
        if (!_button.interactable)
        {
            _buttonImg.fillAmount = (Time.time - _inactiveStartTime) / _inactivityTime;

            if (Time.time - _inactiveStartTime > _inactivityTime)
            {
                _button.interactable = true;
            }
        }
    }

    public void SetInactive()
    {
        _button.interactable = false;
        _inactiveStartTime = Time.time;
    }
}
