using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PoolControl : MonoBehaviour
{
    [SerializeField] private List<GameObject> _poolBrick = new List<GameObject>();
    [SerializeField] public List<GameObject> _purpleBrick = new List<GameObject>();
    public int PurpleBrickCount => _purpleBrick.Count;
    [SerializeField] public List<GameObject> _pinkBrick = new List<GameObject>();
    public int PinkBrickCount => _pinkBrick.Count;
    [SerializeField] public List<GameObject> _brownBrick = new List<GameObject>();
    public int BrownBrickCount => _brownBrick.Count;
    [SerializeField] public List<GameObject> _yellowBrick = new List<GameObject>();
    public int YellowBrickCount => _yellowBrick.Count;
    private void Update()
    {
        _purpleBrick.Clear();
        _pinkBrick.Clear();
        _brownBrick.Clear();
        _yellowBrick.Clear();
        foreach (GameObject brick in _poolBrick)
        {
            if(brick != null) 
            {
                if((int)brick.GetComponent<Brick>().color == 2) //purple
                {
                    _purpleBrick.Add(brick);
                }
                if ((int)brick.GetComponent<Brick>().color == 3) //pink
                {
                    _pinkBrick.Add(brick);
                }
                if ((int)brick.GetComponent<Brick>().color == 4) //brown
                {
                    _brownBrick.Add(brick);
                }
                if ((int)brick.GetComponent<Brick>().color == 5) //yellow
                {
                    _yellowBrick.Add(brick);
                }
            }
        }
    }
}
