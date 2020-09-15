using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController2 : MonoBehaviour
{
    private HingeJoint myHingeJoint;
    private float defaultAngle = 20;
    private float flickAngle = -20;

    // Start is called before the first frame update
    void Start()
    {
        this.myHingeJoint = GetComponent<HingeJoint>();
        SetAngle(this.defaultAngle);
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<Input.touchCount; i++)
        {
            var pha = Input.touches[i].phase;
            var pos = Input.touches[i].position;
            int size = Screen.width;
            if(pos.x>=Screen.width/2 && tag=="RightFripperTag")
            {
                switch(pha)
                {
                    case TouchPhase.Began:
                    case TouchPhase.Moved:
                    case TouchPhase.Stationary:
                        SetAngle(this.flickAngle);
                        break;

                    default:
                        SetAngle(this.defaultAngle);
                        break;


                }
            }
            if(pos.x<Screen.width/2 && tag=="LeftFripperTag")
            {
                switch(pha)
                {
                    case TouchPhase.Began:
                    case TouchPhase.Moved:
                    case TouchPhase.Stationary:
                        SetAngle(this.flickAngle);
                        break;

                    default:
                        SetAngle(this.defaultAngle);
                        break;
                }
            }
        }   
    }
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}
