using TMPro;
using UnityEngine;

public class TextScript : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_InputField yearInput;
    public TMP_Text outputField;

    public void GetText()
    {
        string name = nameInput.text;
        int birthYear;

        if (int.TryParse(yearInput.text, out birthYear))
        {
            int age = System.DateTime.Now.Year - birthYear;

            outputField.text = "Varonis " + name + " ir " + age + " gadus vecs!";
        }
    }
}