﻿using System;
using System.Drawing;
using HSL = System.ValueTuple<float, float, float>;
using RGB = System.ValueTuple<byte, byte, byte>;

namespace Palett.Convert {
  public static partial class Converter {
    public static int HslToInt(this HSL hsl) => hsl.HslToRgb().RgbToInt();
    public static string HslToHex(this HSL hsl) => hsl.HslToRgb().RgbToHex();
    public static (byte r, byte g, byte b) HslToRgb(this HSL hsl) {
      var (h, os, ol) = hsl;
      var s = os / 100;
      var l = ol / 100;
      var a = s * Math.Min(l, 1 - l);
      var r = Utils.Hal(0, h, a, l);
      var g = Utils.Hal(8, h, a, l);
      var b = Utils.Hal(4, h, a, l);
      return ((byte) (r * 0xFF), (byte) (g * 0xFF), (byte) (b * 0xFF));
    }
    public static Color HslToColor(this HSL hsl) => hsl.HslToRgb().RgbToColor();
  }
}