using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {
        //Vector3.forward�͑O�����i���m�ɂ�z����=�F�̎��j
        //����ɁA�����~���Ԃ��������������ړ�������悤�ɂ��Ă���
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
