using UnityEngine;
using UnityEngine.UI;

public class PositionSliderText : MonoBehaviour {

    public Text slText;
    public Slider slider;

    private float textValue;

    void Start()
    {
        textValue = slider.value / 2;
        slText.text = textValue.ToString();
    }


    void Update()
    {
        textValue = slider.value / 2;
        slText.text = textValue.ToString();
    }
}
