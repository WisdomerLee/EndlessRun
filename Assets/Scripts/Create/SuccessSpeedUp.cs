using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�����̵� ��� ������...
public class SuccessSpeedUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //�ε����� �ӵ� ����(���� ��)
        if (FindObjectOfType<TrackManager>())
        {
            FindObjectOfType<TrackManager>().speed += Time.deltaTime;
            print($"�ӵ� ���� :{FindObjectOfType<TrackManager>().speed}");
            FindObjectOfType<TrackManager>().Combo++;
        }
    }
}
