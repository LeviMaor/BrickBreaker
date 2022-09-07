using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Ball initialBall;
    public Ball ballPrefab;
    public int count;
    public Board board;
    public static bool startGame;
    public static bool gameStarted;
    public Text endScreen;
    // Start is called before the first frame update
    void Start()
    {

        
        InitializeBall();
    }

    // Update is called once per frame
    void Update()
    {
        YouWin();
        PreStartGame();
        YouLose();
       
    }

    void PreStartGame()
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
    void YouWin()
    {
        GameObject[] blocks;
        blocks = GameObject.FindGameObjectsWithTag("Block");
        count = blocks.Length;
        if (count == 0)
        {
            endScreen.text = "You Win!!!!";
        }
    }
    void YouLose()
    {
        if (initialBall == null && count !=0)
        {
            endScreen.text = "You Lose!!!!";
        }
    }

    void InitializeBall()
    {
        Vector3 boardPos = board.gameObject.transform.position;

        Vector3 ballPos = new Vector3(boardPos.x, boardPos.y + .5f, 0);
        initialBall = Instantiate(ballPrefab, ballPos, Quaternion.identity);
    }
}
