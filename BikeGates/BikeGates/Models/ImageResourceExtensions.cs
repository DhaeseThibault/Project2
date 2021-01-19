using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BikeGates.Models
{
    [ContentProperty(nameof(Source))]
    class ImageResourceExtensions : IMarkupExtension
    {
        public string Source { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }

            var imageSource = ImageSource.FromResource(Source, typeof(ImageResourceExtensions).GetTypeInfo().Assembly);
            return imageSource;
        }
    }
}