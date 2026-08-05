using UnityEngine;
using UnityEngine.UI;
public class UIScript : MonoBehaviour
{
    public GameObject imageField;
    public Sprite[] sprites;
    public GameObject sizeSlider;
    public GameObject rotationSlider;

    public void ChangeImage(int ix)
    {
        imageField.GetComponent<Image>().sprite = sprites[ix];

    }

    public void ChangeSize()
    {
        float currentSize = sizeSlider.GetComponent<Slider>().value;
        imageField.GetComponent<RectTransform>().localScale = new Vector2(1f * currentSize, 1f * currentSize);
    }

    public void ChangeRotation()
    {
        float currentRotation = rotationSlider.GetComponent<Slider>().value;
        imageField.GetComponent<RectTransform>().localRotation = Quaternion.Euler(0, 0, currentRotation * 360);
    }
}
