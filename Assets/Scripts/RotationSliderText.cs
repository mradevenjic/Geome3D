using UnityEngine;
using UnityEngine.UI;

public class RotationSliderText : MonoBehaviour {

    public Text slText;
    public Slider slider;

    private float textValue;

    void Start()
    {
        textValue = slider.value * 5;
        slText.text = textValue.ToString();
    }


    void Update()
    {
        textValue = slider.value * 5;
        slText.text = textValue.ToString();
    }
}
