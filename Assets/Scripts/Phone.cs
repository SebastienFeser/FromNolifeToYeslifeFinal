using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    [SerializeField] GameObject mainMenuTab;
    [SerializeField] GameObject contactsTab;
    [SerializeField] GameObject therapistTab;

    bool isOpen = false;

    public void TogglePhone()
    {
        if(isOpen)
        {
            ClosePhone();
        }
        else
        {
            OpenPhone();
        }
    }

    public void OpenPhone()
    {
        gameObject.SetActive(true);
        mainMenuTab.SetActive(true);
        contactsTab.SetActive(false);
        therapistTab.SetActive(false);
        isOpen = true;
    }

    public void ClosePhone()
    {
        gameObject.SetActive(false);
        isOpen = false;
    }

    public void OpenContacts()
    {
        mainMenuTab.SetActive(false);
        contactsTab.SetActive(true);
        therapistTab.SetActive(false);
    }

    public void OpenTherapist()
    {
        mainMenuTab.SetActive(false);
        contactsTab.SetActive(false);
        therapistTab.SetActive(true);
    }
}
