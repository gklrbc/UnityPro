using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour, IClickable
{
    [SerializeField] private GameObject _objectToActivate;


    public void OnClick()
    {
       _objectToActivate.SetActive(true);  
    }

    
}
