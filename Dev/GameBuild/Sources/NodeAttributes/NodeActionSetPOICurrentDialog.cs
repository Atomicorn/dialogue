using DialogueEditor;

namespace GameBuild
{
    class NodeActionSetPOICurrentDialog : NodeAction
    {
        public string POIName { get; set; }
        public string CurrentDialog { get; set; }

        public NodeActionSetPOICurrentDialog()
        {
            CurrentDialog = "Default";
            POIName = "DefaultPOIName";
        }

        public override string GetDisplayText()
        {
            return $"[Set POI Current Dialog] {{ \"{ POIName }\" : { CurrentDialog } }}";
        }
    }
}
