using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cubecode : MonoBehaviour
{
    [SerializeField] float movespeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction(){
        Debug.Log("Welcome to the game!");
        Debug.Log("Move your player with ADSW or arrow key");
        Debug.Log("Don't hit the walls");
    }

    void MovePlayer()
    {
        //Time.deltaTime = �� �������� �� ������������ ��� �� ��������� ���� ��� �� ������
        //Input.GetAxis = ���������� ��� ���� ��� ��������� ����� ��� �������������� ��� axisName.
        float xv = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed; //������� ����� ��� �������� ��� ������
        float zv = Input.GetAxis("Vertical") * Time.deltaTime * movespeed; //������� ���� ��� ���� ��� ������
        transform.Translate(xv, 0, zv);
    }
}
 