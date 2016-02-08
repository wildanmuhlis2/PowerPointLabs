﻿using System.Collections.Generic;
using Microsoft.Office.Interop.PowerPoint;
using PowerPointLabs.PictureSlidesLab.Model;

namespace PowerPointLabs.PictureSlidesLab.Service.StylesWorker
{
    class PictureCitationStyleWorker : IStyleWorker
    {
        public IList<Shape> Execute(StyleOption option, EffectsDesigner designer, ImageItem source, Shape imageShape)
        {
            designer.ApplyImageReference(source.ContextLink);
            if (option.IsInsertReference)
            {
                designer.ApplyImageReferenceInsertion(source.ContextLink, option.GetFontFamily(), option.FontColor,
                    option.CitationFontSize, option.ImageReferenceTextBoxColor, option.GetCitationTextBoxAlignment());
            }
            return new List<Shape>();
        }
    }
}