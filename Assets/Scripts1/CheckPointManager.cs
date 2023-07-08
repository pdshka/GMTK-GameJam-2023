using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckPointManager : MonoBehaviour
{
    [SerializeField] private float respawn_time = 0.5f;
    [SerializeField] private Transform current_checkpoint;
    [SerializeField] private GameObject player;

    [SerializeField] private GameObject text;
    [SerializeField] private float textDuration;

    private BulbMobileController bulb;
    private Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = player.GetComponent<Rigidbody>();
        bulb = player.GetComponent<BulbMobileController>();
    }

    public void TeleportToCheckPoint()
    {
        StartCoroutine(Respawn());
        player.transform.position = current_checkpoint.position;
        player.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        bulb.ResetRotation();
        rigidbody.velocity = new Vector3();
    }

    public void SetCheckPoint(Transform transform)
    {
        current_checkpoint = transform;
        StartCoroutine(ShowNotification());
    }

    private IEnumerator ShowNotification()
    {
        text.SetActive(true);
        yield return new WaitForSeconds(textDuration);
        text.SetActive(false);
    }

    private IEnumerator Respawn()
    {
        bulb.enabled = false;
        yield return new WaitForSeconds(respawn_time);
        bulb.enabled = true;
    }
}
