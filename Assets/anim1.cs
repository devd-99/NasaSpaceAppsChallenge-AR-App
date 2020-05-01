using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim1 : MonoBehaviour

{
    private Animator anim;
    private MeshRenderer ms;
    private bool flag = false;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        ms = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((PinchCheck() > 0) && (flag == true))
        {
            Debug.Log("Pinch In.\n");
            if (null != anim)
            {
                //Play Plane_1
                anim.Play("info1_reverse");
                flag = false;
            }
            else
            {
                Debug.Log("Animation is Null");
            }

        }
        else if ((flag == false) && (PinchCheck() < 0))
        {
            Debug.Log("Pinch out.\n");
            //Debug.Log(PinchCheck());
            if (null != anim)
            {
                //Play Plane_1
                anim.Play("info1");
                flag = true;
            }
            else
            {
                Debug.Log("Animation is Null");
            }
        }

    }

    float PinchCheck()
    {
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            return deltaMagnitudeDiff;
        }

        return 0;
    }
}
