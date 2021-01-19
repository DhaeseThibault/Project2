using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BikeGates.Models
{
    public class SliderLabelControl : AbsoluteLayout
    {
        private Label _sliderValue;
        private Slider _slider;
        public SliderLabelControl()
        {
            AddControls();
        }

        private void AddControls()
        {
            _slider = new Slider { Margin = new Thickness(0, 20, 0, 0) };
            _slider.ValueChanged += (s, e) =>
            {
                PositionLabel(e.NewValue);
            };

            _sliderValue = new Label();
            _sliderValue.SetBinding(Label.TextProperty, new Binding("Value", source: _slider) { StringFormat = "{0:F0}" });

            SetLayoutFlags(_slider, AbsoluteLayoutFlags.All);
            SetLayoutBounds(_slider, new Rectangle(0f, 1f, 1f, 1f));

            Children.Add(_sliderValue);
            Children.Add(_slider);
        }

        private void PositionLabel(double newValue)
        {
            if (newValue == 0.0) return;

            var xPosition = (newValue - _slider.Minimum) / (_slider.Maximum - _slider.Minimum);

            SetLayoutFlags(_sliderValue, AbsoluteLayoutFlags.PositionProportional);
            SetLayoutBounds(_sliderValue, new Rectangle(xPosition, 0f, AutoSize, AutoSize));
        }

        public double Minimum
        {
            get => (double)_slider.GetValue(Slider.MinimumProperty);
            set => _slider.SetValue(Slider.MinimumProperty, value);
        }

        public double Maximum
        {
            get => (double)_slider.GetValue(Slider.MaximumProperty);
            set => _slider.SetValue(Slider.MaximumProperty, value);

        }
        public string Color
        {
            get => (string)_slider.GetValue(Slider.ThumbColorProperty);
            set => _slider.SetValue(Slider.ThumbColorProperty, value);

        }
        public double HeigthAboveCircle
        {
            get => (double)_slider.GetValue(Slider.HeightRequestProperty);
            set => _slider.SetValue(Slider.HeightRequestProperty, value);
        }
    }
}
