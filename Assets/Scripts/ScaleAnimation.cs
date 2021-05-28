using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleAnimation : MonoBehaviour
{
    void Update()
    {
        float transScale = 0.5f * Time.deltaTime;
        this.gameObject.transform.localScale += new Vector3(transScale, transScale, transScale);
    }
}
