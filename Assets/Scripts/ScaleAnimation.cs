using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleAnimation : MonoBehaviour
{
    void Update()
    {
        float transScale = 1f * Time.deltaTime;
        this.gameObject.transform.localScale += new Vector3(transScale, transScale, transScale);
    }
}
