using DialogueEditor;

namespace DemoBuild
{
    class NodeActionSetPOIState : NodeAction
    {
        public enum POIState
        {
            Hidden = 0,
            Locked = 1,
            Unlocked = 2,
            Highlighted = 3
        }

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
