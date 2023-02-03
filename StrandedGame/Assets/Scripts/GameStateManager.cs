using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    private bool atObelisk;
    private int counter;
    private int targetNum;
    public void Start()
    {
        resetTargetNum();
    }
    public int queryTargetNum()
    {
        if (targetNum == -1)
        {
            targetNum = Random.Range(1, 9);
        }
        return targetNum;
    }
    public void resetTargetNum()
    {
        targetNum = -1;
    }
    public void setAtObelisk(bool b)
    {
        atObelisk = b;
    }
    public bool queryAtObelisk()
    {
        return atObelisk;
    }
    public void adjustCounter(int val)
    {
        counter += val;
    }
    public int queryCounter()
    {
        return counter;
    }
}