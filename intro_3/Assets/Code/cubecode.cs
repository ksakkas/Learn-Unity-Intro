using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cubecode : MonoBehaviour
{
    //�� Unity ����������� (SerializeField) ��� �� �������� ��� �������� ���, �������� ���� ��� ���� ������������ ��� ������������� �� �������� ��� �������� ��� ��� ��� ��������� ��������.

    [SerializeField] float xv = 0.01f;
    [SerializeField] float yv = 0.0f;
    [SerializeField] float zv = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xv, yv, zv);
        //��������� ��� frame ���� �� X ����� �� �����������

    }
}
 