using TMPro;
using UnityEngine;

public class ScrollScript : MonoBehaviour
{
    public GameObject motorbiker;
    public GameObject lost;

    public TMP_Text description;

    public void ChangeCharacter(int index)
    {
        motorbiker.SetActive(false);
        lost.SetActive(false);

        if (index == 0)
        {
            motorbiker.SetActive(true);
            description.text = "A: Motociklists, kurð ar jaudu panâk visu.";
        }

        if (index == 1)
        {
            lost.SetActive(true);
            description.text = "B: Vîrietis, kurð ir pazudis uz nezinâmas salas.";
        }
    }
}