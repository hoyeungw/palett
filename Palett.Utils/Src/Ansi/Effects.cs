using System;

namespace Palett.Utils.Ansi {
  public enum Effects {
    Bold,
    Italic,
    Underline,
    Inverse
  }

  public static class EffectCodes {
    public static (string, string)? EffectToAnsi(this Effects effect) {
      switch (effect) {
        case Effects.Bold: return (BOLD, CLR_BOLD);
        case Effects.Italic: return (ITALIC, CLR_ITALIC);
        case Effects.Underline: return (UNDERLINE, CLR_UNDERLINE);
        case Effects.Inverse: return (INVERSE, CLR_INVERSE);
        default: throw new ArgumentOutOfRangeException(nameof(effect), effect, null);
      }
    }

    public const string BOLD = "1";
    public const string ITALIC = "3";
    public const string UNDERLINE = "4";
    public const string INVERSE = "7";
    public const string CLR_BOLD = "22";
    public const string CLR_ITALIC = "23";
    public const string CLR_UNDERLINE = "24";
    public const string CLR_INVERSE = "27";
  }
}