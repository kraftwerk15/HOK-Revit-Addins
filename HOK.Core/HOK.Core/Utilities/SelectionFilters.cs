﻿using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;

namespace HOK.Core.Utilities
{
    public class RoomElementFilter : ISelectionFilter
    {
        public bool AllowElement(Element elem)
        {
            if (elem.Category != null)
            {
                return elem.Category.Name == "Rooms";
            }
            return false;
        }

        public bool AllowReference(Reference reference, XYZ position)
        {
            return true;
        }
    }
}
