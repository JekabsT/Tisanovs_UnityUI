using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour
{
    public Toggle toggle;
    public GameObject[] clothes;

    void Start()
    {
        toggle.onValueChanged.AddListener(ChangeVisibility);
    }

    void ChangeVisibility(bool value)
    {
        foreach (GameObject item in clothes)
        {
            item.SetActive(value);
        }
    }
}