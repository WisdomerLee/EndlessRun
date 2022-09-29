using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//추가용 생성 장애물
public class NewObstacleEmpty : Obstacle
{
    public override IEnumerator Spawn(TrackSegment segment, float t)
    {

        yield break;
    }
}
