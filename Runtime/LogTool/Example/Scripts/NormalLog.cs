using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalLog : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        Debug.Log("Unity Normal Log.");
        Debug.LogWarning("Unity Warn Log.");
        Debug.LogError("Unity Error Log.");
    }

    // Update is called once per frame
    void Update() {

    }
}
