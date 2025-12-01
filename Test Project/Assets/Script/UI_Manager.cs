using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    [Header("UI Steps")]
    public GameObject[] UI_Text;

    [Header("Step Objects")]
    public GameObject[] VasarDown;
    public GameObject[] ChasLift;
    public GameObject[] Chas_Coll;
    public GameObject[] crank_coll;
    public GameObject[] VasarUp;
    public GameObject[] bar_Coll;
    public GameObject[] Screw_Coll;
    public GameObject[] PistonTop;
    public GameObject[] PistonBottom;

    [Header("Other Objects")]
    public GameObject crank_coll_Move;
    public GameObject crankarrow;

    [Header("UI Elements")]
    public Button StartButton;
    public GameObject WarningUI;

    private int num = 0; // Current step

/*    private void Start()
    {
        // Assign single listener
        StartButton.onClick.AddListener(OnStartButtonPressed);

        // Initialize first step
        //SetStep(1);
    }*/

    public void OnStartButtonPressed()
    {
        // Step-specific checks
        switch (num)
        {
            case 1:
                CheckStepObjectsAndProceed(VasarDown);
                break;
            case 2:
                CheckStepObjectsAndProceed(ChasLift);
                break;
            case 3:
                CheckStepObjectsAndProceed(Chas_Coll);
                break;
            case 7:
                CheckStepObjectsAndProceed(Screw_Coll);
                break;
            case 10:
                CheckStepObjectsAndProceed(PistonTop);
                break;
            case 11:
                CheckStepObjectsAndProceed(PistonBottom);
                break;
            default:
                NextStep();
                break;
        }
    }

    // Generic step-check method
    private void CheckStepObjectsAndProceed(GameObject[] stepObjects)
    {
        bool allMeshDisabled = true;

        foreach (var obj in stepObjects)
        {
            if (obj != null)
            {
                MeshRenderer mr = obj.GetComponent<MeshRenderer>();

                if (mr != null && mr.enabled) // IF mesh is ON
                {
                    allMeshDisabled = false;
                    break;
                }
            }
        }

        if (allMeshDisabled)
        {
            WarningUI.SetActive(false);
            StartButton.interactable = true;
            NextStep();
        }
        else
        {
            WarningUI.SetActive(true);
            // StartButton.interactable = false;
        }
    }


    // Move to next step
    private void NextStep()
    {
        UI_Text[num].SetActive(false);
        num++;
        UI_Text[num].SetActive(true);
/*        if (num < UI_Text.Length && UI_Text[num] != null)
 *        
        if (num >= UI_Text.Length) num = 1;

        if (num < UI_Text.Length && UI_Text[num] != null)*/
        SetStep(num);
    }

    // Setup for each step
    public void SetStep(int step)
    {
        switch (step)
        {
            case 1:
                StartButton.GetComponentInChildren<TextMeshProUGUI>().text = "Next";
                SetAllActive(VasarDown);
                //StartButton.interactable = false;
                WarningUI.SetActive(false);
                break;

            case 2:
                //SetAllDeactive(Chas_Coll);
                break;

            case 3:
                SetAllActive(Chas_Coll);
                SetAllDeactive(Chas_Coll);
                break;

            case 4:
                SetAllActive(crank_coll);
                SetAllActive(crank_coll);
                //crank_coll.SetActive(true);
                break;

            case 5:
                SetAllActive(VasarUp);
                SetAllActive(VasarUp);
                crankarrow.SetActive(false);
                break;

            case 6:
                SetAllActive(bar_Coll);
                SetAllDeactive(bar_Coll);
                //SetAllDeactive(VasarUp);
                break;

            case 7:
                SetAllActive(Screw_Coll);
                SetAllDeactive(Screw_Coll);
                break;

            case 10:
                SetAllActive(PistonTop);
                break;

            case 11:
                SetAllActive(PistonBottom);
                break;
        }
    }

    #region Utility Methods

    private void SetAllActive(GameObject[] objects)
    {
        foreach (var obj in objects)
        {
            if (obj != null) obj.SetActive(true);
        }
    }

    private void SetAllDeactive(GameObject[] objects)
    {
        foreach (var obj in objects)
        {
            if (obj != null) obj.SetActive(false);
        }
    }

