using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathMovement : MonoBehaviour {

    public LoopMode mode;
    public float moveSpeedMultiplyer = 1.0f;
    public List<Transform> pathPoints;
    
    private int currentTargetPoint = -1;
    private float targetDistance = -1f;
    private bool loopDirectionForwards = true;

    // Start is called before the first frame update
    void Start()
    {
        if(pathPoints.Count > 0)
        {
            transform.position = pathPoints[0].position;
            setTarget(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(currentTargetPoint != -1)
        {
            Vector3 directionVector = pathPoints[currentTargetPoint].position - transform.position;
            directionVector = directionVector.normalized;


            //transform.LookAt(pathPoints[currentTargetPoint]);
            if (targetDistance >= 1.0f * Time.deltaTime * moveSpeedMultiplyer)
            {
                //transform.Translate(Vector3.forward * Time.deltaTime * moveSpeedMultiplyer);
                transform.Translate(directionVector * Time.deltaTime * moveSpeedMultiplyer);
            }
            else
            {
                //transform.Translate(Vector3.forward * targetDistance);
                transform.Translate(directionVector * targetDistance);
            }
            targetDistance = Vector3.Distance(transform.position, pathPoints[currentTargetPoint].position);


            if (targetDistance <= 0.1f)
            {
                switch (mode)
                {
                    case LoopMode.ClosedLoop:
                        {
                            if (pathPoints.Count - 1 > currentTargetPoint)
                            {
                                setTarget(currentTargetPoint + 1);
                            }
                            else
                            {
                                setTarget(0);
                            }
                        }
                        break;

                    case LoopMode.OneDirectionalLoop:
                        {
                            if (pathPoints.Count - 1 > currentTargetPoint)
                            {
                                setTarget(currentTargetPoint + 1);
                            }
                            else
                            {
                                transform.position = pathPoints[0].position;
                                setTarget(1);
                            }
                        }
                        break;

                    case LoopMode.PingPongLoop:
                        {
                            if(loopDirectionForwards == true)
                            {
                                if(pathPoints.Count - 1 > currentTargetPoint)
                                {
                                    setTarget(currentTargetPoint + 1);
                                }
                                else
                                {
                                    setTarget(currentTargetPoint - 1);
                                    loopDirectionForwards = false;
                                }
                                
                            }
                            else
                            {
                                if (currentTargetPoint > 0)
                                {
                                    setTarget(currentTargetPoint - 1);
                                }
                                else
                                {
                                    setTarget(currentTargetPoint + 1);
                                    loopDirectionForwards = true;
                                }
                            }
                        }
                        break;

                    default:
                        {
                            setTarget(currentTargetPoint + 1);
                        }break;
                }
            }
        }
    }

    private void setTarget(int target)
    {
        if(pathPoints.Count > target && target >= 0)
        {
            currentTargetPoint = target;
            targetDistance = Vector3.Distance(transform.position, pathPoints[currentTargetPoint].position);
        }
        else
        {
            currentTargetPoint = -1;
            targetDistance = -1f;
        }
    }

    public enum LoopMode
    {
        None,
        ClosedLoop,
        OneDirectionalLoop,
        PingPongLoop
    }
}
