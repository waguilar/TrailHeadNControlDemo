using NControl.Abstractions;
using NGraphics;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TrailHeadNControlDemo.Controls
{
    public class CircularButtonControl : NControlView
    {
        #region Bindable Properties

        public static BindableProperty TextColorProperty =
            BindableProperty.Create(nameof(TextColor),
                                    typeof(Xamarin.Forms.Color),
                                    typeof(CircularButtonControl),
                                    propertyChanged: (b, o, n) => ((CircularButtonControl)b).TextColor = (Xamarin.Forms.Color)n);

        public static BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text),
                                    typeof(string),
                                    typeof(CircularButtonControl),
                                    propertyChanged: (b, o, n) => ((CircularButtonControl)b).Text = (string)n);

        public static BindableProperty FontSizeProperty =
            BindableProperty.Create(nameof(FontSize),
                                    typeof(short),
                                    typeof(CircularButtonControl),
                                    propertyChanged: (b, o, n) => ((CircularButtonControl)b).FontSize = (short)n);

        public new static BindableProperty BackgroundColorProperty =
            BindableProperty.Create(nameof(BackgroundColor),
                                    typeof(Xamarin.Forms.Color),
                                    typeof(CircularButtonControl),
                                    propertyChanged: (b, o, n) => ((CircularButtonControl)b).BackgroundColor = (Xamarin.Forms.Color)n);

        #endregion Bindable Properties

        private readonly NControlView _background;
        private readonly Label _label;

        public CircularButtonControl()
        {
            _label = new Label
            {
                HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center,
                VerticalTextAlignment = Xamarin.Forms.TextAlignment.Center
            };

            _background = new NControlView
            {
                DrawingFunction = (canvas, rect) =>
                {
                    canvas.FillEllipse(rect, new NGraphics.Color(BackgroundColor.R, BackgroundColor.G, BackgroundColor.B, BackgroundColor.A));
                }
            };

            var content = new Grid
            {
                Children = { _background, _label }
            };

            Content = content;
        }

        #region Properties

        public string Text
        {
            get => GetValue(TextProperty) as string;
            set
            {
                SetValue(TextProperty, value);
                _label.Text = value;
                Invalidate();
            }
        }

        public short FontSize
        {
            get => (short)GetValue(FontSizeProperty);
            set
            {
                SetValue(FontSizeProperty, value);
                _label.FontSize = value;
                Invalidate();
            }
        }

        public Xamarin.Forms.Color TextColor
        {
            get => (Xamarin.Forms.Color)GetValue(TextColorProperty);
            set
            {
                SetValue(TextColorProperty, value);
                _label.TextColor = value;
                Invalidate();
            }
        }

        public new Xamarin.Forms.Color BackgroundColor
        {
            get => (Xamarin.Forms.Color)GetValue(BackgroundColorProperty);
            set
            {
                SetValue(BackgroundColorProperty, value);
                Invalidate();
            }
        }

        #endregion Properties

        #region Methods

        public override bool TouchesBegan(IEnumerable<NGraphics.Point> points)
        {
            base.TouchesBegan(points);
            this.ScaleTo(0.98, 40, Easing.CubicInOut);
            return true;
        }

        public override bool TouchesCancelled(IEnumerable<NGraphics.Point> points)
        {
            base.TouchesCancelled(points);
            this.ScaleTo(1.0, 40, Easing.CubicInOut);
            return true;
        }

        public override bool TouchesEnded(IEnumerable<NGraphics.Point> points)
        {
            base.TouchesEnded(points);
            this.ScaleTo(1.0, 40, Easing.CubicInOut);
            return true;
        }

        #endregion Methods
    }
}