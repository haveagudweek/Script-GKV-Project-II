using UnityEngine;

public class NavigationManager : MonoBehaviour
{
    public MeshRenderer sphereRenderer;
    public LokasiNode titikAwal;
    private LokasiNode nodeSaatIni;

    void Start()
    {
        LokasiNode[] semuaNode = FindObjectsOfType<LokasiNode>();
        foreach (LokasiNode node in semuaNode)
        {
            if (node.wadahTombol != null)
            {
                node.wadahTombol.SetActive(false);
            }
        }

        PindahKeNode(titikAwal);
    }

    public void PindahKeNode(LokasiNode targetNode)
    {
        if (targetNode == null) return;

        if (nodeSaatIni != null && nodeSaatIni.wadahTombol != null)
        {
            nodeSaatIni.wadahTombol.SetActive(false);
        }

        sphereRenderer.material = targetNode.materialLokasiIni;
        nodeSaatIni = targetNode;

        if (nodeSaatIni.wadahTombol != null)
        {
            nodeSaatIni.wadahTombol.SetActive(true);
        }
    }
}
