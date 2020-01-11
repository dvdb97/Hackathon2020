using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBarController : MonoBehaviour
{
    public GameObject bar;

    private float maxLength;
    private float startX;

    // Start is called before the first frame update
    void Start()
    {
        maxLength = bar.transform.localScale.x;
        startX = bar.transform.position.x;
    }

    public void SetValue(float percent)
    {
        percent = Mathf.Max(percent, 0f);

        float delta = bar.transform.localScale.x - percent * maxLength;

        bar.transform.localScale = new Vector3(percent * maxLength, bar.transform.localScale.y, bar.transform.localScale.z);
        bar.transform.localPosition -= new Vector3(delta / 2f, 0f, 0f);
    }
}
