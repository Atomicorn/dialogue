using DialogueEditor;

namespace GameBuild
{
    class NodeActionSetPOIState : NodeAction
    {
        public string POIName { get; set; }
        public POIState State { get; set; }

        public NodeActionSetPOIState()
        {
            State = POIState.Hidden;
            POIName = "DefaultPOIName";
        }

        public override string GetDisplayText()
        {
            return $"[Set POI State] {{ \"{ POIName }\" : { State } }}";
        }
    }
}
