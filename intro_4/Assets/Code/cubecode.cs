using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cubecode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetAxis = ���������� ��� ���� ��� ��������� ����� ��� �������������� ��� axisName.
        float xv = Input.GetAxis("Horizontal"); //������� ����� ��� �������� ��� ������
        float zv = Input.GetAxis("Vertical"); //������� ���� ��� ���� ��� ������
        transform.Translate(xv, 0, zv);

    }
}
 