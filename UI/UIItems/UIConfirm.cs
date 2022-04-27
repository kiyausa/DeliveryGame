using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Cysharp.Threading.Tasks;

public class UIConfirm : MonoBehaviour
{
    [SerializeField] private GameObject target1, target2;

    public UnityEvent StartEvent;
    private void Start()
    {
        StartEvent.Invoke();
        this.gameObject.SetActive(false);
    }
    public async void OnWaitSec(int sec)
    {
        await WaitSec(sec);
        target1.SetActive(false);
        target2.SetActive(false);
        Debug.Log($"{sec}ïbåoâﬂ");
    }

    async UniTask WaitSec(int sec)
    {
        await UniTask.Delay(sec);
    }
}
