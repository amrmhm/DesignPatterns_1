using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Flyweight.EX;

public class CellContext
{
     // These are the attributes that can be shared by many cells.
  // That's why I've encapsulated them inside this class.
  // Our CellContextFactory class will ensure that every combination
  // of these attributes will only be stored once.
  private readonly string fontFamily;
  private readonly int fontSize;
  private readonly bool isBolds;

  public CellContext(string fontFamily, int fontSize, bool isBold) {
    this.fontFamily = fontFamily;
    this.fontSize = fontSize;
    this.isBolds = isBold;
  }

  public String getFontFamily() {
    return fontFamily;
  }

  public int getFontSize() {
    return fontSize;
  }

  public bool isBold() {
    return isBolds;
  }

   public override int GetHashCode()
    {
        return HashCode.Combine(fontFamily, fontSize, isBolds);
    }
}
