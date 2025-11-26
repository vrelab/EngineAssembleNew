using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions;

public class InfoManager : MonoBehaviour
{
    public TextMeshProUGUI Header;
    public TextMeshProUGUI BodyContent;

    // Ensure buttons are hooked up correctly in Unity
/*    public Button SOP;
    public Button Precaution;
    public Button Scenario;*/
    public Button Next;
    public Button Prev;
    public TextMeshProUGUI NextButtonText;
    public TextMeshProUGUI PrevButtonText;
    public bool IsNext;
    public bool IsPrev;

    public void UpdatePanel(string header, string bodyContent, string nextButtonText="Next",string prevButtonText="Prev",bool isNext=true,bool isPrev=true)
    {
        Header.text = header;
        BodyContent.text = bodyContent;
        NextButtonText.text = nextButtonText;
        PrevButtonText.text = prevButtonText;
        Next.gameObject.SetActive(isNext);
        Prev.gameObject.SetActive(isPrev);
    }
}
