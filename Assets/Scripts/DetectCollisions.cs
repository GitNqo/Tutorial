using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);//�A�^�b�`����Ă��鎩�����g������
        Destroy(other.gameObject);//�Ԃ���������iother�j������
    }
}
