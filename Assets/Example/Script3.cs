using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityExecutionOrder;

// this script will have an execution order of 100
[ExecutionOrder(100)]
public class Script3 : MonoBehaviour {
    void Start () {
        Debug.Log("Third");
    }
}