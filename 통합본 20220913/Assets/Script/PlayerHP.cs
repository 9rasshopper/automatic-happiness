using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    private Slider hpbar;

    public float maxHp = 100;
    private float curHp = 100;
    float imsi;
    // Start is called before the first frame update
    void Start()
    {
        imsi = (float) curHp / (float) maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            if(curHp > 0)
            {
                curHp -= 10;
            }
            else
            {
                curHp = 0;
            }
            imsi = (float) curHp / (float) maxHp;
        }
        HandleHp();
    }

    private void HandleHp()
    {
        hpbar.value = Mathf.Lerp(hpbar.value, imsi, Time.deltaTime * 10);
    }
}
