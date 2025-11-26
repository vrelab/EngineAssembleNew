using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public GameObject[] UI_Text;
    public Button Start;
    public Sprite next;
    int num = 0;

    public GameObject vasar_bottom_coll;
    public GameObject Chas_Coll;
    public GameObject Vasar_Top_Coll;
    public GameObject bar_Coll;
    public GameObject crank_coll;
    public GameObject crank_coll_Move;
    public GameObject screw_Coll;
    public GameObject Piston_Top;
    public GameObject Piston_Top1;
    public GameObject Piston;
    public GameObject crankarrow;

    //public GameObject crane_Move;
    //public GameObject crane_Move_1;
    //public GameObject crane_Rotate;

    private void Update()
    {
        if (num == 1)
        {
            vasar_bottom_coll.SetActive(false);
            Start.image.sprite= next;
            Chas_Coll.SetActive(true);
        }
        if (num == 2)
        {
            
        }
        if (num == 3)
        {
            crank_coll.SetActive(true);
            //crank_coll_Move.SetActive(true);
        }
        if (num == 4)
        {
            crankarrow.SetActive(false);
            Vasar_Top_Coll.SetActive(true);
        }
        if (num == 5)
        {
            bar_Coll.SetActive(true);
        }
        if (num == 6)
        {
            screw_Coll.SetActive(true);
        }
        if (num == 7)
        {

        }
        if (num == 9)
        {
            Piston_Top.SetActive(true);
            Piston_Top1.SetActive(true);
        }
        if (num == 10)
        {
            Piston.SetActive(true);
        }
        if (num == UI_Text.Length)
        {
            num = 0;
        }
    }
    public void Next()
    {
        UI_Text[num].SetActive(false);
        num++;

        UI_Text[num].SetActive(true);
    }
}
