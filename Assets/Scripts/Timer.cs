using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _maxTime;
    [SerializeField] private UnityEvent _onTimerOverEvent;

    private Image _img;
    private float _currentTime;

    private void Start()
    {
        _img = GetComponent<Image>();
        _currentTime = 0;
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime > _maxTime)
        {
            _currentTime = 0;
            _onTimerOverEvent.Invoke();
        }

        _img.fillAmount = _currentTime / _maxTime;
    }
}
