using System.Collections.Generic;
using UnityEngine;

public class TabGroup : MonoBehaviour
{
   
    [SerializeField] private List<TabButtonUI> _tabButtons;
    [SerializeField] private List<GameObject> _objectsToSwap;
    [SerializeField] private Color _default, _selected;
    private TabButtonUI _selectedTab;

    public void OnTabSelected(TabButtonUI button)
    {
        if (_selectedTab != null)
        {
            _selectedTab.Deselect();
        }

        _selectedTab = button;

        ResetTabs();

        _selectedTab.Icon.color = _selected;
        _selectedTab.Text.color = _selected;
        int index = _selectedTab.transform.GetSiblingIndex();

        for (int i = 0; i < _objectsToSwap.Count; i++)
        {
            if (i == index)
            {
                _objectsToSwap[i].SetActive(true);
            }
            else
            {
                _objectsToSwap[i].SetActive(false);
            }
        }
    }

    public void ResetTabs()
    {
        foreach (TabButtonUI button in _tabButtons)
        {
            if (_selectedTab != null && button == _selectedTab)
            {
                continue;
            }

            button.Icon.color = _default;
            button.Text.color = _default;
        }
    }
}