/*    public void CheckDisabled(GameObject[] objects)
    {
        bool allDisabled = true;

        foreach (var obj in objects)
        {
            if (obj != null && obj.activeSelf)
            {
                allDisabled = false;
                break;
            }
        }

        if (allDisabled)
        {
            WarningUI.SetActive(false);
            StartButton.interactable = true;
        }
        else
        {
            WarningUI.SetActive(true);
            StartButton.interactable = false;
        }
    }

    public void buttoncheck()
    {
        if (num == 1)
        {
            CheckDisabled(VasarDown);
        }
    }*/

    #endregion
}


/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public GameObject[] UI_Text;
    public GameObject[] VasarDown;
    public GameObject[] VasarUp;
    GameObject[] Empty;

    public Button StartButton;

    public int num = 0;

    public GameObject Chas_Coll;
    public GameObject bar_Coll;
    public GameObject crank_coll;
    public GameObject crank_coll_Move;
    public GameObject screw_Coll;
    public GameObject Piston_Top;
    public GameObject Piston_Top1;
    public GameObject Piston;
    public GameObject crankarrow;

    public GameObject WarningUI;

    private void Start()
    {
        // Set default to avoid null
        Empty = new GameObject[0];
    }

    public void Update()
    {
        if (num == 1)
        {
            StartButton.GetComponentInChildren<TextMeshProUGUI>().text = "Next";
            StartButton.interactable = false;

            Empty = VasarDown;
            Disableall(Empty);
        }

        if (num == 2)
        {
            Chas_Coll.SetActive(true);
            SetAllDeactive(Empty);
        }

        if (num == 3)
        {
            Empty = VasarUp;
        }

        if (num == 4)
        {
            StartButton.onClick.RemoveAllListeners();
            StartButton.onClick.AddListener(vasercheck);

            crank_coll.SetActive(true);
        }

        if (num == 5)
        {
            crankarrow.SetActive(false);
            Empty = VasarUp;
            SetAllActive(Empty);
        }

        if (num == 6)
        {
            bar_Coll.SetActive(true);
            SetAllDeactive(Empty);
        }

        if (num == 7)
        {
            screw_Coll.SetActive(true);
        }

        if (num == 10)
        {
            Piston_Top.SetActive(true);
            Piston_Top1.SetActive(true);
        }

        if (num == 11)
        {
            Piston.SetActive(true);
        }

        if (num == UI_Text.Length)
        {
            num = 1;
        }
    }

    public void Next()
    {
        if (num == 5 && Chas_Coll.activeSelf)
        {
            Debug.Log("Cannot proceed: Chas_Coll is still active.");
            return;
        }

        UI_Text[num].SetActive(false);
        num++;
        UI_Text[num].SetActive(true);
    }

    public void vasercheck()
    {
        Disableall(Empty);
    }

    public void Disableall(GameObject[] objects)
    {
        foreach (var obj in objects)
        {
            if (obj != null && obj.activeSelf)
            {
                WarningUI.SetActive(true);
                StartButton.interactable = false;
                return; // stop here, no need to check others
            }
        }

        // Reached here = NO object was active
        WarningUI.SetActive(false);
        StartButton.interactable = true;
    }
    public void SetAllActive(GameObject[] objects)
    {
        foreach (var obj in objects)
        {
            if (obj != null)
                obj.SetActive(true);
        }
    }

    public void SetAllDeactive(GameObject[] objects)
    {
        foreach (var obj in objects)
        {
            if (obj != null)
                obj.SetActive(false);
        }
    }
}
*/