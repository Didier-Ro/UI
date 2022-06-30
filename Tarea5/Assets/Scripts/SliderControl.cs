using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    [SerializeField] private Image[] _images = new Image[3];
    [SerializeField] private Slider[] _redSliders = new Slider[3];
    [SerializeField] private Slider[] _greenSliders = new Slider[3];
    [SerializeField] private Slider[] _blueSliders = new Slider[3];

    // Update is called once per frame
    public void OnEditImage1()
    {
        _images[0].color = new Color(_redSliders[0].value, _blueSliders[0].value, _greenSliders[0].value, 1);
    }

    public void OnEditImage2()
    {
        _images[1].color = new Color(_redSliders[1].value, _blueSliders[1].value, _greenSliders[1].value, 1);
    }

    public void OnEditImage3()
    {
        _images[2].color = new Color(_redSliders[2].value, _blueSliders[2].value, _greenSliders[2].value, 1);
    }
}
