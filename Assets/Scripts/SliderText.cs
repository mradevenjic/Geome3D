using UnityEngine;
using UnityEngine.UI;

public class SliderText : MonoBehaviour {

    public Text slText;
    public Slider slider;
    
    void Start ()
    {

        slText.text = slider.value.ToString();
    }
	
	
	void Update ()
    {
        slText.text = slider.value.ToString();
    }
}
