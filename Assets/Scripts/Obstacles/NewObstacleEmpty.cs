using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�߰��� ���� ��ֹ�
public class NewObstacleEmpty : Obstacle
{
    public override IEnumerator Spawn(TrackSegment segment, float t)
    {

        yield break;
    }
}
