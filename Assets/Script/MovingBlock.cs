using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour
{
    public GameObject movingBlock;
    private Vector3 posA;
    private Vector3 posB;
    private Vector3 nextPos;
    public float speed;

    [SerializeField]
    private Transform blockPlatform;
    [SerializeField]
    private Transform posOne;
    [SerializeField]
    private Transform posTwo;

    // Start is called before the first frame update
    void Start()
    {
        posA = posOne.position;
        posB = posTwo.position;
        nextPos = posB;



        
    }

    // Update is called once per frame
    void Update()
    {
        BlockMovment();
    }

    public void BlockMovment()
    {
        blockPlatform.localPosition = Vector3.MoveTowards(blockPlatform.localPosition, nextPos, speed * Time.deltaTime);
        if(Vector3.Distance(blockPlatform.localPosition, nextPos) <=0.1)
        {
            ChangePos();
        }




    }
    private void ChangePos()
    {
        nextPos = nextPos != posA ? posA : posB;
    }


}
