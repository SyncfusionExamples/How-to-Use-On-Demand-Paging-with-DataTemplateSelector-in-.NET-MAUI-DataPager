using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Maui.Controls;

namespace SfDataGridSample.Selector
{
    public class MatchTemplateSelector : DataTemplateSelector
    {
        public DataTemplate NineBallTemplate { get; set; } = null!;
        public DataTemplate OnePocketTemplate { get; set; } = null!;

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is not BaseViewMatch) throw new ArgumentException("Item must be of type BaseViewMatch", nameof(item));

            return item switch
            {
                NineBallViewMatch => NineBallTemplate,
                OnePocketViewMatch => OnePocketTemplate,
                _ => NineBallTemplate
            };
        }
    }
}
