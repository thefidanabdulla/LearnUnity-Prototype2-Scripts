using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private Image foregroundImage;

    private void Awake()
    {
    }

    private void Update()
    {
        foregroundImage.fillAmount =  GetComponentInParent<Health>().healthPercentValue;
        
    }

}
