using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//슬라이드 통과 성공시...
public class SuccessSpeedUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //부딪히면 속도 증가(성공 존)
        if (FindObjectOfType<TrackManager>())
        {
            FindObjectOfType<TrackManager>().speed += Time.deltaTime;
            print($"속도 증가 :{FindObjectOfType<TrackManager>().speed}");
            FindObjectOfType<TrackManager>().Combo++;
        }
    }
}
