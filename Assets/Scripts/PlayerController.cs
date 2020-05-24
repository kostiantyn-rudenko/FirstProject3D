using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent = null;
    [SerializeField] private Camera _camera = null;
    [SerializeField] private float _jumpTime = 1f;
    private Rigidbody _rigidbody = null;

    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (_agent.enabled && Input.GetMouseButtonDown(0))
        {
            var ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;
            if (Physics.Raycast(ray, out raycastHit))
            {
                SetDestination(raycastHit.point);
            }
        }
        //_agent.
        //Debug.Log(_agent.nextPosition);
        //_agent.nextPosition;
        //_agent.desiredVelocity;
        //_agent.
        if (_agent.isOnOffMeshLink)
        {
            // перед прыжком берем позицию, куда двигался объект
            Vector3 dest = new Vector3(_agent.destination.x, _agent.destination.y, _agent.destination.z);
            // прыжек
            DG.Tweening.ShortcutExtensions.DOJump(transform, _agent.currentOffMeshLinkData.endPos, 2f, 1, _jumpTime);
            // выключаеи агента на время прыжка, чтоб он не мешал
            _agent.enabled = false;
            // после прыжка включаем агент и двигаемся дальше
            StartCoroutine(EnableAfterTimer(dest, 1f));
        }

        if (_agent.enabled)
        {
            BroadcastMessage("ChangePosition", _agent.velocity);
        }
    }

    private IEnumerator EnableAfterTimer(Vector3 destination, float time)
    {
        yield return new WaitForSeconds(time);
        _agent.enabled = true;
        _agent.SetDestination(destination);
    }
    private void SetDestination(Vector3 position)
    {
        _agent.SetDestination(position);
    }
}
