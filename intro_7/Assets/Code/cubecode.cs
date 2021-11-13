using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cubecode : MonoBehaviour
{
    [SerializeField] float movespeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime = �� �������� �� ������������ ��� �� ��������� ���� ��� �� ������
        //Input.GetAxis = ���������� ��� ���� ��� ��������� ����� ��� �������������� ��� axisName.
        float xv = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed; //������� ����� ��� �������� ��� ������
        float zv = Input.GetAxis("Vertical") * Time.deltaTime * movespeed; //������� ���� ��� ���� ��� ������
        transform.Translate(xv, 0, zv);

    }
}
 