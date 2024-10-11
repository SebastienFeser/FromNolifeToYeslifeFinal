using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechnologiesButton : MonoBehaviour
{
    [SerializeField] GameObject techTree;

    public void ActivateTechTree()
    {
        techTree.SetActive(true);
    }
}
