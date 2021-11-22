using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Ball initialBall;
    public Ball ballPrefab;

    public Board board;
    public static bool startGame;
    public static bool gameStarted;
    // Start is called before the first frame update
    void Start()
    {
        InitializeBall();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 boardPos = board.gameObject.transform.position;
        Vector3 ballPos = new Vector3(boardPos.x, boardPos.y + .5f, 0);
        if (Input.GetMouseButtonDown(0))
        {
            startGame = true;
        }


        if (!startGame)
        {
            initialBall.transform.position = ballPos;
        }
    }


    void InitializeBall()
    {
        Vector3 boardPos = board.gameObject.transform.position;

        Vector3 ballPos = new Vector3(boardPos.x, boardPos.y + .5f, 0);
        initialBall = Instantiate(ballPrefab, ballPos, Quaternion.identity);
    }
}
