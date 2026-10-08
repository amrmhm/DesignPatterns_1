using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Flyweight.EX;

public class Cell
{
    private readonly int row;
    private readonly int column;
    private string content;
    private CellContext context;

    public Cell(int row, int column, CellContext context)
    {
        this.row = row;
        this.column = column;
        this.context = context;
    }

    public void setContent(String content)
    {
        this.content = content;
    }

    public CellContext getContext()
    {
        return context;
    }

    public void setContext(CellContext context)
    {
        this.context = context;
    }

    public void render()
    {
        Console.WriteLine($"({row}, {column}): {content} [{context.getFontFamily()}]\n");
    }
}
