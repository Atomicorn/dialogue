using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using DialogueEditor;
using System.Text;

namespace GameBuild
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Handle float edition in PropertyGrid
            //http://visualhint.com/blog/70/how-to-format-a-number-with-a-specific-cultureinfonumberformatinfo-in-the-propert
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Core
            EditorCore.FillDefaultImageList();
            EditorCore.InitDefaultWindow();
            EditorCore.InitDefaultLists();

            EditorCore.VersionProject = "1.0.0";

            //..............................................................
            // Here you can declare custom types, bindings and menus

            // Animations
            EditorCore.Animations.Add("Common", new List<string>() { "WaveHands", "CrossArms" });
            EditorCore.Animations.Add("Angry", new List<string>() { "Speak_01", "Speak_02" });

            // Additional lists items
            EditorCore.CustomLists["Builds"].Add("Dwarf", "Dwarf");

            // Bind Nodes Attributes
            BindType<NodeConditionHasItemStack>();
            BindType<NodeActionItemStack>();
            BindType<NodeActionTag>();
            BindType<NodeActionLoadScene>();
            BindType<NodeActionSetPOIState>();

            // Delegate post-load project
            EditorCore.OnProjectLoad = delegate
            {
                //...
                // Here you can start additional processes like filling the loaded project/dialogues with some imported data
                //...
            };

            // Delegate to check custom errors
            EditorCore.OnCheckDialogueErrors = delegate (Dialogue dialogue)
            {
                //...
                // Here you can plug custom checks, using this kind of messages :
                //EditorCore.LogError(String.Format("{0} {1} - Sentence has no Speaker", dialogue.GetName(), node.ID), dialogue, node);
                //...
            };

            //..............................................................

            // MainWindow
            EditorCore.MainWindow.Init();

            // Add the event handler for handling UI thread exceptions to the event.
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(WIN32.ShowCrashMessage);

            // Run
            Application.Run(EditorCore.MainWindow);
        }

        private static void BindType<T>()
        {
            Type type = typeof(T);
            string nodeType = type.Name.Replace("Node", string.Empty);
            EditorCore.BindAttribute(type, nodeType, NicifyName(nodeType));
        }

        static string NicifyName(string nodeName)
        {
            StringBuilder stringBuilder = new StringBuilder(Convert.ToInt32(nodeName.Length*1.5f));
            stringBuilder.Append(nodeName[0]);

            for (int count = nodeName.Length, i = 1; i< count; i++)
            {
                if (char.IsUpper(nodeName[i]))
                    stringBuilder.Append(' ');

                stringBuilder.Append(nodeName[i]);
            }

            return stringBuilder.ToString();
        }
    }
}
