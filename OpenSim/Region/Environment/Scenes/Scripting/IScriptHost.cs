using System;
using System.Collections.Generic;
using System.Text;
using libsecondlife;

namespace OpenSim.Region.Environment.Scenes.Scripting
{
    public interface IScriptHost
    {
        string Name { get; set;}
        string SitName{ get; set;}
        string TouchName { get; set;}
        string Description { get; set; }
        LLUUID UUID { get; }
        LLUUID ObjectOwner { get;}
        LLUUID ObjectCreator { get; }
        LLVector3 AbsolutePosition { get; }
        void SetText(string text, Axiom.Math.Vector3 color, double alpha);
    }
}
