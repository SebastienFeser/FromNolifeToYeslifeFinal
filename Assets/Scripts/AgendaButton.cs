using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgendaButton : MonoBehaviour
{
    [SerializeField] GameObject timeline;

    public void OnAgendaClick()
    {
        timeline.SetActive(!timeline.activeInHierarchy);
    }
}
