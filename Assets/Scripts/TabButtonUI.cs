using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class TabButtonUI : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private TabGroup _tabGroup;
    public Image Icon;
    public TextMeshProUGUI Text;

    private void Awake()
    {
        if(_tabGroup == null)
        {
            _tabGroup = GetComponentInParent<TabGroup>();
        }

        if (Icon == null)
        {
            Icon = GetComponentInChildren<Image>();
        }

        if (Text == null)
        {
            Text = GetComponentInChildren<TextMeshProUGUI>();
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _tabGroup.OnTabSelected(this);
    }

    public void Select()
    {
        
    }

    public void Deselect()
    {

    }
}
