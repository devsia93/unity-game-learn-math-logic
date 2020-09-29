using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicLevel : MonoBehaviour
{
    //[Header("Buttons")]
    //public ButtonController Button1;
    //public ButtonController Button2;
    //public ButtonController Button3;
    //public ButtonController Button4;
    //public ButtonController Button5;
    //public ButtonController Button6;
    [Header("Platforms")]
    //public PlatformController platform1;
    //public PlatformController platform2;
    //public PlatformController platform3;
    //public PlatformController platform4;
    //private bool b1, b2, b3, b4, b5, b6 = false;
    public List<PlatformController> platformControllers = new List<PlatformController>();

    // Start is called before the first frame update
    void Start()
    {
        //platformControllers.Add(platform1);
        //platformControllers.Add(platform2);
        //platformControllers.Add(platform3);
        //platformControllers.Add(platform4);
        platformControllers[0].onCollision = true;
    }

    // Update is called once per frame
    void Update()
    {
        //#region Button1
        //if ((Button1.statusButton != b1) && Button1.statusButton)
        //{
        //    Helper.MoveDownPlatform(platform1);
        //    b1 = Button1.statusButton;
        //}
        //else if ((Button1.statusButton != b1) && !Button1.statusButton)
        //{
        //    Helper.MoveUpPlatform(platform1);
        //    b1 = Button1.statusButton;
        //}
        //#endregion

        //#region Button 2,3
        //if (LogicController.Conjunction(Button2.statusButton, Button3.statusButton) && (Button2.statusButton != b2 | Button3.statusButton != b3))
        //{
        //    Helper.MoveUpPlatform(platform2);
        //    b2 = Button2.statusButton;
        //    b3 = Button3.statusButton;
        //}
        //else if (!LogicController.Conjunction(Button2.statusButton, Button3.statusButton) && (Button2.statusButton != b2 | Button3.statusButton != b3))
        //{
        //    platform2.transform.position = platform2.DefaultPosition; ;
        //    b2 = Button2.statusButton;
        //    b3 = Button3.statusButton;
        //}
        //#endregion

        //#region Button4
        //if (!LogicController.Inversion(Button4.statusButton) && Button4.statusButton != b4)
        //{
        //    Helper.MoveDownPlatform(platform3);
        //    b4 = Button1.statusButton;
        //}
        //else if ((Button4.statusButton != b4) && LogicController.Inversion(Button4.statusButton))
        //{
        //    Helper.MoveUpPlatform(platform3);
        //    b4 = Button4.statusButton;
        //}
        //#endregion

        //#region Button5,6
        //if (LogicController.Disjunction(Button5.statusButton, Button6.statusButton) &&
        //    (Button5.statusButton != b5 | Button6.statusButton != b5) &
        //    (platform4.DefaultPosition.x + 3.0f != platform4.transform.position.x))
        //{
        //    Helper.MoveUpPlatform(platform4);
        //    b5 = Button5.statusButton;
        //    b6 = Button6.statusButton;
        //}
        //else if (!LogicController.Disjunction(Button5.statusButton, Button6.statusButton) && (Button5.statusButton != true | Button6.statusButton != true))
        //{
        //    platform4.transform.position = platform4.DefaultPosition;
        //    b5 = Button5.statusButton;
        //    b6 = Button6.statusButton;
        //}
        //#endregion

        Helper.CheckCorrectCollision(platformControllers);
    }
}
