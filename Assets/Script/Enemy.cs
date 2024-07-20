using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Enemy : MonoBehaviour
{
    [SerializeField] private PathHolder pathHolder;

    // Start is called before the first frame update
    void Start()
    {
        MoveFollowPath();
    }

    // Update is called once per frame
    private  void MoveFollowPath() 
    {
        transform.DOPath(pathHolder.GetWayPoint(), 5f,PathType.CatmullRom);
    }
    
    
}
