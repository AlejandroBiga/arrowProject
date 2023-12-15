using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BowScript : MonoBehaviour
{
    public Slider BowSlider;
    public Transform Bow;
    public Slider BaseSlider;

    public TextMeshProUGUI xText;
    public TextMeshProUGUI yText;
    void Update()
    {
        float BowRotate = BowSlider.value;
        float BowRotation = BaseSlider.value;
        Bow.rotation = Quaternion.Euler(BowRotate, BowRotation, 0f);

        xText.text = "" + BowSlider.value;
        yText.text = "" + BaseSlider.value;
    }
}
